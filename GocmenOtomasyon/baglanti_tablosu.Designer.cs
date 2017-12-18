namespace GocmenOtomasyon
{
    partial class baglanti_tablosu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kamp_id = new System.Windows.Forms.ComboBox();
            this.yk_id = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.gorn_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "kamp_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "yk_id(yardım kuruluş id)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(484, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlgili Yardım Kuruluş Bağlantı ";
            // 
            // kamp_id
            // 
            this.kamp_id.FormattingEnabled = true;
            this.kamp_id.Location = new System.Drawing.Point(341, 110);
            this.kamp_id.Name = "kamp_id";
            this.kamp_id.Size = new System.Drawing.Size(121, 24);
            this.kamp_id.TabIndex = 3;
            // 
            // yk_id
            // 
            this.yk_id.FormattingEnabled = true;
            this.yk_id.Location = new System.Drawing.Point(341, 150);
            this.yk_id.Name = "yk_id";
            this.yk_id.Size = new System.Drawing.Size(121, 24);
            this.yk_id.TabIndex = 4;
            this.yk_id.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(626, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(503, 294);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ekle_btn
            // 
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.Location = new System.Drawing.Point(94, 299);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(85, 29);
            this.ekle_btn.TabIndex = 6;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // gorn_btn
            // 
            this.gorn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorn_btn.Location = new System.Drawing.Point(244, 299);
            this.gorn_btn.Name = "gorn_btn";
            this.gorn_btn.Size = new System.Drawing.Size(105, 29);
            this.gorn_btn.TabIndex = 7;
            this.gorn_btn.Text = "Görüntüle";
            this.gorn_btn.UseVisualStyleBackColor = true;
            this.gorn_btn.Click += new System.EventHandler(this.gorn_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1054, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // baglanti_tablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 527);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gorn_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yk_id);
            this.Controls.Add(this.kamp_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "baglanti_tablosu";
            this.Text = "baglanti_tablosu";
            this.Load += new System.EventHandler(this.baglanti_tablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kamp_id;
        private System.Windows.Forms.ComboBox yk_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button gorn_btn;
        private System.Windows.Forms.Button button3;
    }
}