namespace CryptoKeys
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.save = new System.Windows.Forms.Button();
            this.canceladd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newtag = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(201, 423);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(174, 56);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // canceladd
            // 
            this.canceladd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceladd.Location = new System.Drawing.Point(481, 423);
            this.canceladd.Name = "canceladd";
            this.canceladd.Size = new System.Drawing.Size(174, 56);
            this.canceladd.TabIndex = 1;
            this.canceladd.Text = "Cancel";
            this.canceladd.UseVisualStyleBackColor = true;
            this.canceladd.Click += new System.EventHandler(this.canceladd_Click);
            // 
            // label1
            // 
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 154);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // newtag
            // 
            this.newtag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtag.Location = new System.Drawing.Point(224, 265);
            this.newtag.MaxLength = 42;
            this.newtag.Name = "newtag";
            this.newtag.Size = new System.Drawing.Size(394, 30);
            this.newtag.TabIndex = 3;
            this.newtag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Special_char);
            // 
            // newpass
            // 
            this.newpass.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(224, 343);
            this.newpass.MaxLength = 64;
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(394, 30);
            this.newpass.TabIndex = 4;
            this.newpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Special_char);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.newtag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canceladd);
            this.Controls.Add(this.save);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button canceladd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newtag;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}