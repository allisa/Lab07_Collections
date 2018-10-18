using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Deck<T> : IEnumerable
    {

        T[] deck = new T[10];
        public int count = 0;

        public void Add(T card)
        {
            if (count == deck.Length)
            {
                // Resize() is not magic; it is an array under the hood, doing normal array things
                Array.Resize(ref deck, deck.Length * 2);
            }
            // count++ will only increase count *after* the action has been taken. ++count would do it before
            deck[count++] = card;

        }

        /// <summary>
        /// Method to find card at the array index removes card
        /// </summary>
        /// <param name="card"></param>
        public void RemoveCard(T card)
        {
            for (int i = 0; i < count; i++)
            {
                if (deck[i].Equals(card))
                {
                    deck.SetValue(null, i);
                    break; ;
                }
            }
        }

        /// <summary>
        /// Method to show all cards of a specific suit
        /// </summary>
        /// <param name="cardSuit"></param>
        /// <returns></returns>
        public Deck<Card> ShowCardsInSuit(Suits cardSuit)
        {
            Deck<Card> newDeck = new Deck<Card>();

            for (int i = 0; i < count; i++)
            {
                Card card = (Card)Convert.ChangeType(deck[i], typeof(Card));
                {
                    if (card.CardSuits == cardSuit)
                    {
                        newDeck.Add(card);
                    }
                }
            }
                return newDeck;
        }

        /// <summary>
        /// Allows foreach loops to be used
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            // this is the underlying loop that will allow your foreach loop to run
            for (int i = 0; i < count; i++)
            {
                yield return deck[i];
            }

        }

        // Required to allow enumeration with legacy code
        // This is not a generic, we are using it to call the version that is a generic (above)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
