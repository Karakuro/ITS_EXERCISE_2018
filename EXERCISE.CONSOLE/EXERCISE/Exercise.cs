using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; }

        private Player()
        {

        }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    public class FiveASide
    {
        public static int ChooseSides(Player[] players)
        {
            throw new NotImplementedException();
        }
    }
}
