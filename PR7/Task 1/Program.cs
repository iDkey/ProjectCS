using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int K = 0;
            string path = "";
            const char ch = '*';
            Console.WriteLine("Input a path to file:");
            path = Console.ReadLine();
            Console.WriteLine("Input count of lines:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Input count of symbols:");
            K = int.Parse(Console.ReadLine());
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < N; i++)
                    {
                        string line = "";
                        for (int j = 0; j < K; j++)
                        {
                            line += ch;
                        }
                        sw.WriteLine(line);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}
