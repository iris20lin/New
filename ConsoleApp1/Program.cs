using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int guess = 55;

            while (true)
            {
                string input_str = Console.ReadLine();
                int guess = new Random().Next(100); //0-100
                input = int.Parse(input_str);


                if (input==guess)
                {
                    break;
                }
                Console.WriteLine("gg");
            }
            
            
            Console.ReadKey();

        }
    }
}
