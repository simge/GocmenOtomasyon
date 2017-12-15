namespace GocmenOtomasyon
{
    partial class listelemeform_sehir
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
            this.lst_goc = new System.Windows.Forms.Button();
            this.goclabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 413);
            this.dataGridView1.TabIndex = 19;
            // 
            // lst_goc
            // 
            this.lst_goc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_goc.Location = new System.Drawing.Point(594, 545);
            this.lst_goc.Name = "lst_goc";
            this.lst_goc.Size = new System.Drawing.Size(113, 47);
            this.lst_goc.TabIndex = 18;
            this.lst_goc.Text = "Listeleme";
            this.lst_goc.UseVisualStyleBackColor = true;
            this.lst_goc.Click += new System.EventHandler(this.lst_goc_Click);
            // 
            // goclabel
            // 
            this.goclabel.AutoSize = true;
            this.goclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goclabel.Location = new System.Drawing.Point(534, 41);
            this.goclabel.Name = "goclabel";
            this.goclabel.Size = new System.Drawing.Size(198, 24);
            this.goclabel.TabIndex = 17;
            this.goclabel.Text = "Kalınan Şehir Listesi";
            // 
            // listelemeform_sehir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 644);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lst_goc);
            this.Controls.Add(this.goclabel);
            this.Name = "listelemeform_sehir";
            this.Text = "listelemeform_sehir";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lst_goc;
        private System.Windows.Forms.Label goclabel;
    }
}