using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleAppication
{
    class Program
    {
        static void Main(string[] args)
        {
            // comment
            /*
             * also comment
             */
            Console.WriteLine("hello, world");
            // get user input
            Console.Write("what is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);

            bool canVote = true;

            char grade = 'A';

            int maxInt = int.MaxValue;

            long maxLong = long.MaxValue;

            float maxFloat = float.MaxValue;

            double maxDouble = double.MaxValue;

            Console.WriteLine("MaxInt: " + maxInt);

            var anotherName = "Tom";
            Console.WriteLine("anotherName is a {0} ", anotherName.GetTypeCode());

            double pi = 3.14;
            int intPi = (int)pi;

            var age = 20;

            if (age > 18)
            {
                Console.WriteLine("It is an adult");
            }
            else
            {
                Console.WriteLine("It is a minor");
            }

            bool canDrive = age >= 18 ? true : false;

            switch (age)
            {
                case 0:
                    Console.WriteLine("infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    break;
            }

            int i = 0;
            while (i < 10)
            {
                i++;
                if (i == 10)
                {
                    break;
                }
            }

            string randStr = "herre are some random character";

            if (!String.IsNullOrEmpty(randStr))
            {

                foreach (char c in randStr)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("This string is null or empty");
            }

            int[] randArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array Length " + randArray.Length);

            Console.WriteLine("what is the index of element \'1\' " + Array.IndexOf(randArray, 1));

            string[] names = { "Tom", "Paul", "Sally" };

            string nameStr = string.Join(", ", names);

            string[] nameString = nameStr.Split(",");

            // multi dimensional array defined with a comma in the bracket

            int[,] multiArray = new int[5, 3];

            int[,] multiArray2 = { { 1, 2, 3 }, { 3, 4, 5 } };

            foreach (int num in multiArray2)
            {
                Console.WriteLine(num); // print element by element in 2 d array
            }

            for (int x = 0; x < multiArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multiArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0}|{1}: {2}", x, y, multiArray2[x, y]);
                }
            }

            List<int> numList = new List<int>();
            numList.Add(5);
            // add array elems to the list
            numList.AddRange(randArray);

            // add an element at a particular index
            numList.Insert(1, 10);

            // remove the element that is equal to 5
            numList.Remove(5);

            // remove the element at the index 5
            numList.RemoveAt(2);

            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });
            Console.WriteLine(" Tom in the List " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            strList.Sort();

            // parsing string into integer

            try
            {
                Console.Write("please enter the string to parse: ");
                int result = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"unable to parse input");
            }

            if (Int32.TryParse("-105", out int j))
            {
                Console.WriteLine(j);
            }
            else
            {
                Console.WriteLine(j);
            }

            try
            {
                Console.WriteLine("{10/0}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("cannot divide by zero " + ex.GetType().Name);
                throw new InvalidOperationException("Operation failed ", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Animal spot = new Animal(15, 10, "Spot");
            Console.WriteLine(spot.ToString());

            Dog dollar = new Dog(20, 15, "Dollar", "Pedigree");
            Console.WriteLine(dollar.toString());

        }

        class Animal
        {
            public double height { get; set; }
            public double weight { get; set; }
            public string name;
            // lets only allow some rules for getters and setters
            public string Name
            {
                get { return name; }
                set
                {
                    if (value == "tom")
                    {
                        name = "cat";
                    }
                    else
                    {
                        name = value;
                    }
                }
            }

            public Animal()
            {
                this.height = 0;
                this.Name = "no name";
                numOfAnimal++;
            }

            public Animal(double height, double weight, string name)
            {
                this.height = height;
                this.weight = weight;
                this.name = name;
                numOfAnimal++;
            }

            static int numOfAnimal = 0;
            public static int getNumOfAnimals()
            {
                return numOfAnimal;
            }

            public string toString()
            {
                return String.Format("{0} is {1} inches tall, weighs {2}lbs and likes to say {3}", name, height, weight);
            }
        }

        class Dog : Animal
        {
            public string favFood { get; set; }
            // call the initialisation in the super class
            public Dog() : base()
            {
                this.favFood = "no fav food";
            }

            public Dog(double height, double weight, string name, string favFood) : base(height, weight, name)
            {
                this.favFood = favFood;
            }

            // if we want to overshadow the method of the parent class, we have to use the new keyword
            new public string toString()
            {
                return String.Format("{0} is {1} inches tall, weighs {2}lbs and likes to say {3} and its fav food is", name, height, weight, favFood);
            }

        }

    }
}
