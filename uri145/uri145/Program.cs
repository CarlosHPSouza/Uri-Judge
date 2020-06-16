using System;

namespace uri145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] armazena = Console.ReadLine().Split(' ');
            int X = int.Parse(armazena[0]);
            int Y = int.Parse(armazena[1]);

            
            for(int i = 1; i <= Y; i++)
            {
                               
                Console.Write(i);
                if(i % X == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
