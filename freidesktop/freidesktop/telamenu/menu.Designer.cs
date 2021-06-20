namespace freidesktop.telamenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desafioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionToolStripMenuItem,
            this.eventoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneToolStripMenuItem,
            this.twoToolStripMenuItem,
            this.threeToolStripMenuItem,
            this.fourToolStripMenuItem,
            this.fiveToolStripMenuItem});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // oneToolStripMenuItem
            // 
            this.oneToolStripMenuItem.Name = "oneToolStripMenuItem";
            this.oneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oneToolStripMenuItem.Text = "one";
            this.oneToolStripMenuItem.Click += new System.EventHandler(this.oneToolStripMenuItem_Click);
            // 
            // twoToolStripMenuItem
            // 
            this.twoToolStripMenuItem.Name = "twoToolStripMenuItem";
            this.twoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twoToolStripMenuItem.Text = "two";
            this.twoToolStripMenuItem.Click += new System.EventHandler(this.twoToolStripMenuItem_Click);
            // 
            // threeToolStripMenuItem
            // 
            this.threeToolStripMenuItem.Name = "threeToolStripMenuItem";
            this.threeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.threeToolStripMenuItem.Text = "Three";
            this.threeToolStripMenuItem.Click += new System.EventHandler(this.threeToolStripMenuItem_Click);
            // 
            // fourToolStripMenuItem
            // 
            this.fourToolStripMenuItem.Name = "fourToolStripMenuItem";
            this.fourToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fourToolStripMenuItem.Text = "Four";
            this.fourToolStripMenuItem.Click += new System.EventHandler(this.fourToolStripMenuItem_Click);
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desafioToolStripMenuItem});
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.eventoToolStripMenuItem.Text = "Evento";
            // 
            // desafioToolStripMenuItem
            // 
            this.desafioToolStripMenuItem.Name = "desafioToolStripMenuItem";
            this.desafioToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.desafioToolStripMenuItem.Text = "Desafio";
            this.desafioToolStripMenuItem.Click += new System.EventHandler(this.desafioToolStripMenuItem_Click_1);
            // 
            // fiveToolStripMenuItem
            // 
            this.fiveToolStripMenuItem.Name = "fiveToolStripMenuItem";
            this.fiveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fiveToolStripMenuItem.Text = "Five";
            this.fiveToolStripMenuItem.Click += new System.EventHandler(this.fiveToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 329);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desafioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiveToolStripMenuItem;
    }
}