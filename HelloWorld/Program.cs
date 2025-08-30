using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(5 + 5);

            String name = "Alice";
            Console.WriteLine(name);
            Console.WriteLine($"Hello there, {name}!");
            int mynum = 15;
            Console.WriteLine(mynum);


            const double pi = 3.14D, bi = 2.14D;
            Console.WriteLine("Const var " + pi + bi);

            double radius = 5.0D;
            int ra = (int)radius;
            Console.WriteLine("Radius " + ra);
            Console.WriteLine(Convert.ToString(ra));


            String s = Console.ReadLine();
            Console.WriteLine("You entered: " + s);

            Console.WriteLine(3 > 4 || 7 > 9);


            Cons



        }
    }
}