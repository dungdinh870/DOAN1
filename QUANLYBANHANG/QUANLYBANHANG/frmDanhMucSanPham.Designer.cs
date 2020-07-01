namespace QUANLYBANHANG
{
    partial class frmDanhMucSanPham
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
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvDanhMucSP = new System.Windows.Forms.DataGridView();
            this.lblDanhMucSP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Red;
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(598, 378);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(127, 40);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở Về ";
            this.btnTroVe.UseVisualStyleBackColor = false;
            // 
            // dgvDanhMucSP
            // 
            this.dgvDanhMucSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSP.Location = new System.Drawing.Point(75, 117);
            this.dgvDanhMucSP.Name = "dgvDanhMucSP";
            this.dgvDanhMucSP.RowHeadersWidth = 51;
            this.dgvDanhMucSP.RowTemplate.Height = 24;
            this.dgvDanhMucSP.Size = new System.Drawing.Size(637, 232);
            this.dgvDanhMucSP.TabIndex = 4;
            // 
            // lblDanhMucSP
            // 
            this.lblDanhMucSP.AutoSize = true;
            this.lblDanhMucSP.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhMucSP.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhMucSP.Location = new System.Drawing.Point(182, 33);
            this.lblDanhMucSP.Name = "lblDanhMucSP";
            this.lblDanhMucSP.Size = new System.Drawing.Size(323, 37);
            this.lblDanhMucSP.TabIndex = 3;
            this.lblDanhMucSP.Text = "Danh Mục Sản Phẩm ";
            // 
            // frmDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvDanhMucSP);
            this.Controls.Add(this.lblDanhMucSP);
            this.Name = "frmDanhMucSanPham";
            this.Text = "frmDanhMucSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvDanhMucSP;
        private System.Windows.Forms.Label lblDanhMucSP;
    }
}