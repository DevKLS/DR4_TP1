
using System;

namespace Exercicio06_Logger
{
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"[CONSOLE] {message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"[ARQUIVO] Registro simulado: {message}");
        }

        public void LogToDatabase(string message)
        {
            Console.WriteLine($"[BANCO DE DADOS] Registro simulado: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE LOG ===");

            Logger logger = new Logger();

            Action<string> logAction = logger.LogToConsole;

            logAction += logger.LogToFile;
            logAction += logger.LogToDatabase;

            Console.Write("\nDigite uma mensagem para registrar: ");
            string mensagem = Console.ReadLine() ?? "";

            logAction(mensagem);

            Console.WriteLine("\nTodos os registros foram executados.");
        }
    }
}
