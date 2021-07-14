namespace freitrabalho.telas.menu
{
    partial class menuplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuplayer));
            this.lblnick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.picbarra = new System.Windows.Forms.PictureBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblpts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picask = new System.Windows.Forms.PictureBox();
            this.pictop = new System.Windows.Forms.PictureBox();
            this.picmap = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnick
            // 
            this.lblnick.AutoSize = true;
            this.lblnick.BackColor = System.Drawing.Color.Teal;
            this.lblnick.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnick.ForeColor = System.Drawing.Color.White;
            this.lblnick.Location = new System.Drawing.Point(179, 2);
            this.lblnick.Name = "lblnick";
            this.lblnick.Size = new System.Drawing.Size(45, 19);
            this.lblnick.TabIndex = 30;
            this.lblnick.Text = "nick";
            this.lblnick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblnick_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Seja bem vindo(a)";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.Teal;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(428, -2);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(39, 31);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 29;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            this.picclose.MouseEnter += new System.EventHandler(this.picclose_MouseEnter);
            this.picclose.MouseLeave += new System.EventHandler(this.picclose_MouseLeave);
            // 
            // picbarra
            // 
            this.picbarra.BackColor = System.Drawing.Color.Teal;
            this.picbarra.Location = new System.Drawing.Point(-1, -2);
            this.picbarra.Name = "picbarra";
            this.picbarra.Size = new System.Drawing.Size(471, 31);
            this.picbarra.TabIndex = 28;
            this.picbarra.TabStop = false;
            this.picbarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbarra_MouseMove);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Teal;
            this.lbltime.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(344, 2);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(57, 19);
            this.lbltime.TabIndex = 31;
            this.lbltime.Text = "Hora:";
            this.lbltime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbltime_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblpts
            // 
            this.lblpts.AutoSize = true;
            this.lblpts.BackColor = System.Drawing.Color.Teal;
            this.lblpts.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpts.ForeColor = System.Drawing.Color.White;
            this.lblpts.Location = new System.Drawing.Point(261, 2);
            this.lblpts.Name = "lblpts";
            this.lblpts.Size = new System.Drawing.Size(19, 19);
            this.lblpts.TabIndex = 32;
            this.lblpts.Text = "0";
            this.lblpts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblpts_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "pts";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // picask
            // 
            this.picask.BackColor = System.Drawing.Color.Teal;
            this.picask.Image = ((System.Drawing.Image)(resources.GetObject("picask.Image")));
            this.picask.Location = new System.Drawing.Point(13, 124);
            this.picask.Name = "picask";
            this.picask.Size = new System.Drawing.Size(48, 38);
            this.picask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picask.TabIndex = 42;
            this.picask.TabStop = false;
            this.picask.Click += new System.EventHandler(this.picask_Click);
            this.picask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picask_MouseMove);
            // 
            // pictop
            // 
            this.pictop.BackColor = System.Drawing.Color.Teal;
            this.pictop.Image = ((System.Drawing.Image)(resources.GetObject("pictop.Image")));
            this.pictop.Location = new System.Drawing.Point(12, 80);
            this.pictop.Name = "pictop";
            this.pictop.Size = new System.Drawing.Size(48, 38);
            this.pictop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictop.TabIndex = 41;
            this.pictop.TabStop = false;
            this.pictop.Click += new System.EventHandler(this.pictop_Click);
            this.pictop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictop_MouseMove);
            // 
            // picmap
            // 
            this.picmap.BackColor = System.Drawing.Color.Teal;
            this.picmap.Image = ((System.Drawing.Image)(resources.GetObject("picmap.Image")));
            this.picmap.Location = new System.Drawing.Point(13, 36);
            this.picmap.Name = "picmap";
            this.picmap.Size = new System.Drawing.Size(48, 38);
            this.picmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmap.TabIndex = 39;
            this.picmap.TabStop = false;
            this.picmap.Click += new System.EventHandler(this.picmap_Click);
            this.picmap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picmap_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 267);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(467, 276);
            this.Controls.Add(this.picask);
            this.Controls.Add(this.pictop);
            this.Controls.Add(this.picmap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpts);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblnick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.picbarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuplayer_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.PictureBox picbarra;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblpts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picask;
        private System.Windows.Forms.PictureBox pictop;
        private System.Windows.Forms.PictureBox picmap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}