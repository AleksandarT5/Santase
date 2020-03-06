﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Santase
{
    class FirstPlayPlayerSixToTwelfthTour : PlayerStrategyFirst
    {
        public override Card PlayerPlayFirst(Player player, Card openTrumpCard, Check check)
        {
            Card playerCard = check.DeterminingThePlayerCard(player.CardsPlayer);

            player.Points  += check.CheckingFor40and20(player, openTrumpCard, playerCard);

            return playerCard;
        }
    }
}
