using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_num_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int count = 0;
            int[] array = new int[count];
            int sum = 0;

            do
            {
                Console.Write("Please enter a number: ");
                count++;
                number = int.Parse(Console.ReadLine());
                array.Append(number);
                sum += number;

                
            } while (number > 0);
            Console.WriteLine($"The sum of all of your numbers is {sum}");
        }
    }
}
