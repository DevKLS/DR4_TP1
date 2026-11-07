
using System;

namespace Exercicio07_LoggerRobusto
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
            Console.WriteLine("=== LOGGER ROBUSTO ===");

            Logger logger = new Logger();

            Action<string>? logAction = null;

            Console.WriteLine("\nTeste 1: Delegate sem métodos associados.");

            logAction?.Invoke("Mensagem de teste");

            Console.WriteLine("Nenhuma exceção foi gerada.");

            Console.WriteLine("\nTeste 2: Delegate com métodos associados.");

            logAction += logger.LogToConsole;
            logAction += logger.LogToFile;
            logAction += logger.LogToDatabase;

            logAction?.Invoke("Sistema funcionando corretamente.");

            Console.WriteLine("\nTestes concluídos.");
        }
    }
}
