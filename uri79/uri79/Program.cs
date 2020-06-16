using System;
using System.Globalization;

namespace uri79
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
        
    }
}
