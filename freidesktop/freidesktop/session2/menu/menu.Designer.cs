namespace freidesktop.session2.menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentoPcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criptografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quizToolStripMenuItem,
            this.orçamentoPcToolStripMenuItem,
            this.envioDeEmailToolStripMenuItem,
            this.consultaCepToolStripMenuItem,
            this.criptografiaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.quizToolStripMenuItem.Text = "Quiz";
            this.quizToolStripMenuItem.Click += new System.EventHandler(this.quizToolStripMenuItem_Click);
            // 
            // orçamentoPcToolStripMenuItem
            // 
            this.orçamentoPcToolStripMenuItem.Name = "orçamentoPcToolStripMenuItem";
            this.orçamentoPcToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.orçamentoPcToolStripMenuItem.Text = "Orçamento Pc";
            this.orçamentoPcToolStripMenuItem.Click += new System.EventHandler(this.orçamentoPcToolStripMenuItem_Click);
            // 
            // envioDeEmailToolStripMenuItem
            // 
            this.envioDeEmailToolStripMenuItem.Name = "envioDeEmailToolStripMenuItem";
            this.envioDeEmailToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.envioDeEmailToolStripMenuItem.Text = "Envio de e-mail";
            this.envioDeEmailToolStripMenuItem.Click += new System.EventHandler(this.envioDeEmailToolStripMenuItem_Click);
            // 
            // consultaCepToolStripMenuItem
            // 
            this.consultaCepToolStripMenuItem.Name = "consultaCepToolStripMenuItem";
            this.consultaCepToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.consultaCepToolStripMenuItem.Text = "Consulta cep";
            this.consultaCepToolStripMenuItem.Click += new System.EventHandler(this.consultaCepToolStripMenuItem_Click);
            // 
            // criptografiaToolStripMenuItem
            // 
            this.criptografiaToolStripMenuItem.Name = "criptografiaToolStripMenuItem";
            this.criptografiaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.criptografiaToolStripMenuItem.Text = "Criptografia";
            this.criptografiaToolStripMenuItem.Click += new System.EventHandler(this.criptografiaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentoPcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criptografiaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}