namespace GocmenOtomasyon
{
    partial class gocmen_kayıt_silme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.giristxb = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.yenile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // giristxb
            // 
            this.giristxb.Location = new System.Drawing.Point(29, 409);
            this.giristxb.Name = "giristxb";
            this.giristxb.Size = new System.Drawing.Size(164, 22);
            this.giristxb.TabIndex = 1;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(30, 488);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(111, 23);
            this.sil.TabIndex = 2;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(30, 528);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(111, 34);
            this.yenile.TabIndex = 3;
            this.yenile.Text = "Listeyi Getir";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Silinmesini istediğiniz kaydın idsini giriniz.";
            // 
            // gocmen_kayıt_silme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.giristxb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gocmen_kayıt_silme";
            this.Text = "kayıt_silmeform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox giristxb;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Label label1;
    }
}