namespace Justin_Blackjack
{
    partial class My_MsgBox_Prompt
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
            this.btnAnswer_One = new System.Windows.Forms.Button();
            this.btnAnswer_Two = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnswer_One
            // 
            this.btnAnswer_One.Location = new System.Drawing.Point(13, 38);
            this.btnAnswer_One.Name = "btnAnswer_One";
            this.btnAnswer_One.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer_One.TabIndex = 0;
            this.btnAnswer_One.Text = "1";
            this.btnAnswer_One.UseVisualStyleBackColor = true;
            this.btnAnswer_One.Click += new System.EventHandler(this.btnAnswer_One_Click);
            // 
            // btnAnswer_Two
            // 
            this.btnAnswer_Two.Location = new System.Drawing.Point(167, 38);
            this.btnAnswer_Two.Name = "btnAnswer_Two";
            this.btnAnswer_Two.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer_Two.TabIndex = 1;
            this.btnAnswer_Two.Text = "11";
            this.btnAnswer_Two.UseVisualStyleBackColor = true;
            this.btnAnswer_Two.Click += new System.EventHandler(this.btnAnswer_Two_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtQuestion.Location = new System.Drawing.Point(40, 9);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(188, 15);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.Text = "Would you like this ace to be 1 or 11?";
            this.txtQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 91);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnAnswer_Two);
            this.Controls.Add(this.btnAnswer_One);
            this.Name = "myMessageBox";
            this.Text = "myMessageBox";
            this.Load += new System.EventHandler(this.myMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer_One;
        private System.Windows.Forms.Button btnAnswer_Two;
        private System.Windows.Forms.Label txtQuestion;
    }
}