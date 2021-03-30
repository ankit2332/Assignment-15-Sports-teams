using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_teams
{
    class basketball: team

    {
        private int blocks = 0;
        private int steals = 0;
        private int baskets = 0;

        public basketball(string name, int steals, int baskets) 
        {
            this.
        }

        public void addsteals()
        {
            steals++;
        }

        public void addbaskets()
        {
            baskets++;
        }
        public void averagesteals()
        {
            double average = 0;
            average = (double)steals / numgame;
            average *= 100;
        }
        public int numberofblocks()
        {
            return blocks;
        }
    }
}
