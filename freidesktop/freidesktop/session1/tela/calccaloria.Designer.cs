namespace freidesktop.session1.tela
{
    partial class calccaloria
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltconsumiu = new System.Windows.Forms.Label();
            this.lbltcal = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFastFood = new System.Windows.Forms.RadioButton();
            this.btnlanchenatural = new System.Windows.Forms.RadioButton();
            this.btnchurra = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsuconatural = new System.Windows.Forms.RadioButton();
            this.btnsucocaixa = new System.Windows.Forms.RadioButton();
            this.btncocacola = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnmousse = new System.Windows.Forms.RadioButton();
            this.btnbolo = new System.Windows.Forms.RadioButton();
            this.btnacai = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "vou  calcular suas calorias ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "informe o que você consumiu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "sobremesa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "bebida";
            // 
            // lbltconsumiu
            // 
            this.lbltconsumiu.AutoSize = true;
            this.lbltconsumiu.Location = new System.Drawing.Point(112, 194);
            this.lbltconsumiu.Name = "lbltconsumiu";
            this.lbltconsumiu.Size = new System.Drawing.Size(79, 13);
            this.lbltconsumiu.TabIndex = 15;
            this.lbltconsumiu.Text = "você consumiu";
            this.lbltconsumiu.Visible = false;
            // 
            // lbltcal
            // 
            this.lbltcal.AutoSize = true;
            this.lbltcal.Location = new System.Drawing.Point(220, 194);
            this.lbltcal.Name = "lbltcal";
            this.lbltcal.Size = new System.Drawing.Size(46, 13);
            this.lbltcal.TabIndex = 16;
            this.lbltcal.Text = "calorias ";
            this.lbltcal.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(192, 194);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(27, 13);
            this.lbltotal.TabIndex = 17;
            this.lbltotal.Text = "total";
            this.lbltotal.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFastFood);
            this.groupBox1.Controls.Add(this.btnlanchenatural);
            this.groupBox1.Controls.Add(this.btnchurra);
            this.groupBox1.Location = new System.Drawing.Point(0, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 87);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnFastFood
            // 
            this.btnFastFood.AutoSize = true;
            this.btnFastFood.Location = new System.Drawing.Point(6, 10);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(69, 17);
            this.btnFastFood.TabIndex = 21;
            this.btnFastFood.TabStop = true;
            this.btnFastFood.Text = "FastFood";
            this.btnFastFood.UseVisualStyleBackColor = true;
            // 
            // btnlanchenatural
            // 
            this.btnlanchenatural.AutoSize = true;
            this.btnlanchenatural.Location = new System.Drawing.Point(6, 56);
            this.btnlanchenatural.Name = "btnlanchenatural";
            this.btnlanchenatural.Size = new System.Drawing.Size(98, 17);
            this.btnlanchenatural.TabIndex = 20;
            this.btnlanchenatural.TabStop = true;
            this.btnlanchenatural.Text = "Lanche Natural";
            this.btnlanchenatural.UseVisualStyleBackColor = true;
            // 
            // btnchurra
            // 
            this.btnchurra.AutoSize = true;
            this.btnchurra.Location = new System.Drawing.Point(6, 33);
            this.btnchurra.Name = "btnchurra";
            this.btnchurra.Size = new System.Drawing.Size(61, 17);
            this.btnchurra.TabIndex = 19;
            this.btnchurra.TabStop = true;
            this.btnchurra.Text = "Churras";
            this.btnchurra.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsuconatural);
            this.groupBox2.Controls.Add(this.btnsucocaixa);
            this.groupBox2.Controls.Add(this.btncocacola);
            this.groupBox2.Location = new System.Drawing.Point(115, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 87);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnsuconatural
            // 
            this.btnsuconatural.AutoSize = true;
            this.btnsuconatural.Location = new System.Drawing.Point(15, 58);
            this.btnsuconatural.Name = "btnsuconatural";
            this.btnsuconatural.Size = new System.Drawing.Size(87, 17);
            this.btnsuconatural.TabIndex = 14;
            this.btnsuconatural.TabStop = true;
            this.btnsuconatural.Text = "Suco Natural";
            this.btnsuconatural.UseVisualStyleBackColor = true;
            // 
            // btnsucocaixa
            // 
            this.btnsucocaixa.AutoSize = true;
            this.btnsucocaixa.Location = new System.Drawing.Point(15, 35);
            this.btnsucocaixa.Name = "btnsucocaixa";
            this.btnsucocaixa.Size = new System.Drawing.Size(79, 17);
            this.btnsucocaixa.TabIndex = 13;
            this.btnsucocaixa.TabStop = true;
            this.btnsucocaixa.Text = "Suco Caixa";
            this.btnsucocaixa.UseVisualStyleBackColor = true;
            // 
            // btncocacola
            // 
            this.btncocacola.AutoSize = true;
            this.btncocacola.Location = new System.Drawing.Point(15, 12);
            this.btncocacola.Name = "btncocacola";
            this.btncocacola.Size = new System.Drawing.Size(73, 17);
            this.btncocacola.TabIndex = 12;
            this.btncocacola.TabStop = true;
            this.btncocacola.Text = "Coca-cola";
            this.btncocacola.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnmousse);
            this.groupBox3.Controls.Add(this.btnbolo);
            this.groupBox3.Controls.Add(this.btnacai);
            this.groupBox3.Location = new System.Drawing.Point(237, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 87);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // btnmousse
            // 
            this.btnmousse.AutoSize = true;
            this.btnmousse.Location = new System.Drawing.Point(6, 56);
            this.btnmousse.Name = "btnmousse";
            this.btnmousse.Size = new System.Drawing.Size(62, 17);
            this.btnmousse.TabIndex = 17;
            this.btnmousse.TabStop = true;
            this.btnmousse.Text = "Mousse";
            this.btnmousse.UseVisualStyleBackColor = true;
            // 
            // btnbolo
            // 
            this.btnbolo.AutoSize = true;
            this.btnbolo.Location = new System.Drawing.Point(6, 33);
            this.btnbolo.Name = "btnbolo";
            this.btnbolo.Size = new System.Drawing.Size(46, 17);
            this.btnbolo.TabIndex = 16;
            this.btnbolo.TabStop = true;
            this.btnbolo.Text = "Bolo";
            this.btnbolo.UseVisualStyleBackColor = true;
            // 
            // btnacai
            // 
            this.btnacai.AutoSize = true;
            this.btnacai.Location = new System.Drawing.Point(6, 10);
            this.btnacai.Name = "btnacai";
            this.btnacai.Size = new System.Drawing.Size(48, 17);
            this.btnacai.TabIndex = 15;
            this.btnacai.TabStop = true;
            this.btnacai.Text = "Açaí";
            this.btnacai.UseVisualStyleBackColor = true;
            // 
            // calccaloria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 239);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbltcal);
            this.Controls.Add(this.lbltconsumiu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "calccaloria";
            this.Text = "calccaloria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltconsumiu;
        private System.Windows.Forms.Label lbltcal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnFastFood;
        private System.Windows.Forms.RadioButton btnlanchenatural;
        private System.Windows.Forms.RadioButton btnchurra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnsuconatural;
        private System.Windows.Forms.RadioButton btnsucocaixa;
        private System.Windows.Forms.RadioButton btncocacola;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnmousse;
        private System.Windows.Forms.RadioButton btnbolo;
        private System.Windows.Forms.RadioButton btnacai;
    }
}