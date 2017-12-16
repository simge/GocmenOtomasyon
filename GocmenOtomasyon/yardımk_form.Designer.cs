namespace GocmenOtomasyon
{
    partial class yardımk_form
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
            this.yarktext = new System.Windows.Forms.TextBox();
            this.ykbttn = new System.Windows.Forms.Button();
            this.goruntu_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(559, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yardım Kuruluşları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yardım Kuruluşunun Adı";
            // 
            // yarktext
            // 
            this.yarktext.Location = new System.Drawing.Point(350, 103);
            this.yarktext.Name = "yarktext";
            this.yarktext.Size = new System.Drawing.Size(132, 22);
            this.yarktext.TabIndex = 2;
            // 
            // ykbttn
            // 
            this.ykbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ykbttn.Location = new System.Drawing.Point(74, 180);
            this.ykbttn.Name = "ykbttn";
            this.ykbttn.Size = new System.Drawing.Size(97, 32);
            this.ykbttn.TabIndex = 3;
            this.ykbttn.Text = "Ekle";
            this.ykbttn.UseVisualStyleBackColor = true;
            this.ykbttn.Click += new System.EventHandler(this.ykbttn_Click);
            // 
            // goruntu_btn
            // 
            this.goruntu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goruntu_btn.Location = new System.Drawing.Point(74, 250);
            this.goruntu_btn.Name = "goruntu_btn";
            this.goruntu_btn.Size = new System.Drawing.Size(144, 39);
            this.goruntu_btn.TabIndex = 4;
            this.goruntu_btn.Text = "Görüntüleme";
            this.goruntu_btn.UseVisualStyleBackColor = true;
            this.goruntu_btn.Click += new System.EventHandler(this.goruntu_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(591, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 329);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1154, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yardımk_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.goruntu_btn);
            this.Controls.Add(this.ykbttn);
            this.Controls.Add(this.yarktext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yardımk_form";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.yardımk_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yarktext;
        private System.Windows.Forms.Button ykbttn;
        private System.Windows.Forms.Button goruntu_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}