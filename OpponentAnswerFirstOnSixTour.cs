﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Santase
{
    class OpponentAnswerFirstOnSixTour : OpponentStrategyAnswer
    {
        public override Card AnswerOnOpponent(Player opponent, Player player, Card playerCard, 
            Card openTrumpCard, Check check)
        {
            
            Card opponentCard = null;
            if ((playerCard.Type != openTrumpCard.Type && (playerCard.Value == "10" || playerCard.Value == "A"))
                && opponent.CardsPlayer.Count(a => a.Type == openTrumpCard.Type) > 0)
            {
                List<Card> opponentTrumpCards = opponent.CardsPlayer.Where(a => a.Type == openTrumpCard.Type).ToList();

                return opponentCard = check.CheckForWeakTrump(opponent.CardsPlayer, openTrumpCard);
            }
            




            return null;
        }
    }
}
