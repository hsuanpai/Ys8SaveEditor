using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Save_Editor
{
     public class Ys8Data
    {
        #region Fields
        #endregion

        #region Properties
        public List<Ys8Item> Ys8Items
        {
            get; internal set;
        } = new List<Ys8Item>();
        public List<Ys8Skill> Ys8Skills
        {
            get; internal set;
        } = new List<Ys8Skill>();
        #endregion

        #region Constructor/Destructors
        public Ys8Data()
        {
        }
        #endregion

        #region Helper Methods
        #endregion

        #region Methods
        public static Ys8Data DeserializeFromFile(string path)
        {
            Ys8Data ys8Data;

            XmlSerializer serializer = new XmlSerializer(typeof(Ys8Data));
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

            ys8Data = (Ys8Data)serializer.Deserialize(fs);
            fs.Close();

            return ys8Data;
        }
        public static Ys8Data DeserializeFromString(string data)
        {
            Ys8Data ys8Data;

            XmlSerializer serializer = new XmlSerializer(typeof(Ys8Data));

            using (TextReader reader = new StringReader(data))
            {
                ys8Data = (Ys8Data)serializer.Deserialize(reader);
            }

            return ys8Data;
        }
        #endregion
    }
}
