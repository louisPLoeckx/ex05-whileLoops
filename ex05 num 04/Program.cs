using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_num_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int squared = 0;
            int number = 0;
            int check = 0;
            do
            {
                
                Console.WriteLine("Please enter a value:");
                number = int.Parse(Console.ReadLine());
                int whole = number % 2;
                check = number * number;
                
                if (whole == 0)
                {
                    squared = number * number;
                    Console.WriteLine(squared);
                }

            } while (squared == check);

        }
    }
}
