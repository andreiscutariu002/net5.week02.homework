namespace Week1
{
    using System;

    public class Ex01
    {
        public static void Run()
        {
            for (var i = 1; i <= 100; i++)
                CheckFizzBuz(i);
        }

        private static void CheckFizzBuz(int i)
        {
            if (i % 15 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else
            {
                if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else
                    Console.Write(i + " ");
            }
        }
    }
}
