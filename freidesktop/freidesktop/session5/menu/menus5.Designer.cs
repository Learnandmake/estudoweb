namespace freidesktop.session5.menu
{
    partial class menus5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menus5));
            this.picclose = new System.Windows.Forms.PictureBox();
            this.picfechar = new System.Windows.Forms.PictureBox();
            this.picarea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picarea)).BeginInit();
            this.SuspendLayout();
            // 
            // picclose
            // 
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(0, 0);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(92, 67);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 0;
            this.picclose.TabStop = false;
           
            // 
            // picfechar
            // 
            this.picfechar.Image = ((System.Drawing.Image)(resources.GetObject("picfechar.Image")));
            this.picfechar.Location = new System.Drawing.Point(201, 0);
            this.picfechar.Name = "picfechar";
            this.picfechar.Size = new System.Drawing.Size(92, 67);
            this.picfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfechar.TabIndex = 1;
            this.picfechar.TabStop = false;
         
            // 
            // picarea
            // 
            this.picarea.Image = ((System.Drawing.Image)(resources.GetObject("picarea.Image")));
            this.picarea.Location = new System.Drawing.Point(98, 0);
            this.picarea.Name = "picarea";
            this.picarea.Size = new System.Drawing.Size(92, 67);
            this.picarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picarea.TabIndex = 2;
            this.picarea.TabStop = false;
          
            // 
            // menus5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 69);
            this.Controls.Add(this.picarea);
            this.Controls.Add(this.picfechar);
            this.Controls.Add(this.picclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menus5";
            this.Text = "menus5";
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picarea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.PictureBox picfechar;
        private System.Windows.Forms.PictureBox picarea;
    }
}