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

        public Figure WitnessRight { get {return SumFigures(NieceFirst, NieceSecond); } }
        public Figure WitnessLeft { get { return SumFigures(NieceThird, NieceFourth); } }

        public Figure Judge { get { return SumFigures(WitnessRight, WitnessLeft); } }

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

        #region Twelve Houses Chart
        public void RenderTwelveHousesChart()
        {
            Console.WriteLine("#####################################");                                                                 //1
            Console.WriteLine("##               # #               ##");                                                                 //2
            Console.WriteLine("# #    " + NieceThird.PartString(head) + "    #   #    " + NieceFirst.PartString(head) + "    # #");     //3
            Console.WriteLine("#  #   " + NieceThird.PartString(neck) + "   #     #   " + NieceFirst.PartString(neck) + "   #  #");     //4
            Console.WriteLine("#   #  " + NieceThird.PartString(legs) + "  # " + NieceSecond.PartString(head) + " #  " +
                                NieceFirst.PartString(legs) + "  #   #");                                                               //5
            Console.WriteLine("#    # " + NieceThird.PartString(feet) + " #  " + NieceSecond.PartString(neck) + "  # " +
                                NieceFirst.PartString(feet) + " #    #");                                                               //6
            Console.WriteLine("#     #     #   " + NieceSecond.PartString(legs) + "   #     #     #");                                  //7
            Console.WriteLine("#      #   #    " + NieceSecond.PartString(feet) + "    #   #      #");                                  //8
            Console.WriteLine("#" + NieceFourth.PartString(head) + "  # #               # #  " + 
                                DaughterFourth.PartString(head) + "#");                                                                 //9
            Console.WriteLine("#" + NieceFourth.PartString(neck) + "   ###################   " + 
                                DaughterFourth.PartString(neck) + "#");                                                                 //10
            Console.WriteLine("#" + NieceFourth.PartString(legs) + "  ##                 ##  " + 
                                DaughterFourth.PartString(legs) + "#");                                                                 //11
            Console.WriteLine("#" + NieceFourth.PartString(feet) + " # #                 # # " + 
                                DaughterFourth.PartString(feet) + "#");                                                                 //12
            Console.WriteLine("#     #  #                 #  #     #");                                                                 //13
            Console.WriteLine("#    #   #                 #   #    #");                                                                 //14
            Console.WriteLine("#   #    #                 #    #   #");                                                                 //15
            Console.WriteLine("#  #     #                 #     #  #");                                                                 //16
            Console.WriteLine("# # " + MotherFirst.PartString(head) + "#                 #      # #");                                                                 //17
            Console.WriteLine("##  " + MotherFirst.PartString(neck) + "#                 #       ##");                                                                 //18
            Console.WriteLine("#   " + MotherFirst.PartString(legs) + "#                 #        #");                                                                 //19
            Console.WriteLine("##  " + MotherFirst.PartString(feet) + "#                 #       ##");                                                                 //20
            Console.WriteLine("# #      #                 #      # #");                                                                 //21
            Console.WriteLine("#  #     #                 #     #  #");                                                                 //22
            Console.WriteLine("#   #    #                 #    #   #");                                                                 //23
            Console.WriteLine("#    #   #                 #   #    #");                                                                 //24
            Console.WriteLine("#     #  #                 #  #     #");                                                                 //25
            Console.WriteLine("#      # #                 # #      #");                                                                 //26
            Console.WriteLine("#       ##                 ##       #");                                                                 //27
            Console.WriteLine("#        ###################        #");                                                                 //28
            Console.WriteLine("#       # #               # #       #");                                                                 //29
            Console.WriteLine("#      #   #             #   #      #");                                                                 //30
            Console.WriteLine("#     #     #           #     #     #");                                                                 //31
            Console.WriteLine("#    #       #         #       #    #");                                                                 //32
            Console.WriteLine("#   #         #       #         #   #");                                                                 //33
            Console.WriteLine("#  #           #     #           #  #");                                                                 //34
            Console.WriteLine("# #             #   #             # #");                                                                 //35
            Console.WriteLine("##               # #               ##");                                                                 //36
            Console.WriteLine("#####################################");                                                                 //37
        }
        #endregion
    }
}
