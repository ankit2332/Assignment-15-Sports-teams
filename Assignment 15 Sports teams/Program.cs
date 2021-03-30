using System;

namespace Assignment_15_Sports_teams
{
    class Program
    {
        static void Main(string[] args)
        {
            team Football = new team("FootBall");
            Football.addlose();
            Football.addwin();
            Console.WriteLine(Football.getnumberofgame() + Football.getwinpercentage());
        }
    }
}
