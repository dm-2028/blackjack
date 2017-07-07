using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Deck
    {
        public Card[] cards;
        public static char[] suits = { 'S', 'C', 'H', 'D' };
        public int curCard;

        public Deck()
        {
            cards = new Card[52];
            curCard = 0;

            int i = 0;

            for(int suit = 0; suit < suits.Length; suit++)
            {
                for(int val = 1; val < 13; val++)
                {
                    cards[i++] = new Card(val, suits[suit]);
                }
            }
        }

        public void Shuffle()
        {
            Card temp;
            int switchVal;
            for(int i = 0; i < cards.Length-1; i++)
            {
                Random rand = new System.Random();
                temp = cards[i];
                switchVal = rand.Next(i + 1, cards.Length - 1);
                cards[i] = cards[switchVal];
                cards[switchVal] = temp;
            }
        }

        public Card Deal()
        {
            if(curCard < cards.Length)
            {
                return cards[curCard++];
                
            }
            else
            {
                Shuffle();
                curCard = 0;
                return cards[curCard++];
            }
        }

    }
}
