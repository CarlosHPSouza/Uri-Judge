using System;
using System.Globalization;

namespace uri09
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo, totalDeVendas, total;

            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = totalDeVendas * 15 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
