using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static bool comparsionZero(double a)
        {
            if((a + 0.01 > 0 ) && (a - 0.01 > 0))
            {
                return true;
            }
            else
                return false;
        }
        static bool comparsionNum(double a, double b)
        {
            if ((a + 0.01) < b && (a - 0.01 < b))
            {
                return true;
            }
            else
                return false;
        }
        static void typeTriangle(double a, double b, double c)
        {
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
            {
                Console.WriteLine("right");
            }
            else
            if (a * a < b * b + c * c || b * b < a * a + c * c || c * c < b * b + a * a)
            {
                Console.WriteLine("obtuse");
            }
            else
            if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > b * b + a * a)
            {
                Console.WriteLine("acute"); 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a side:");
            string aSideStr = Console.ReadLine();
            Console.WriteLine("Input b side:");
            string bSideStr = Console.ReadLine();
            Console.WriteLine("Input c side:");
            string cSideStr = Console.ReadLine();
            double aSide;
            double bSide;
            double cSide;
            double area;
            if (double.TryParse(aSideStr, out aSide) && double.TryParse(bSideStr, out bSide) && double.TryParse(cSideStr, out cSide))
            {
                if(comparsionZero(aSide) && comparsionZero(bSide) && comparsionZero(cSide))
                {
                    if(comparsionNum(aSide, bSide + cSide) && comparsionNum(bSide, aSide + cSide) && comparsionNum(cSide, bSide + aSide))
                    {
                        double p = (aSide + bSide + cSide) / 2;
                        area = Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));
                        Console.WriteLine("Area is " + area.ToString());
                        typeTriangle(aSide, bSide, cSide);
                    }
                    else 
                    {
                        Console.WriteLine("Imposible");
                    }
                }
                else
                {
                    Console.WriteLine("Imposible");
                }
            }
            else
            {
                Console.WriteLine("Imposible");
            }
            Console.ReadKey();
        }
    }
}


