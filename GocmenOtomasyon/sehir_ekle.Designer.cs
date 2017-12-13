namespace GocmenOtomasyon
{
    partial class sehir_ekle
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
            this.sehir_tbox = new System.Windows.Forms.TextBox();
            this.shrekle_bttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(436, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalınan Şehirler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şehir Adı";
            // 
            // sehir_tbox
            // 
            this.sehir_tbox.Location = new System.Drawing.Point(197, 98);
            this.sehir_tbox.Name = "sehir_tbox";
            this.sehir_tbox.Size = new System.Drawing.Size(160, 22);
            this.sehir_tbox.TabIndex = 2;
            this.sehir_tbox.TextChanged += new System.EventHandler(this.sehir_tbox_TextChanged);
            // 
            // shrekle_bttn
            // 
            this.shrekle_bttn.Location = new System.Drawing.Point(197, 190);
            this.shrekle_bttn.Name = "shrekle_bttn";
            this.shrekle_bttn.Size = new System.Drawing.Size(75, 23);
            this.shrekle_bttn.TabIndex = 3;
            this.shrekle_bttn.Text = "Ekle";
            this.shrekle_bttn.UseVisualStyleBackColor = true;
            this.shrekle_bttn.Click += new System.EventHandler(this.shrekle_bttn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Görüntüleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 290);
            this.dataGridView1.TabIndex = 5;
            // 
            // sehir_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shrekle_bttn);
            this.Controls.Add(this.sehir_tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sehir_ekle";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sehir_tbox;
        private System.Windows.Forms.Button shrekle_bttn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}