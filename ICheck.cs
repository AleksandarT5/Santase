﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Santase
{
    interface ICheck
    {
        Card CheckForTwenty(Player player, Card openTrumpCard, Player theOtherParticipant);

        Card CheckForFourty(Player player, Card openTrumpCard, Player theOtherParticipant);

        Card CheckForCard(List<Card> opponentCards, Card openTrumpCard);

        Card CheckCards(List<Card> opponentCardsNoTrumps, Card openTrumpCard, Card card, string[] values, int number);

        void CheckWinnerTurn(Player opponent, Player player, Card opponentCard, Card myCard, Card openTrumpCard);

        bool CheckPlayerHaveSixtySix(Player player, Player theOtherParticipant);

        void CheckPayerHaveNineTrump(List<Card> playerCards, Card openTrumpCard);
    }
}