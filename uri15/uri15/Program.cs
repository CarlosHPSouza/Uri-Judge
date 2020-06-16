using System;
using System.Globalization;

namespace uri15
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, valorDistancia, p1, p2;

            string[] vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            p1 = (x2 - x1);
            p2 = (y2 - y1);
            valorDistancia = Math.Sqrt(Math.Pow(p1, 2.0) + Math.Pow(p2, 2.0));

            Console.WriteLine(valorDistancia.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}
