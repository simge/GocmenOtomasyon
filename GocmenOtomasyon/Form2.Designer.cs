namespace GocmenOtomasyon
{
    partial class Form2
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
            this.guncelle = new System.Windows.Forms.Button();
            this.egitim_duzeyi = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.TextBox();
            this.yas = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(180, 365);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(87, 23);
            this.guncelle.TabIndex = 38;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // egitim_duzeyi
            // 
            this.egitim_duzeyi.Location = new System.Drawing.Point(180, 293);
            this.egitim_duzeyi.Name = "egitim_duzeyi";
            this.egitim_duzeyi.Size = new System.Drawing.Size(100, 22);
            this.egitim_duzeyi.TabIndex = 35;
            // 
            // cinsiyet
            // 
            this.cinsiyet.Location = new System.Drawing.Point(180, 252);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(100, 22);
            this.cinsiyet.TabIndex = 34;
            // 
            // yas
            // 
            this.yas.Location = new System.Drawing.Point(180, 204);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(100, 22);
            this.yas.TabIndex = 33;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(180, 157);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(100, 22);
            this.soyad.TabIndex = 32;
            this.soyad.TextChanged += new System.EventHandler(this.soyad_TextChanged_1);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(180, 109);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(100, 22);
            this.ad.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "eğitim düzeyi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "cinsiyet ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "soyad";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(121, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 30);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Göçmen Güncelleme İşlemleri";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(180, 81);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "ad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "yas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.egitim_duzeyi);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.TextBox egitim_duzeyi;
        private System.Windows.Forms.TextBox cinsiyet;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}