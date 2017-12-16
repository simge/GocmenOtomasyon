namespace GocmenOtomasyon
{
    partial class listelemeform_yardımk
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
            this.lst_yk = new System.Windows.Forms.Button();
            this.goclabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 413);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lst_yk
            // 
            this.lst_yk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_yk.Location = new System.Drawing.Point(584, 545);
            this.lst_yk.Name = "lst_yk";
            this.lst_yk.Size = new System.Drawing.Size(113, 47);
            this.lst_yk.TabIndex = 24;
            this.lst_yk.Text = "Listeleme";
            this.lst_yk.UseVisualStyleBackColor = true;
            this.lst_yk.Click += new System.EventHandler(this.lst_yk_Click);
            // 
            // goclabel
            // 
            this.goclabel.AutoSize = true;
            this.goclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goclabel.Location = new System.Drawing.Point(524, 41);
            this.goclabel.Name = "goclabel";
            this.goclabel.Size = new System.Drawing.Size(233, 24);
            this.goclabel.TabIndex = 23;
            this.goclabel.Text = "Alınan Yardımlar Listesi ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listelemeform_yardımk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lst_yk);
            this.Controls.Add(this.goclabel);
            this.Name = "listelemeform_yardımk";
            this.Text = "listelemeform_yardımk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lst_yk;
        private System.Windows.Forms.Label goclabel;
        private System.Windows.Forms.Button button1;
    }
}