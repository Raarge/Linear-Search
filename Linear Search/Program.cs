using System;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new[] { 1, 5, 0, 34, 3, 9 };

            Console.WriteLine("Original Array: ");
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.Write("Find in this Array. It is at position: ");
            var position = LinearSearch(myArray, 3);
            Console.Write(position + ". ");

        }

        private static int LinearSearch(int[] array, int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
