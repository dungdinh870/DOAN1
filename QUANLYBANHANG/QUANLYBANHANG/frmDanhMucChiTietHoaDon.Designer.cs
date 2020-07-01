namespace QUANLYBANHANG
{
    partial class frmDanhMucChiTietHoaDon
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
            this.dgvDanhMucCTHD = new System.Windows.Forms.DataGridView();
            this.lblDanhMucCTHD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucCTHD)).BeginInit();
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
            // dgvDanhMucCTHD
            // 
            this.dgvDanhMucCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucCTHD.Location = new System.Drawing.Point(75, 117);
            this.dgvDanhMucCTHD.Name = "dgvDanhMucCTHD";
            this.dgvDanhMucCTHD.RowHeadersWidth = 51;
            this.dgvDanhMucCTHD.RowTemplate.Height = 24;
            this.dgvDanhMucCTHD.Size = new System.Drawing.Size(637, 232);
            this.dgvDanhMucCTHD.TabIndex = 4;
            // 
            // lblDanhMucCTHD
            // 
            this.lblDanhMucCTHD.AutoSize = true;
            this.lblDanhMucCTHD.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhMucCTHD.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhMucCTHD.Location = new System.Drawing.Point(182, 33);
            this.lblDanhMucCTHD.Name = "lblDanhMucCTHD";
            this.lblDanhMucCTHD.Size = new System.Drawing.Size(431, 37);
            this.lblDanhMucCTHD.TabIndex = 3;
            this.lblDanhMucCTHD.Text = "Danh Mục Chi Tiết Hóa Đơn ";
            // 
            // frmDanhMucChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvDanhMucCTHD);
            this.Controls.Add(this.lblDanhMucCTHD);
            this.Name = "frmDanhMucChiTietHoaDon";
            this.Text = "frmDanhMucChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvDanhMucCTHD;
        private System.Windows.Forms.Label lblDanhMucCTHD;
    }
}