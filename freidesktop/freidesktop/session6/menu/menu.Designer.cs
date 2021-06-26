namespace freidesktop.session6.menu
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
            this.telaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // telaToolStripMenuItem
            // 
            this.telaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmloginToolStripMenuItem});
            this.telaToolStripMenuItem.Name = "telaToolStripMenuItem";
            this.telaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.telaToolStripMenuItem.Text = "Tela";
            // 
            // frmloginToolStripMenuItem
            // 
            this.frmloginToolStripMenuItem.Name = "frmloginToolStripMenuItem";
            this.frmloginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.frmloginToolStripMenuItem.Text = "frmlogin";
            this.frmloginToolStripMenuItem.Click += new System.EventHandler(this.frmloginToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 400);
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
        private System.Windows.Forms.ToolStripMenuItem telaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmloginToolStripMenuItem;
    }
}