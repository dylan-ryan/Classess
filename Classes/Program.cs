using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args) // <-- entry point doesnt matter what class its in
        {
            Console.WriteLine("Classes");
            Console.WriteLine();

            // variables
            //int score; // decalaration
            //score = 0;

            //array
            //int[] ammo; // decalaration
            //ammo = new int[5]; // instantiation
            //ammo[0] = 5;

            //creating player instance
            Player player; // declaration
            player = new Player(); // instantiation
            
            //creating enemy instances
            Enemy enemy = new Enemy(); // declararion and instantiation together
            Enemy enemy2 = new Enemy();

            Enemy[] smallEnemies;
            smallEnemies = new Enemy[10];
            for ( int i = 0; i < smallEnemies.Length; i++ )
            {

            }

            //player.health = 50;
            //player.x = 1;
            //player.y = 1;

            enemy.health = 100;
            enemy.x = 2;
            enemy.y = 2;

            Console.WriteLine("Player health: " + player.health);
            player.Heal(5);
            Console.WriteLine("Player health: " + player.health);
            Console.WriteLine("Enemy health: " + enemy.health);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
