using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Var_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# can convert between instances of compatible types.

            int x = 12345;  //int is a 32-bit integer
            long y = x;     //implicit conversion to 64-bit integer
            short z = (short)x; //Explicit conversion to 16-bit integer
        }
    }
}
