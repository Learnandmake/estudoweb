namespace freitrabalho.telas.usuario
{
    partial class consultarusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultarusuario));
            this.picclose = new System.Windows.Forms.PictureBox();
            this.picbarra = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnickusuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbnick = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgusuario = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.Teal;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(685, -1);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(39, 31);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 16;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            this.picclose.MouseEnter += new System.EventHandler(this.picclose_MouseEnter);
            this.picclose.MouseLeave += new System.EventHandler(this.picclose_MouseLeave);
            // 
            // picbarra
            // 
            this.picbarra.BackColor = System.Drawing.Color.Teal;
            this.picbarra.Location = new System.Drawing.Point(-1, -1);
            this.picbarra.Name = "picbarra";
            this.picbarra.Size = new System.Drawing.Size(725, 31);
            this.picbarra.TabIndex = 14;
            this.picbarra.TabStop = false;
            this.picbarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbarra_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(52, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 101);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // txtnickusuario
            // 
            this.txtnickusuario.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnickusuario.ForeColor = System.Drawing.Color.Black;
            this.txtnickusuario.Location = new System.Drawing.Point(73, 37);
            this.txtnickusuario.Name = "txtnickusuario";
            this.txtnickusuario.Size = new System.Drawing.Size(100, 23);
            this.txtnickusuario.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtidusuario);
            this.groupBox1.Controls.Add(this.txtsenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnickusuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 132);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id:";
            // 
            // txtidusuario
            // 
            this.txtidusuario.Enabled = false;
            this.txtidusuario.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidusuario.ForeColor = System.Drawing.Color.Black;
            this.txtidusuario.Location = new System.Drawing.Point(73, 9);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(20, 23);
            this.txtidusuario.TabIndex = 18;
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.Black;
            this.txtsenha.Location = new System.Drawing.Point(73, 98);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 23);
            this.txtsenha.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Senha:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(73, 68);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 23);
            this.txtemail.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nick:";
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.MintCream;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.ForeColor = System.Drawing.Color.Teal;
            this.btncadastrar.Location = new System.Drawing.Point(6, 247);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(96, 44);
            this.btncadastrar.TabIndex = 17;
            this.btncadastrar.Text = "Alterar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btncadastrar);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(4, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 300);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(107, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtbnick);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.dvgusuario);
            this.groupBox4.Location = new System.Drawing.Point(224, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 300);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nick:";
            // 
            // txtbnick
            // 
            this.txtbnick.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbnick.ForeColor = System.Drawing.Color.Black;
            this.txtbnick.Location = new System.Drawing.Point(107, 16);
            this.txtbnick.Name = "txtbnick";
            this.txtbnick.Size = new System.Drawing.Size(243, 23);
            this.txtbnick.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(359, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvgusuario
            // 
            this.dvgusuario.AllowUserToAddRows = false;
            this.dvgusuario.AllowUserToDeleteRows = false;
            this.dvgusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nick,
            this.email,
            this.registro,
            this.tbpontuacao,
            this.tblogin});
            this.dvgusuario.Location = new System.Drawing.Point(6, 49);
            this.dvgusuario.Name = "dvgusuario";
            this.dvgusuario.ReadOnly = true;
            this.dvgusuario.Size = new System.Drawing.Size(478, 245);
            this.dvgusuario.TabIndex = 0;
            this.dvgusuario.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgusuario_RowHeaderMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idusuario";
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 90;
            // 
            // nick
            // 
            this.nick.DataPropertyName = "nick";
            this.nick.Frozen = true;
            this.nick.HeaderText = "nick";
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            this.nick.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nick.Width = 90;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.Frozen = true;
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.email.Width = 145;
            // 
            // registro
            // 
            this.registro.DataPropertyName = "registro";
            this.registro.Frozen = true;
            this.registro.HeaderText = "registro";
            this.registro.Name = "registro";
            this.registro.ReadOnly = true;
            this.registro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.registro.Width = 145;
            // 
            // tbpontuacao
            // 
            this.tbpontuacao.DataPropertyName = "tbpontuacao";
            this.tbpontuacao.HeaderText = "tbpontuacao";
            this.tbpontuacao.Name = "tbpontuacao";
            this.tbpontuacao.ReadOnly = true;
            this.tbpontuacao.Visible = false;
            // 
            // tblogin
            // 
            this.tblogin.DataPropertyName = "tblogin";
            this.tblogin.HeaderText = "tblogin";
            this.tblogin.Name = "tblogin";
            this.tblogin.ReadOnly = true;
            this.tblogin.Visible = false;
            // 
            // consultarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 335);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.picbarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultarusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta";
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.PictureBox picbarra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnickusuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dvgusuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbnick;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbpontuacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidusuario;
    }
}