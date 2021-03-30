using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_15_Sports_teams
{
    class football: team
    {
        private int goals = 0;
        private int redcards = 0;
        private int yellowcards = 0;

        
        public football(string name, int win, int lost)
        {
            this.name = name;
            this.gamewon = win;
            this.gamelost = lost;
        }
        public void addgame(string result, int goals, int redcards, int yellowcards)
        {
            if(result == "win")
            {
                gamewon++;
            }
            else if (result == "lose")
            {
                gamelost++;
            }

            redcards += redcards;
            yellowcards += yellowcards;
            goals += goals;



        }
    }
}
