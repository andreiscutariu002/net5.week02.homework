namespace Week1
{
    using System;

    public class Ex04B
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number: ");
            string inputStr = Console.ReadLine();
            int number = int.Parse(inputStr);

            if (IsPrime(number))
            {
                Console.WriteLine("Number is prime!");
            }
            else
            {
                Console.WriteLine("Number not is prime!");
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            var boundary = number / 2;

            for (var i = 3; i <= boundary; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}