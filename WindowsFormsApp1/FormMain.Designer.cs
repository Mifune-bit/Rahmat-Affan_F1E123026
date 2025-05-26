namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.btnDataBuku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDataBuku
            // 
            this.btnDataBuku.Location = new System.Drawing.Point(12, 12);
            this.btnDataBuku.Name = "btnDataBuku";
            this.btnDataBuku.Size = new System.Drawing.Size(75, 23);
            this.btnDataBuku.TabIndex = 0;
            this.btnDataBuku.Text = "Data Buku";
            this.btnDataBuku.UseVisualStyleBackColor = true;
            this.btnDataBuku.Click += new System.EventHandler(this.btnDataBuku_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 294);
            this.Controls.Add(this.btnDataBuku);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataBuku;
    }
}