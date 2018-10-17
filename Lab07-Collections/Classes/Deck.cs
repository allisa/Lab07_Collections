using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Lab07_Collections.Classes
{
    class Deck<T> : IEnumerable
    {
        //remove method
        //return suit (this method returns all cards in the suit)

        T[] cards = new T[10];
        int count = 0;

        public void Add(T card)
        {
            if (count == cards.Length)
            {
                // Resize() is not magic; it is an array under the hood, doing normal array things
                Array.Resize(ref cards, cards.Length * 2);
            }
            // count++ will only increase count *after* the action has been taken. ++count would do it before
            cards[count++] = card;

        }

        //public Deck<T> ReturnCards(T cards)
        //{
        //    //write logic
        //    return "";
        //}

        public IEnumerator<T> GetEnumerator()
        {
            // this is the underlying loop that will allow your foreach loop to run
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
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
