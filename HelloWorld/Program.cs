using System;

namespace HelloWorld
{
    class Program
    {


        static void Fun(String name, int age)
        {
            Console.WriteLine($"Name: {name} and Age: {age}");
        }

        static void Fun2(String name = "Ishu")
        {
            Console.WriteLine("Fun2 " + name);
        }

        static int plusMethod(int x, int y)
        {
            return x + y;
        }

        static double plusMethod(double x, double y)
        {
            return x + y;
        }

        public int MyMethod(int a)
        {
            return a * 2;
        }

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


            String s = "Ishank";
            Console.WriteLine("You entered: " + s);

            Console.WriteLine(3 > 4 || 7 > 9);


            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Round(3.14D));
            Console.WriteLine(s.Length);
            Console.WriteLine(String.Concat("Ishnak ", "Jain"));
            String firstName = "Ishnak", lastName = "Jain";
            Console.WriteLine($"FirstName: {firstName} and LastName: {lastName}");


            Console.WriteLine(s[0] + " and " + s[2]);
            Console.WriteLine(s.IndexOf('a'));
            Console.WriteLine(s.Substring(3));

            Console.WriteLine("\"Hello to this world \"");
            Console.WriteLine("\'Hello to new world \'");
            Console.WriteLine("\\Hello to new world \\");
            Console.WriteLine("\nHello to new world \n");


            if (20 > 18) Console.WriteLine("20 is greater than 18");
            else if (18 > 16) Console.WriteLine("18 is greater than 16");
            else Console.WriteLine("None");


            String result = (18 > 17) ? "18 is greater than 17" : "None";




            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("None");
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
            foreach (String car in cars)
            {
                Console.Write(car + " ");
            }


            Array.Sort(cars);


            Fun("Ishank", 26);


            Fun(age: 26, name: "Ishank");

            Fun("Ishank", age: 26);
            Fun(name: "Ishank", 26);



            Fun2();
            Fun2("Ishu Jain");


            Program p = new Program();
            Console.WriteLine(p.MyMethod(5));


            Console.WriteLine(plusMethod(8, 5));
            Console.WriteLine(plusMethod(4.3, 6.26));



            Car car1 = new Car("Red");
            Console.WriteLine(car1.color);

            car1.fun();

            car1.honk();
            Console.WriteLine(car1.brand);



            car1.engineName();



            try {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            try
            {
                int[] number = { 1, 2, 3 };
                Console.WriteLine(number[4]);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }


        }
    }


    class Vehicle
    {
        public String brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }

        public virtual void engineName()
        {
            Console.WriteLine("Engine Name is F1");
        }

    }

    class Car: Vehicle
    {
        public Car(String color)
        {
            this.color = color;
        }

        public String color;
        public void fun()
        {
            Console.WriteLine("Car class function");
        }

        public override void engineName()
        {
            Console.WriteLine("Car Engine Name is C1");
        }

    }

    abstract class Thing
    {
        public abstract void abstractFun();


    }


    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
        void sleep(); // interface method (does not have a body)
    }


    enum Level { low, med, high}

}


