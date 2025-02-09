using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public readonly double PI;

        public MyMathClass()
        {
            PI = 3.14;
        }

        /* Error:
         * public void ChangePI()
        {
            PI = 3.44441;
        }
        */

        static void LocalConstStringVariable()
        {
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);
        }
    }
}
