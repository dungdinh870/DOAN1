namespace QUANLYBANHANG
{
    partial class frmDanhMucHoaDon
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
            this.dgvDanhMucHD = new System.Windows.Forms.DataGridView();
            this.lblDanhMucHD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucHD)).BeginInit();
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
            // dgvDanhMucHD
            // 
            this.dgvDanhMucHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucHD.Location = new System.Drawing.Point(75, 117);
            this.dgvDanhMucHD.Name = "dgvDanhMucHD";
            this.dgvDanhMucHD.RowHeadersWidth = 51;
            this.dgvDanhMucHD.RowTemplate.Height = 24;
            this.dgvDanhMucHD.Size = new System.Drawing.Size(637, 232);
            this.dgvDanhMucHD.TabIndex = 4;
            // 
            // lblDanhMucHD
            // 
            this.lblDanhMucHD.AutoSize = true;
            this.lblDanhMucHD.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhMucHD.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhMucHD.Location = new System.Drawing.Point(182, 33);
            this.lblDanhMucHD.Name = "lblDanhMucHD";
            this.lblDanhMucHD.Size = new System.Drawing.Size(309, 37);
            this.lblDanhMucHD.TabIndex = 3;
            this.lblDanhMucHD.Text = "Danh Mục Hóa Đơn ";
            // 
            // frmDanhMucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvDanhMucHD);
            this.Controls.Add(this.lblDanhMucHD);
            this.Name = "frmDanhMucHoaDon";
            this.Text = "frmDanhMucHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvDanhMucHD;
        private System.Windows.Forms.Label lblDanhMucHD;
    }
}