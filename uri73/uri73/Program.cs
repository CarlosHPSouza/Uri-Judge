using System;

namespace uri73
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for( int i=2; i<= N; i++)
            {
                
                if(i % 2 == 0)
                {
                    soma = i * i ;
                    Console.WriteLine(i + "^2 = " + soma);
                }

            }
            
        }
    }
}
