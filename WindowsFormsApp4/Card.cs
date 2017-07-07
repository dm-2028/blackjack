using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Card
    {
        public int Value;
        public char Suit { get; set; }

        public Card(int value, char suit)
        {
            if (value > 0 && value < 14)
            {
                this.Value = value;
            }
            else
            {
                throw new System.ArgumentException("Card value outside expected values");
            }
            if (suit == 'S' || suit == 'H' || suit == 'C' || suit == 'D')
            {
                this.Suit = suit;
            }
            else
            {
                throw new System.ArgumentException("Card suit outside expected values");
            }
        }

        public int getValue()
        {
            if (Value > 9 && Value < 14)
            {
                return 10;
            }
            else return Value;
        }

        public Char getCard()
        {
            if (Value == 1) return 'A';
            if (Value > 1 && Value < 10) return Convert.ToChar(Value + '0');
            if (Value == 10) return 'T';
            if (Value == 11) return 'J';
            if (Value == 12) return 'Q';
            if (Value == 13) return 'K';
            else return 'X';
        }
    }
}
