using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeomancyApp.Figures;

namespace GeomancyApp.Charts
{
    class TwelveHouses : Chart
    {
        public Figure firstHouse;
        public Figure secondHouse;
        public Figure thirdHouse;
        public Figure fourthHouse;
        public Figure fifthHouse;
        public Figure sixthHouse;
        public Figure seventhHouse;
        public Figure eigthHouse;
        public Figure ninthHouse;
        public Figure tenthHouse;
        public Figure eleventhHouse;
        public Figure twelfthHouse;

        private string[] template = new string[]
        {
            "##########################################################################",   // 0
            "####                              ##  ##                              ####",   // 1
            "##  ##                          ##      ##                          ##  ##",   // 2
            "##    ##                      ##          ##                      ##    ##",   // 3
            "##      ##                  ##              ##                  ##      ##",   // 4
            "##        ##              ##                  ##              ##        ##",   // 5
            "##          ##          ##                      ##          ##          ##",   // 6
            "##            ##      ##                          ##      ##            ##",   // 7
            "##              ##  ##                              ##  ##              ##",   // 8
            "##                ######################################                ##",   // 9
            "##              ####                                  ####              ##",   // 10
            "##            ##  ##                                  ##  ##            ##",   // 11
            "##          ##    ##                                  ##    ##          ##",   // 12
            "##        ##      ##                                  ##      ##        ##",   // 13
            "##      ##        ##                                  ##        ##      ##",   // 14
            "##    ##          ##                                  ##          ##    ##",   // 15
            "##  ##            ##                                  ##            ##  ##",   // 16
            "####              ##                                  ##              ####",   // 17
            "##                ##                                  ##                ##",   // 18
            "####              ##                                  ##              ####",   // 19
            "##  ##            ##                                  ##            ##  ##",   // 20
            "##    ##          ##                                  ##          ##    ##",   // 21
            "##      ##        ##                                  ##        ##      ##",   // 22
            "##        ##      ##                                  ##      ##        ##",   // 23
            "##          ##    ##                                  ##    ##          ##",   // 24
            "##            ##  ##                                  ##  ##            ##",   // 25
            "##              ####                                  ####              ##",   // 26
            "##                ######################################                ##",   // 27
            "##              ##  ##                              ##  ##              ##",   // 28
            "##            ##      ##                          ##      ##            ##",   // 29
            "##          ##          ##                      ##          ##          ##",   // 30
            "##        ##              ##                  ##              ##        ##",   // 31
            "##      ##                  ##              ##                  ##      ##",   // 32
            "##    ##                      ##          ##                      ##    ##",   // 33
            "##  ##                          ##      ##                          ##  ##",   // 34
            "####                              ##  ##                              ####",   // 35
            "##########################################################################",   // 36
        };

        public TwelveHouses(Chart chart)
        {
        }
    }
}
