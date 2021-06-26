using System;

namespace Rectangle
{
    class Program
    {
 
        static void Main(string[] args)
        {

            int a = 1;
            string var = "my first variable";
            Console.WriteLine(var + a);
            Console.WriteLine("Hello World!");

            int length = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());

            Class1 rect = new Class1();
            Class1.Calculate();

            Console.WriteLine(rect.calcualteArea(length, breadth));

            Console.ReadKey(true);
        }
    }
}
