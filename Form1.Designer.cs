using BlackJack.Models;
using System;
using System.Windows.Forms;

namespace BlackJack
{


    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Inzet1 = new ListBox();
            Inzet3 = new ListBox();
            Inzet2 = new ListBox();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 557);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Dealer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 314);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 4;
            label2.Text = "Speler1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 204);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Speler2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(835, 314);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "Speler3";
            // 
            // button1
            // 
            button1.Location = new Point(39, 548);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Shuffle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(67, 375);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Deal Cards";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(434, 265);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Deal Cards";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(771, 375);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Deal Cards";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(393, 557);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 12;
            button5.Text = "Deal Cards";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Inzet1
            // 
            Inzet1.FormattingEnabled = true;
            Inzet1.Location = new Point(162, 337);
            Inzet1.Name = "Inzet1";
            Inzet1.Size = new Size(94, 24);
            Inzet1.TabIndex = 13;
            // 
            // Inzet3
            // 
            Inzet3.FormattingEnabled = true;
            Inzet3.Location = new Point(823, 337);
            Inzet3.Name = "Inzet3";
            Inzet3.Size = new Size(94, 24);
            Inzet3.TabIndex = 14;
            // 
            // Inzet2
            // 
            Inzet2.FormattingEnabled = true;
            Inzet2.Location = new Point(487, 227);
            Inzet2.Name = "Inzet2";
            Inzet2.Size = new Size(94, 24);
            Inzet2.TabIndex = 15;
            // 
            // button6
            // 
            button6.Location = new Point(162, 548);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 16;
            button6.Text = "New Game";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(54, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 160);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(218, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 160);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(393, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 160);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(546, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 160);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(727, 151);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 160);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(881, 151);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(125, 160);
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(393, 375);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(125, 160);
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(546, 375);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(125, 160);
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 618);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(Inzet2);
            Controls.Add(Inzet3);
            Controls.Add(Inzet1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ListBox Inzet1;
        private ListBox Inzet3;
        private ListBox Inzet2;
        private Button button6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}
