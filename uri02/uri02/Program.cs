using System;
using System.Globalization;

namespace uri02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area =  Math.Pow(raio,2)* 3.14159 ;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
