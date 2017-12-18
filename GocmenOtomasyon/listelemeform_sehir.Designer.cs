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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sayici = new System.Windows.Forms.TextBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(921, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Bulunulan şehir sayısı";
            // 
            // sayici
            // 
            this.sayici.Location = new System.Drawing.Point(1196, 507);
            this.sayici.Name = "sayici";
            this.sayici.Size = new System.Drawing.Size(100, 22);
            this.sayici.TabIndex = 43;
            // 
            // listelemeform_sehir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1333, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayici);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayici;
    }
}