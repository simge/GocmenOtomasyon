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
            this.yarktext.TextChanged += new System.EventHandler(this.yarktext_TextChanged);
            // 
            // ykbttn
            // 
            this.ykbttn.Location = new System.Drawing.Point(74, 180);
            this.ykbttn.Name = "ykbttn";
            this.ykbttn.Size = new System.Drawing.Size(75, 23);
            this.ykbttn.TabIndex = 3;
            this.ykbttn.Text = "Ekle";
            this.ykbttn.UseVisualStyleBackColor = true;
            this.ykbttn.Click += new System.EventHandler(this.ykbttn_Click);
            // 
            // yardımk_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 524);
            this.Controls.Add(this.ykbttn);
            this.Controls.Add(this.yarktext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yardımk_form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yarktext;
        private System.Windows.Forms.Button ykbttn;
    }
}