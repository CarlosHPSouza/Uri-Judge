using System;
using System.Globalization;

namespace uri154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            int contador;
            double soma, media;

            contador = 0;
            soma = 0.0;

            while(idade > 0)
            {
                soma = soma + idade;
                contador = contador + 1;
                idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            media = soma / contador;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
