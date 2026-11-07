
using System;

namespace Exercicio02_ActionIdiomas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE BOAS-VINDAS ===");
            Console.WriteLine("1 - Português");
            Console.WriteLine("2 - Inglês");
            Console.WriteLine("3 - Espanhol");

            Console.Write("Escolha um idioma: ");
            string opcao = Console.ReadLine() ?? "";

            Action<string> portugues = nome =>
                Console.WriteLine($"Olá, {nome}! Seja bem-vindo(a)!");

            Action<string> ingles = nome =>
                Console.WriteLine($"Hello, {nome}! Welcome!");

            Action<string> espanhol = nome =>
                Console.WriteLine($"¡Hola, {nome}! ¡Bienvenido(a)!");

            Console.Write("\nDigite seu nome: ");
            string nomeUsuario = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    portugues(nomeUsuario);
                    break;

                case "2":
                    ingles(nomeUsuario);
                    break;

                case "3":
                    espanhol(nomeUsuario);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
