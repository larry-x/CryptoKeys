namespace CryptoKeys
{
    partial class Open
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
            this.welcometext = new System.Windows.Forms.Label();
            this.passinput = new System.Windows.Forms.TextBox();
            this.passsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcometext
            // 
            this.welcometext.AutoSize = true;
            this.welcometext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometext.Location = new System.Drawing.Point(390, 111);
            this.welcometext.Name = "welcometext";
            this.welcometext.Size = new System.Drawing.Size(229, 25);
            this.welcometext.TabIndex = 0;
            this.welcometext.Text = "Welcome to CryptoKeyz.";
            // 
            // passinput
            // 
            this.passinput.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passinput.Location = new System.Drawing.Point(254, 274);
            this.passinput.MaxLength = 64;
            this.passinput.Name = "passinput";
            this.passinput.PasswordChar = '$';
            this.passinput.Size = new System.Drawing.Size(535, 30);
            this.passinput.TabIndex = 1;
            this.passinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(PressEnter);
            // 
            // passsubmit
            // 
            this.passsubmit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passsubmit.Location = new System.Drawing.Point(395, 337);
            this.passsubmit.Name = "passsubmit";
            this.passsubmit.Size = new System.Drawing.Size(224, 75);
            this.passsubmit.TabIndex = 2;
            this.passsubmit.Text = "Unlock";
            this.passsubmit.UseVisualStyleBackColor = true;
            this.passsubmit.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 585);
            this.Controls.Add(this.passsubmit);
            this.Controls.Add(this.passinput);
            this.Controls.Add(this.welcometext);
            this.Name = "Open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoKeys";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcometext;
        private System.Windows.Forms.TextBox passinput;
        private System.Windows.Forms.Button passsubmit;
    }
}

