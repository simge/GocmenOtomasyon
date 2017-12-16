namespace GocmenOtomasyon
{
    partial class guncelleme_form_ekranı
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
            this.kurulus_listeleme = new System.Windows.Forms.Button();
            this.sehir_listeleme = new System.Windows.Forms.Button();
            this.ulke_listeleme = new System.Windows.Forms.Button();
            this.meslek_listeleme = new System.Windows.Forms.Button();
            this.kamp_listeleme = new System.Windows.Forms.Button();
            this.goc_listeleme = new System.Windows.Forms.Button();
            this.gocmen_liste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kurulus_listeleme
            // 
            this.kurulus_listeleme.Location = new System.Drawing.Point(996, 213);
            this.kurulus_listeleme.Name = "kurulus_listeleme";
            this.kurulus_listeleme.Size = new System.Drawing.Size(206, 80);
            this.kurulus_listeleme.TabIndex = 13;
            this.kurulus_listeleme.Text = "Yardım Kuruluşu";
            this.kurulus_listeleme.UseVisualStyleBackColor = true;
            this.kurulus_listeleme.Click += new System.EventHandler(this.kurulus_listeleme_Click);
            // 
            // sehir_listeleme
            // 
            this.sehir_listeleme.Location = new System.Drawing.Point(987, 72);
            this.sehir_listeleme.Name = "sehir_listeleme";
            this.sehir_listeleme.Size = new System.Drawing.Size(206, 80);
            this.sehir_listeleme.TabIndex = 12;
            this.sehir_listeleme.Text = "Bulunduğu Şehir";
            this.sehir_listeleme.UseVisualStyleBackColor = true;
            this.sehir_listeleme.Click += new System.EventHandler(this.sehir_listeleme_Click);
            // 
            // ulke_listeleme
            // 
            this.ulke_listeleme.Location = new System.Drawing.Point(576, 213);
            this.ulke_listeleme.Name = "ulke_listeleme";
            this.ulke_listeleme.Size = new System.Drawing.Size(206, 80);
            this.ulke_listeleme.TabIndex = 11;
            this.ulke_listeleme.Text = "Geldiği Ülke";
            this.ulke_listeleme.UseVisualStyleBackColor = true;
            this.ulke_listeleme.Click += new System.EventHandler(this.ulke_listeleme_Click);
            // 
            // meslek_listeleme
            // 
            this.meslek_listeleme.Location = new System.Drawing.Point(576, 72);
            this.meslek_listeleme.Name = "meslek_listeleme";
            this.meslek_listeleme.Size = new System.Drawing.Size(206, 80);
            this.meslek_listeleme.TabIndex = 10;
            this.meslek_listeleme.Text = "Meslek ";
            this.meslek_listeleme.UseVisualStyleBackColor = true;
            this.meslek_listeleme.Click += new System.EventHandler(this.meslek_listeleme_Click);
            // 
            // kamp_listeleme
            // 
            this.kamp_listeleme.Location = new System.Drawing.Point(576, 374);
            this.kamp_listeleme.Name = "kamp_listeleme";
            this.kamp_listeleme.Size = new System.Drawing.Size(206, 80);
            this.kamp_listeleme.TabIndex = 9;
            this.kamp_listeleme.Text = "Bulunduğu Kamp";
            this.kamp_listeleme.UseVisualStyleBackColor = true;
            this.kamp_listeleme.Click += new System.EventHandler(this.kamp_listeleme_Click);
            // 
            // goc_listeleme
            // 
            this.goc_listeleme.Location = new System.Drawing.Point(137, 213);
            this.goc_listeleme.Name = "goc_listeleme";
            this.goc_listeleme.Size = new System.Drawing.Size(206, 80);
            this.goc_listeleme.TabIndex = 8;
            this.goc_listeleme.Text = "Göç";
            this.goc_listeleme.UseVisualStyleBackColor = true;
            this.goc_listeleme.Click += new System.EventHandler(this.goc_listeleme_Click);
            // 
            // gocmen_liste
            // 
            this.gocmen_liste.Location = new System.Drawing.Point(137, 72);
            this.gocmen_liste.Name = "gocmen_liste";
            this.gocmen_liste.Size = new System.Drawing.Size(206, 80);
            this.gocmen_liste.TabIndex = 7;
            this.gocmen_liste.Text = "Göçmen";
            this.gocmen_liste.UseVisualStyleBackColor = true;
            this.gocmen_liste.Click += new System.EventHandler(this.gocmen_liste_Click);
            // 
            // guncelleme_form_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 526);
            this.Controls.Add(this.kurulus_listeleme);
            this.Controls.Add(this.sehir_listeleme);
            this.Controls.Add(this.ulke_listeleme);
            this.Controls.Add(this.meslek_listeleme);
            this.Controls.Add(this.kamp_listeleme);
            this.Controls.Add(this.goc_listeleme);
            this.Controls.Add(this.gocmen_liste);
            this.Name = "guncelleme_form_ekranı";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kurulus_listeleme;
        private System.Windows.Forms.Button sehir_listeleme;
        private System.Windows.Forms.Button ulke_listeleme;
        private System.Windows.Forms.Button meslek_listeleme;
        private System.Windows.Forms.Button kamp_listeleme;
        private System.Windows.Forms.Button goc_listeleme;
        private System.Windows.Forms.Button gocmen_liste;
    }
}