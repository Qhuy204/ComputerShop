namespace ĐA1
{
    partial class UC_ProductControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ProductControl));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTensp = new System.Windows.Forms.Label();
            this.pbAnhSP = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblSoluong);
            this.guna2Panel1.Controls.Add(this.lblTensp);
            this.guna2Panel1.Controls.Add(this.pbAnhSP);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(291, 91);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(96, 46);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(41, 17);
            this.lblSoluong.TabIndex = 7;
            this.lblSoluong.Text = "label1";
            // 
            // lblTensp
            // 
            this.lblTensp.AutoSize = true;
            this.lblTensp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensp.Location = new System.Drawing.Point(96, 20);
            this.lblTensp.Name = "lblTensp";
            this.lblTensp.Size = new System.Drawing.Size(41, 17);
            this.lblTensp.TabIndex = 6;
            this.lblTensp.Text = "label1";
            // 
            // pbAnhSP
            // 
            this.pbAnhSP.Image = ((System.Drawing.Image)(resources.GetObject("pbAnhSP.Image")));
            this.pbAnhSP.Location = new System.Drawing.Point(11, 10);
            this.pbAnhSP.Name = "pbAnhSP";
            this.pbAnhSP.Size = new System.Drawing.Size(70, 70);
            this.pbAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnhSP.TabIndex = 5;
            this.pbAnhSP.TabStop = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(291, 91);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblTensp;
        private System.Windows.Forms.PictureBox pbAnhSP;
    }
}
