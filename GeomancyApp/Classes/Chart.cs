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
    }
}
