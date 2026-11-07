
using System;

namespace Exercicio03_FuncArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE ÁREA ===");

            Console.Write("Digite a base do retângulo: ");
            bool baseValida = double.TryParse(
                Console.ReadLine(), out double baseRetangulo);

            Console.Write("Digite a altura do retângulo: ");
            bool alturaValida = double.TryParse(
                Console.ReadLine(), out double altura);

            if (baseValida && alturaValida &&
                baseRetangulo > 0 && altura > 0)
            {
                Func<double, double, double> calcularArea =
                    (b, h) => b * h;

                double area = calcularArea(baseRetangulo, altura);

                Console.WriteLine($"\nBase: {baseRetangulo}");
                Console.WriteLine($"Altura: {altura}");
                Console.WriteLine($"Área do retângulo: {area:F2}");
            }
            else
            {
                Console.WriteLine("Informe valores numéricos positivos.");
            }
        }
    }
}
