namespace freitrabalho2._0.telas.menu
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
            this.lbltime = new System.Windows.Forms.Label();
            this.lblnick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.picbarra = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picask = new System.Windows.Forms.PictureBox();
            this.pictop = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpts = new System.Windows.Forms.Label();
            this.picmap = new System.Windows.Forms.PictureBox();
            this.picloginout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picloginout)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Teal;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(515, 5);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(60, 25);
            this.lbltime.TabIndex = 47;
            this.lbltime.Text = "Hora:";
            // 
            // lblnick
            // 
            this.lblnick.AutoSize = true;
            this.lblnick.BackColor = System.Drawing.Color.Teal;
            this.lblnick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnick.ForeColor = System.Drawing.Color.White;
            this.lblnick.Location = new System.Drawing.Point(267, 5);
            this.lblnick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnick.Name = "lblnick";
            this.lblnick.Size = new System.Drawing.Size(47, 25);
            this.lblnick.TabIndex = 46;
            this.lblnick.Text = "nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Seja bem vindo(a)";
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.Teal;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(641, -1);
            this.picclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(58, 48);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 45;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            this.picclose.MouseEnter += new System.EventHandler(this.picclose_MouseEnter);
            this.picclose.MouseLeave += new System.EventHandler(this.picclose_MouseLeave);
            // 
            // picbarra
            // 
            this.picbarra.BackColor = System.Drawing.Color.Teal;
            this.picbarra.Location = new System.Drawing.Point(-3, -1);
            this.picbarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbarra.Name = "picbarra";
            this.picbarra.Size = new System.Drawing.Size(706, 48);
            this.picbarra.TabIndex = 44;
            this.picbarra.TabStop = false;
            this.picbarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbarra_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picask
            // 
            this.picask.BackColor = System.Drawing.Color.Teal;
            this.picask.Image = ((System.Drawing.Image)(resources.GetObject("picask.Image")));
            this.picask.Location = new System.Drawing.Point(15, 125);
            this.picask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picask.Name = "picask";
            this.picask.Size = new System.Drawing.Size(72, 58);
            this.picask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picask.TabIndex = 53;
            this.picask.TabStop = false;
            this.picask.Click += new System.EventHandler(this.picask_Click);
            // 
            // pictop
            // 
            this.pictop.BackColor = System.Drawing.Color.Teal;
            this.pictop.Image = ((System.Drawing.Image)(resources.GetObject("pictop.Image")));
            this.pictop.Location = new System.Drawing.Point(13, 57);
            this.pictop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictop.Name = "pictop";
            this.pictop.Size = new System.Drawing.Size(72, 58);
            this.pictop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictop.TabIndex = 52;
            this.pictop.TabStop = false;
            this.pictop.Click += new System.EventHandler(this.pictop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 411);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "pts";
            // 
            // lblpts
            // 
            this.lblpts.AutoSize = true;
            this.lblpts.BackColor = System.Drawing.Color.Teal;
            this.lblpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpts.ForeColor = System.Drawing.Color.White;
            this.lblpts.Location = new System.Drawing.Point(391, 5);
            this.lblpts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpts.Name = "lblpts";
            this.lblpts.Size = new System.Drawing.Size(23, 25);
            this.lblpts.TabIndex = 48;
            this.lblpts.Text = "0";
            // 
            // picmap
            // 
            this.picmap.BackColor = System.Drawing.Color.Teal;
            this.picmap.Image = ((System.Drawing.Image)(resources.GetObject("picmap.Image")));
            this.picmap.Location = new System.Drawing.Point(15, 205);
            this.picmap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picmap.Name = "picmap";
            this.picmap.Size = new System.Drawing.Size(72, 58);
            this.picmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmap.TabIndex = 54;
            this.picmap.TabStop = false;
            this.picmap.Click += new System.EventHandler(this.picmap_Click);
            // 
            // picloginout
            // 
            this.picloginout.BackColor = System.Drawing.Color.Teal;
            this.picloginout.Image = ((System.Drawing.Image)(resources.GetObject("picloginout.Image")));
            this.picloginout.Location = new System.Drawing.Point(24, 391);
            this.picloginout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picloginout.Name = "picloginout";
            this.picloginout.Size = new System.Drawing.Size(55, 41);
            this.picloginout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picloginout.TabIndex = 58;
            this.picloginout.TabStop = false;
            this.picloginout.Click += new System.EventHandler(this.picloginout_Click);
            // 
            // menuplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(699, 446);
            this.Controls.Add(this.picloginout);
            this.Controls.Add(this.picmap);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblnick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.picbarra);
            this.Controls.Add(this.picask);
            this.Controls.Add(this.pictop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuplayer";
            this.Text = "menuplayer";
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picloginout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblnick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.PictureBox picbarra;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picask;
        private System.Windows.Forms.PictureBox pictop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpts;
        private System.Windows.Forms.PictureBox picmap;
        private System.Windows.Forms.PictureBox picloginout;
    }
}