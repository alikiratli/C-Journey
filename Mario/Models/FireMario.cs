﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.Models
{
    internal class FireMario : IState
    {
        private MariO mario;

        public FireMario(MariO mario)
        {
            this.mario = mario;
        }

        public void GotMushroom()
        {
            Console.WriteLine("Got Mushroom!");
            mario.GotCoins(100);
        }

        public void GotFireFlower()
        {
            Console.WriteLine("Got FireFlower!");
            mario.GotCoins(200);
        }

        public void GotFeather()
        {
            Console.WriteLine("Got Feather!");
            mario.state = mario.GetState("capeMario");
            mario.GotCoins(300);
        }

        public void MetMonster()
        {
            Console.WriteLine("Met Monster!");
            mario.state = mario.GetState("smallMario");
        }
    }
}
