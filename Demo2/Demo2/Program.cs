using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} = {1}", 100, ConvertCelsiusToFahrenheit(100));

            Console.WriteLine("{0} = {1}", 212, ConvertFahrenheitToCelsius(212));

            Console.WriteLine("{0} = {1}", 50, ConvertCelsiusToFahrenheit(50));

            Console.WriteLine("{0} = {1}", 122, ConvertFahrenheitToCelsius(122));

            Console.ReadKey();
        }

        public static double ConvertCelsiusToFahrenheit(double c)
        {
            return ((9.0 / 5.0) * c) + 32;
        }

        public static double ConvertFahrenheitToCelsius(double f)
        {
            return (5.0 / 9.0) * (f - 32);
        }
    }
}
