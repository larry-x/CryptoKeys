﻿namespace CryptoKeys
{
    partial class Retrieve
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
            this.button1 = new System.Windows.Forms.Button();
            this.showtag = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showtag
            // 
            this.showtag.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtag.Location = new System.Drawing.Point(103, 38);
            this.showtag.Name = "showtag";
            this.showtag.Size = new System.Drawing.Size(524, 119);
            this.showtag.TabIndex = 0;
            // 
            // showpass
            // 
            this.showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.Location = new System.Drawing.Point(151, 204);
            this.showpass.Name = "showpass";
            this.showpass.ReadOnly = true;
            this.showpass.Size = new System.Drawing.Size(438, 30);
            this.showpass.TabIndex = 3;
            // 
            // Retrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(738, 384);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showtag);
            this.Name = "Retrieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label showtag;
        private System.Windows.Forms.TextBox showpass;
    }
}