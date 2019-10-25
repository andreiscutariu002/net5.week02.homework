namespace Week1
{
    using System;
    using System.Collections.Generic;

    public class Ex03
    {
        public static void Run()
        {
            int[] array = { 1, 4, 5, 2, 1, 4, 3, 1, 2 };

            int[] evens = new int[array.Length];
            int[] odds = new int[array.Length];
            int evenIdx = 0;
            int oddIdx = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evens[evenIdx++] = array[i];
                }
                else
                {
                    odds[oddIdx++] = array[i];
                }
            }

            Print(evens);
            Print(odds);
        }

        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}