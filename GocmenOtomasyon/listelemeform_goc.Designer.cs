namespace GocmenOtomasyon
{
    partial class listelemeform_goc
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
            this.lst_goc = new System.Windows.Forms.Button();
            this.goclabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.don_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sayici = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_goc
            // 
            this.lst_goc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_goc.Location = new System.Drawing.Point(602, 534);
            this.lst_goc.Name = "lst_goc";
            this.lst_goc.Size = new System.Drawing.Size(113, 47);
            this.lst_goc.TabIndex = 15;
            this.lst_goc.Text = "Listeleme";
            this.lst_goc.UseVisualStyleBackColor = true;
            this.lst_goc.Click += new System.EventHandler(this.lst_goc_Click);
            // 
            // goclabel
            // 
            this.goclabel.AutoSize = true;
            this.goclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goclabel.Location = new System.Drawing.Point(542, 30);
            this.goclabel.Name = "goclabel";
            this.goclabel.Size = new System.Drawing.Size(193, 24);
            this.goclabel.TabIndex = 12;
            this.goclabel.Text = "Göç Tablosu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 413);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // don_btn
            // 
            this.don_btn.Location = new System.Drawing.Point(61, 510);
            this.don_btn.Name = "don_btn";
            this.don_btn.Size = new System.Drawing.Size(75, 23);
            this.don_btn.TabIndex = 17;
            this.don_btn.Text = "Geri";
            this.don_btn.UseVisualStyleBackColor = true;
            this.don_btn.Click += new System.EventHandler(this.don_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(929, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Göç türlerinin toplam sayısı";
            // 
            // sayici
            // 
            this.sayici.Location = new System.Drawing.Point(1204, 496);
            this.sayici.Name = "sayici";
            this.sayici.Size = new System.Drawing.Size(100, 22);
            this.sayici.TabIndex = 18;
            // 
            // listelemeform_goc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1339, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayici);
            this.Controls.Add(this.don_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lst_goc);
            this.Controls.Add(this.goclabel);
            this.Name = "listelemeform_goc";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lst_goc;
        private System.Windows.Forms.Label goclabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button don_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayici;
    }
}