namespace CryptoKeys
{
    partial class Initialize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initialize));
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.confirmpassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(212, 450);
            this.passwordbox.MaxLength = 64;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(570, 30);
            this.passwordbox.TabIndex = 0;
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(95, 92);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(853, 295);
            this.info.TabIndex = 1;
            this.info.Text = resources.GetString("info.Text");
            // 
            // confirmpassword
            // 
            this.confirmpassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassword.Location = new System.Drawing.Point(400, 529);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(184, 48);
            this.confirmpassword.TabIndex = 2;
            this.confirmpassword.Text = "Memorized!";
            this.confirmpassword.UseVisualStyleBackColor = true;
            this.confirmpassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // Initialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 650);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.info);
            this.Controls.Add(this.passwordbox);
            this.Name = "Initialize";
            this.Text = "Initialize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button confirmpassword;
    }
}