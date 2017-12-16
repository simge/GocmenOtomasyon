namespace GocmenOtomasyon
{
    partial class listelemeform_kamp
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
            this.lst_ulke = new System.Windows.Forms.Button();
            this.goclabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 413);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lst_ulke
            // 
            this.lst_ulke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_ulke.Location = new System.Drawing.Point(556, 515);
            this.lst_ulke.Name = "lst_ulke";
            this.lst_ulke.Size = new System.Drawing.Size(113, 47);
            this.lst_ulke.TabIndex = 24;
            this.lst_ulke.Text = "Listeleme";
            this.lst_ulke.UseVisualStyleBackColor = true;
            this.lst_ulke.Click += new System.EventHandler(this.lst_goc_Click);
            // 
            // goclabel
            // 
            this.goclabel.AutoSize = true;
            this.goclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goclabel.Location = new System.Drawing.Point(532, 50);
            this.goclabel.Name = "goclabel";
            this.goclabel.Size = new System.Drawing.Size(210, 24);
            this.goclabel.TabIndex = 23;
            this.goclabel.Text = "Bulunan Kamp Listesi";
            this.goclabel.Click += new System.EventHandler(this.goclabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listelemeform_kamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lst_ulke);
            this.Controls.Add(this.goclabel);
            this.Name = "listelemeform_kamp";
            this.Text = "listelemeform_kamp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lst_ulke;
        private System.Windows.Forms.Label goclabel;
        private System.Windows.Forms.Button button1;
    }
}