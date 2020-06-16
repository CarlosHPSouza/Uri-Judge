using System;

namespace uri72
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = 0, fora = 0;
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i<N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if ( x >= 10 && x <= 20)
                {
                    entrada++;

                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(entrada + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
