using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card
    {

        public Suits CardSuits { get; set; }

        public int CardValue { get; set; }


        public enum Suits
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }
    }
}
