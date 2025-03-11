using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlCNTheLoai : UserControl
    {
        private DatabaseManager dbManager;

        public UserControlCNTheLoai()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void UserControlCNTheLoai_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang("SELECT MaTheLoai AS 'Mã thể loại', TenTheLoai AS 'Tên thể loại', MoTa AS 'Mô tả' FROM TheLoai");
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
            if (ValidateInput(out string tenTheLoai, out string moTa))
            {
                string query = $"INSERT INTO TheLoai (TenTheLoai, MoTa) VALUES (N'{tenTheLoai}', N'{moTa}')";
                ExecuteQuery(query, "Thêm");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaTheLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn thể loại để sửa.");
                return;
            }

            if (ValidateInput(out string tenTheLoai, out string moTa))
            {
                string query = $"UPDATE TheLoai SET TenTheLoai=N'{tenTheLoai}', MoTa=N'{moTa}' WHERE MaTheLoai='{textBoxMaTheLoai.Text}'";
                ExecuteQuery(query, "Sửa");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaTheLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn thể loại để xoá.");
                return;
            }

            string query = $"DELETE FROM TheLoai WHERE MaTheLoai='{textBoxMaTheLoai.Text}'";
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
                MessageBox.Show("Vui lòng nhập tên thể loại để tìm kiếm.");
                return;
            }

            string query = $"SELECT * FROM TheLoai WHERE TenTheLoai COLLATE utf8_general_ci LIKE N'%{textBoxTim.Text}%'";
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang(query);
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thể loại với tên này.", "Không tìm thấy");
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

        private bool ValidateInput(out string tenTheLoai, out string moTa)
        {
            tenTheLoai = textBoxTenTheLoai.Text;
            moTa = textBoxMoTa.Text;

            if (string.IsNullOrEmpty(tenTheLoai) || string.IsNullOrEmpty(moTa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
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
            textBoxMaTheLoai.Clear();
            textBoxTenTheLoai.Clear();
            textBoxMoTa.Clear();
            textBoxTim.Clear();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxMaTheLoai.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxTenTheLoai.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxMoTa.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
