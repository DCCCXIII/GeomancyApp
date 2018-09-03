using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeomancyApp.Classes;

namespace GeomancyApp
{
    class Program
    {
        static readonly Random rng = new Random();

        static void Main(string[] args)
        {
            Chart chart = new Chart();

            chart.SetRandomChartValues(rng);
            chart.RenderShieldChart();
            Console.WriteLine();
            chart.RenderTwelveHousesChart();

            Console.WriteLine();
            Console.WriteLine("Press ENTER to generate a new chart.");

            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                chart.SetRandomChartValues(rng);

                chart.RenderShieldChart();
                Console.WriteLine();
                chart.RenderTwelveHousesChart();
                Console.WriteLine();
                Console.WriteLine("Press ENTER to generate a new chart.");
            }
            Console.WriteLine();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
