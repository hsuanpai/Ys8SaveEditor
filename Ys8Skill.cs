using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace Save_Editor
{
    [XmlRoot("Skill")]
    public class Ys8Skill
    {
        #region Fields
        #endregion

        #region Properties
        [XmlElementAttribute("id1", typeof(int))]
        public int ID1
        {
            get;
            set;
        }
        [XmlElementAttribute("id2", typeof(int))]
        public int ID2
        {
            get;
            set;
        }
        [XmlElementAttribute("id3", typeof(int))]
        public int ID3
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string EffectDescription
        {
            get;
            set;
        }
        [XmlElementAttribute("owner", typeof(Ys8CharacterEnum))]
        public Ys8CharacterEnum Owner
        {
            get;
            set;
        }
        #endregion

        #region Constructors/Destructors
        #endregion

        #region Helper Methods
        #endregion
    }
}
