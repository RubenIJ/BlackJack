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
        private int tellerP2 = 0;
        private int tellerP3 = 0;
        private int tellerDealer = 0;

        public Form1()
        {
            InitializeComponent();
            blackjackShoe = new Shoe(6);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            blackjackShoe.Shuffle();
            MessageBox.Show("Kaarten geshuffeld!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                string pad = Path.Combine(Application.StartupPath, "..", "..", "..", "Cards model", "PNG-cards-1.3", c.ImageName);
                pictureBox1.Image = Image.FromFile(pad);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                TekenKaart(c, 250, 300, tellerP2);
                tellerP2++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                TekenKaart(c, 450, 300, tellerP3);
                tellerP3++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                TekenKaart(c, 250, 50, tellerDealer);
                tellerDealer++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void TekenKaart(Card kaart, int xPos, int yPos, int hoeveelsteKaart)
        {
            PictureBox pb = new PictureBox();
            string pad = Path.Combine(Application.StartupPath, "..", "..", "Cards model", "SVG-cards-1.3", kaart.ToString().ToLower() + ".svg");

            if (File.Exists(pad))
            {
                pb.ImageLocation = pad;
            }

            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Width = 80;
            pb.Height = 110;
            pb.Location = new Point(xPos + (hoeveelsteKaart * 20), yPos);

            this.Controls.Add(pb);
            pb.BringToFront();
        }
    }
}