using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoyTests.Maths
{
    class DiscountCode
    {
        private int discountPercent { get; set; }
        private string discountName { get; set; }

        public DiscountCode(int discountPercent, string discountName)
        {
            discountPercent = discountPercent;
            discountName = discountName;
        }

        public bool CompareDiscountCodes(DiscountCode firstCode, DiscountCode secondCode)
        {
            return firstCode.discountPercent == secondCode.discountPercent &&
                   secondCode.discountName == firstCode.discountName;
        }

    }
}
