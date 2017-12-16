namespace GocmenOtomasyon
{
    partial class meslek_kayıt_silme
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
            this.yenile = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.giristxb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Silinmesini istediğiniz kaydın idsini giriniz.";
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(60, 531);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(111, 34);
            this.yenile.TabIndex = 13;
            this.yenile.Text = "Listeyi Getir";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click_1);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(60, 491);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(111, 23);
            this.sil.TabIndex = 12;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // giristxb
            // 
            this.giristxb.Location = new System.Drawing.Point(59, 412);
            this.giristxb.Name = "giristxb";
            this.giristxb.Size = new System.Drawing.Size(164, 22);
            this.giristxb.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 324);
            this.dataGridView1.TabIndex = 10;
            // 
            // meslek_kayıt_silme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.giristxb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "meslek_kayıt_silme";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox giristxb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}