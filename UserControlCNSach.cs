using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlCNSach : UserControl
    {
        private string maS;
        private DatabaseManager dbManager;

        public UserControlCNSach()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void UserControlCNSach_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang("SELECT MaSach AS 'Mã sách', TenSach AS 'Tên sách', NamXuatBan AS 'Năm xuất bản', MaTheLoai AS 'Mã thể loại', MaNhaXuatBan AS 'Mã nhà xuất bản', MaTacGia AS 'Mã tác giả', UrlBiaSach AS 'Url ảnh bìa' FROM Sach");
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
            if (!ValidateBookInput(out int maTheLoai, out int maNhaXuatBan, out int maTacGia))
                return;

            string query = $"INSERT INTO Sach (TenSach, NamXuatBan, MaTheLoai, MaNhaXuatBan, MaTacGia, UrlBiaSach) " +
                           $"VALUES (N'{textBoxTenSach.Text}', N'{textBoxNamXuatBan.Text}', '{maTheLoai}', " +
                           $"'{maNhaXuatBan}', '{maTacGia}', '{textBoxUrlBiaSach.Text}')";

            ExecuteQuery(query, "Thêm");
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maS))
            {
                MessageBox.Show("Vui lòng chọn để sửa.");
                return;
            }

            if (!ValidateBookInput(out int maTheLoai, out int maNhaXuatBan, out int maTacGia))
                return;

            string query = $"UPDATE Sach SET TenSach=N'{textBoxTenSach.Text}', NamXuatBan=N'{textBoxNamXuatBan.Text}', " +
                           $"MaTheLoai='{maTheLoai}', MaNhaXuatBan='{maNhaXuatBan}', MaTacGia='{maTacGia}', UrlBiaSach='{textBoxUrlBiaSach.Text}'" +
                           $"WHERE MaSach='{maS}'";

            ExecuteQuery(query, "Sửa");
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maS))
            {
                MessageBox.Show("Vui lòng chọn để xoá.");
                return;
            }

            string query = $"DELETE FROM Sach WHERE MaSach = '{maS}'";
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
                MessageBox.Show("Vui lòng nhập tên sách để tìm kiếm.");
                return;
            }

            string query = $"SELECT * FROM Sach WHERE TenSach COLLATE utf8_general_ci LIKE N'%{textBoxTim.Text}%'";

            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang(query);
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách với tên này.", "Không tìm thấy");
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedRow = e.RowIndex;
                addtext(selectedRow);
            }
        }

        private void addtext(int rowIndex)
        {
            textBoxTenSach.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxTacGia.Text = dataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxNamXuatBan.Text = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxMaTheLoai.Text = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxMaNhaXuatBan.Text = dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxUrlBiaSach.Text = dataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            maS = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private bool ValidateBookInput(out int maTheLoai, out int maNhaXuatBan, out int maTacGia)
        {
            maTheLoai = 0;
            maNhaXuatBan = 0;
            maTacGia = 0;

            if (string.IsNullOrEmpty(textBoxTacGia.Text) || string.IsNullOrEmpty(textBoxNamXuatBan.Text) ||
                string.IsNullOrEmpty(textBoxMaTheLoai.Text) || string.IsNullOrEmpty(textBoxMaNhaXuatBan.Text) ||
                string.IsNullOrEmpty(textBoxTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            if (!int.TryParse(textBoxMaTheLoai.Text, out maTheLoai) ||
                !int.TryParse(textBoxMaNhaXuatBan.Text, out maNhaXuatBan) ||
                !int.TryParse(textBoxTacGia.Text, out maTacGia))
            {
                MessageBox.Show("Mã thể loại, nhà xuất bản, hoặc tác giả không hợp lệ.");
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
            textBoxTenSach.Clear();
            textBoxTacGia.Clear();
            textBoxNamXuatBan.Clear();
            textBoxMaTheLoai.Clear();
            textBoxMaNhaXuatBan.Clear();
            textBoxUrlBiaSach.Clear();
            textBoxTim.Clear();
        }
    }
}
