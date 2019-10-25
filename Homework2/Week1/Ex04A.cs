namespace Week1
{
    using System;

    public class Ex04A
    {
        public static void Run()
        {
            int[] array1 = { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
            int[] array2 = { 1, 4 };

            for (int i = 0; i < array1.Length; i++)
            {
                if (ArrayContains(array2, array1[i]))
                {
                    Console.WriteLine($"{array1[i]} contained by both arrays");
                }
            }
        }

        private static bool ArrayContains(int[] array, int elem)
        {
            for (var j = 0; j < array.Length; j++)
                if (array[j] == elem)
                    return true;

            return false;
        }
    }
}