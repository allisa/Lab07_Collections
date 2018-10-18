using System;
using System.Collections.Generic;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CardTest();
        }

        /// <summary>
        /// Instantiate cards from Card class
        /// </summary>
        public static void CardTest()
        {

            Card cardOne = new Card() { CardSuits = Suits.Clubs, CardFace = CardValue.Four };
            Card cardTwo = new Card() { CardSuits = Suits.Spades, CardFace = CardValue.Queen };
            Card cardThree = new Card() { CardSuits = Suits.Diamonds, CardFace = CardValue.Two };
            Card cardFour = new Card() { CardSuits = Suits.Hearts, CardFace = CardValue.Ace };
            Card cardFive = new Card() { CardSuits = Suits.Clubs, CardFace = CardValue.Ace };
            Card cardSix = new Card() { CardSuits = Suits.Spades, CardFace = CardValue.Five };
            Card cardSeven = new Card() { CardSuits = Suits.Diamonds, CardFace = CardValue.King };
            Card cardEight = new Card() { CardSuits = Suits.Clubs, CardFace = CardValue.Eight };
            Card cardiNne = new Card() { CardSuits = Suits.Diamonds, CardFace = CardValue.Ace };
            Card cardTen = new Card() { CardSuits = Suits.Hearts, CardFace = CardValue.Two };

            Deck<Card> deckOfCards = new Deck<Card>
            {
                cardOne, cardTwo, cardThree, cardFour, cardFive, cardSix, cardSeven, cardEight, cardiNne, cardTen
            };

            DisplayCards(deckOfCards);

            Console.WriteLine("**Add cards**");

            Card cardEleven = new Card() { CardSuits = Suits.Spades, CardFace = CardValue.King };
            Card cardTwelve = new Card() { CardSuits = Suits.Spades, CardFace = CardValue.Two };
            deckOfCards.Add(cardEleven);
            deckOfCards.Add(cardTwelve);
            DisplayCards(deckOfCards);

            //getting null exception
            Console.WriteLine("**Remove Card**");
            deckOfCards.RemoveCard(cardEleven);
            deckOfCards.RemoveCard(cardTwelve);
            DisplayCards(deckOfCards);

            Console.WriteLine("**All cards in this suit**");
            DisplayCards(deckOfCards.ShowCardsInSuit(Suits.Spades));
        }

        /// <summary>
        /// Method to display all cards in deck if not null
        /// </summary>
        /// <param name="deck"></param>
        public static void DisplayCards(Deck<Card> deck)
        {
            foreach (Card card in deck)
            {
                if (card != null)
                {
                    Console.WriteLine($"{card.CardFace} of {card.CardSuits}");
                }
            }
        }
    }
}
