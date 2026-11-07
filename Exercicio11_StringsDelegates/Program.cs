
using System;

namespace Exercicio11_StringsDelegates
{
    class Program
    {
        static string Concatenar(string nome, string sobrenome)
        {
            Console.WriteLine("Executando concatenação...");

            return nome + " " + sobrenome;
        }

        static string ConverterMaiusculas(string nome, string sobrenome)
        {
            Console.WriteLine("Executando conversão para maiúsculas...");

            return (nome + " " + sobrenome).ToUpper();
        }

        static string RemoverEspacos(string nome, string sobrenome)
        {
            Console.WriteLine("Executando remoção de espaços...");

            return (nome + " " + sobrenome).Replace(" ", "");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== MANIPULADOR DE STRINGS ===");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine() ?? "";

            Func<string, string, string> processarTexto = Concatenar;

            processarTexto += ConverterMaiusculas;
            processarTexto += RemoverEspacos;

            Console.WriteLine("\nExecutando os delegates encadeados...");

            string resultado = processarTexto(nome, sobrenome);

            Console.WriteLine($"\nResultado retornado: {resultado}");

            Console.WriteLine("\nAnálise:");
            Console.WriteLine("Todos os métodos foram executados.");
            Console.WriteLine("O resultado retornado pertence ao último método.");
        }
    }
}
