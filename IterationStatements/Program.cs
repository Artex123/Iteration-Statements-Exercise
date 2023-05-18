namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool TwoIntegers(int a, int b) 
        {
            if (a == b)
            {
                Console.WriteLine($"{a} and {b} is the same");
                return true;
            }
            else 
            {
                Console.WriteLine($"{a} and {b} are not the same");
                return false;
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void Evens(int num) 
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else 
            {
                Console.WriteLine($"{num} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static bool Positive(int num) 
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is posisive");
                return true;
            }
            else 
            { 
                Console.WriteLine($"{num} is negative");
                return false;
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool Vote() 
        {
            Console.WriteLine("Age Please");
            var canParse = int.TryParse(Console.ReadLine(), out int userage);

            while (canParse == false) 
            {
                Console.WriteLine("Valid Age Please");
                canParse = int.TryParse(Console.ReadLine(),out userage);
            }
            if (userage >= 18)
            {
                Console.WriteLine($"This {userage} can vote");
                return true;
            }
            else 
            {
                Console.WriteLine($"Invalid {userage} is not a voting age");
                return false;
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool TenIsTheWay(int num) 
        {
            if (num <= 10 && num >= -10)
            {
                Console.WriteLine($"{num} is in range!");
                return true;
            }
            else 
            {
                Console.WriteLine($"{num} is not in range, how sad");
                return false;
            }
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Multiply(int num) 
        {
            for (int i = 1; i <= 12; i++) 
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintThousand();
            Threes();
            //TwoIntegers(5,3);
           // Evens(5);
            //Positive(5);
           //Vote();
            //TenIsTheWay(15);
            //Multiply(7);
        }
        
    }
}
