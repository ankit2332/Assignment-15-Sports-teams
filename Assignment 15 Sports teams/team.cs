using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_teams
{
    class team
    {
        protected string name;
        protected int numgame = 0;
        protected int gamewon = 0;
        protected int gamelost = 0;


        public void addlose()
        {
            gamelost++;
            numgame++;
        }

        public void addwin()
        {
            gamewon++;
            numgame++;
        }
        public string getteamname()
        {
            return name;
        }

        public int getnumberofgame()
        {
            return numgame;
        }

        public int getwincount()
        {
            return gamewon;
        }

        public int numgamelost()
        {
            return gamelost;
        }
        public double getwinpercentage()
        {
            double percentage;
            percentage = (double) gamewon /numgame;
            percentage *= 100;
            return percentage;
        }
    }
}
