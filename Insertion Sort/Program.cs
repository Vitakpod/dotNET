using System;

namespace Insertion_Sort
{
    class Program
    {
        static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the array: ");
            var numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = Convert.ToInt32(numbers[i]);
            }
            Console.WriteLine("The ordered array: {0}", string.Join(", ", Sort(array)));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
