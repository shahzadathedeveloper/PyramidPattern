using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    internal class ArrayPractice
    {
        public void ReverArrayOrder()
        {
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter value to add in unsorted array");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Reverse logic of array list start here
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }

                    Console.Write($"{numbers[i]} ");
                }
                //logic to print sorted array
                //for (int i = 0; i < sortednumber.Length; i++)
                //{
                //    Console.Write($"{sortednumber[i]} ");
                //}
                Console.WriteLine();
            }
        }
    }
}
