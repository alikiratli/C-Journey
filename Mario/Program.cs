using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mario.Models;

namespace Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MariO mario = new MariO();
            Console.WriteLine(mario);

            mario.GotMushroom();
            Console.WriteLine(mario);

            mario.GotFireFlower();
            Console.WriteLine(mario);

            mario.GotFeather();
            Console.WriteLine(mario);

            mario.GotCoins(4800);
            Console.WriteLine(mario);

            mario.MetMonster();
            Console.WriteLine(mario);

            mario.MetMonster();
            Console.WriteLine(mario);

            mario.MetMonster();
            Console.WriteLine(mario);

            Console.ReadKey();
        }
    }
}
