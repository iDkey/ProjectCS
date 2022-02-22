using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathFileToRead = "";
            string pathFileToWrite = "";
            Console.WriteLine("Input a path to file 1:");
            pathFileToWrite = Console.ReadLine();
            Console.WriteLine("Input count of lines:");
            pathFileToRead = Console.ReadLine();
            string plug = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(pathFileToWrite, true, System.Text.Encoding.Default))
                {
                    using (StreamReader sr = new StreamReader(pathFileToRead))
                    {
                        plug = sr.ReadToEnd();
                        sw.WriteLine(plug);
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
