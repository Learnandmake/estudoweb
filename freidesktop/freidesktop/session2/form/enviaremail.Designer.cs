namespace freidesktop.session2.form
{
    partial class enviaremail
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.txtassunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmensagem = new System.Windows.Forms.TextBox();
            this.mensagem = new System.Windows.Forms.Label();
            this.lblok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para:";
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(3, 31);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(213, 20);
            this.txtpara.TabIndex = 2;
            // 
            // txtassunto
            // 
            this.txtassunto.Location = new System.Drawing.Point(3, 84);
            this.txtassunto.Name = "txtassunto";
            this.txtassunto.Size = new System.Drawing.Size(213, 20);
            this.txtassunto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assunto:";
            // 
            // txtmensagem
            // 
            this.txtmensagem.Location = new System.Drawing.Point(3, 132);
            this.txtmensagem.Multiline = true;
            this.txtmensagem.Name = "txtmensagem";
            this.txtmensagem.Size = new System.Drawing.Size(213, 89);
            this.txtmensagem.TabIndex = 6;
            // 
            // mensagem
            // 
            this.mensagem.AutoSize = true;
            this.mensagem.Location = new System.Drawing.Point(0, 116);
            this.mensagem.Name = "mensagem";
            this.mensagem.Size = new System.Drawing.Size(62, 13);
            this.mensagem.TabIndex = 5;
            this.mensagem.Text = "Mensagem:";
            // 
            // lblok
            // 
            this.lblok.AutoSize = true;
            this.lblok.Location = new System.Drawing.Point(12, 234);
            this.lblok.Name = "lblok";
            this.lblok.Size = new System.Drawing.Size(35, 13);
            this.lblok.TabIndex = 7;
            this.lblok.Text = "label4";
            this.lblok.Visible = false;
            // 
            // enviaremail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 302);
            this.Controls.Add(this.lblok);
            this.Controls.Add(this.txtmensagem);
            this.Controls.Add(this.mensagem);
            this.Controls.Add(this.txtassunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "enviaremail";
            this.Text = "enviaremail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.TextBox txtassunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmensagem;
        private System.Windows.Forms.Label mensagem;
        private System.Windows.Forms.Label lblok;
    }
}