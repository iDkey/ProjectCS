using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double x = 0;
            Console.WriteLine("Input a x:");
            x = double.Parse(Console.ReadLine());
            try
            {
                if (x >= 3 && x <= 4)
                {
                    result = Math.Pow(x, 0.333333);
                    result = Math.Round(result, 4);
                    Console.WriteLine(result);
                }
                else
                    throw new Exception("Wrong data");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
            Console.ReadKey();
        }
    }
}
