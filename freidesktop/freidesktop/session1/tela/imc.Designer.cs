namespace freidesktop.session1.tela
{
    partial class imc
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
            this.resposta = new System.Windows.Forms.Label();
            this.btnfmc = new System.Windows.Forms.Button();
            this.idade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudaltura = new System.Windows.Forms.NumericUpDown();
            this.nudpeso = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudaltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudpeso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfmc
            // 
            this.lblfmc.AutoSize = true;
            this.lblfmc.Location = new System.Drawing.Point(69, 132);
            this.lblfmc.Name = "lblfmc";
            this.lblfmc.Size = new System.Drawing.Size(23, 13);
            this.lblfmc.TabIndex = 11;
            this.lblfmc.Text = "imc";
            this.lblfmc.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vou calcular seu imc";
            // 
            // resposta
            // 
            this.resposta.AutoSize = true;
            this.resposta.Location = new System.Drawing.Point(12, 132);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(60, 13);
            this.resposta.TabIndex = 9;
            this.resposta.Text = "Seu imc é: ";
            this.resposta.Visible = false;
            // 
            // btnfmc
            // 
            this.btnfmc.Location = new System.Drawing.Point(15, 148);
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
            this.idade.Location = new System.Drawing.Point(12, 46);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(30, 13);
            this.idade.TabIndex = 7;
            this.idade.Text = "peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "altura";
            // 
            // nudaltura
            // 
            this.nudaltura.Location = new System.Drawing.Point(15, 98);
            this.nudaltura.Name = "nudaltura";
            this.nudaltura.Size = new System.Drawing.Size(45, 20);
            this.nudaltura.TabIndex = 14;
            // 
            // nudpeso
            // 
            this.nudpeso.Location = new System.Drawing.Point(12, 62);
            this.nudpeso.Name = "nudpeso";
            this.nudpeso.Size = new System.Drawing.Size(48, 20);
            this.nudpeso.TabIndex = 15;
            // 
            // imc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 176);
            this.Controls.Add(this.nudpeso);
            this.Controls.Add(this.nudaltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfmc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.btnfmc);
            this.Controls.Add(this.idade);
            this.Name = "imc";
            this.Text = "imc";
            ((System.ComponentModel.ISupportInitialize)(this.nudaltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudpeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfmc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resposta;
        private System.Windows.Forms.Button btnfmc;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudaltura;
        private System.Windows.Forms.NumericUpDown nudpeso;
    }
}