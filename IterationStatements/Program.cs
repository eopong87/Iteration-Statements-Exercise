namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThree()
        {

            for (int I = 3; I <= 999; I += 3)
            {
                Console.WriteLine(I);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void IsEqual(int a, int b)
        {
           // var check = (a == b) ? true : false;
           // return check;

            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            else
            {
                Console.WriteLine($"{a}Is Not Equal to {b}");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void PrintRange1()
        {
            for (int i = 1000; i <= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void EvenOrOdd(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNeg(int num1)
        {
            if (num1 < 0)
            {
                Console.WriteLine($"{num1} is negative");
            }
            else
            {
                Console.WriteLine($"{num1} is positve");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CheckAge()
        {
            Console.WriteLine("what is your age? I can tell if youcan vote:");
            bool validNumber = int.TryParse(Console.ReadLine(), out int age);
            if (validNumber == true)
                if (age >= 18)
                {
                    Console.WriteLine("you can vote.");
                }
                else
                {
                    Console.WriteLine("you cant vote yet.");
                }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintRange(); 
        }
    }













}
