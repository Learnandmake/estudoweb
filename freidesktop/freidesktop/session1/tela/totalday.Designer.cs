namespace freidesktop.session1.tela
{
    partial class totalday
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
            this.dtnasci = new System.Windows.Forms.DateTimePicker();
            this.lblt1 = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.lblt2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "digite sua data de nascimento:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtnasci
            // 
            this.dtnasci.Location = new System.Drawing.Point(15, 25);
            this.dtnasci.Name = "dtnasci";
            this.dtnasci.Size = new System.Drawing.Size(148, 20);
            this.dtnasci.TabIndex = 2;
            // 
            // lblt1
            // 
            this.lblt1.AutoSize = true;
            this.lblt1.Location = new System.Drawing.Point(22, 53);
            this.lblt1.Name = "lblt1";
            this.lblt1.Size = new System.Drawing.Size(63, 13);
            this.lblt1.TabIndex = 3;
            this.lblt1.Text = "você viveu ";
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(91, 53);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(13, 13);
            this.lbldia.TabIndex = 4;
            this.lbldia.Text = "a";
            this.lbldia.Visible = false;
            // 
            // lblt2
            // 
            this.lblt2.AutoSize = true;
            this.lblt2.Location = new System.Drawing.Point(124, 53);
            this.lblt2.Name = "lblt2";
            this.lblt2.Size = new System.Drawing.Size(26, 13);
            this.lblt2.TabIndex = 5;
            this.lblt2.Text = "dias";
            this.lblt2.Visible = false;
            // 
            // totalday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 119);
            this.Controls.Add(this.lblt2);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.lblt1);
            this.Controls.Add(this.dtnasci);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "totalday";
            this.Text = "totalday";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtnasci;
        private System.Windows.Forms.Label lblt1;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lblt2;
    }
}