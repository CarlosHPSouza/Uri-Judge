using System;

namespace uri13
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, maiorValor, maiorAB;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maiorAB = (A + B + Math.Abs(A - B))/2;
            maiorValor = (maiorAB + C + Math.Abs(maiorAB - C))/2;

            Console.WriteLine(maiorValor + " eh o maior");
        }
    }
}
