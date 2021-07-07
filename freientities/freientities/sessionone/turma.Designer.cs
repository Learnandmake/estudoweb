namespace freientities.sessionone
{
    partial class turma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(turma));
            this.picbarra = new System.Windows.Forms.PictureBox();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // picbarra
            // 
            this.picbarra.BackColor = System.Drawing.Color.Maroon;
            this.picbarra.Location = new System.Drawing.Point(0, 0);
            this.picbarra.Name = "picbarra";
            this.picbarra.Size = new System.Drawing.Size(621, 38);
            this.picbarra.TabIndex = 0;
            this.picbarra.TabStop = false;
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.Maroon;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(580, 0);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(38, 38);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 1;
            this.picclose.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(52, 44);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(14, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtcurso
            // 
            this.txtcurso.Location = new System.Drawing.Point(53, 73);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(100, 20);
            this.txtcurso.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "curso:";
            // 
            // dvg
            // 
            this.dvg.AllowUserToAddRows = false;
            this.dvg.AllowUserToDeleteRows = false;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Location = new System.Drawing.Point(160, 44);
            this.dvg.Name = "dvg";
            this.dvg.ReadOnly = true;
            this.dvg.Size = new System.Drawing.Size(458, 140);
            this.dvg.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "qtdmax de alunos:";
            // 
            // turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 193);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.picbarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "turma";
            this.Text = "turma";
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbarra;
        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}