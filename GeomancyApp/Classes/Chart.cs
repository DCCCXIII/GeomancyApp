using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomancyApp.Classes
{
    class Chart
    {
        public Figure MotherFirst { get; set; }
        public Figure MotherSecond { get; set; }
        public Figure MotherThird { get; set; }
        public Figure MotherFourth { get; set; }

        public Figure DaughterFirst 
        {
            get {
                return new Figure(MotherFirst.HeadValue, MotherSecond.HeadValue, MotherThird.HeadValue, MotherFourth.HeadValue);
            }
        }
        public Figure DaughterSecond {
            get {
                return new Figure(MotherFirst.NeckValue, MotherSecond.NeckValue, MotherThird.NeckValue, MotherFourth.NeckValue);
            }
        }
        public Figure DaughterThird {
            get {
                return new Figure(MotherFirst.LegsValue, MotherSecond.LegsValue, MotherThird.LegsValue, MotherFourth.LegsValue);
            }
        }
        public Figure DaughterFourth {
            get {
                return new Figure(MotherFirst.FeetValue, MotherSecond.FeetValue, MotherThird.FeetValue, MotherFourth.FeetValue);
            }
        }

        public Figure NieceFirst { get { return SumFigures(MotherFirst, MotherSecond); } }
        public Figure NieceSecond { get { return SumFigures(MotherThird, MotherFourth); } }
        public Figure NieceThird { get { return SumFigures(DaughterFirst, DaughterSecond); } }
        public Figure NieceFourth { get { return SumFigures(DaughterThird, DaughterFourth); } }

        public Figure RightWitness { get {return SumFigures(NieceFirst, NieceSecond); } }
        public Figure LeftWitness { get { return SumFigures(NieceThird, NieceFourth); } }

        public Figure Judge { get { return SumFigures(RightWitness, LeftWitness); } }

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

        public void RenderShieldChart()
        {
            RenderMothersDaughtersLine(Figure.FigurePart.Head);
            RenderMothersDaughtersLine(Figure.FigurePart.Neck);
            RenderMothersDaughtersLine(Figure.FigurePart.Legs);
            RenderMothersDaughtersLine(Figure.FigurePart.Feet);
            Console.WriteLine("--------------------------------------------------------------");
            RenderNieceLine(Figure.FigurePart.Head);
            RenderNieceLine(Figure.FigurePart.Neck);
            RenderNieceLine(Figure.FigurePart.Legs);
            RenderNieceLine(Figure.FigurePart.Feet);
            Console.WriteLine("--------------------------------------------------------------");
            RenderWitnessLine(Figure.FigurePart.Head);
            RenderWitnessLine(Figure.FigurePart.Neck);
            RenderWitnessLine(Figure.FigurePart.Legs);
            RenderWitnessLine(Figure.FigurePart.Feet);
            Console.WriteLine("--------------------------------------------------------------");
            RenderJudgeLine(Figure.FigurePart.Head);
            RenderJudgeLine(Figure.FigurePart.Neck);
            RenderJudgeLine(Figure.FigurePart.Legs);
            RenderJudgeLine(Figure.FigurePart.Feet);
        }

        public void RenderMothersDaughtersLine (Figure.FigurePart figurePart)
        {
            DaughterFourth.RenderPart(figurePart);
            Console.Write(" | ");
            DaughterThird.RenderPart(figurePart);
            Console.Write(" | ");
            DaughterSecond.RenderPart(figurePart);
            Console.Write(" | ");
            DaughterFirst.RenderPart(figurePart);
            Console.Write(" | ");
            MotherFourth.RenderPart(figurePart);
            Console.Write(" | ");
            MotherThird.RenderPart(figurePart);
            Console.Write(" | ");
            MotherSecond.RenderPart(figurePart);
            Console.Write(" | ");
            MotherFirst.RenderPart(figurePart);
            Console.WriteLine();
        }

        public void RenderNieceLine(Figure.FigurePart figurePart)
        {
            Console.Write("    ");
            NieceFourth.RenderPart(figurePart);
            Console.Write("     |     ");
            NieceThird.RenderPart(figurePart);
            Console.Write("     |     ");
            NieceSecond.RenderPart(figurePart);
            Console.Write("     |     ");
            NieceFirst.RenderPart(figurePart);
            Console.WriteLine();
        }

        public void RenderWitnessLine(Figure.FigurePart figurePart)
        {
            Console.Write("            ");
            LeftWitness.RenderPart(figurePart);
            Console.Write("             |             ");
            RightWitness.RenderPart(figurePart);
            Console.WriteLine();
        }

        public void RenderJudgeLine(Figure.FigurePart figurePart)
        {
            Console.Write("                            ");
            Judge.RenderPart(figurePart);
            Console.WriteLine();
        }
    }
}
