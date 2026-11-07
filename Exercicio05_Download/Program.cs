
using System;
using System.Threading;

namespace Exercicio05_Download
{
    public class DownloadManager
    {
        public event EventHandler? DownloadCompleted;

        public void StartDownload()
        {
            Console.WriteLine("Iniciando download...");

            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000);

                Console.WriteLine($"Baixando... {i * 20}%");
            }

            Console.WriteLine("\nDownload finalizado!");

            DownloadCompleted?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GERENCIADOR DE DOWNLOAD ===");

            DownloadManager manager = new DownloadManager();

            manager.DownloadCompleted += (sender, e) =>
            {
                Console.WriteLine("Notificação: seu download foi concluído!");
            };

            manager.StartDownload();
        }
    }
}
