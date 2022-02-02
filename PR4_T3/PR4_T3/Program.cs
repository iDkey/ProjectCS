using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string line = Console.ReadLine();
            for (int i = 0; line[i] != ':'; i++)
            {
                count++;
            }
            Console.WriteLine(count.ToString() + " simbols before ':'");
            Console.ReadKey();
        }
    }
}
