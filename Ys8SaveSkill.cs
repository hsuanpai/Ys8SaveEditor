using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Editor
{
    public class Ys8SaveSkill
    {
        #region Fields
        private const int m_maxRank = 3;
        private int m_rank = 1;
        #endregion

        #region Properties
        public Ys8Skill Parent
        {
            get; private set;
        }
        public bool Unlocked
        {
            get; set;
        }
        public int Rank
        {
            get { return m_rank; }
            set
            {
                if (value > 0 && value <= m_maxRank)
                    m_rank = value;
            }
        }
        public int ID
        {
            get { return Parent.ID1; }
        }
        public string Name
        {
            get { return Parent.Name; }
        }
        public string Description
        {
            get { return Parent.Description; }
        }
        public string EffectDescription
        {
            get { return Parent.EffectDescription; }
        }
        public Ys8CharacterEnum Owner
        {
            get { return Parent.Owner; }
        }
        #endregion

        #region Constructors/Destructors
        public Ys8SaveSkill(Ys8Skill parent, int rank = 1)
        {
            Parent = parent ?? throw new ArgumentNullException("parent");
            Rank = rank;
        }
        #endregion

        #region Methods
        #endregion
    }
}
