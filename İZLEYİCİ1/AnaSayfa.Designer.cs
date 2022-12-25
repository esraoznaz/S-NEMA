namespace İZLEYİCİ1
{
    partial class AnaSayfa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_yonetici = new System.Windows.Forms.Button();
            this.button_izleyici = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_izleyici);
            this.groupBox1.Controls.Add(this.button_yonetici);
            this.groupBox1.Location = new System.Drawing.Point(161, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OTURUM";
            // 
            // button_yonetici
            // 
            this.button_yonetici.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yonetici.Location = new System.Drawing.Point(112, 93);
            this.button_yonetici.Name = "button_yonetici";
            this.button_yonetici.Size = new System.Drawing.Size(234, 53);
            this.button_yonetici.TabIndex = 0;
            this.button_yonetici.Text = "YÖNETİCİ GİRİŞİ";
            this.button_yonetici.UseVisualStyleBackColor = true;
            this.button_yonetici.Click += new System.EventHandler(this.button_yonetici_Click);
            // 
            // button_izleyici
            // 
            this.button_izleyici.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_izleyici.Location = new System.Drawing.Point(112, 185);
            this.button_izleyici.Name = "button_izleyici";
            this.button_izleyici.Size = new System.Drawing.Size(234, 53);
            this.button_izleyici.TabIndex = 1;
            this.button_izleyici.Text = "İZLEYİCİ GİRİŞİ";
            this.button_izleyici.UseVisualStyleBackColor = true;
            this.button_izleyici.Click += new System.EventHandler(this.button_izleyici_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_izleyici;
        private System.Windows.Forms.Button button_yonetici;
    }
}