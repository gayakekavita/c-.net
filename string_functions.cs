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


            

            String str = "Hello Everyone";
            Console.WriteLine("Length of string " + str + "is " + str.Length);
            Console.WriteLine(str+" in lower case: " + str.ToLower());
            Console.WriteLine(str + " in upper case: " + str.ToUpper());
            Console.WriteLine(String.Concat(str,"welcome"));
            String name = "kavya";
            int candies = 45;
            //String interpolation
            Console.WriteLine($"My name is {name}. i will get {candies} candies");
            Console.ReadLine();

    
        }
    }
}
