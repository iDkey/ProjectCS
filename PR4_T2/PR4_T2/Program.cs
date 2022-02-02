using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            int minLength = 0;
            int maxLength = 0;
            int count = 0;
            for (int i = 0; text[i] != ' '; i++)
            {
                minLength = i;
                maxLength = i;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ')
                {
                    if(count > maxLength)
                    {
                        maxLength = count;
                    }
                    if (count < minLength)
                    {
                        minLength = count;
                    }
                    count = 0;
                }
                else
                    count++;
            }
            if (count > maxLength)
            {
                maxLength = count;
            }
            if (count < minLength)
            {
                minLength = count;
            }
            Console.WriteLine("Min: " + minLength.ToString());
            Console.WriteLine("Max: " + maxLength.ToString());
            Console.ReadKey();
        }
    }
}
