using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card
    {

        public Suits CardSuits { get; set; }

        public CardValue CardFace { get; set; }

    }

        public enum Suits
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public enum CardValue
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King

        }
}
