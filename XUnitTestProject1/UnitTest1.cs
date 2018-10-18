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

        //need to add tests for remove but the method is not working

    }
}
