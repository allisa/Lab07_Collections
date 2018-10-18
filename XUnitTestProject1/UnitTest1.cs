using System;
using Xunit;
using Lab07_Collections;
using Lab07_Collections.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        /// <summary>
        /// test to see if card can be added
        /// </summary>
        [Fact]
        public void CanAddCards()
        {
            Card testCard = new Card() { CardSuits = Suits.Hearts, CardFace = CardValue.Ace };
            Deck<Card> testdeck = new Deck<Card>();
            testdeck.Add(testCard);


            Assert.Equal(1, testdeck.count);
        }

        /// <summary>
        /// Tests the suit property of the card
        /// </summary>
        [Fact]
        public void CanSetCardPropoertySuit()
        {
            Card testCard = new Card() { CardSuits = Suits.Hearts, CardFace = CardValue.Ace };

            Assert.Equal(Suits.Hearts, testCard.CardSuits);
        }

        /// <summary>
        /// Test the card face value property
        /// </summary>
        [Fact]
        public void CanSetCardPropertyFace()
        {
            Card testCard = new Card() { CardSuits = Suits.Hearts, CardFace = CardValue.Ace };

            Assert.Equal(CardValue.Ace, testCard.CardFace);
        }

        /// <summary>
        /// Test to remove non-exixting card
        /// </summary>
        [Fact]
        public void CanRemoveACardNonExisiting()
        {
            Card testCard = new Card() { CardSuits = Suits.Hearts, CardFace = CardValue.Ace };
            Card testCard2 = new Card() { CardSuits = Suits.Diamonds, CardFace = CardValue.Ten };
            Deck<Card> testdeck = new Deck<Card> { testCard };

            testdeck.RemoveCard(testCard2);

            Assert.Equal(1, testdeck.count);
        }

        /// <summary>
        /// Can remove exisiting card
        /// </summary>
        [Fact]
        public void CanRemoveExistingCard()
        {
            Card testCard = new Card() { CardSuits = Suits.Hearts, CardFace = CardValue.Ace };
            Card testCard2 = new Card() { CardSuits = Suits.Diamonds, CardFace = CardValue.Ten };
            Deck<Card> testdeck = new Deck<Card>
            {
                testCard, testCard2
            };

            testdeck.RemoveCard(testCard);
            int count = 0;
            foreach (Card card in testdeck)
            {
                if (card != null)
                {
                    count++;
                }
            }
        }

    }
}
