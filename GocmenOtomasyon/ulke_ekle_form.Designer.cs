namespace GocmenOtomasyon
{
    partial class ulke_ekle_form
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
            this.ulkead = new System.Windows.Forms.TextBox();
            this.ulkeuyruk = new System.Windows.Forms.TextBox();
            this.ulkebttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(536, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Göçmenin Geldiği Ülke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ülke Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Göçmen Uyruğu";
            // 
            // ulkead
            // 
            this.ulkead.Location = new System.Drawing.Point(292, 94);
            this.ulkead.Name = "ulkead";
            this.ulkead.Size = new System.Drawing.Size(100, 22);
            this.ulkead.TabIndex = 3;
            // 
            // ulkeuyruk
            // 
            this.ulkeuyruk.Location = new System.Drawing.Point(292, 164);
            this.ulkeuyruk.Name = "ulkeuyruk";
            this.ulkeuyruk.Size = new System.Drawing.Size(100, 22);
            this.ulkeuyruk.TabIndex = 4;
            this.ulkeuyruk.TextChanged += new System.EventHandler(this.ulkeuyruk_TextChanged);
            // 
            // ulkebttn
            // 
            this.ulkebttn.Location = new System.Drawing.Point(99, 265);
            this.ulkebttn.Name = "ulkebttn";
            this.ulkebttn.Size = new System.Drawing.Size(75, 23);
            this.ulkebttn.TabIndex = 5;
            this.ulkebttn.Text = "Ekle";
            this.ulkebttn.UseVisualStyleBackColor = true;
            this.ulkebttn.Click += new System.EventHandler(this.ulkebttn_Click);
            // 
            // ulke_ekle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 520);
            this.Controls.Add(this.ulkebttn);
            this.Controls.Add(this.ulkeuyruk);
            this.Controls.Add(this.ulkead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ulke_ekle_form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ulkead;
        private System.Windows.Forms.TextBox ulkeuyruk;
        private System.Windows.Forms.Button ulkebttn;
    }
}