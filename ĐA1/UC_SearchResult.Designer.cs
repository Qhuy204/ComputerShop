namespace ĐA1
{
    partial class UC_SearchResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SearchResult));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch_result = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch_result
            // 
            this.btnSearch_result.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_result.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_result.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch_result.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch_result.FillColor = System.Drawing.Color.White;
            this.btnSearch_result.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_result.ForeColor = System.Drawing.Color.Black;
            this.btnSearch_result.Location = new System.Drawing.Point(53, 0);
            this.btnSearch_result.Name = "btnSearch_result";
            this.btnSearch_result.Size = new System.Drawing.Size(295, 47);
            this.btnSearch_result.TabIndex = 2;
            this.btnSearch_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch_result.Click += new System.EventHandler(this.btnSearch_result_Click);
            // 
            // UC_SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch_result);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_SearchResult";
            this.Size = new System.Drawing.Size(349, 47);
            this.Load += new System.EventHandler(this.SearchResult_Load);
            this.MouseLeave += new System.EventHandler(this.SearchResult_MouseLeave);
            this.MouseHover += new System.EventHandler(this.SearchResult_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI2.WinForms.Guna2Button btnSearch_result;
    }
}
