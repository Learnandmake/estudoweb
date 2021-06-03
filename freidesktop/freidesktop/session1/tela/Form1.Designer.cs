namespace freidesktop
{
    partial class Form1
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
            this.txtidade = new System.Windows.Forms.TextBox();
            this.idade = new System.Windows.Forms.Label();
            this.btnfmc = new System.Windows.Forms.Button();
            this.resposta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblfmc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(48, 81);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 0;
            // 
            // idade
            // 
            this.idade.AutoSize = true;
            this.idade.Location = new System.Drawing.Point(45, 65);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(81, 13);
            this.idade.TabIndex = 1;
            this.idade.Text = "digite sua idade";
            // 
            // btnfmc
            // 
            this.btnfmc.Location = new System.Drawing.Point(63, 136);
            this.btnfmc.Name = "btnfmc";
            this.btnfmc.Size = new System.Drawing.Size(75, 23);
            this.btnfmc.TabIndex = 2;
            this.btnfmc.Text = "ok";
            this.btnfmc.UseVisualStyleBackColor = true;
            this.btnfmc.Click += new System.EventHandler(this.btnfmc_Click);
            // 
            // resposta
            // 
            this.resposta.AutoSize = true;
            this.resposta.Location = new System.Drawing.Point(45, 120);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(61, 13);
            this.resposta.TabIndex = 3;
            this.resposta.Text = "Seu fmc é: ";
            this.resposta.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "vou calcular seu fmc";
            // 
            // lblfmc
            // 
            this.lblfmc.AutoSize = true;
            this.lblfmc.Location = new System.Drawing.Point(97, 120);
            this.lblfmc.Name = "lblfmc";
            this.lblfmc.Size = new System.Drawing.Size(24, 13);
            this.lblfmc.TabIndex = 5;
            this.lblfmc.Text = "fmc";
            this.lblfmc.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 198);
            this.Controls.Add(this.lblfmc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.btnfmc);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.txtidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.Button btnfmc;
        private System.Windows.Forms.Label resposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblfmc;
    }
}

