
using System;

namespace Exercicio04_Temperatura
{
    public class TemperatureSensor
    {
        public event EventHandler? TemperatureExceeded;

        public void CheckTemperature(double temperature)
        {
            Console.WriteLine($"Temperatura registrada: {temperature:F1} °C");

            if (temperature > 100)
            {
                TemperatureExceeded?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MONITORAMENTO DE TEMPERATURA ===");

            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += (sender, e) =>
            {
                Console.WriteLine("ALERTA: Temperatura acima de 100°C!");
                Console.WriteLine("Atenção! Limite seguro ultrapassado.");
            };

            while (true)
            {
                Console.Write("\nDigite a temperatura ou -999 para sair: ");

                if (!double.TryParse(Console.ReadLine(), out double temperatura))
                {
                    Console.WriteLine("Valor inválido.");
                    continue;
                }

                if (temperatura == -999)
                {
                    break;
                }

                sensor.CheckTemperature(temperatura);
            }

            Console.WriteLine("\nMonitoramento encerrado.");
        }
    }
}
