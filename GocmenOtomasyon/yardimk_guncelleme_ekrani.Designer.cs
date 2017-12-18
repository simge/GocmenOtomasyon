namespace GocmenOtomasyon
{
    partial class yardimk_guncelleme_ekrani
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
            this.label2 = new System.Windows.Forms.Label();
            this.yenile_btn = new System.Windows.Forms.Button();
            this.guncel_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(460, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Yardım Kuruluş Bilgileri Güncelleme İşlemleri";
            // 
            // yenile_btn
            // 
            this.yenile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile_btn.Location = new System.Drawing.Point(750, 482);
            this.yenile_btn.Name = "yenile_btn";
            this.yenile_btn.Size = new System.Drawing.Size(200, 65);
            this.yenile_btn.TabIndex = 59;
            this.yenile_btn.Text = "Görüntüle";
            this.yenile_btn.UseVisualStyleBackColor = true;
            this.yenile_btn.Click += new System.EventHandler(this.yenile_btn_Click);
            // 
            // guncel_btn
            // 
            this.guncel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncel_btn.Location = new System.Drawing.Point(967, 482);
            this.guncel_btn.Name = "guncel_btn";
            this.guncel_btn.Size = new System.Drawing.Size(230, 65);
            this.guncel_btn.TabIndex = 58;
            this.guncel_btn.Text = "Güncelle";
            this.guncel_btn.UseVisualStyleBackColor = true;
            this.guncel_btn.Click += new System.EventHandler(this.guncel_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1316, 407);
            this.dataGridView1.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yardimk_guncelleme_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1344, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yenile_btn);
            this.Controls.Add(this.guncel_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "yardimk_guncelleme_ekrani";
            this.Text = "yardimk_guncelleme_ekrani";
            this.Load += new System.EventHandler(this.yardimk_guncelleme_ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yenile_btn;
        private System.Windows.Forms.Button guncel_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}