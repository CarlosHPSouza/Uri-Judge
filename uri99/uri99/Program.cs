using System;

namespace uri99
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            

            for(int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]);
                int Y = int.Parse(vet[1]);
                int min, max;
                if(X < Y)
                {
                    min = X;
                    max = Y;
                }
                else
                {
                    min = Y;
                    max = X;
                }
                int soma = 0;
                for(int r = min + 1; r < max; r++)
                {
                    if (r % 2 == 1)
                    {
                        soma = soma + r;
                    }
                }
                
                Console.WriteLine(soma);
            }
            
        }
    }
}
