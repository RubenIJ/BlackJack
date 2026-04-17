using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BlackJack.Models;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private Shoe blackjackShoe;
        private int tellerP1 = 0;

        private int tellerDealer = 0;
        private Hand handP1 = new Hand();

        private Hand handDealer = new Hand();

        public Form1()
        {
            InitializeComponent();
            blackjackShoe = new Shoe(6);
        }

        private void ZetKaartInBox(PictureBox pb, Card kaart)
        {
            string pad = Path.Combine(Application.StartupPath, "..", "..", "..", "Cards model", "PNG-cards-1.3", kaart.ImageName);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = Image.FromFile(pad);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            blackjackShoe.Shuffle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tellerP1 >= 6) return;

            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                handP1.Hit(c);

                PictureBox[] boxen = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
                ZetKaartInBox(boxen[tellerP1], c);

                tellerP1++;
                label1.Text = "Speler 1: " + handP1.Total;

                if (handP1.Total > 21)
                {
                    MessageBox.Show("De speler heeft meer dan 21, Dealer wint.");
                }
            }
        }





        private void button5_Click(object sender, EventArgs e)
        {
            if (tellerDealer >= 2) return;
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                handDealer.Hit(c);
                if (tellerDealer == 0)
                {
                    string pad = Path.Combine(Application.StartupPath, "..", "..", "..", "Cards model", "PNG-cards-1.3", "Back_of_card.png");
                    pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox7.Image = Image.FromFile(pad);
                    pictureBox7.Tag = c;
                    label4.Text = "Dealer: 0";
                }
                else if (tellerDealer == 1)
                {
                    ZetKaartInBox(pictureBox8, c);
                    label4.Text = "Dealer: " + c.Value;
                }
                tellerDealer++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tellerP1 = tellerDealer = 0;

            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = null;
            pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = null;
            pictureBox7.Image = pictureBox8.Image = null;

            handP1 = new Hand();
            handDealer = new Hand();

            label1.Text = "Speler 1: 0";
            label4.Text = "Dealer: 0";

            blackjackShoe = new Shoe(6);
            blackjackShoe.Shuffle();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}