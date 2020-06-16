using System;

namespace uri47
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaTotal, minutoTotal;

            string[] vet = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vet[0]);
            int minutoInicial = int.Parse(vet[1]);
            int horaFinal = int.Parse(vet[2]);
            int minutoFinal = int.Parse(vet[3]);

            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;


            if ( instanteInicial < instanteFinal)
            {
                horaTotal = instanteFinal - instanteInicial;
                
            }
            else
            {
                horaTotal = (24 * 60 - instanteInicial) + instanteFinal;
                
            }

            int duração = horaTotal / 60;
            minutoTotal = horaTotal % 60;


            Console.WriteLine("O JOGO DUROU " + duração + " HORA(S) E " + minutoTotal + " MINUTO(S)");
        }
    }
}
