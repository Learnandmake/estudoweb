namespace freidesktop.session1.tela
{
    partial class midade
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
            this.lblfmc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresposta = new System.Windows.Forms.Label();
            this.btnfmc = new System.Windows.Forms.Button();
            this.idade = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblfmc
            // 
            this.lblfmc.AutoSize = true;
            this.lblfmc.Location = new System.Drawing.Point(106, 83);
            this.lblfmc.Name = "lblfmc";
            this.lblfmc.Size = new System.Drawing.Size(33, 13);
            this.lblfmc.TabIndex = 11;
            this.lblfmc.Text = "idade";
            this.lblfmc.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "vou verificar se você é maior de idade";
            // 
            // lblresposta
            // 
            this.lblresposta.AutoSize = true;
            this.lblresposta.Location = new System.Drawing.Point(54, 83);
            this.lblresposta.Name = "lblresposta";
            this.lblresposta.Size = new System.Drawing.Size(43, 13);
            this.lblresposta.TabIndex = 9;
            this.lblresposta.Text = "você é:";
            this.lblresposta.Visible = false;
           
            // 
            // btnfmc
            // 
            this.btnfmc.Location = new System.Drawing.Point(60, 99);
            this.btnfmc.Name = "btnfmc";
            this.btnfmc.Size = new System.Drawing.Size(75, 23);
            this.btnfmc.TabIndex = 8;
            this.btnfmc.Text = "ok";
            this.btnfmc.UseVisualStyleBackColor = true;
            this.btnfmc.Click += new System.EventHandler(this.btnfmc_Click);
            // 
            // idade
            // 
            this.idade.AutoSize = true;
            this.idade.Location = new System.Drawing.Point(54, 44);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(81, 13);
            this.idade.TabIndex = 7;
            this.idade.Text = "digite sua idade";
       
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(57, 60);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 6;
      
            // 
            // midade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 150);
            this.Controls.Add(this.lblfmc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblresposta);
            this.Controls.Add(this.btnfmc);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.txtidade);
            this.Name = "midade";
            this.Text = "midade";
     
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfmc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresposta;
        private System.Windows.Forms.Button btnfmc;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.TextBox txtidade;
    }
}