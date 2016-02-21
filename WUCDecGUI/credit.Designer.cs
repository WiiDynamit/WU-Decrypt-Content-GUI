namespace WUCDecGUI
{
    partial class wucdecGUIcredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wucdecGUIcredit));
            this.creditBox = new System.Windows.Forms.TextBox();
            this.officalhomepageBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // creditBox
            // 
            this.creditBox.Location = new System.Drawing.Point(12, 60);
            this.creditBox.Multiline = true;
            this.creditBox.Name = "creditBox";
            this.creditBox.ReadOnly = true;
            this.creditBox.Size = new System.Drawing.Size(330, 143);
            this.creditBox.TabIndex = 0;
            this.creditBox.Text = resources.GetString("creditBox.Text");
            this.creditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // officalhomepageBox
            // 
            this.officalhomepageBox.Location = new System.Drawing.Point(12, 229);
            this.officalhomepageBox.Name = "officalhomepageBox";
            this.officalhomepageBox.ReadOnly = true;
            this.officalhomepageBox.Size = new System.Drawing.Size(330, 20);
            this.officalhomepageBox.TabIndex = 1;
            this.officalhomepageBox.Text = "Offical homepage is http://wiiubrew.net";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(329, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "WU_Decrypt Content GUI Version 0.10.0";
            // 
            // wucdecGUIcredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.officalhomepageBox);
            this.Controls.Add(this.creditBox);
            this.Name = "wucdecGUIcredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WU_Decrypt Content GUI credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditBox;
        private System.Windows.Forms.TextBox officalhomepageBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}