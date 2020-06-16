using System;
using System.Globalization;
namespace uri08
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double recebePorHora, salario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            recebePorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * recebePorHora;

            Console.WriteLine("NUMBER = " + numeroFuncionario + "\n" + "SALARY = U$ " + salario.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
