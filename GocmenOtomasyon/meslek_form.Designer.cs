namespace GocmenOtomasyon
{
    partial class meslek_form
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
            this.meslektxb = new System.Windows.Forms.TextBox();
            this.meslekbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(445, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Göçmen Meslekleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meslek Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // meslektxb
            // 
            this.meslektxb.Location = new System.Drawing.Point(277, 107);
            this.meslektxb.Name = "meslektxb";
            this.meslektxb.Size = new System.Drawing.Size(100, 22);
            this.meslektxb.TabIndex = 2;
            // 
            // meslekbtn
            // 
            this.meslekbtn.Location = new System.Drawing.Point(92, 218);
            this.meslekbtn.Name = "meslekbtn";
            this.meslekbtn.Size = new System.Drawing.Size(75, 23);
            this.meslekbtn.TabIndex = 3;
            this.meslekbtn.Text = "Ekle";
            this.meslekbtn.UseVisualStyleBackColor = true;
            this.meslekbtn.Click += new System.EventHandler(this.meslekbtn_Click);
            // 
            // meslek_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 485);
            this.Controls.Add(this.meslekbtn);
            this.Controls.Add(this.meslektxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "meslek_form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meslektxb;
        private System.Windows.Forms.Button meslekbtn;
    }
}