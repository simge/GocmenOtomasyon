namespace GocmenOtomasyon
{
    partial class listeleme_formu
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
            this.gocmen_liste = new System.Windows.Forms.Button();
            this.goc_listeleme = new System.Windows.Forms.Button();
            this.kamp_listeleme = new System.Windows.Forms.Button();
            this.meslek_listeleme = new System.Windows.Forms.Button();
            this.ulke_listeleme = new System.Windows.Forms.Button();
            this.sehir_listeleme = new System.Windows.Forms.Button();
            this.kurulus_listeleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gocmen_liste
            // 
            this.gocmen_liste.Location = new System.Drawing.Point(110, 36);
            this.gocmen_liste.Name = "gocmen_liste";
            this.gocmen_liste.Size = new System.Drawing.Size(206, 80);
            this.gocmen_liste.TabIndex = 0;
            this.gocmen_liste.Text = "Göçmen";
            this.gocmen_liste.UseVisualStyleBackColor = true;
            this.gocmen_liste.Click += new System.EventHandler(this.button1_Click);
            // 
            // goc_listeleme
            // 
            this.goc_listeleme.Location = new System.Drawing.Point(110, 177);
            this.goc_listeleme.Name = "goc_listeleme";
            this.goc_listeleme.Size = new System.Drawing.Size(206, 80);
            this.goc_listeleme.TabIndex = 1;
            this.goc_listeleme.Text = "Göç";
            this.goc_listeleme.UseVisualStyleBackColor = true;
            this.goc_listeleme.Click += new System.EventHandler(this.button2_Click);
            // 
            // kamp_listeleme
            // 
            this.kamp_listeleme.Location = new System.Drawing.Point(549, 338);
            this.kamp_listeleme.Name = "kamp_listeleme";
            this.kamp_listeleme.Size = new System.Drawing.Size(206, 80);
            this.kamp_listeleme.TabIndex = 2;
            this.kamp_listeleme.Text = "Bulunduğu Kamp";
            this.kamp_listeleme.UseVisualStyleBackColor = true;
            this.kamp_listeleme.Click += new System.EventHandler(this.button3_Click);
            // 
            // meslek_listeleme
            // 
            this.meslek_listeleme.Location = new System.Drawing.Point(549, 36);
            this.meslek_listeleme.Name = "meslek_listeleme";
            this.meslek_listeleme.Size = new System.Drawing.Size(206, 80);
            this.meslek_listeleme.TabIndex = 3;
            this.meslek_listeleme.Text = "Meslek ";
            this.meslek_listeleme.UseVisualStyleBackColor = true;
            this.meslek_listeleme.Click += new System.EventHandler(this.button4_Click);
            // 
            // ulke_listeleme
            // 
            this.ulke_listeleme.Location = new System.Drawing.Point(549, 177);
            this.ulke_listeleme.Name = "ulke_listeleme";
            this.ulke_listeleme.Size = new System.Drawing.Size(206, 80);
            this.ulke_listeleme.TabIndex = 4;
            this.ulke_listeleme.Text = "Geldiği Ülke";
            this.ulke_listeleme.UseVisualStyleBackColor = true;
            this.ulke_listeleme.Click += new System.EventHandler(this.button5_Click);
            // 
            // sehir_listeleme
            // 
            this.sehir_listeleme.Location = new System.Drawing.Point(960, 36);
            this.sehir_listeleme.Name = "sehir_listeleme";
            this.sehir_listeleme.Size = new System.Drawing.Size(206, 80);
            this.sehir_listeleme.TabIndex = 5;
            this.sehir_listeleme.Text = "Bulunduğu Şehir";
            this.sehir_listeleme.UseVisualStyleBackColor = true;
            this.sehir_listeleme.Click += new System.EventHandler(this.button6_Click);
            // 
            // kurulus_listeleme
            // 
            this.kurulus_listeleme.Location = new System.Drawing.Point(969, 177);
            this.kurulus_listeleme.Name = "kurulus_listeleme";
            this.kurulus_listeleme.Size = new System.Drawing.Size(206, 80);
            this.kurulus_listeleme.TabIndex = 6;
            this.kurulus_listeleme.Text = "Yardım Kuruluşu";
            this.kurulus_listeleme.UseVisualStyleBackColor = true;
            this.kurulus_listeleme.Click += new System.EventHandler(this.button7_Click);
            // 
            // listeleme_formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 529);
            this.Controls.Add(this.kurulus_listeleme);
            this.Controls.Add(this.sehir_listeleme);
            this.Controls.Add(this.ulke_listeleme);
            this.Controls.Add(this.meslek_listeleme);
            this.Controls.Add(this.kamp_listeleme);
            this.Controls.Add(this.goc_listeleme);
            this.Controls.Add(this.gocmen_liste);
            this.Name = "listeleme_formu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gocmen_liste;
        private System.Windows.Forms.Button goc_listeleme;
        private System.Windows.Forms.Button kamp_listeleme;
        private System.Windows.Forms.Button meslek_listeleme;
        private System.Windows.Forms.Button ulke_listeleme;
        private System.Windows.Forms.Button sehir_listeleme;
        private System.Windows.Forms.Button kurulus_listeleme;
    }
}