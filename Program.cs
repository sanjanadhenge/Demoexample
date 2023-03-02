using System;
namespace Demoexample
{
    class program
    {
        static void Main(string[] args)
        {
           int a ,b ;
            Console.WriteLine("Please Enter First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second number");
            b = Convert.ToInt32(Console.ReadLine());
            int c = a + b ;
            Console.WriteLine("Addition of two number is " + c);
            Console.ReadKey();
        }
    }
}
