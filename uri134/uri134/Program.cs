using System;

namespace uri134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            
            while ( tipo != 4)
            {
                if( tipo < 1 || tipo > 4)
                {
                    Console.WriteLine("fora da faixa de 1 a 4");
                }
                else if (tipo == 1)
                {
                    alcool = alcool + 1;                                     
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    gasolina = gasolina + 1;
                }

                tipo = int.Parse(Console.ReadLine());
                
               
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
