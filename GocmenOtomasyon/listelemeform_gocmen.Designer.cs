namespace GocmenOtomasyon
{
    partial class listelemeform_gocmen
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.don_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sayici = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(548, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 48);
            this.button2.TabIndex = 39;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1270, 462);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(482, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 30);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Göçmen Tablosu Listesi";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // don_btn
            // 
            this.don_btn.Location = new System.Drawing.Point(39, 517);
            this.don_btn.Name = "don_btn";
            this.don_btn.Size = new System.Drawing.Size(75, 23);
            this.don_btn.TabIndex = 40;
            this.don_btn.Text = "Geri";
            this.don_btn.UseVisualStyleBackColor = true;
            this.don_btn.Click += new System.EventHandler(this.don_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(934, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Göçmenlerin sayısı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sayici
            // 
            this.sayici.Location = new System.Drawing.Point(1209, 515);
            this.sayici.Name = "sayici";
            this.sayici.Size = new System.Drawing.Size(100, 22);
            this.sayici.TabIndex = 41;
            this.sayici.TextChanged += new System.EventHandler(this.sayici_TextChanged);
            // 
            // listelemeform_gocmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayici);
            this.Controls.Add(this.don_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "listelemeform_gocmen";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button don_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayici;
    }
}