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

        private void ZetKaartInBox(PictureBox pb, Card kaart)
        {
            string pad = Path.Combine(Application.StartupPath, "..", "..", "..", "Cards model", "PNG-cards-1.3", kaart.ImageName);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = Image.FromFile(pad);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            blackjackShoe.Shuffle();
            //MessageBox.Show("Kaarten geshuffeld!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tellerP1 >= 2) return;
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                if (tellerP1 == 0) ZetKaartInBox(pictureBox1, c);
                else if (tellerP1 == 1) ZetKaartInBox(pictureBox2, c);
                tellerP1++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tellerP2 >= 2) return;
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                if (tellerP2 == 0) ZetKaartInBox(pictureBox3, c);
                else if (tellerP2 == 1) ZetKaartInBox(pictureBox4, c);
                tellerP2++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tellerP3 >= 2) return;
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                if (tellerP3 == 0) ZetKaartInBox(pictureBox5, c);
                else if (tellerP3 == 1) ZetKaartInBox(pictureBox6, c);
                tellerP3++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tellerDealer >= 2) return;
            Card c = blackjackShoe.Draw();
            if (c != null)
            {
                if (tellerDealer == 0) ZetKaartInBox(pictureBox7, c);
                else if (tellerDealer == 1) ZetKaartInBox(pictureBox8, c);
                tellerDealer++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tellerP1 = tellerP2 = tellerP3 = tellerDealer = 0;

            pictureBox1.Image = pictureBox2.Image = null;
            pictureBox3.Image = pictureBox4.Image = null;
            pictureBox5.Image = pictureBox6.Image = null;
            pictureBox7.Image = pictureBox8.Image = null;

            blackjackShoe = new Shoe(6);
            blackjackShoe.Shuffle();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}