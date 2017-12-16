namespace GocmenOtomasyon
{
    partial class arama_gocmen
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
            this.ara_txb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ara_btn = new System.Windows.Forms.Button();
            this.don_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(342, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranacak Kelime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ara_txb
            // 
            this.ara_txb.Location = new System.Drawing.Point(531, 54);
            this.ara_txb.Name = "ara_txb";
            this.ara_txb.Size = new System.Drawing.Size(138, 22);
            this.ara_txb.TabIndex = 1;
            this.ara_txb.TextChanged += new System.EventHandler(this.ara_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 527);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ara_btn
            // 
            this.ara_btn.Location = new System.Drawing.Point(736, 53);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(99, 23);
            this.ara_btn.TabIndex = 3;
            this.ara_btn.Text = "Ara";
            this.ara_btn.UseVisualStyleBackColor = true;
            this.ara_btn.Click += new System.EventHandler(this.ara_btn_Click);
            // 
            // don_btn
            // 
            this.don_btn.Location = new System.Drawing.Point(924, 53);
            this.don_btn.Name = "don_btn";
            this.don_btn.Size = new System.Drawing.Size(108, 23);
            this.don_btn.TabIndex = 4;
            this.don_btn.Text = "Dön";
            this.don_btn.UseVisualStyleBackColor = true;
            this.don_btn.Click += new System.EventHandler(this.don_btn_Click);
            // 
            // arama_gocmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 640);
            this.Controls.Add(this.don_btn);
            this.Controls.Add(this.ara_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ara_txb);
            this.Controls.Add(this.label1);
            this.Name = "arama_gocmen";
            this.Text = "arama_gocmen";
            this.Load += new System.EventHandler(this.arama_gocmen_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ara_txb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ara_btn;
        private System.Windows.Forms.Button don_btn;
    }
}