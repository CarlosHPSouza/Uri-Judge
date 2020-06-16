using System;
using System.Globalization;

namespace uri10
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca, numeroPeca, codigoPeca2, numeroPeca2;
            double valorUnitarioPeca, valorPagar, valorUnitarioPeca2;


            string[] vet = Console.ReadLine().Split(' ');
            codigoPeca = int.Parse(vet[0]);
            numeroPeca = int.Parse(vet[1]);
            valorUnitarioPeca = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vet2[0]);
            numeroPeca2 = int.Parse(vet2[1]);
            valorUnitarioPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
                                             
            valorPagar = numeroPeca * valorUnitarioPeca + numeroPeca2 * valorUnitarioPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2",CultureInfo.InvariantCulture));

                                          
        }
    }
}
