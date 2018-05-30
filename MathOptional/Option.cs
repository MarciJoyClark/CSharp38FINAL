using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOptional
{
    public class Option
    {
        public static int option(int number)
        {
            int newOp = number * 10;
            return newOp;
        }
        public static int option2(int optionalInt, int times = 2)
        {
            int newOp2 = optionalInt * times;
            return newOp2;
        }              
    }
}
