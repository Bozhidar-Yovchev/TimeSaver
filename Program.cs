using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSaver
{
    class Program
    {
        static double Converter(double num, string first, string second)
        {

            if (first == "mm")
            {
                if (second == "m")
                {
                    return num /= 1000;
                }
                else if (second == "cm")
                {
                    return num /= 100;
                }
            }
            else if (first == "m")
            {
                if (second == "cm")
                {
                    return num *= 100;
                }
                else if (second == "mm")
                {
                    return num *= 1000;
                }
            }
            else if (first == "cm")
            {
                if (second == "m")
                {
                    return num /= 100;
                }
                else if (second == "mm")
                {
                    return num *= 10;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("First unit of measurement:");
            string first = Console.ReadLine();
            Console.WriteLine("Convert to:");
            string second = Console.ReadLine();

            Console.WriteLine($"{Converter(num, first, second):f3}");
        }
    }
}
