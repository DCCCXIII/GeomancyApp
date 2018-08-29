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
            Chart newChart = new Chart();

            newChart.SetRandomChartValues(rng);

            newChart.MotherFirst.RenderFigure();
            Console.WriteLine();
            newChart.MotherSecond.RenderFigure();
            Console.WriteLine();
            newChart.MotherThird.RenderFigure();
            Console.WriteLine();
            newChart.MotherFourth.RenderFigure();
            Console.WriteLine();

            Console.WriteLine();
            newChart.DaughterFirst.RenderFigure();
            Console.WriteLine();
            newChart.DaughterSecond.RenderFigure();
            Console.WriteLine();
            newChart.DaughterThird.RenderFigure();
            Console.WriteLine();
            newChart.DaughterFourth.RenderFigure();
            Console.WriteLine();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
