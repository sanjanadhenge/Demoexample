using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoexample
{
    internal class Greatest_among_three
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("Please Enter First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Third number");
            c = Convert.ToInt32(Console.ReadLine());
           if ( a > b && a > c)
            {
                Console.WriteLine("The greatest among three is " + a);

            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The greatest among three is " + b);
            }
            else
            {
                Console.WriteLine("The greatest among three is " + c);
            }
            Console.ReadKey();
        }
    }
}
