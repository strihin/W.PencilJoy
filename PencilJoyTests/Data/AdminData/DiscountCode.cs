using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests.Data.AdminData
{
    class DiscountCode
    {
        internal string CodeName { get; set; }
        internal int CodeValue { get; set; }

        public DiscountCode(string CodeName, int CodeValue)
        {
            CodeName = CodeName;
            CodeValue = CodeValue;
        }

    }
}
