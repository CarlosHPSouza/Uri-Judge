using System;
using System.Globalization;

namespace uri48
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioFuncionario,novoSalario,reajusteGanho;

            salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ( salarioFuncionario <= 400.00)
            {
                reajusteGanho = salarioFuncionario * 15 /100;
                novoSalario = reajusteGanho + salarioFuncionario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salarioFuncionario >= 400.01 &&  salarioFuncionario <= 800.00)
            {
                reajusteGanho = salarioFuncionario * 12 / 100;
                novoSalario = reajusteGanho + salarioFuncionario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salarioFuncionario >= 800.01 && salarioFuncionario <= 1200.00)
            {
                reajusteGanho = salarioFuncionario * 10 / 100;
                novoSalario = reajusteGanho + salarioFuncionario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salarioFuncionario >= 1200.01 && salarioFuncionario <= 2000.00)
            {
                reajusteGanho = salarioFuncionario * 7 / 100;
                novoSalario = reajusteGanho + salarioFuncionario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salarioFuncionario > 2000.00)
            {
                reajusteGanho = salarioFuncionario * 4 / 100;
                novoSalario = reajusteGanho + salarioFuncionario;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }

        }
    }
}
