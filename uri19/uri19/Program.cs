using System;

namespace uri19
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, tempoSegundo, tempoMinuto, tempoHora, resto;

            N = int.Parse(Console.ReadLine());

            tempoHora = N / 3600;
            resto = N % 3600;
            tempoMinuto = resto / 60;
            tempoSegundo = resto % 60;
            
            

            Console.WriteLine(tempoHora + ":" + tempoMinuto + ":" + tempoSegundo);

        }
    }
}
