using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeomancyApp.Figures;

namespace GeomancyApp.Charts
{
    class Chart
    {
        public Figure MotherFirst { get; set; }
        public Figure MotherSecond { get; set; }
        public Figure MotherThird { get; set; }
        public Figure MotherFourth { get; set; }

        private readonly Figure.FigurePart head = Figure.FigurePart.Head;
        private readonly Figure.FigurePart neck = Figure.FigurePart.Neck;
        private readonly Figure.FigurePart legs = Figure.FigurePart.Legs;
        private readonly Figure.FigurePart feet = Figure.FigurePart.Feet;

        public Chart(Figure firstMother, Figure secondMother, Figure thirdMother, Figure fourthMother)
        {
            MotherFirst = firstMother;
            MotherSecond = secondMother;
            MotherThird = thirdMother;
            MotherFourth = fourthMother;
        }

        public Chart()
        {
            MotherFirst = new Figure();
            MotherSecond = new Figure();
            MotherThird = new Figure();
            MotherFourth = new Figure();
        }

        public void SetRandomChartValues(Random randomSeed)
        {
            MotherFirst.SetRandomFigureValues(randomSeed);
            MotherSecond.SetRandomFigureValues(randomSeed);
            MotherThird.SetRandomFigureValues(randomSeed);
            MotherFourth.SetRandomFigureValues(randomSeed);
        }

        public Figure SumFigures(Figure firstFigure, Figure secondFigure)
        {
            int head = (firstFigure.HeadValue + secondFigure.HeadValue) % 2;
            int neck = (firstFigure.NeckValue + secondFigure.NeckValue) % 2;
            int legs = (firstFigure.LegsValue + secondFigure.LegsValue) % 2;
            int feet = (firstFigure.FeetValue + secondFigure.FeetValue) % 2;

            return new Figure(head, neck, legs, feet);
        }
    }
}
