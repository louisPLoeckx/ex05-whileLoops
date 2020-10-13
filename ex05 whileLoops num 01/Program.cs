 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_whileLoops_num_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 101)
            {
                int wholeNumber = number % 2;
                number++;

                if(wholeNumber == 0)
                {
                    int squared = number* number;
                    Console.WriteLine($"{number} squared is {squared}");
                }
                ;
            }
        }
    }
}
