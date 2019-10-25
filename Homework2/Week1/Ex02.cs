namespace Week1
{
    using System;

    // metoda simpla de rezolvare (ineficienta)
    // metoda eficienta: https://www.geeksforgeeks.org/count-frequencies-elements-array-o1-extra-space-time/
    // se mai poate folosi si dictionar pentru implementare
    public class Ex02
    {
        public static void Run()
        {
            int[] array = {1, 4, 5, 2, 1, 4, 3, 1, 2};

            var keys = new int[array.Length];
            var count = new int[array.Length];

            for (var i = 0; i < array.Length; i++)
            {
                var currentElement = array[i];
                if (AlreadyCounted(keys, currentElement)) // verificam daca a fost deja numarat
                {
                    var firstIndex = IndexOf(array, currentElement); // daca da, folosim index-ul
                    count[firstIndex]++;
                }
                else
                {
                    keys[i] = currentElement;
                    count[i] = 1;
                }
            }

            for (var i = 0; i < keys.Length; i++)
                if (count[i] > 0)
                    Console.WriteLine($"Elem {keys[i]}: {count[i]}");
        }

        private static bool AlreadyCounted(int[] keys, int i)
        {
            for (var j = 0; j < keys.Length; j++)
                if (keys[j] == i)
                    return true;

            return false;
        }

        private static int IndexOf(int[] keys, int i)
        {
            for (var j = 0; j < keys.Length; j++)
                if (keys[j] == i)
                    return j;

            return -1;
        }
    }
}
