using Microsoft.EntityFrameworkCore;
using QuanLySach_ThuVien.Models;

namespace QuanLySach_ThuVien
{
    public partial class frmSach : Form
    {
        private DuLieuContext _context = new DuLieuContext();

        public frmSach()
        {
            InitializeComponent();
        }

        // 1. Khi form mới được load lên:
        // - Các nút Sửa, Xóa ở trạng thái không hoạt động
        // - Các nút Thêm, Thoát ở trạng thái hoạt động
        // - Toàn bộ dữ liệu trong bảng Sach của database DuLieu_ThuVien hiển thị trên lưới danh sách sách
        private async void frmSach_Load(object sender, EventArgs e)
        {
            SetupFormState();
            SetupDataGridView();
            await LoadDataAsync();
        }

        private void SetupFormState()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void SetupDataGridView()
        {
            dgvSach.AutoGenerateColumns = true;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.MultiSelect = false;
            dgvSach.ReadOnly = true;
            dgvSach.AllowUserToAddRows = false;
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Tải toàn bộ dữ liệu từ bảng Sach
                var list = await _context.Sach
                    .AsNoTracking()
                    .OrderBy(s => s.MaSach)
                    .ToListAsync();

                dgvSach.DataSource = list;

                // Đổi tiêu đề các cột cho rõ ràng và đẹp mắt
                if (dgvSach.Columns["MaSach"] is DataGridViewColumn colMaSach)
                {
                    colMaSach.HeaderText = "Mã sách";
                }
                if (dgvSach.Columns["TenSach"] is DataGridViewColumn colTenSach)
                {
                    colTenSach.HeaderText = "Tên sách";
                }
                if (dgvSach.Columns["GiaTien"] is DataGridViewColumn colGiaTien)
                {
                    colGiaTien.HeaderText = "Giá tiền";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Chỉ cho phép nhập số thực hoặc số nguyên vào textbox giá tiền
        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép các phím điều khiển (như Backspace, Delete)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Cho phép các chữ số từ 0 - 9 (số nguyên)
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Cho phép dấu '.' hoặc ',' biểu diễn số thực (chỉ cho phép 1 dấu)
            if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtGiaTien.Text.Contains('.') && !txtGiaTien.Text.Contains(','))
            {
                return;
            }

            // Chặn tất cả các ký tự không hợp lệ còn lại
            e.Handled = true;
        }

        // Khi bấm vào 1 dòng trên DataGridView: hiển thị thông tin lên TextBox và bật nút Sửa, Xóa
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSach.Rows.Count)
            {
                var row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"]?.Value?.ToString() ?? "";
                txtTenSach.Text = row.Cells["TenSach"]?.Value?.ToString() ?? "";
                txtGiaTien.Text = row.Cells["GiaTien"]?.Value?.ToString() ?? "";

                // Khi đã chọn dòng thì cho phép Sửa và Xóa
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void ResetInputs()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaTien.Clear();
            txtMaSach.Enabled = true;
            SetupFormState();
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            XacNhanThoat();
        }

        // Phím Esc để thoát
        private void frmSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                XacNhanThoat();
            }
        }

        private void XacNhanThoat()
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}