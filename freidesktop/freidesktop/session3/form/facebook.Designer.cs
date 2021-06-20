namespace freidesktop.session3.form
{
    partial class facebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facebook));
            this.label1 = new System.Windows.Forms.Label();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.dtpnasc = new System.Windows.Forms.DateTimePicker();
            this.picfb = new System.Windows.Forms.PictureBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboidioma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbamigo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbtrabalho = new System.Windows.Forms.CheckBox();
            this.cboutro = new System.Windows.Forms.CheckBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtcsenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btncadastro = new System.Windows.Forms.Button();
            this.picfbesp = new System.Windows.Forms.PictureBox();
            this.picfbbr = new System.Windows.Forms.PictureBox();
            this.picfbeua = new System.Windows.Forms.PictureBox();
            this.lblaviso = new System.Windows.Forms.Label();
            this.lblfsenha = new System.Windows.Forms.Label();
            this.txtoutro = new System.Windows.Forms.TextBox();
            this.lblrua = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picfb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbesp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbeua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(175, 149);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(34, 17);
            this.rbm.TabIndex = 2;
            this.rbm.TabStop = true;
            this.rbm.Text = "M";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idioma:";
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(215, 149);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(31, 17);
            this.rbf.TabIndex = 4;
            this.rbf.TabStop = true;
            this.rbf.Text = "F";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // dtpnasc
            // 
            this.dtpnasc.Location = new System.Drawing.Point(45, 145);
            this.dtpnasc.Name = "dtpnasc";
            this.dtpnasc.Size = new System.Drawing.Size(123, 20);
            this.dtpnasc.TabIndex = 5;
            this.dtpnasc.ValueChanged += new System.EventHandler(this.dtpnasc_ValueChanged);
            // 
            // picfb
            // 
            this.picfb.Image = ((System.Drawing.Image)(resources.GetObject("picfb.Image")));
            this.picfb.Location = new System.Drawing.Point(96, 5);
            this.picfb.Name = "picfb";
            this.picfb.Size = new System.Drawing.Size(93, 61);
            this.picfb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfb.TabIndex = 6;
            this.picfb.TabStop = false;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(45, 72);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(201, 20);
            this.txtnome.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(45, 96);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(201, 20);
            this.txtemail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail:";
            // 
            // cboidioma
            // 
            this.cboidioma.FormattingEnabled = true;
            this.cboidioma.Items.AddRange(new object[] {
            "Brasil",
            "Espanha",
            "Estados Unidos"});
            this.cboidioma.Location = new System.Drawing.Point(45, 119);
            this.cboidioma.Name = "cboidioma";
            this.cboidioma.Size = new System.Drawing.Size(201, 21);
            this.cboidioma.TabIndex = 10;
            this.cboidioma.Text = "Selecione:";
            this.cboidioma.TextChanged += new System.EventHandler(this.cboidioma_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nasc:";
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(45, 168);
            this.mskcep.Mask = "00000-000";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(57, 20);
            this.mskcep.TabIndex = 12;
            this.mskcep.TextChanged += new System.EventHandler(this.mskcep_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cep:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(42, 230);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(39, 13);
            this.lblestado.TabIndex = 14;
            this.lblestado.Text = "estado";
            this.lblestado.Visible = false;
            // 
            // cbamigo
            // 
            this.cbamigo.AutoSize = true;
            this.cbamigo.Location = new System.Drawing.Point(14, 276);
            this.cbamigo.Name = "cbamigo";
            this.cbamigo.Size = new System.Drawing.Size(63, 17);
            this.cbamigo.TabIndex = 15;
            this.cbamigo.Text = "Amigos ";
            this.cbamigo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Interesse:";
            // 
            // cbtrabalho
            // 
            this.cbtrabalho.AutoSize = true;
            this.cbtrabalho.Location = new System.Drawing.Point(100, 276);
            this.cbtrabalho.Name = "cbtrabalho";
            this.cbtrabalho.Size = new System.Drawing.Size(68, 17);
            this.cbtrabalho.TabIndex = 17;
            this.cbtrabalho.Text = "Trabalho";
            this.cbtrabalho.UseVisualStyleBackColor = true;
            // 
            // cboutro
            // 
            this.cboutro.AutoSize = true;
            this.cboutro.Location = new System.Drawing.Point(14, 299);
            this.cboutro.Name = "cboutro";
            this.cboutro.Size = new System.Drawing.Size(57, 17);
            this.cboutro.TabIndex = 18;
            this.cboutro.Text = "Outros";
            this.cboutro.UseVisualStyleBackColor = true;
            this.cboutro.CheckedChanged += new System.EventHandler(this.cboutro_CheckedChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(60, 335);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(86, 20);
            this.txtsenha.TabIndex = 19;
            // 
            // txtcsenha
            // 
            this.txtcsenha.Location = new System.Drawing.Point(60, 361);
            this.txtcsenha.Name = "txtcsenha";
            this.txtcsenha.Size = new System.Drawing.Size(86, 20);
            this.txtcsenha.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Senha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Confirmar:";
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(96, 400);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(113, 53);
            this.btncadastro.TabIndex = 23;
            this.btncadastro.Text = "Sing up";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // picfbesp
            // 
            this.picfbesp.Image = ((System.Drawing.Image)(resources.GetObject("picfbesp.Image")));
            this.picfbesp.Location = new System.Drawing.Point(96, 5);
            this.picfbesp.Name = "picfbesp";
            this.picfbesp.Size = new System.Drawing.Size(93, 61);
            this.picfbesp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfbesp.TabIndex = 24;
            this.picfbesp.TabStop = false;
            this.picfbesp.Visible = false;
            // 
            // picfbbr
            // 
            this.picfbbr.Image = ((System.Drawing.Image)(resources.GetObject("picfbbr.Image")));
            this.picfbbr.Location = new System.Drawing.Point(96, 5);
            this.picfbbr.Name = "picfbbr";
            this.picfbbr.Size = new System.Drawing.Size(93, 61);
            this.picfbbr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfbbr.TabIndex = 26;
            this.picfbbr.TabStop = false;
            this.picfbbr.Visible = false;
            // 
            // picfbeua
            // 
            this.picfbeua.Image = ((System.Drawing.Image)(resources.GetObject("picfbeua.Image")));
            this.picfbeua.Location = new System.Drawing.Point(96, 5);
            this.picfbeua.Name = "picfbeua";
            this.picfbeua.Size = new System.Drawing.Size(93, 61);
            this.picfbeua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfbeua.TabIndex = 27;
            this.picfbeua.TabStop = false;
            this.picfbeua.Visible = false;
            // 
            // lblaviso
            // 
            this.lblaviso.AutoSize = true;
            this.lblaviso.Location = new System.Drawing.Point(57, 384);
            this.lblaviso.Name = "lblaviso";
            this.lblaviso.Size = new System.Drawing.Size(159, 13);
            this.lblaviso.TabIndex = 28;
            this.lblaviso.Text = "Cadastro efetuado com sucesso";
            this.lblaviso.Visible = false;
            // 
            // lblfsenha
            // 
            this.lblfsenha.AutoSize = true;
            this.lblfsenha.Location = new System.Drawing.Point(152, 338);
            this.lblfsenha.Name = "lblfsenha";
            this.lblfsenha.Size = new System.Drawing.Size(31, 13);
            this.lblfsenha.TabIndex = 29;
            this.lblfsenha.Text = "fraco";
            this.lblfsenha.Visible = false;
            // 
            // txtoutro
            // 
            this.txtoutro.Location = new System.Drawing.Point(77, 296);
            this.txtoutro.Name = "txtoutro";
            this.txtoutro.Size = new System.Drawing.Size(86, 20);
            this.txtoutro.TabIndex = 30;
            this.txtoutro.Visible = false;
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Location = new System.Drawing.Point(42, 191);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(27, 13);
            this.lblrua.TabIndex = 31;
            this.lblrua.Text = "Rua";
            this.lblrua.Visible = false;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(42, 204);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(33, 13);
            this.lblbairro.TabIndex = 32;
            this.lblbairro.Text = "bairro";
            this.lblbairro.Visible = false;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(42, 217);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(40, 13);
            this.lblcidade.TabIndex = 33;
            this.lblcidade.Text = "Cidade";
            this.lblcidade.Visible = false;
            // 
            // facebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 460);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblrua);
            this.Controls.Add(this.txtoutro);
            this.Controls.Add(this.lblfsenha);
            this.Controls.Add(this.lblaviso);
            this.Controls.Add(this.picfbeua);
            this.Controls.Add(this.picfbbr);
            this.Controls.Add(this.picfbesp);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcsenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.cboutro);
            this.Controls.Add(this.cbtrabalho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbamigo);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskcep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboidioma);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.picfb);
            this.Controls.Add(this.dtpnasc);
            this.Controls.Add(this.rbf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbm);
            this.Controls.Add(this.label1);
            this.Name = "facebook";
            this.Text = "facebook";
            ((System.ComponentModel.ISupportInitialize)(this.picfb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbesp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfbeua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.DateTimePicker dtpnasc;
        private System.Windows.Forms.PictureBox picfb;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboidioma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.CheckBox cbamigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbtrabalho;
        private System.Windows.Forms.CheckBox cboutro;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtcsenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.PictureBox picfbesp;
        private System.Windows.Forms.PictureBox picfbbr;
        private System.Windows.Forms.PictureBox picfbeua;
        private System.Windows.Forms.Label lblaviso;
        private System.Windows.Forms.Label lblfsenha;
        private System.Windows.Forms.TextBox txtoutro;
        private System.Windows.Forms.Label lblrua;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblcidade;
    }
}