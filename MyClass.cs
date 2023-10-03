using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed_Binary_Addition
{
    class MyClass
    {
        public static long toDecimal(long num, int Base)
        {
            long converted = 0;
            long index = 0;
            long en;
            while (num != 0)
            {
                en = num % 10;
                converted += (long)(en * Math.Pow(Base, index));
                num /= 10;
                index++;
            }

            return converted;
        }
        public static Boolean isValidate(String binary)
        {

            for(int i=0; i<binary.Length; i++)
            {
                if(binary[i]!='0' && binary[i] !='1')
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}

;