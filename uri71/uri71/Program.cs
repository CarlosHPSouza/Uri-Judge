using System;

namespace uri71
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimo, maximo, soma;
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if ( X < Y)
            {
                    minimo = X;
                    maximo = Y;
            }
            else
            {
                minimo = Y;
                maximo = X;
            }

            soma = 0;
            for (int i=minimo+1; i<maximo; i++)
            {
                if ( i % 2 != 0)
                {
                    soma = soma + i;
                    
                }
            }
            Console.WriteLine(soma);
        }
    }
}
