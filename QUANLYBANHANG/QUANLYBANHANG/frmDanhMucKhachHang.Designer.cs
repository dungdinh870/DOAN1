namespace QUANLYBANHANG
{
    partial class frmDanhMucKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.lblDanhMucKH = new System.Windows.Forms.Label();
            this.dgvDanhMucKH = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.qlbanhangDataSet3 = new QUANLYBANHANG.qlbanhangDataSet3();
            this.qlbanhangDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbanhangDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbanhangDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhMucKH
            // 
            this.lblDanhMucKH.AutoSize = true;
            this.lblDanhMucKH.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhMucKH.ForeColor = System.Drawing.Color.Navy;
            this.lblDanhMucKH.Location = new System.Drawing.Point(186, 43);
            this.lblDanhMucKH.Name = "lblDanhMucKH";
            this.lblDanhMucKH.Size = new System.Drawing.Size(360, 37);
            this.lblDanhMucKH.TabIndex = 0;
            this.lblDanhMucKH.Text = "Danh Mục Khách Hàng ";
            // 
            // dgvDanhMucKH
            // 
            this.dgvDanhMucKH.AutoGenerateColumns = false;
            this.dgvDanhMucKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMucKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucKH.DataSource = this.qlbanhangDataSet3BindingSource;
            this.dgvDanhMucKH.Location = new System.Drawing.Point(79, 127);
            this.dgvDanhMucKH.Name = "dgvDanhMucKH";
            this.dgvDanhMucKH.RowHeadersWidth = 51;
            this.dgvDanhMucKH.RowTemplate.Height = 24;
            this.dgvDanhMucKH.Size = new System.Drawing.Size(637, 232);
            this.dgvDanhMucKH.TabIndex = 1;
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Red;
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(602, 388);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(127, 40);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.Text = "Trở Về ";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.button1_Click);
            // 
            // qlbanhangDataSet3
            // 
            this.qlbanhangDataSet3.DataSetName = "qlbanhangDataSet3";
            this.qlbanhangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlbanhangDataSet3BindingSource
            // 
            this.qlbanhangDataSet3BindingSource.DataSource = this.qlbanhangDataSet3;
            this.qlbanhangDataSet3BindingSource.Position = 0;
            // 
            // frmDanhMucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dgvDanhMucKH);
            this.Controls.Add(this.lblDanhMucKH);
            this.Name = "frmDanhMucKhachHang";
            this.Text = "frmDanhMucKhachHang";
            this.Load += new System.EventHandler(this.frmDanhMucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbanhangDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbanhangDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhMucKH;
        private System.Windows.Forms.DataGridView dgvDanhMucKH;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.BindingSource qlbanhangDataSet3BindingSource;
        private qlbanhangDataSet3 qlbanhangDataSet3;
    }
}