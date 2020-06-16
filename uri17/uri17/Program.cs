using System;
using System.Globalization;

namespace uri17
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGastoDeViagem, velocidadeMedia;
            double litrosNecessario, distanciaPercorrida;

            tempoGastoDeViagem = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempoGastoDeViagem * velocidadeMedia;

            litrosNecessario = distanciaPercorrida / 12;

           Console.WriteLine(litrosNecessario.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
