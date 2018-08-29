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
        {Figure newFigure = new Figure();

            newFigure.SetRandomFigureValues(rng);

            Console.WriteLine(newFigure.HeadValue);
            Console.WriteLine(newFigure.NeckValue);
            Console.WriteLine(newFigure.LegsValue);
            Console.WriteLine(newFigure.FeetValue);

            Console.WriteLine();

            newFigure.RenderFigure();

            Console.WriteLine();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
