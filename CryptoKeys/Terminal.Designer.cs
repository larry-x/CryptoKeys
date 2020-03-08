namespace CryptoKeys
{
    partial class Terminal
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
            this.readme = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.allitems = new System.Windows.Forms.ListBox();
            this.retrieve = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readme
            // 
            this.readme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.readme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.readme.FlatAppearance.BorderSize = 3;
            this.readme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readme.Location = new System.Drawing.Point(51, 272);
            this.readme.Name = "readme";
            this.readme.Size = new System.Drawing.Size(223, 56);
            this.readme.TabIndex = 0;
            this.readme.Text = "README";
            this.readme.UseVisualStyleBackColor = false;
            this.readme.Click += new System.EventHandler(this.readme_Click);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.generate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generate.FlatAppearance.BorderSize = 3;
            this.generate.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(51, 172);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(223, 56);
            this.generate.TabIndex = 1;
            this.generate.Text = "Generate Bitcoin keys";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.add.FlatAppearance.BorderSize = 3;
            this.add.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(51, 70);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(223, 56);
            this.add.TabIndex = 2;
            this.add.Text = "Add Password";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // allitems
            // 
            this.allitems.FormattingEnabled = true;
            this.allitems.ItemHeight = 20;
            this.allitems.Location = new System.Drawing.Point(324, 23);
            this.allitems.Name = "allitems";
            this.allitems.Size = new System.Drawing.Size(502, 504);
            this.allitems.TabIndex = 3;
            this.allitems.SelectedValueChanged += new System.EventHandler(this.Enable_buttons);
            // 
            // retrieve
            // 
            this.retrieve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retrieve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.retrieve.FlatAppearance.BorderSize = 3;
            this.retrieve.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieve.Location = new System.Drawing.Point(869, 102);
            this.retrieve.Name = "retrieve";
            this.retrieve.Size = new System.Drawing.Size(132, 56);
            this.retrieve.TabIndex = 4;
            this.retrieve.Text = "Retrieve";
            this.retrieve.UseVisualStyleBackColor = false;
            this.retrieve.Click += new System.EventHandler(this.retrieve_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.edit.FlatAppearance.BorderSize = 3;
            this.edit.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(869, 214);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(132, 56);
            this.edit.TabIndex = 5;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delete.FlatAppearance.BorderSize = 3;
            this.delete.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(869, 320);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 56);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // leave
            // 
            this.leave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.leave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.leave.FlatAppearance.BorderSize = 3;
            this.leave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(51, 377);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(223, 56);
            this.leave.TabIndex = 7;
            this.leave.Text = "Exit";
            this.leave.UseVisualStyleBackColor = false;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 569);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.retrieve);
            this.Controls.Add(this.allitems);
            this.Controls.Add(this.add);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.readme);
            this.Name = "Terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoKeys";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readme;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox allitems;
        private System.Windows.Forms.Button retrieve;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button leave;
    }
}