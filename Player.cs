using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_palmer_justin
{
    internal class Player
    {

        public int Health { get; set; }


        public string GamerTag { get; }
        //health and gamertage parameter 
        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        public void JoinGame(Game game, Queue<Player> queue)
        {
            if(game.CurrrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this); 
            }
            else
            {//prints to the console jouning game!
                Console.WriteLine("Jouning Game!");
                game.CurrrentPlayers++;
            }

        }
        // public override return gamertage MMSix xXAwesomenessXx Get Good ZombieSlaya
        public override string ToString()
        {
            return GamerTag;
        }


    }
}
