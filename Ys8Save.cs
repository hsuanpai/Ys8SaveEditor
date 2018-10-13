using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Save_Editor
{
    public class Ys8Save
    {
        #region Structures/Classes
        private class Ys8Checksum
        {
            public int Checksum1
            {
                get;
                private set;
            }
            public int Checksum2
            {
                get;
                private set;
            }

            unsafe public static Ys8Checksum GetChecksum(byte[] data)
            {
                fixed (byte* ptrData = data)
                {
                    Ys8Checksum ys8Checksum = new Ys8Checksum();
                    long checksumPosition = data.Length - 8; // x12
                    int i;
                    long checkSumBeginning; // fileSize - 11
                    int lowerChecksum;
                    int higherChecksum;
                    int generatedChecksum1; //w11
                    int generatedChecksum2; // w10
                    byte* dataPtr;

                    int w14;
                    long x16;
                    long x15;

                    if (checksumPosition < 8)
                    {
                        return null;
                    }

                    lowerChecksum = *((int*)(ptrData + checksumPosition)); // get the first 4 bytes of checksum;
                    higherChecksum = *(int*)(ptrData + data.Length - 4);// Get the last 4 bytes of checksum?
                    checkSumBeginning = data.Length - 11;

                    if (checkSumBeginning < 11 || checkSumBeginning == 0)
                    {
                        i = 0;
                        generatedChecksum1 = 0;
                        generatedChecksum2 = 0;
                    }
                    else
                    {
                        generatedChecksum1 = 0;
                        generatedChecksum2 = 0;

                        for (i = 0; i < checkSumBeginning; i += 4)
                        {
                            int temp = *(int*)(ptrData + i);
                            generatedChecksum1 += temp;
                            temp = ~temp;
                            generatedChecksum2 += temp;
                        }
                    }

                    if (i != checksumPosition)
                    {
                        if (i >= checksumPosition)
                        {
                            w14 = 0;
                        }
                        else
                        {
                            w14 = (int)(data.Length - i);
                            x15 = data.Length - 9;
                            if ((w14 & 1) != 0)
                            {
                                w14 = *(int*)(ptrData + (i << 2));
                                x16 = i + 1;
                            }
                            else
                            {
                                w14 = 0;
                                x16 = i;
                            }

                            if (x15 != i)
                            {
                                dataPtr = ptrData + (x16 << 2);
                                dataPtr += 4;
                                for (i = (int)(checksumPosition - x16); i != 0; i -= 2)
                                {
                                    int temp = *(int*)(dataPtr - 4);
                                    w14 = temp + (w14 << 8);
                                    temp = *(int*)dataPtr;
                                    dataPtr += 8;
                                    w14 = temp + (w14 << 8);
                                }
                            }
                        }
                        i = ~w14;
                        generatedChecksum1 += generatedChecksum1;
                        generatedChecksum2 += i;
                    }
                    ys8Checksum.Checksum1 = generatedChecksum1;
                    ys8Checksum.Checksum2 = generatedChecksum2;

                    return ys8Checksum;
                }
            }
        }
        #endregion

        #region Fields
        private byte[] m_data;
        private readonly Ys8Data m_database;

        private Dictionary<string, long> m_adolOffsets = new Dictionary<string, long>()
        {
            { "level", 0x44 },
            { "max_hp", 0x48 },
            { "equipped", 0x7d0 }
        };
        private Dictionary<string, long> m_laxiaOffsets = new Dictionary<string, long>()
        {
            { "level", 0x6c },
            { "max_hp", 0x70 },
            { "equipped", 0x96c }
        };
        private Dictionary<string, long> m_sahadOffsets = new Dictionary<string, long>()
        {
            { "level", 0x94 },
            { "max_hp", 0x98 },
            { "equipped", 0xb08 }
        };
        private Dictionary<string, long> m_hummelOffsets = new Dictionary<string, long>()
        {
            { "level", 0xbc },
            { "max_hp", 0xc0 },
            { "equipped", 0xca4 }
        };
        private Dictionary<string, long> m_ricottaOffsets = new Dictionary<string, long>()
        {
            { "level", 0xe4 },
            { "max_hp", 0xe8 },
            { "equipped", 0xe40 }
        };
        private Dictionary<string, long> m_danaOffsets = new Dictionary<string, long>()
        {
            { "level", 0x10c },
            { "max_hp", 0x110 },
            { "equipped", 0xfdc }
        };
        private Dictionary<string, long> m_currentInventoryOffsets = new Dictionary<string, long>()
        {
            { "count", 0xb5f0 },
            { "obtained", 0xc0b4 }
        };
        private Dictionary<string, long> m_previousInventoryOffsets = new Dictionary<string, long>()
        {
            { "count", 0xa6ab0 },
            { "obtained", 0xa7574 }
        };
        #endregion

        #region Properties
        public Ys8Inventory CurrentInventory
        {
            get;
            private set;
        }
        public Ys8Inventory PreviousInventory
        {
            get;
            private set;
        }
        public List<Ys8Character> Characters
        {
            get;
            private set;
        } = new List<Ys8Character>();
        #endregion

        #region Constructors/Destructors
        public Ys8Save(Ys8Data database, string path)
        {
            m_database = database ?? throw new ArgumentNullException("data");

            InitializeCharacters();
            InitializeInventories();
            LoadSave(path);
        }
        #endregion

        #region Helper Methods
        private void InitializeInventories()
        {
            CurrentInventory = new Ys8Inventory(m_database)
            {
                Offsets = m_currentInventoryOffsets
            };

            PreviousInventory = new Ys8Inventory(m_database)
            {
                Offsets = m_previousInventoryOffsets
            };
        }
        private void InitializeCharacters()
        {
            Characters.Add(new Ys8Character("Adol") { Offsets = m_adolOffsets });
            Characters.Add(new Ys8Character("Laxia") { Offsets = m_laxiaOffsets });
            Characters.Add(new Ys8Character("Sahad") { Offsets = m_sahadOffsets });
            Characters.Add(new Ys8Character("Hummel") { Offsets = m_hummelOffsets });
            Characters.Add(new Ys8Character("Ricotta") { Offsets = m_ricottaOffsets });
            Characters.Add(new Ys8Character("Dana") { Offsets = m_danaOffsets});
        }
        unsafe private void FixChecksum()
        {
            fixed (byte* dataPtr = m_data)
            {
                Ys8Checksum checksum = Ys8Checksum.GetChecksum(m_data);
                if (checksum != null)
                {
                    *(int*)(dataPtr + m_data.Length - 8) = checksum.Checksum1;
                    *(int*)(dataPtr + m_data.Length - 4) = checksum.Checksum2;
                }
            }
        }
        #endregion

        #region Methods
        public void LoadSave(string path)
        {
            BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read));
            m_data = br.ReadBytes((int)br.BaseStream.Length);
            br.Close();

            foreach (Ys8Character character in Characters)
            {
                character.SetCharacterData(m_data, m_database);
            }

            CurrentInventory.SetItems(m_data);
            PreviousInventory.SetItems(m_data);
        }

        public void Save(string path)
        {
            foreach (Ys8Character character in Characters)
                character.Save(m_data, m_database);

            CurrentInventory.Save(m_data);
            PreviousInventory.Save(m_data);
            FixChecksum();

            File.WriteAllBytes(path, m_data);
        }
        
        public void BackupSave(string path)
        {
            File.WriteAllBytes(path, m_data);
        }
        #endregion
    }
}
