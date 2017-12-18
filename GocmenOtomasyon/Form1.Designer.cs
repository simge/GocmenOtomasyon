namespace GocmenOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.baslik = new System.Windows.Forms.TextBox();
            this.ekle_button = new System.Windows.Forms.Button();
            this.ara_button = new System.Windows.Forms.Button();
            this.sil_button = new System.Windows.Forms.Button();
            this.duzenle_button = new System.Windows.Forms.Button();
            this.listele_button = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.SystemColors.WindowText;
            this.baslik.Location = new System.Drawing.Point(329, 2);
            this.baslik.Multiline = true;
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(626, 60);
            this.baslik.TabIndex = 0;
            this.baslik.Text = "GÖÇMEN OTOMASYON";
            this.baslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.baslik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ekle_button
            // 
            this.ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_button.Location = new System.Drawing.Point(133, 333);
            this.ekle_button.Name = "ekle_button";
            this.ekle_button.Size = new System.Drawing.Size(128, 43);
            this.ekle_button.TabIndex = 6;
            this.ekle_button.Text = "Kayıt Ekle";
            this.ekle_button.UseVisualStyleBackColor = true;
            this.ekle_button.Click += new System.EventHandler(this.ekle_button_Click);
            // 
            // ara_button
            // 
            this.ara_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara_button.Location = new System.Drawing.Point(584, 332);
            this.ara_button.Name = "ara_button";
            this.ara_button.Size = new System.Drawing.Size(117, 43);
            this.ara_button.TabIndex = 7;
            this.ara_button.Text = "Kayıt Ara";
            this.ara_button.UseVisualStyleBackColor = true;
            this.ara_button.Click += new System.EventHandler(this.ara_button_Click);
            // 
            // sil_button
            // 
            this.sil_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_button.Location = new System.Drawing.Point(992, 333);
            this.sil_button.Name = "sil_button";
            this.sil_button.Size = new System.Drawing.Size(104, 43);
            this.sil_button.TabIndex = 8;
            this.sil_button.Text = "Kayıt Sil";
            this.sil_button.UseVisualStyleBackColor = true;
            this.sil_button.Click += new System.EventHandler(this.sil_button_Click);
            // 
            // duzenle_button
            // 
            this.duzenle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duzenle_button.Location = new System.Drawing.Point(384, 651);
            this.duzenle_button.Name = "duzenle_button";
            this.duzenle_button.Size = new System.Drawing.Size(125, 60);
            this.duzenle_button.TabIndex = 9;
            this.duzenle_button.Text = "Kayıt Güncelle";
            this.duzenle_button.UseVisualStyleBackColor = true;
            this.duzenle_button.Click += new System.EventHandler(this.duzenle_button_Click);
            // 
            // listele_button
            // 
            this.listele_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listele_button.Location = new System.Drawing.Point(835, 651);
            this.listele_button.Name = "listele_button";
            this.listele_button.Size = new System.Drawing.Size(130, 60);
            this.listele_button.TabIndex = 10;
            this.listele_button.Text = "Kayıt Listele";
            this.listele_button.UseVisualStyleBackColor = true;
            this.listele_button.Click += new System.EventHandler(this.listele_button_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GocmenOtomasyon.Properties.Resources.listeyeni;
            this.pictureBox5.Location = new System.Drawing.Point(786, 394);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(223, 226);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GocmenOtomasyon.Properties.Resources.sil;
            this.pictureBox4.Location = new System.Drawing.Point(912, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 242);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GocmenOtomasyon.Properties.Resources.araaaaaa;
            this.pictureBox3.Location = new System.Drawing.Point(519, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(245, 242);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GocmenOtomasyon.Properties.Resources.ekleeee;
            this.pictureBox1.Location = new System.Drawing.Point(91, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 242);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GocmenOtomasyon.Properties.Resources.ddddddd;
            this.pictureBox2.Location = new System.Drawing.Point(309, 381);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 239);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1369, 723);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.listele_button);
            this.Controls.Add(this.duzenle_button);
            this.Controls.Add(this.sil_button);
            this.Controls.Add(this.ara_button);
            this.Controls.Add(this.ekle_button);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.baslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button ekle_button;
        private System.Windows.Forms.Button ara_button;
        private System.Windows.Forms.Button sil_button;
        private System.Windows.Forms.Button duzenle_button;
        private System.Windows.Forms.Button listele_button;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

