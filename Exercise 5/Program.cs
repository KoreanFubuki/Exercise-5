using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static int highscore = 500;
        static string HighschorePlayer = "Xx__Slayer__xX";
        static void Main(string[] args)
        {
            game(350, "Gamer");
            game(499, "Random Edgelord");
            game(696, "Fubuki");

            Console.Read();
        }
        public static void game(int score, string playername)
        {
            if (score > highscore)
            {
                highscore = score;
                HighschorePlayer = playername;

                Console.WriteLine("The new highscore is " + score);
                Console.WriteLine("The holder of new the highscore is " + playername);
            }
            else
            {
                Console.WriteLine("your score was " + score);
                Console.WriteLine("the current Highscore is " + highscore);
                Console.WriteLine("Current Highscore holder is " + HighschorePlayer);
            }
        }
    }
}
