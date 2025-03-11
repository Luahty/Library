using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlCNSinhVien : UserControl
    {
        private DatabaseManager dbManager;

        public UserControlCNSinhVien()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void UserControlCNSinhVien_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        // Hiển thị dữ liệu từ bảng TheSinhVien
        private void displaydata()
        {
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang("SELECT MaSinhVien AS 'Số thứ tự', HoTen AS 'Họ và tên', NgaySinh AS 'Ngày sinh', Lop AS 'Lớp', MSSV AS 'Mã số sinh viên' FROM SinhVien");
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }
        }

        // Thêm sinh viên mới
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string hoTen, out DateTime ngaySinh, out string lop, out int mssv))
            {
                string query = $"INSERT INTO SinhVien (HoTen, NgaySinh, Lop, MSSV) " +
                               $"VALUES (N'{hoTen}', '{ngaySinh:yyyy-MM-dd}', N'{lop}', {mssv})";
                ExecuteQuery(query, "Thêm");
            }
        }

        // Cập nhật thông tin sinh viên
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaSinhVien.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.");
                return;
            }

            if (ValidateInput(out string hoTen, out DateTime ngaySinh, out string lop, out int mssv))
            {
                string query = $"UPDATE SinhVien SET HoTen=N'{hoTen}', NgaySinh='{ngaySinh:yyyy-MM-dd}', " +
                               $"Lop=N'{lop}', MSSV={mssv} WHERE MaTheSV={textBoxMaSinhVien.Text}";
                ExecuteQuery(query, "Sửa");
            }
        }

        // Xóa sinh viên
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaSinhVien.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xoá.");
                return;
            }

            string query = $"DELETE FROM SinhVien WHERE MaSinhVien={textBoxMaSinhVien.Text}";
            ExecuteQuery(query, "Xoá");
        }

        // Làm mới dữ liệu
        private void buttonMoi_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        // Tìm sinh viên theo họ tên
        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTim.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên để tìm kiếm.");
                return;
            }

            string query = $"SELECT * FROM SinhVien WHERE MSSV COLLATE utf8_general_ci LIKE N'%{textBoxTim.Text}%'";
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang(query);
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên này.", "Không tìm thấy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }
        }

        // Kiểm tra và lấy dữ liệu từ các textbox
        private bool ValidateInput(out string hoTen, out DateTime ngaySinh, out string lop, out int mssv)
        {
            hoTen = textBoxHoTen.Text;
            lop = textBoxLop.Text;
            mssv = 0;

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(textBoxNgaySinh.Text) ||
                string.IsNullOrEmpty(lop) || string.IsNullOrEmpty(textBoxMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                ngaySinh = DateTime.MinValue;
                return false;
            }

            if (!DateTime.TryParseExact(textBoxNgaySinh.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng dd/MM/yyyy.");
                return false;
            }

            if (!int.TryParse(textBoxMSSV.Text, out mssv))
            {
                MessageBox.Show("MSSV phải là số hợp lệ.");
                return false;
            }

            return true;
        }

        // Thực thi câu lệnh SQL và hiển thị thông báo
        private void ExecuteQuery(string query, string action)
        {
            try
            {
                dbManager.myconnect();
                dbManager.ExecuteNonQuery(query);
                cleardata();
                displaydata();
                MessageBox.Show($"{action} thành công", action);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi {action.ToLower()}: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }
        }

        // Xoá dữ liệu trong các textbox
        private void cleardata()
        {
            textBoxMaSinhVien.Clear();
            textBoxHoTen.Clear();
            textBoxNgaySinh.Clear();
            textBoxLop.Clear();
            textBoxMSSV.Clear();
            textBoxTim.Clear();
        }

        // Khi nhấn vào một ô trong DataGridView, hiển thị dữ liệu lên các textbox
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxMaSinhVien.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxHoTen.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxNgaySinh.Text = Convert.ToDateTime(dataGridView.Rows[e.RowIndex].Cells[2].Value).ToString("dd/MM/yyyy");
                textBoxLop.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxMSSV.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
