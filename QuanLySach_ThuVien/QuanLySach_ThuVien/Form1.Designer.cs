namespace QuanLySach_ThuVien
{
    partial class frmSach
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grbSach = new GroupBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            txtGiaTien = new TextBox();
            lblGiaTien = new Label();
            lblTenSach = new Label();
            lblMaSach = new Label();
            dgvSach = new DataGridView();
            lblDanhSach = new Label();
            grbSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(288, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(422, 27);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(562, 27);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(694, 27);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 46);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grbSach
            // 
            grbSach.Controls.Add(txtTenSach);
            grbSach.Controls.Add(txtMaSach);
            grbSach.Controls.Add(txtGiaTien);
            grbSach.Controls.Add(lblGiaTien);
            grbSach.Controls.Add(lblTenSach);
            grbSach.Controls.Add(lblMaSach);
            grbSach.Location = new Point(22, 26);
            grbSach.Name = "grbSach";
            grbSach.Size = new Size(237, 401);
            grbSach.TabIndex = 4;
            grbSach.TabStop = false;
            grbSach.Text = "Thông tin sách";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(24, 203);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(186, 27);
            txtTenSach.TabIndex = 5;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(24, 87);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(186, 27);
            txtMaSach.TabIndex = 4;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(24, 321);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(186, 27);
            txtGiaTien.TabIndex = 3;
            txtGiaTien.KeyPress += txtGiaTien_KeyPress;
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.Location = new Point(24, 283);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new Size(63, 20);
            lblGiaTien.TabIndex = 2;
            lblGiaTien.Text = "Giá tiền:";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(24, 167);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(68, 20);
            lblTenSach.TabIndex = 1;
            lblTenSach.Text = "Tên sách:";
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(24, 44);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(66, 20);
            lblMaSach.TabIndex = 0;
            lblMaSach.Text = "Mã sách:";
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(280, 158);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(482, 267);
            dgvSach.TabIndex = 5;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(288, 120);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(110, 20);
            lblDanhSach.TabIndex = 6;
            lblDanhSach.Text = "Danh sách sách";
            // 
            // frmSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDanhSach);
            Controls.Add(dgvSach);
            Controls.Add(grbSach);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "frmSach";
            Text = "Quản lý Sách / Thư viện - VP 103";
            KeyPreview = true;
            Load += frmSach_Load;
            KeyDown += frmSach_KeyDown;
            grbSach.ResumeLayout(false);
            grbSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox grbSach;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private TextBox txtGiaTien;
        private Label lblGiaTien;
        private Label lblTenSach;
        private Label lblMaSach;
        private DataGridView dgvSach;
        private Label lblDanhSach;
    }
}
