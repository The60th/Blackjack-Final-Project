namespace Justin_Blackjack
{
    partial class Login_Form
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
            this.btnNewUsr = new System.Windows.Forms.Button();
            this.btnOldUsr = new System.Windows.Forms.Button();
            this.lblDisplay_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewUsr
            // 
            this.btnNewUsr.Location = new System.Drawing.Point(12, 104);
            this.btnNewUsr.Name = "btnNewUsr";
            this.btnNewUsr.Size = new System.Drawing.Size(118, 27);
            this.btnNewUsr.TabIndex = 0;
            this.btnNewUsr.Text = "Yes!";
            this.btnNewUsr.UseVisualStyleBackColor = true;
            this.btnNewUsr.Click += new System.EventHandler(this.btnNewUsr_Click);
            // 
            // btnOldUsr
            // 
            this.btnOldUsr.Location = new System.Drawing.Point(175, 104);
            this.btnOldUsr.Name = "btnOldUsr";
            this.btnOldUsr.Size = new System.Drawing.Size(118, 27);
            this.btnOldUsr.TabIndex = 1;
            this.btnOldUsr.Text = "No, let me play!";
            this.btnOldUsr.UseVisualStyleBackColor = true;
            this.btnOldUsr.Click += new System.EventHandler(this.btnOldUsr_Click);
            // 
            // lblDisplay_1
            // 
            this.lblDisplay_1.AutoSize = true;
            this.lblDisplay_1.Location = new System.Drawing.Point(35, 24);
            this.lblDisplay_1.Name = "lblDisplay_1";
            this.lblDisplay_1.Size = new System.Drawing.Size(151, 17);
            this.lblDisplay_1.TabIndex = 2;
            this.lblDisplay_1.Text = "Welcome to Black Jack.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you need intructions on how to play?";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplay_1);
            this.Controls.Add(this.btnOldUsr);
            this.Controls.Add(this.btnNewUsr);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewUsr;
        private System.Windows.Forms.Button btnOldUsr;
        private System.Windows.Forms.Label lblDisplay_1;
        private System.Windows.Forms.Label label1;
    }
}

