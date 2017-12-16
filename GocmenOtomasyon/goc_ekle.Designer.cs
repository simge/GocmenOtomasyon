namespace GocmenOtomasyon
{
    partial class goc_ekle
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
            this.goctur = new System.Windows.Forms.Label();
            this.goctarihi = new System.Windows.Forms.Label();
            this.goc_tur = new System.Windows.Forms.TextBox();
            this.goclabel = new System.Windows.Forms.Label();
            this.goc_trh = new System.Windows.Forms.DateTimePicker();
            this.ekleme_button = new System.Windows.Forms.Button();
            this.goc_goruntu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // goctur
            // 
            this.goctur.AutoSize = true;
            this.goctur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goctur.Location = new System.Drawing.Point(78, 93);
            this.goctur.Name = "goctur";
            this.goctur.Size = new System.Drawing.Size(87, 20);
            this.goctur.TabIndex = 0;
            this.goctur.Text = "Göç Türü";
            this.goctur.Click += new System.EventHandler(this.label1_Click);
            // 
            // goctarihi
            // 
            this.goctarihi.AutoSize = true;
            this.goctarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goctarihi.Location = new System.Drawing.Point(78, 149);
            this.goctarihi.Name = "goctarihi";
            this.goctarihi.Size = new System.Drawing.Size(92, 20);
            this.goctarihi.TabIndex = 2;
            this.goctarihi.Text = "Göç Tarih";
            this.goctarihi.Click += new System.EventHandler(this.goctarihi_Click);
            // 
            // goc_tur
            // 
            this.goc_tur.Location = new System.Drawing.Point(279, 88);
            this.goc_tur.Name = "goc_tur";
            this.goc_tur.Size = new System.Drawing.Size(140, 22);
            this.goc_tur.TabIndex = 3;
            this.goc_tur.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // goclabel
            // 
            this.goclabel.AutoSize = true;
            this.goclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goclabel.Location = new System.Drawing.Point(507, 26);
            this.goclabel.Name = "goclabel";
            this.goclabel.Size = new System.Drawing.Size(82, 32);
            this.goclabel.TabIndex = 4;
            this.goclabel.Text = "GÖÇ";
            this.goclabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // goc_trh
            // 
            this.goc_trh.Location = new System.Drawing.Point(279, 149);
            this.goc_trh.Name = "goc_trh";
            this.goc_trh.Size = new System.Drawing.Size(200, 22);
            this.goc_trh.TabIndex = 5;
            this.goc_trh.ValueChanged += new System.EventHandler(this.goc_trh_ValueChanged);
            // 
            // ekleme_button
            // 
            this.ekleme_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleme_button.Location = new System.Drawing.Point(279, 237);
            this.ekleme_button.Name = "ekleme_button";
            this.ekleme_button.Size = new System.Drawing.Size(111, 34);
            this.ekleme_button.TabIndex = 6;
            this.ekleme_button.Text = "Ekle";
            this.ekleme_button.UseVisualStyleBackColor = true;
            this.ekleme_button.Click += new System.EventHandler(this.ekleme_button_Click);
            // 
            // goc_goruntu
            // 
            this.goc_goruntu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goc_goruntu.Location = new System.Drawing.Point(279, 305);
            this.goc_goruntu.Name = "goc_goruntu";
            this.goc_goruntu.Size = new System.Drawing.Size(111, 31);
            this.goc_goruntu.TabIndex = 7;
            this.goc_goruntu.Text = "Görüntüle";
            this.goc_goruntu.UseVisualStyleBackColor = true;
            this.goc_goruntu.Click += new System.EventHandler(this.goc_goruntu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(554, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 326);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // goc_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goc_goruntu);
            this.Controls.Add(this.ekleme_button);
            this.Controls.Add(this.goc_trh);
            this.Controls.Add(this.goclabel);
            this.Controls.Add(this.goc_tur);
            this.Controls.Add(this.goctarihi);
            this.Controls.Add(this.goctur);
            this.Name = "goc_ekle";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goctur;
        private System.Windows.Forms.Label goctarihi;
        private System.Windows.Forms.TextBox goc_tur;
        private System.Windows.Forms.Label goclabel;
        private System.Windows.Forms.DateTimePicker goc_trh;
        private System.Windows.Forms.Button ekleme_button;
        private System.Windows.Forms.Button goc_goruntu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}