using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayIntArray(new int[] {2, 3, 4, 7, 8, 9 });
            Console.WriteLine("");
            var temp = GenerateRandomArray(15, 10);
            DisplayIntArray(temp);
            Console.Write("\n\tEven and Odd are ");
            var count = CountOddEvent(temp);
            DisplayIntArray(count);
            Console.WriteLine("");
        }

        static void DisplayIntArray(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write($"{item,3}");
            }

        }
        static int[] GenerateRandomArray(int numberofItem, int largestValue)
        {
            Random generator = new Random();
            int[] result = new int[numberofItem];
            for (int i = 0; i < numberofItem; i++)
                result[i] = generator.Next(largestValue);
            return result;

        }
        static int[] CountOddEvent(int[] array)
        {
            int[] result = new int[2];
            foreach (var item in array)
            {
                result[item % 2]++;
            }


            return result;
        }

    }
}
