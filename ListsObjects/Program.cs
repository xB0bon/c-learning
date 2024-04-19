using System.Reflection.Metadata;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            
            players.Add(new Player("Janek"));
            players.Add(new Player("Bartek"));
            players.Add(new Player("Piorek"));
            
            foreach (Player player in players)
            {
                Console.WriteLine(player.username);
            }
        }
    }

    class Player
    {
        public String username;
        
        public Player(String username)
        {
            this.username = username;
        }
    }

    
    
    

    

    
};