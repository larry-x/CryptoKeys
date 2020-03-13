namespace CryptoKeys
{
    partial class Generate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate));
            this.gseed = new System.Windows.Forms.Button();
            this.gsave = new System.Windows.Forms.Button();
            this.gok = new System.Windows.Forms.Button();
            this.hashbox = new System.Windows.Forms.TextBox();
            this.seedbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tagbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gseed
            // 
            this.gseed.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gseed.Location = new System.Drawing.Point(65, 498);
            this.gseed.Name = "gseed";
            this.gseed.Size = new System.Drawing.Size(243, 54);
            this.gseed.TabIndex = 1;
            this.gseed.Text = "Generate";
            this.gseed.UseVisualStyleBackColor = true;
            this.gseed.Click += new System.EventHandler(this.gseed_Click);
            // 
            // gsave
            // 
            this.gsave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsave.Location = new System.Drawing.Point(373, 498);
            this.gsave.Name = "gsave";
            this.gsave.Size = new System.Drawing.Size(243, 54);
            this.gsave.TabIndex = 2;
            this.gsave.Text = "Save";
            this.gsave.UseVisualStyleBackColor = true;
            this.gsave.Click += new System.EventHandler(this.gsave_Click);
            // 
            // gok
            // 
            this.gok.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gok.Location = new System.Drawing.Point(706, 498);
            this.gok.Name = "gok";
            this.gok.Size = new System.Drawing.Size(243, 54);
            this.gok.TabIndex = 3;
            this.gok.Text = "Cancel";
            this.gok.UseVisualStyleBackColor = true;
            this.gok.Click += new System.EventHandler(this.gok_Click);
            // 
            // hashbox
            // 
            this.hashbox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashbox.Location = new System.Drawing.Point(52, 132);
            this.hashbox.Name = "hashbox";
            this.hashbox.ReadOnly = true;
            this.hashbox.Size = new System.Drawing.Size(570, 30);
            this.hashbox.TabIndex = 4;
            // 
            // seedbox
            // 
            this.seedbox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedbox.Location = new System.Drawing.Point(52, 219);
            this.seedbox.Name = "seedbox";
            this.seedbox.Size = new System.Drawing.Size(570, 30);
            this.seedbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 425);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password Hash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tag";
            // 
            // tagbox
            // 
            this.tagbox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagbox.Location = new System.Drawing.Point(52, 327);
            this.tagbox.Name = "tagbox";
            this.tagbox.Size = new System.Drawing.Size(570, 30);
            this.tagbox.TabIndex = 13;
            this.tagbox.Enabled = false;
            // 
            // Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1041, 608);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tagbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seedbox);
            this.Controls.Add(this.hashbox);
            this.Controls.Add(this.gok);
            this.Controls.Add(this.gsave);
            this.Controls.Add(this.gseed);
            this.Name = "Generate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gseed;
        private System.Windows.Forms.Button gsave;
        private System.Windows.Forms.Button gok;
        private System.Windows.Forms.TextBox hashbox;
        private System.Windows.Forms.TextBox seedbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tagbox;
    }
}