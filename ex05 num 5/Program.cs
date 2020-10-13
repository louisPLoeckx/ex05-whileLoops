using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_num_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] numArray = new int[count];
            int number;
            int max = 0;
            int min = 0;

            do
            {
                count++;
                do
                {
                    Console.WriteLine("Please enter a number a positive number(to close enter -1): ");
                    number = int.Parse(Console.ReadLine());
                    if (max <= number)
                    {
                        max = number;
                        Console.WriteLine($"max: {max}");
                    }
                    if (min >= number)
                    {
                        min = number;
                        Console.WriteLine($"min: {min}");
                    }

                } while (number >= 0);
                
            } while (number != -1);

            //int max = numArray.Max();
            //Console.WriteLine($"max: {max}");
            //int min = numArray.Min();
            //Console.WriteLine($"min: {min}");

            int diff = max - min;
            Console.WriteLine($"diff: {diff}");
        }
    }
}
