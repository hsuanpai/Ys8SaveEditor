using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Editor
{
    public interface ISaveOffset
    {
        #region Properties
        Dictionary<string, long> Offsets
        {
            get;
        }
        #endregion
    }
}
