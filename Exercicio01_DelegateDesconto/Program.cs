
using System;

namespace Exercicio01_DelegateDesconto
{
    delegate decimal CalculateDiscount(decimal price);

    class Program
    {
        static decimal ApplyDiscount(decimal price)
        {
            return price * 0.90m;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE DESCONTO ===");

            Console.Write("Digite o preço original do produto: R$ ");

            if (decimal.TryParse(Console.ReadLine(), out decimal price) && price >= 0)
            {
                CalculateDiscount discount = ApplyDiscount;

                decimal finalPrice = discount(price);

                Console.WriteLine($"\nPreço original: R$ {price:F2}");
                Console.WriteLine("Desconto aplicado: 10%");
                Console.WriteLine($"Preço final: R$ {finalPrice:F2}");
            }
            else
            {
                Console.WriteLine("Valor inválido. Digite um preço válido.");
            }
        }
    }
}
