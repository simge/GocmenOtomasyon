namespace GocmenOtomasyon
{
    partial class tablolar_ekleme
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
            this.goc_tablo = new System.Windows.Forms.Button();
            this.sehir_bttn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(82, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Göçmen Tablosu ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goc_tablo
            // 
            this.goc_tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goc_tablo.Location = new System.Drawing.Point(376, 55);
            this.goc_tablo.Name = "goc_tablo";
            this.goc_tablo.Size = new System.Drawing.Size(188, 68);
            this.goc_tablo.TabIndex = 1;
            this.goc_tablo.Text = "Göç Tablosu ";
            this.goc_tablo.UseVisualStyleBackColor = true;
            this.goc_tablo.Click += new System.EventHandler(this.button2_Click);
            // 
            // sehir_bttn
            // 
            this.sehir_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sehir_bttn.Location = new System.Drawing.Point(667, 55);
            this.sehir_bttn.Name = "sehir_bttn";
            this.sehir_bttn.Size = new System.Drawing.Size(216, 68);
            this.sehir_bttn.TabIndex = 2;
            this.sehir_bttn.Text = "Göçmenin Kaldığı Şehir";
            this.sehir_bttn.UseVisualStyleBackColor = true;
            this.sehir_bttn.Click += new System.EventHandler(this.sehir_bttn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(988, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Göçmenin Geldiği Ülke";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(82, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "Göçmenin Mesleği";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(773, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(301, 65);
            this.button7.TabIndex = 6;
            this.button7.Text = "Yardım Kuruluşları";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(423, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(249, 65);
            this.button6.TabIndex = 5;
            this.button6.Text = "Bulunduğu Kamp";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tablolar_ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 547);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.sehir_bttn);
            this.Controls.Add(this.goc_tablo);
            this.Controls.Add(this.button1);
            this.Name = "tablolar_ekleme";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button goc_tablo;
        private System.Windows.Forms.Button sehir_bttn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}