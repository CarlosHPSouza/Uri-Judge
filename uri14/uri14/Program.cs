using System;
using System.Globalization;

namespace uri14
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaTotalPercorrida;
            double combustivelGasto, valorMedio;

            distanciaTotalPercorrida = int.Parse(Console.ReadLine());
            combustivelGasto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            valorMedio = (double) distanciaTotalPercorrida / combustivelGasto;

            Console.WriteLine(valorMedio.ToString("F3",CultureInfo.InvariantCulture) + " Km/l");



        }
    }
}
