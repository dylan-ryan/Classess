using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        //members - fields(variables)

        //defaults to private
        public int health;
        public int shield;
        public int score;
        public int x; //position
        public int y; //position

        //members - methods

        //constructor
        public Player()
        {
            Console.WriteLine("Player constructed");

            //initalize
            health = 100;
            shield = 0;
            x = 0;
            y = 0;
        }

        public void Heal(int hp)
        {
            health += hp;
        }
    }
}
