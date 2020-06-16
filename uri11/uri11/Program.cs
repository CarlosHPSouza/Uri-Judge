using System;
using System.Globalization;

namespace uri11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double pi = 3.14159, volume, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume =  (4/3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
