namespace HW1
{
    partial class ShowHistogram
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Xsec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Xmin = new System.Windows.Forms.Label();
            this.Ymax = new System.Windows.Forms.Label();
            this.Ysec = new System.Windows.Forms.Label();
            this.Ythird = new System.Windows.Forms.Label();
            this.Yforth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(42, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "100";
            // 
            // Xsec
            // 
            this.Xsec.AutoSize = true;
            this.Xsec.Location = new System.Drawing.Point(184, 218);
            this.Xsec.Name = "Xsec";
            this.Xsec.Size = new System.Drawing.Size(17, 12);
            this.Xsec.TabIndex = 1;
            this.Xsec.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "75";
            // 
            // Xmin
            // 
            this.Xmin.AutoSize = true;
            this.Xmin.Location = new System.Drawing.Point(106, 218);
            this.Xmin.Name = "Xmin";
            this.Xmin.Size = new System.Drawing.Size(17, 12);
            this.Xmin.TabIndex = 1;
            this.Xmin.Text = "25";
            // 
            // Ymax
            // 
            this.Ymax.AutoSize = true;
            this.Ymax.Location = new System.Drawing.Point(5, 11);
            this.Ymax.Name = "Ymax";
            this.Ymax.Size = new System.Drawing.Size(35, 12);
            this.Ymax.TabIndex = 1;
            this.Ymax.Text = "10000";
            // 
            // Ysec
            // 
            this.Ysec.AutoSize = true;
            this.Ysec.Location = new System.Drawing.Point(7, 61);
            this.Ysec.Name = "Ysec";
            this.Ysec.Size = new System.Drawing.Size(29, 12);
            this.Ysec.TabIndex = 1;
            this.Ysec.Text = "7500";
            // 
            // Ythird
            // 
            this.Ythird.AutoSize = true;
            this.Ythird.Location = new System.Drawing.Point(7, 110);
            this.Ythird.Name = "Ythird";
            this.Ythird.Size = new System.Drawing.Size(29, 12);
            this.Ythird.TabIndex = 1;
            this.Ythird.Text = "5000";
            // 
            // Yforth
            // 
            this.Yforth.AutoSize = true;
            this.Yforth.Location = new System.Drawing.Point(7, 160);
            this.Yforth.Name = "Yforth";
            this.Yforth.Size = new System.Drawing.Size(29, 12);
            this.Yforth.TabIndex = 1;
            this.Yforth.Text = "2500";
            // 
            // ShowHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 237);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Xmin);
            this.Controls.Add(this.Xsec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Yforth);
            this.Controls.Add(this.Ythird);
            this.Controls.Add(this.Ysec);
            this.Controls.Add(this.Ymax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShowHistogram";
            this.Text = "ShowHistogram";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Xsec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Xmin;
        private System.Windows.Forms.Label Ymax;
        private System.Windows.Forms.Label Ysec;
        private System.Windows.Forms.Label Ythird;
        private System.Windows.Forms.Label Yforth;
    }
}