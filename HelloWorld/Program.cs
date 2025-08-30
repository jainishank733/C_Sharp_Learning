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


            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Round(3.14D));
            Console.WriteLine(s.Length);
            Console.WriteLine(String.Concat("Ishnak ", "Jain"));
            String firstName = "Ishnak", lastName = "Jain";
            Console.WriteLine($"FirstName: {firstName} and LastName: {lastName}");


            Console.WriteLine(s[0]+" and " + s[2]);
            Console.WriteLine(s.IndexOf('a'));
            Console.WriteLine(s.Substring(3));

            Console.WriteLine("\"Hello to this world \"");
            Console.WriteLine("\'Hello to new world \'");
            Console.WriteLine("\\Hello to new world \\");
            Console.WriteLine("\nHello to new world \n");

             
            if (20 > 18) Console.WriteLine("20 is greater than 18");
            else if (18 > 16) Console.WriteLine("18 is greater than 16");
            else Console.WriteLine("None"); 


            String result = (18>17) ? "18 is greater than 17" : "None";




            int day = 4;
            switch (day)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                default: Console.WriteLine("None");
                    break;
            }


            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            for (int j = 0; j < 5; j++)
            {
                if (j == 3) continue;
                Console.WriteLine(j);
            }

            String[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(String car in cars)
            {
                Console.Write(car+" ");
            }


            Array.Sort(cars);











        }
    }
}