using System.Reflection.Metadata;
using System.Collections.Generic;

namespace getters.setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Car(12);
            Console.WriteLine(player.Speed);
            
        }

    }

    class Player
    {
        private int speed;

        public void Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
                
            }
        }
    }










};