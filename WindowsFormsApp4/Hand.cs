using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Hand
    {
        public bool isDealer;
        public Card[] cards;
        public int numCards;
        public int total;
        public int numAces;
        public bool Bust { get; set; }


        public Hand(bool isDealer)
        {
            this.isDealer = isDealer;
            total = 0;
            numCards = 0;
            numAces = 0;
            Bust = false;
            cards = new Card[21];
        }
        public Card Deal(Deck deck)
        {
            if (numCards < 21)
            {
                Card retCard = deck.Deal();
                cards[numCards] = retCard;
                if (cards[numCards].getValue() == 1)
                {
                    numAces++;
                    total += 11;
                }
                else
                {
                    total += cards[numCards].getValue();
                }
                if (total > 21 && numAces > 0)
                {
                    total -= 10;
                    numAces--;
                }
                else if (total > 21)
                {
                    Bust = true;
                }
                else if (total == 21)
                {
                    Stay();
                }


                numCards++;

                return retCard;
           }
           else return null;
        }

        public void Stay()
        {

        }

        public void Blackjack()
        {

        }
    }
}
