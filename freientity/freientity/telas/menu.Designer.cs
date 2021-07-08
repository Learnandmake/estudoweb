namespace freientity.telas
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.telasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.challengeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // telasToolStripMenuItem
            // 
            this.telasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionToolStripMenuItem1,
            this.challengeToolStripMenuItem1});
            this.telasToolStripMenuItem.Name = "telasToolStripMenuItem";
            this.telasToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.telasToolStripMenuItem.Text = "Telas";
            // 
            // sessionToolStripMenuItem1
            // 
            this.sessionToolStripMenuItem1.Name = "sessionToolStripMenuItem1";
            this.sessionToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sessionToolStripMenuItem1.Text = "Session";
            this.sessionToolStripMenuItem1.Click += new System.EventHandler(this.sessionToolStripMenuItem1_Click);
            // 
            // challengeToolStripMenuItem1
            // 
            this.challengeToolStripMenuItem1.Name = "challengeToolStripMenuItem1";
            this.challengeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.challengeToolStripMenuItem1.Text = "Challenge";
            this.challengeToolStripMenuItem1.Click += new System.EventHandler(this.challengeToolStripMenuItem1_Click);
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.White;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(257, 0);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(30, 24);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 2;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem telasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem challengeToolStripMenuItem1;
        private System.Windows.Forms.PictureBox picclose;
    }
}