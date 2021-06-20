namespace freidesktop.desafio.form
{
    partial class mouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mouse));
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblaviso1 = new System.Windows.Forms.Label();
            this.lblaviso2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(104, 70);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(230, 184);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.pic.MouseLeave += new System.EventHandler(this.pic_MouseLeave_1);
            // 
            // lblaviso1
            // 
            this.lblaviso1.AutoSize = true;
            this.lblaviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaviso1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblaviso1.Location = new System.Drawing.Point(127, 19);
            this.lblaviso1.Name = "lblaviso1";
            this.lblaviso1.Size = new System.Drawing.Size(194, 33);
            this.lblaviso1.TabIndex = 1;
            this.lblaviso1.Text = "Clique laranja";
            // 
            // lblaviso2
            // 
            this.lblaviso2.AutoSize = true;
            this.lblaviso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaviso2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblaviso2.Location = new System.Drawing.Point(98, 19);
            this.lblaviso2.Name = "lblaviso2";
            this.lblaviso2.Size = new System.Drawing.Size(257, 33);
            this.lblaviso2.TabIndex = 2;
            this.lblaviso2.Text = "Você foi capturado";
            this.lblaviso2.Visible = false;
            // 
            // mouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(430, 326);
            this.Controls.Add(this.lblaviso2);
            this.Controls.Add(this.lblaviso1);
            this.Controls.Add(this.pic);
            this.Name = "mouse";
            this.Text = "mouse";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lblaviso1;
        private System.Windows.Forms.Label lblaviso2;
    }
}