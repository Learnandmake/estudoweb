namespace freitrabalho.telas.pergunta
{
    partial class pergunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pergunta));
            this.picclose = new System.Windows.Forms.PictureBox();
            this.picbarra = new System.Windows.Forms.PictureBox();
            this.lblenunciado = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboresposta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblminuto = new System.Windows.Forms.Label();
            this.lblald = new System.Windows.Forms.Label();
            this.lblalc = new System.Windows.Forms.Label();
            this.lblalb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblala = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnick = new System.Windows.Forms.Label();
            this.lblresposta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpontuacao = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsegundo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.Teal;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(500, 0);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(39, 31);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 31;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            this.picclose.MouseEnter += new System.EventHandler(this.picclose_MouseEnter);
            this.picclose.MouseLeave += new System.EventHandler(this.picclose_MouseLeave);
            // 
            // picbarra
            // 
            this.picbarra.BackColor = System.Drawing.Color.Teal;
            this.picbarra.Location = new System.Drawing.Point(-2, 0);
            this.picbarra.Name = "picbarra";
            this.picbarra.Size = new System.Drawing.Size(545, 31);
            this.picbarra.TabIndex = 27;
            this.picbarra.TabStop = false;
            this.picbarra.Click += new System.EventHandler(this.picbarra_Click);
            this.picbarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbarra_MouseMove);
            // 
            // lblenunciado
            // 
            this.lblenunciado.AutoSize = true;
            this.lblenunciado.BackColor = System.Drawing.Color.Transparent;
            this.lblenunciado.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenunciado.ForeColor = System.Drawing.Color.White;
            this.lblenunciado.Location = new System.Drawing.Point(164, 16);
            this.lblenunciado.Name = "lblenunciado";
            this.lblenunciado.Size = new System.Drawing.Size(101, 19);
            this.lblenunciado.TabIndex = 29;
            this.lblenunciado.Text = "Enunciado:";
            this.lblenunciado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.MintCream;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.ForeColor = System.Drawing.Color.Teal;
            this.btnenviar.Location = new System.Drawing.Point(152, 283);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(197, 44);
            this.btnenviar.TabIndex = 26;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            this.btnenviar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnenviar_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboresposta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(144, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 56);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // cboresposta
            // 
            this.cboresposta.FormattingEnabled = true;
            this.cboresposta.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.cboresposta.Location = new System.Drawing.Point(109, 22);
            this.cboresposta.Name = "cboresposta";
            this.cboresposta.Size = new System.Drawing.Size(111, 21);
            this.cboresposta.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Resposta:";
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblsegundo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblminuto);
            this.groupBox2.Controls.Add(this.lblald);
            this.groupBox2.Controls.Add(this.lblalc);
            this.groupBox2.Controls.Add(this.lblalb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblala);
            this.groupBox2.Controls.Add(this.lblenunciado);
            this.groupBox2.Location = new System.Drawing.Point(12, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 148);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(442, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(331, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tempo:";
            // 
            // lblminuto
            // 
            this.lblminuto.AutoSize = true;
            this.lblminuto.BackColor = System.Drawing.Color.Transparent;
            this.lblminuto.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminuto.ForeColor = System.Drawing.Color.White;
            this.lblminuto.Location = new System.Drawing.Point(413, 16);
            this.lblminuto.Name = "lblminuto";
            this.lblminuto.Size = new System.Drawing.Size(29, 19);
            this.lblminuto.TabIndex = 41;
            this.lblminuto.Text = "00";
            // 
            // lblald
            // 
            this.lblald.AutoSize = true;
            this.lblald.BackColor = System.Drawing.Color.Transparent;
            this.lblald.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblald.ForeColor = System.Drawing.Color.White;
            this.lblald.Location = new System.Drawing.Point(301, 111);
            this.lblald.Name = "lblald";
            this.lblald.Size = new System.Drawing.Size(31, 19);
            this.lblald.TabIndex = 37;
            this.lblald.Text = "AL";
            this.lblald.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblald_MouseMove);
            // 
            // lblalc
            // 
            this.lblalc.AutoSize = true;
            this.lblalc.BackColor = System.Drawing.Color.Transparent;
            this.lblalc.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalc.ForeColor = System.Drawing.Color.White;
            this.lblalc.Location = new System.Drawing.Point(301, 59);
            this.lblalc.Name = "lblalc";
            this.lblalc.Size = new System.Drawing.Size(31, 19);
            this.lblalc.TabIndex = 36;
            this.lblalc.Text = "AL";
            this.lblalc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblalc_MouseMove);
            // 
            // lblalb
            // 
            this.lblalb.AutoSize = true;
            this.lblalb.BackColor = System.Drawing.Color.Transparent;
            this.lblalb.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalb.ForeColor = System.Drawing.Color.White;
            this.lblalb.Location = new System.Drawing.Point(44, 111);
            this.lblalb.Name = "lblalb";
            this.lblalb.Size = new System.Drawing.Size(31, 19);
            this.lblalb.TabIndex = 35;
            this.lblalb.Text = "AL";
            this.lblalb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblalb_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(275, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "D)";
            this.label8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label8_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(275, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "C)";
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label7_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "B)";
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "A)";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // lblala
            // 
            this.lblala.AutoSize = true;
            this.lblala.BackColor = System.Drawing.Color.Transparent;
            this.lblala.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblala.ForeColor = System.Drawing.Color.White;
            this.lblala.Location = new System.Drawing.Point(44, 59);
            this.lblala.Name = "lblala";
            this.lblala.Size = new System.Drawing.Size(31, 19);
            this.lblala.TabIndex = 30;
            this.lblala.Text = "AL";
            this.lblala.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblala_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Olá ";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // lblnick
            // 
            this.lblnick.AutoSize = true;
            this.lblnick.BackColor = System.Drawing.Color.Teal;
            this.lblnick.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnick.ForeColor = System.Drawing.Color.White;
            this.lblnick.Location = new System.Drawing.Point(55, 5);
            this.lblnick.Name = "lblnick";
            this.lblnick.Size = new System.Drawing.Size(45, 19);
            this.lblnick.TabIndex = 34;
            this.lblnick.Text = "nick";
            this.lblnick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblnick_MouseMove);
            // 
            // lblresposta
            // 
            this.lblresposta.AutoSize = true;
            this.lblresposta.BackColor = System.Drawing.Color.Transparent;
            this.lblresposta.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresposta.ForeColor = System.Drawing.Color.White;
            this.lblresposta.Location = new System.Drawing.Point(56, 228);
            this.lblresposta.Name = "lblresposta";
            this.lblresposta.Size = new System.Drawing.Size(20, 19);
            this.lblresposta.TabIndex = 38;
            this.lblresposta.Text = "a";
            this.lblresposta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sua pontuacao é";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove_1);
            // 
            // lblpontuacao
            // 
            this.lblpontuacao.AutoSize = true;
            this.lblpontuacao.BackColor = System.Drawing.Color.Teal;
            this.lblpontuacao.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpontuacao.ForeColor = System.Drawing.Color.White;
            this.lblpontuacao.Location = new System.Drawing.Point(319, 5);
            this.lblpontuacao.Name = "lblpontuacao";
            this.lblpontuacao.Size = new System.Drawing.Size(45, 19);
            this.lblpontuacao.TabIndex = 40;
            this.lblpontuacao.Text = "nick";
            this.lblpontuacao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblpontuacao_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsegundo
            // 
            this.lblsegundo.AutoSize = true;
            this.lblsegundo.BackColor = System.Drawing.Color.Transparent;
            this.lblsegundo.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegundo.ForeColor = System.Drawing.Color.White;
            this.lblsegundo.Location = new System.Drawing.Point(458, 16);
            this.lblsegundo.Name = "lblsegundo";
            this.lblsegundo.Size = new System.Drawing.Size(29, 19);
            this.lblsegundo.TabIndex = 43;
            this.lblsegundo.Text = "00";
            // 
            // pergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 331);
            this.Controls.Add(this.lblpontuacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblresposta);
            this.Controls.Add(this.lblnick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.picbarra);
            this.Controls.Add(this.btnenviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pergunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pergunta";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pergunta_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.PictureBox picbarra;
        private System.Windows.Forms.Label lblenunciado;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblald;
        private System.Windows.Forms.Label lblalc;
        private System.Windows.Forms.Label lblalb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnick;
        private System.Windows.Forms.Label lblresposta;
        private System.Windows.Forms.ComboBox cboresposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpontuacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblminuto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblsegundo;
    }
}