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
            label1.Click += label1_Click;
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
            // 
            // button3
            // 
            button3.Location = new Point(434, 265);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Deal Cards";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(771, 375);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Deal Cards";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(393, 557);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 12;
            button5.Text = "Deal Cards";
            button5.UseVisualStyleBackColor = true;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 618);
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
            Load += Form1_Load;
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
    }
}
