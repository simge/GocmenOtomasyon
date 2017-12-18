namespace GocmenOtomasyon
{
    partial class gocmen_guncel_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guncel_btn = new System.Windows.Forms.Button();
            this.yenile_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.don_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1316, 407);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guncel_btn
            // 
            this.guncel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncel_btn.Location = new System.Drawing.Point(967, 478);
            this.guncel_btn.Name = "guncel_btn";
            this.guncel_btn.Size = new System.Drawing.Size(230, 65);
            this.guncel_btn.TabIndex = 42;
            this.guncel_btn.Text = "Güncelle";
            this.guncel_btn.UseVisualStyleBackColor = true;
            this.guncel_btn.Click += new System.EventHandler(this.guncel_btn_Click);
            // 
            // yenile_btn
            // 
            this.yenile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile_btn.Location = new System.Drawing.Point(750, 478);
            this.yenile_btn.Name = "yenile_btn";
            this.yenile_btn.Size = new System.Drawing.Size(200, 65);
            this.yenile_btn.TabIndex = 43;
            this.yenile_btn.Text = "Görüntüle";
            this.yenile_btn.UseVisualStyleBackColor = true;
            this.yenile_btn.Click += new System.EventHandler(this.yenile_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(554, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Göçmen Güncelleme İşlemleri";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // don_btn
            // 
            this.don_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.don_btn.Location = new System.Drawing.Point(12, 484);
            this.don_btn.Name = "don_btn";
            this.don_btn.Size = new System.Drawing.Size(103, 28);
            this.don_btn.TabIndex = 45;
            this.don_btn.Text = "Geri";
            this.don_btn.UseVisualStyleBackColor = true;
            this.don_btn.Click += new System.EventHandler(this.don_btn_Click);
            // 
            // gocmen_guncel_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1340, 570);
            this.Controls.Add(this.don_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yenile_btn);
            this.Controls.Add(this.guncel_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "gocmen_guncel_form";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncel_btn;
        private System.Windows.Forms.Button yenile_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button don_btn;
    }
}