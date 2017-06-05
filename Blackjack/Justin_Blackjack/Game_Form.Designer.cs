namespace Justin_Blackjack
{
    partial class Game_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player3 = new System.Windows.Forms.PictureBox();
            this.player4 = new System.Windows.Forms.PictureBox();
            this.player5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dealer1 = new System.Windows.Forms.PictureBox();
            this.dealer2 = new System.Windows.Forms.PictureBox();
            this.dealer3 = new System.Windows.Forms.PictureBox();
            this.dealer4 = new System.Windows.Forms.PictureBox();
            this.dealer5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblPlayerHandValue = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(16, 490);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(100, 28);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "Start game";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(137, 490);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(100, 28);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.button2_Click);
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(29, 252);
            this.player1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(133, 167);
            this.player1.TabIndex = 2;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(223, 252);
            this.player2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(133, 167);
            this.player2.TabIndex = 3;
            this.player2.TabStop = false;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // player3
            // 
            this.player3.Location = new System.Drawing.Point(395, 252);
            this.player3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(133, 167);
            this.player3.TabIndex = 4;
            this.player3.TabStop = false;
            this.player3.Click += new System.EventHandler(this.player3_Click);
            // 
            // player4
            // 
            this.player4.Location = new System.Drawing.Point(579, 252);
            this.player4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(133, 167);
            this.player4.TabIndex = 5;
            this.player4.TabStop = false;
            this.player4.Click += new System.EventHandler(this.player4_Click);
            // 
            // player5
            // 
            this.player5.Location = new System.Drawing.Point(753, 252);
            this.player5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player5.Name = "player5";
            this.player5.Size = new System.Drawing.Size(133, 167);
            this.player5.TabIndex = 6;
            this.player5.TabStop = false;
            this.player5.Click += new System.EventHandler(this.player5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-39, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1184, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________________________________________________________";
            // 
            // dealer1
            // 
            this.dealer1.Location = new System.Drawing.Point(29, 15);
            this.dealer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealer1.Name = "dealer1";
            this.dealer1.Size = new System.Drawing.Size(133, 180);
            this.dealer1.TabIndex = 8;
            this.dealer1.TabStop = false;
            // 
            // dealer2
            // 
            this.dealer2.Location = new System.Drawing.Point(223, 15);
            this.dealer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealer2.Name = "dealer2";
            this.dealer2.Size = new System.Drawing.Size(133, 180);
            this.dealer2.TabIndex = 9;
            this.dealer2.TabStop = false;
            // 
            // dealer3
            // 
            this.dealer3.Location = new System.Drawing.Point(395, 15);
            this.dealer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealer3.Name = "dealer3";
            this.dealer3.Size = new System.Drawing.Size(133, 180);
            this.dealer3.TabIndex = 10;
            this.dealer3.TabStop = false;
            // 
            // dealer4
            // 
            this.dealer4.Location = new System.Drawing.Point(579, 15);
            this.dealer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealer4.Name = "dealer4";
            this.dealer4.Size = new System.Drawing.Size(133, 180);
            this.dealer4.TabIndex = 11;
            this.dealer4.TabStop = false;
            // 
            // dealer5
            // 
            this.dealer5.Location = new System.Drawing.Point(753, 15);
            this.dealer5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dealer5.Name = "dealer5";
            this.dealer5.Size = new System.Drawing.Size(133, 180);
            this.dealer5.TabIndex = 12;
            this.dealer5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-39, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1184, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________________________________________________________";
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(457, 489);
            this.btnHit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(100, 28);
            this.btnHit.TabIndex = 14;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(595, 487);
            this.btnStay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(100, 28);
            this.btnStay.TabIndex = 15;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Visible = false;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // lblPlayerHandValue
            // 
            this.lblPlayerHandValue.AutoSize = true;
            this.lblPlayerHandValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerHandValue.Location = new System.Drawing.Point(451, 441);
            this.lblPlayerHandValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerHandValue.Name = "lblPlayerHandValue";
            this.lblPlayerHandValue.Size = new System.Drawing.Size(104, 19);
            this.lblPlayerHandValue.TabIndex = 16;
            this.lblPlayerHandValue.Text = "Hand Value  = ";
            this.lblPlayerHandValue.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(785, 502);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(137, 36);
            this.btnRestart.TabIndex = 17;
            this.btnRestart.Text = "Next hand.";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(949, 505);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 549);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblPlayerHandValue);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dealer5);
            this.Controls.Add(this.dealer4);
            this.Controls.Add(this.dealer3);
            this.Controls.Add(this.dealer2);
            this.Controls.Add(this.dealer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player5);
            this.Controls.Add(this.player4);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnDeal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game_Form";
            this.Text = "Game_Form";
            this.Load += new System.EventHandler(this.Game_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player3;
        private System.Windows.Forms.PictureBox player4;
        private System.Windows.Forms.PictureBox player5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dealer1;
        private System.Windows.Forms.PictureBox dealer2;
        private System.Windows.Forms.PictureBox dealer3;
        private System.Windows.Forms.PictureBox dealer4;
        private System.Windows.Forms.PictureBox dealer5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblPlayerHandValue;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
    }
}