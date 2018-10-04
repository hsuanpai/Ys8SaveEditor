using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Save_Editor
{
    public class Ys8SaveItem
    {
        #region Fields
        #endregion

        #region Properties
        public Ys8Item Parent
        {
            get; private set;
        }
        public int Count
        {
            get; set;
        }
        public string Name
        {
            get { return Parent.Name; }
        }
        public string EffectDescription
        {
            get { return Parent.EffectDescription; }
        }
        public string Description
        {
            get { return Parent.Description; }
        }
        public int ID
        {
            get { return Parent.ID; }
        }
        public Ys8ItemType Type
        {
            get { return Parent.Type; }
        }
        public int Rank
        {
            get { return Parent.Rank; }
        }

        #endregion

        #region Constructors/Destructors
        public Ys8SaveItem(Ys8Item parent, int count = 0) 
        {
            Parent = parent ?? throw new ArgumentNullException("parent");
        }
        #endregion

        #region Methods
        #endregion
    }
}
