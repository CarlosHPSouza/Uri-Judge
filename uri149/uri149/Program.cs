using System;

namespace uri149
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] armazena = Console.ReadLine().Split(' ');
            int A = int.Parse(armazena[0]);
            int N = int.Parse(armazena[1]);
            while (N <= 0)
            {
                armazena = Console.ReadLine().Split(' ');
                 N = int.Parse(armazena[0]);
            }

            int soma = 0;
            for(int i = 1; i < N; i++)
            {
                soma = soma + i;
                ;
                
                Console.WriteLine(soma);
            }
        }
    }
}
