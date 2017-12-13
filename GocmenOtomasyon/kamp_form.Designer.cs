namespace GocmenOtomasyon
{
    partial class kamp_form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kampadi = new System.Windows.Forms.TextBox();
            this.kampbtn = new System.Windows.Forms.Button();
            this.kamp_cbx = new System.Windows.Forms.ComboBox();
            this.kamptrh = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulunduğu Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kamp Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(66, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kampın Kurulduğu Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(477, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Göçmenlerin Bulunduğu Kamp";
            // 
            // kampadi
            // 
            this.kampadi.Location = new System.Drawing.Point(346, 181);
            this.kampadi.Name = "kampadi";
            this.kampadi.Size = new System.Drawing.Size(100, 22);
            this.kampadi.TabIndex = 5;
            // 
            // kampbtn
            // 
            this.kampbtn.Location = new System.Drawing.Point(69, 289);
            this.kampbtn.Name = "kampbtn";
            this.kampbtn.Size = new System.Drawing.Size(104, 38);
            this.kampbtn.TabIndex = 7;
            this.kampbtn.Text = "Ekle";
            this.kampbtn.UseVisualStyleBackColor = true;
            this.kampbtn.Click += new System.EventHandler(this.kampbtn_Click);
            // 
            // kamp_cbx
            // 
            this.kamp_cbx.FormattingEnabled = true;
            this.kamp_cbx.Location = new System.Drawing.Point(346, 109);
            this.kamp_cbx.Name = "kamp_cbx";
            this.kamp_cbx.Size = new System.Drawing.Size(121, 24);
            this.kamp_cbx.TabIndex = 8;
            this.kamp_cbx.SelectedIndexChanged += new System.EventHandler(this.kamp_cbx_SelectedIndexChanged);
            // 
            // kamptrh
            // 
            this.kamptrh.Location = new System.Drawing.Point(346, 219);
            this.kamptrh.Name = "kamptrh";
            this.kamptrh.Size = new System.Drawing.Size(200, 22);
            this.kamptrh.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Görüntüleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(665, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(613, 389);
            this.dataGridView1.TabIndex = 11;
            // 
            // kamp_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kamptrh);
            this.Controls.Add(this.kamp_cbx);
            this.Controls.Add(this.kampbtn);
            this.Controls.Add(this.kampadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kamp_form";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.kamp_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kampadi;
        private System.Windows.Forms.Button kampbtn;
        private System.Windows.Forms.ComboBox kamp_cbx;
        private System.Windows.Forms.DateTimePicker kamptrh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}