using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    internal class Program
    {
        private 
            char[] symbols = { '*', ';', '.' };
            string line;
        
        static void Main(string[] args)
        {
            StringBuilder line = new StringBuilder(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 0; i < line.Length; ++i)
            {
                if (line[i] == '*')
                    count1++;
                if (line[i] == ';')
                    count2++;
                if (line[i] == '.')
                    count3++;
            }
            Console.WriteLine("In text:");
            Console.WriteLine(count1.ToString() + " simbol(s) *");
            Console.WriteLine(count2.ToString() + " simbol(s) ;");
            Console.WriteLine(count3.ToString() + " simbol(s) .");
            Console.ReadKey();
        }
    }
}
