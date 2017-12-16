namespace GocmenOtomasyon
{
    partial class sehir_guncelleme_ekrani
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(456, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Bulunulan Şehir Bilgileri Güncelleme İşlemleri";
            // 
            // yenile_btn
            // 
            this.yenile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile_btn.Location = new System.Drawing.Point(746, 468);
            this.yenile_btn.Name = "yenile_btn";
            this.yenile_btn.Size = new System.Drawing.Size(200, 65);
            this.yenile_btn.TabIndex = 55;
            this.yenile_btn.Text = "Görüntüle";
            this.yenile_btn.UseVisualStyleBackColor = true;
            this.yenile_btn.Click += new System.EventHandler(this.yenile_btn_Click);
            // 
            // guncel_btn
            // 
            this.guncel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncel_btn.Location = new System.Drawing.Point(963, 468);
            this.guncel_btn.Name = "guncel_btn";
            this.guncel_btn.Size = new System.Drawing.Size(230, 65);
            this.guncel_btn.TabIndex = 54;
            this.guncel_btn.Text = "Güncelle";
            this.guncel_btn.UseVisualStyleBackColor = true;
            this.guncel_btn.Click += new System.EventHandler(this.guncel_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1316, 407);
            this.dataGridView1.TabIndex = 53;
            // 
            // sehir_guncelleme_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yenile_btn);
            this.Controls.Add(this.guncel_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sehir_guncelleme_ekrani";
            this.Text = "sehir_guncelleme_ekrani";
            this.Load += new System.EventHandler(this.sehir_guncelleme_ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yenile_btn;
        private System.Windows.Forms.Button guncel_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}