namespace QUANLYBANHANG
{
    partial class frmDanhMucNhanVien
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
            this.dgvDanhMucNV = new System.Windows.Forms.DataGridView();
            this.lblDanhMucNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucNV)).BeginInit();
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
            // dgvDanhMucNV
            // 
            this.dgvDanhMucNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucNV.Location = new System.Drawing.Point(75, 117);
            this.dgvDanhMucNV.Name = "dgvDanhMucNV";
            this.dgvDanhMucNV.RowHeadersWidth = 51;
            this.dgvDanhMucNV.RowTemplate.Height = 24;
            this.dgvDanhMucNV.Size = new System.Drawing.Size(637, 232);
            this.dgvDanhMucNV.TabIndex = 4;
            // 
            // lblDanhMucNV
            // 
            this.lblDanhMucNV.AutoSize = true;
            this.lblDanhMucNV.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhMucNV.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhMucNV.Location = new System.Drawing.Point(182, 33);
            this.lblDanhMucNV.Name = "lblDanhMucNV";
            this.lblDanhMucNV.Size = new System.Drawing.Size(329, 37);
            this.lblDanhMucNV.TabIndex = 3;
            this.lblDanhMucNV.Text = "Danh Mục Nhân Viên ";
            // 
            // frmDanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvDanhMucNV);
            this.Controls.Add(this.lblDanhMucNV);
            this.Name = "frmDanhMucNhanVien";
            this.Text = "frmDanhMucNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvDanhMucNV;
        private System.Windows.Forms.Label lblDanhMucNV;
    }
}