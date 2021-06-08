namespace freidesktop.session1.tela
{
    partial class corprimaria
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
            this.cbo1cor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbo2cor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltcor = new System.Windows.Forms.Label();
            this.lblcor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbo1cor
            // 
            this.cbo1cor.FormattingEnabled = true;
            this.cbo1cor.Items.AddRange(new object[] {
            "azul",
            "amarelo",
            "vermelho"});
            this.cbo1cor.Location = new System.Drawing.Point(12, 60);
            this.cbo1cor.Name = "cbo1cor";
            this.cbo1cor.Size = new System.Drawing.Size(121, 21);
            this.cbo1cor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vou misturar as cores primarias";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo2cor
            // 
            this.cbo2cor.FormattingEnabled = true;
            this.cbo2cor.Items.AddRange(new object[] {
            "azul",
            "amarelo ",
            "vermelho"});
            this.cbo2cor.Location = new System.Drawing.Point(139, 60);
            this.cbo2cor.Name = "cbo2cor";
            this.cbo2cor.Size = new System.Drawing.Size(121, 21);
            this.cbo2cor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1°Cor ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2 °Cor";
            // 
            // lbltcor
            // 
            this.lbltcor.AutoSize = true;
            this.lbltcor.Location = new System.Drawing.Point(86, 106);
            this.lbltcor.Name = "lbltcor";
            this.lbltcor.Size = new System.Drawing.Size(44, 13);
            this.lbltcor.TabIndex = 6;
            this.lbltcor.Text = "A cor é:";
            this.lbltcor.Visible = false;
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Location = new System.Drawing.Point(127, 106);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(35, 13);
            this.lblcor.TabIndex = 7;
            this.lblcor.Text = "label5";
            this.lblcor.Visible = false;
            // 
            // corprimaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 160);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.lbltcor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo2cor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo1cor);
            this.Name = "corprimaria";
            this.Text = "corprimaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo1cor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbo2cor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltcor;
        private System.Windows.Forms.Label lblcor;
    }
}