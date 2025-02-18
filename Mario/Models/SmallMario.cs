﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.Models
{
    internal class SmallMario : IState
    {
        private MariO mario;

        public SmallMario(MariO mario)
        {
            this.mario = mario;
        }

        public void GotMushroom()
        {
            Console.WriteLine("Got Mushroom!");
            mario.state = mario.GetState("superMario");
            mario.GotCoins(100);
        }

        public void GotFireFlower()
        {
            Console.WriteLine("Got FireFlower!");
            mario.state = mario.GetState("fireMario");
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
            mario.LostLife();
        }
    }
}
