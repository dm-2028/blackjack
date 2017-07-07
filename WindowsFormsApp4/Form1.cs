using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Hand DealerHand;
        public Hand[] PlayerHands;
        public Deck cards;
        public int currHand;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            panel1.Visible = true;
            currHand = 0;
            PlayerHands = new Hand[4];
            cards = new Deck();
            cards.Shuffle();
            DealerHand = new Hand(true);
            PlayerHands[currHand] = new Hand(false);
            textBox1.Text += PlayerHands[currHand].Deal(cards).getCard().ToString();
            DealerHand.Deal(cards);
            textBox1.Text += PlayerHands[currHand].Deal(cards).getCard().ToString();
            textBox2.Text += DealerHand.Deal(cards).getCard().ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += PlayerHands[currHand].Deal(cards).getCard().ToString();
            if (PlayerHands[currHand].Bust)
            {
                panel2.Visible = true;
                EndText.Text = "You Busted!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += DealerHand.cards[0].getCard().ToString();
            while((DealerHand.total < 17 || (DealerHand.total == 17 && DealerHand.numAces > 0)) && !DealerHand.Bust )
            {
                textBox2.Text += DealerHand.Deal(cards).getCard().ToString();                
            }
            if (DealerHand.Bust)
            {
                panel2.Visible = true;
                EndText.Text = "Dealer Busted! You Win!";

            }
            else if(DealerHand.total < PlayerHands[currHand].total)
            {
                panel2.Visible = true;
                EndText.Text = "Dealer has " + DealerHand.total + ", you have " + PlayerHands[currHand].total + ", you win!";
            }
            else if(DealerHand.total == PlayerHands[currHand].total)
            {
                panel2.Visible = true;
                EndText.Text = "You and the Dealer both have " + DealerHand.total + ", it's a push";
            }
            else
            {
                panel2.Visible = true;
                EndText.Text = "The Dealer's " + DealerHand.total + " beats your " + PlayerHands[currHand].total + ", too bad";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += PlayerHands[currHand].Deal(cards).getCard().ToString();
            button3_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //PlayerHands = null;
            //DealerHand = null;
            //cards = null;
            panel2.Visible = false;
            button2_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
