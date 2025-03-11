using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlCNTacGia : UserControl
    {
        private DatabaseManager dbManager;

        public UserControlCNTacGia()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void UserControlCNTacGia_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang("SELECT MaTacGia AS 'Mã tác giả', TenTacGia AS 'Tên tác giả', NgaySinh AS 'Ngày sinh', QuocGia AS 'Quốc gia' FROM TacGia");
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

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string tenTacGia, out DateTime ngaySinh, out string quocGia))
            {
                string query = $"INSERT INTO TacGia (TenTacGia, NgaySinh, QuocGia) " +
                               $"VALUES (N'{tenTacGia}', '{ngaySinh:yyyy-MM-dd}', N'{quocGia}')";
                ExecuteQuery(query, "Thêm");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaTacGia.Text))
            {
                MessageBox.Show("Vui lòng chọn tác giả để sửa.");
                return;
            }

            if (ValidateInput(out string tenTacGia, out DateTime ngaySinh, out string quocGia))
            {
                string query = $"UPDATE TacGia SET TenTacGia=N'{tenTacGia}', NgaySinh='{ngaySinh:yyyy-MM-dd}', " +
                               $"QuocGia=N'{quocGia}' WHERE MaTacGia='{textBoxMaTacGia.Text}'";
                ExecuteQuery(query, "Sửa");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaTacGia.Text))
            {
                MessageBox.Show("Vui lòng chọn tác giả để xoá.");
                return;
            }

            string query = $"DELETE FROM TacGia WHERE MaTacGia='{textBoxMaTacGia.Text}'";
            ExecuteQuery(query, "Xoá");
        }

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTim.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả để tìm kiếm.");
                return;
            }

            string query = $"SELECT * FROM TacGia WHERE TenTacGia COLLATE utf8_general_ci LIKE N'%{textBoxTim.Text}%'";
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang(query);
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tác giả với tên này.", "Không tìm thấy");
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

        private bool ValidateInput(out string tenTacGia, out DateTime ngaySinh, out string quocGia)
        {
            tenTacGia = textBoxTenTacGia.Text;
            quocGia = textBoxQuocGia.Text;

            if (string.IsNullOrEmpty(tenTacGia) || string.IsNullOrEmpty(textBoxNgaySinh.Text) || string.IsNullOrEmpty(quocGia))
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

            return true;
        }

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

        private void cleardata()
        {
            textBoxMaTacGia.Clear();
            textBoxTenTacGia.Clear();
            textBoxNgaySinh.Clear();
            textBoxQuocGia.Clear();
            textBoxTim.Clear();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxMaTacGia.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxTenTacGia.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxNgaySinh.Text = Convert.ToDateTime(dataGridView.Rows[e.RowIndex].Cells[2].Value).ToString("dd/MM/yyyy");
                textBoxQuocGia.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
