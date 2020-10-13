using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex05_num_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            char space = ' ';
            string line = "";
            Console.Write("Please enter the width of the square: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Please enter the height of the square: ");
            int height = int.Parse(Console.ReadLine());
            width *= 2;
            string endLine = new string(star, width);
            Console.WriteLine(endLine);
            for (int h = 0; h < height; h++)
            {
                //line = $"{star}";
                Console.Write(star);
                for (int w = 0; w <= width-2; w++)
                {
                    //line += space;
                    Console.Write(space);
                }
                //line += star;
                Console.WriteLine(star);
            }
            Console.WriteLine(endLine);
        }
    }
}
