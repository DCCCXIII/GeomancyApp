using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomancyApp.Classes
{
    class Figure
    {
        public int HeadValue { get; set; }
        public int NeckValue { get; set; }
        public int LegsValue { get; set; }
        public int FeetValue { get; set; }

        public Figure(int newHead, int newNeck, int newLegs, int newFeet )
        {
            HeadValue = newHead;
            NeckValue = newNeck;
            LegsValue = newLegs;
            FeetValue = newFeet;
        }

        public Figure()
        {

        }

        public void SetRandomFigureValues(Random randomSeed)
        {
            HeadValue = randomSeed.Next(2);
            NeckValue = randomSeed.Next(2);
            LegsValue = randomSeed.Next(2);
            FeetValue = randomSeed.Next(2);
        }

        public void RenderFigure()
        {
            RenderPart(FigurePart.Head);
            Console.WriteLine();
            RenderPart(FigurePart.Neck);
            Console.WriteLine();
            RenderPart(FigurePart.Legs);
            Console.WriteLine();
            RenderPart(FigurePart.Feet);
            Console.WriteLine();
        }

        public void RenderPart(FigurePart part)
        {
            int partValue = 2;

            if(part == FigurePart.Head)
            {
                partValue = this.HeadValue;
            }
            else if (part == FigurePart.Neck)
            {
                partValue = this.NeckValue;
            }
            else if (part == FigurePart.Legs)
            {
                partValue = this.LegsValue;
            }
            else if (part == FigurePart.Feet)
            {
                partValue = this.FeetValue;
            }

            if (partValue == 1)
            {
                Console.Write("  0  ");
            } else if (partValue == 0)
            {
                Console.Write("0   0");
            } else
            {
                Console.Write("Invalid value");
            }
        }

        public enum FigurePart {
            Head,
            Neck,
            Legs,
            Feet
        }
    }
}
