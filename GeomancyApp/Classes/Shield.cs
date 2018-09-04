using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeomancyApp.Figures;

namespace GeomancyApp.Charts
{
    class Shield : Chart
    {
        public Figure DaughterFirst {
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

        public Figure WitnessRight { get { return SumFigures(NieceFirst, NieceSecond); } }
        public Figure WitnessLeft { get { return SumFigures(NieceThird, NieceFourth); } }

        public Figure Judge { get { return SumFigures(WitnessRight, WitnessLeft); } }

        public Shield (Chart chart)
        {
            chart.MotherFirst = MotherFirst;
            chart.MotherSecond = MotherSecond;
            chart.MotherThird = MotherThird;
            chart.MotherFourth = MotherFourth;

        }

        #region Shield Chart
        public void RenderShieldChart()
        {
            RenderMothersDaughtersLine(head);
            RenderMothersDaughtersLine(neck);
            RenderMothersDaughtersLine(legs);
            RenderMothersDaughtersLine(feet);
            Console.WriteLine("--------------------------------------------------------------");
            RenderNieceLine(head);
            RenderNieceLine(neck);
            RenderNieceLine(legs);
            RenderNieceLine(feet);
            Console.WriteLine("--------------------------------------------------------------");
            RenderWitnessLine(head);
            RenderWitnessLine(neck);
            RenderWitnessLine(legs);
            RenderWitnessLine(feet);
            Console.WriteLine("--------------------------------------------------------------");
            RenderJudgeLine(head);
            RenderJudgeLine(neck);
            RenderJudgeLine(legs);
            RenderJudgeLine(feet);
        }

        public void RenderMothersDaughtersLine(Figure.FigurePart figurePart)
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
            WitnessLeft.RenderPart(figurePart);
            Console.Write("             |             ");
            WitnessRight.RenderPart(figurePart);
            Console.WriteLine();
        }

        public void RenderJudgeLine(Figure.FigurePart figurePart)
        {
            Console.Write("                            ");
            Judge.RenderPart(figurePart);
            Console.WriteLine();
        }
        #endregion
    }
}
