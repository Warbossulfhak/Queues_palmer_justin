using System;
using System.Numerics;

namespace Queues_palmer_justin
{
     class Game
    {// public int maxplayer get set current players 
        public int MaxPlayers { get; }

        public int CurrrentPlayers { get; set; }

        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrrentPlayers = currentP;
        }
        //public void nothing returns value
        public void KickPlayer()
        {
            CurrrentPlayers--;
        }

        public void CheckQueue(Queue<Player> playerQueue)
        {
            if (CurrrentPlayers < MaxPlayers)
            {
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrrentPlayers++;
                }
                else
                {//prints to the console No player in the queue!
                    Console.WriteLine("No player in the queue!");
                }

            }



        }





    }
}
