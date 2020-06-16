using System;
using System.Globalization;

namespace uri12
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0],CultureInfo.InvariantCulture);
            B = double.Parse(vet[1],CultureInfo.InvariantCulture);
            C = double.Parse(vet[2],CultureInfo.InvariantCulture);

            triangulo = A * C/ 2;
            circulo = pi * C * C;
            trapezio = (A + B) * C / 2;
            quadrado = B * B;
            retangulo = A * B;



            Console.WriteLine("TRIANGULO = " + triangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        
        }
    }
}
