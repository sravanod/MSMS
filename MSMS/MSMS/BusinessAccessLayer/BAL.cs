using MSMS.IRepositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSMS.BusinessAccessLayer
{
    public class BAL
    {
        IReposit IObj;
        public BAL(IReposit _IObj)
        {
            IObj = _IObj;
        }
    }
}