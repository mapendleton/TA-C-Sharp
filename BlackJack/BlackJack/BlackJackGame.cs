﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackJackGame : Game, IWalkAway
    {
        public override void Play()
        {

        }

        public override void ListPlayer()
        {
            Console.WriteLine("BlackJack Players: ");
            base.ListPlayer();
        }

        public void WalkAway(Player player)
        {

        }
    }
}