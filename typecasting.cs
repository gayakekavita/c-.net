using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class first
    {
        static void Main(String[] args)
        {
            /*
             There are two types of casting:
              1.Implicit 
              2.Explicit
             */
            //Implicit casting
            int a = 3;
            float f = a;//implicit casting is done here
            double d = a;//here also implicit casting is done
            float z=43.45f;
            double p = z;
            int character = 'y';//implicit casting
            float chara = 'y';


            //Explicit casting
            int x = (int)d;
            int y = (int)f;

            /*
             other conversion methods
             1.Convert.toInt64
             2.Convert.toInt32
             3.Convert.toString
             4.Convert.toDouble
             */
        }
    }
}
