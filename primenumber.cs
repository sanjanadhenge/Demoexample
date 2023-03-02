using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoexample
{
    internal class primenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers from 1 to 100 are :");
            int f = 1;
           for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= i/2; j++)

                {
                    if (i % j == 0)
                    {
                        f = 0;
                        break;
                    }
                   f = 1;

                }
                if (f == 1 )
                {
                    Console.WriteLine(i);

                }
            }
           Console.ReadKey();
        
        }
    }
}
