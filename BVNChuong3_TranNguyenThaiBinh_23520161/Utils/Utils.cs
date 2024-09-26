using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVNChuong3_TranNguyenThaiBinh_23520161.Utils
{
    internal static class Utils
    {
        public static int GCD(int num1, int num2)
        {
            int Remainder;
            while (num2 != 0)
            {
                Remainder = num1 % num2;
                num1 = num2;
                num2 = Remainder;
            }
            return num1;
        }
    }
}
