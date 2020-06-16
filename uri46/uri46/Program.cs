using System;

namespace uri46
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicio, horaFimdoJogo, horaTotal;

            string[] vet = Console.ReadLine().Split(' ');

            horaInicio = int.Parse(vet[0]);
            horaFimdoJogo = int.Parse(vet[1]);


            if (horaInicio < horaFimdoJogo)
            {
                horaTotal = horaFimdoJogo - horaInicio;
            }
            else
            {
                horaTotal = 24 - horaInicio + horaFimdoJogo;
            }
            Console.WriteLine("O JOGO DUROU " + horaTotal + " HORAS(S)");
        }
    }
}
