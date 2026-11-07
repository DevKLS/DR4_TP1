
using ProductCatalog.Models;

namespace ProductCatalog.Services
{
    public class EventLogger
    {
        public void LogEvent(Event newEvent)
        {
            Console.WriteLine("=== NOVO EVENTO CADASTRADO ===");

            Console.WriteLine($"Título: {newEvent.Title}");

            Console.WriteLine($"Data: {newEvent.Date:dd/MM/yyyy}");

            Console.WriteLine($"Local: {newEvent.Location}");

            Console.WriteLine("==============================");
        }
    }
}
