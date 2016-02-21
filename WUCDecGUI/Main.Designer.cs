namespace WUCDecGUI
{
    partial class wudecGUI
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
            this.tmdfileBTN = new System.Windows.Forms.Button();
            this.cetkBTN = new System.Windows.Forms.Button();
            this.ckeyBTN = new System.Windows.Forms.Button();
            this.decnowBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetkselBox = new System.Windows.Forms.CheckBox();
            this.tmdselBox = new System.Windows.Forms.CheckBox();
            this.ckeyselBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmdfileBTN
            // 
            this.tmdfileBTN.Location = new System.Drawing.Point(11, 65);
            this.tmdfileBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tmdfileBTN.Name = "tmdfileBTN";
            this.tmdfileBTN.Size = new System.Drawing.Size(127, 23);
            this.tmdfileBTN.TabIndex = 0;
            this.tmdfileBTN.Text = "TMD-File";
            this.tmdfileBTN.UseVisualStyleBackColor = true;
            this.tmdfileBTN.Click += new System.EventHandler(this.tmdfileBTNClick);
            // 
            // cetkBTN
            // 
            this.cetkBTN.Location = new System.Drawing.Point(11, 36);
            this.cetkBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cetkBTN.Name = "cetkBTN";
            this.cetkBTN.Size = new System.Drawing.Size(127, 23);
            this.cetkBTN.TabIndex = 1;
            this.cetkBTN.Text = "cetk-File";
            this.cetkBTN.UseVisualStyleBackColor = true;
            this.cetkBTN.Click += new System.EventHandler(this.cetkBTNClick);
            // 
            // ckeyBTN
            // 
            this.ckeyBTN.Location = new System.Drawing.Point(11, 94);
            this.ckeyBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckeyBTN.Name = "ckeyBTN";
            this.ckeyBTN.Size = new System.Drawing.Size(127, 23);
            this.ckeyBTN.TabIndex = 2;
            this.ckeyBTN.Text = "Common Key File";
            this.ckeyBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ckeyBTN.UseVisualStyleBackColor = true;
            this.ckeyBTN.Click += new System.EventHandler(this.ckeyBTNClick);
            // 
            // decnowBTN
            // 
            this.decnowBTN.Location = new System.Drawing.Point(13, 152);
            this.decnowBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.decnowBTN.Name = "decnowBTN";
            this.decnowBTN.Size = new System.Drawing.Size(382, 23);
            this.decnowBTN.TabIndex = 3;
            this.decnowBTN.Text = "Decrypt Now";
            this.decnowBTN.UseVisualStyleBackColor = true;
            this.decnowBTN.Click += new System.EventHandler(this.decnowBTNClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItemClick);
            // 
            // cetkselBox
            // 
            this.cetkselBox.AutoSize = true;
            this.cetkselBox.Enabled = false;
            this.cetkselBox.Location = new System.Drawing.Point(6, 19);
            this.cetkselBox.Name = "cetkselBox";
            this.cetkselBox.Size = new System.Drawing.Size(47, 17);
            this.cetkselBox.TabIndex = 5;
            this.cetkselBox.Text = "cetk";
            this.cetkselBox.UseVisualStyleBackColor = true;
            // 
            // tmdselBox
            // 
            this.tmdselBox.AutoSize = true;
            this.tmdselBox.Enabled = false;
            this.tmdselBox.Location = new System.Drawing.Point(6, 42);
            this.tmdselBox.Name = "tmdselBox";
            this.tmdselBox.Size = new System.Drawing.Size(50, 17);
            this.tmdselBox.TabIndex = 6;
            this.tmdselBox.Text = "TMD";
            this.tmdselBox.UseVisualStyleBackColor = true;
            // 
            // ckeyselBox
            // 
            this.ckeyselBox.AutoSize = true;
            this.ckeyselBox.Enabled = false;
            this.ckeyselBox.Location = new System.Drawing.Point(6, 64);
            this.ckeyselBox.Name = "ckeyselBox";
            this.ckeyselBox.Size = new System.Drawing.Size(88, 17);
            this.ckeyselBox.TabIndex = 7;
            this.ckeyselBox.Text = "Common Key";
            this.ckeyselBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cetkselBox);
            this.groupBox1.Controls.Add(this.ckeyselBox);
            this.groupBox1.Controls.Add(this.tmdselBox);
            this.groupBox1.Location = new System.Drawing.Point(259, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Files";
            // 
            // wudecGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 191);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.decnowBTN);
            this.Controls.Add(this.ckeyBTN);
            this.Controls.Add(this.cetkBTN);
            this.Controls.Add(this.tmdfileBTN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "wudecGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WU_Decrypt Content GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tmdfileBTN;
        private System.Windows.Forms.Button cetkBTN;
        private System.Windows.Forms.Button ckeyBTN;
        private System.Windows.Forms.Button decnowBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox tmdselBox;
        private System.Windows.Forms.CheckBox ckeyselBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cetkselBox;
    }
}

