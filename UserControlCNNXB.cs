using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlCNNXB : UserControl
    {
        private DatabaseManager dbManager;

        public UserControlCNNXB()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void UserControlCNNXB_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang("SELECT MaNhaXuatBan AS 'Mã nhà xuất bản', TenNhaXuatBan AS 'Tên nhà xuất bản', DiaChi AS 'Địa chỉ' FROM NhaXuatBan");
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
            if (string.IsNullOrEmpty(textBoxTenNXB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string query = $"INSERT INTO NhaXuatBan (TenNhaXuatBan, DiaChi) VALUES (N'{textBoxTenNXB.Text}', N'{textBoxDiaChi.Text}')";
            ExecuteQuery(query, "Thêm");
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaNXB.Text))
            {
                MessageBox.Show("Vui lòng chọn để sửa.");
                return;
            }

            string query = $"UPDATE NhaXuatBan SET TenNhaXuatBan = N'{textBoxTenNXB.Text}', DiaChi = N'{textBoxDiaChi.Text}' WHERE MaNhaXuatBan = '{textBoxMaNXB.Text}'";
            ExecuteQuery(query, "Sửa");
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaNXB.Text))
            {
                MessageBox.Show("Vui lòng chọn để xoá.");
                return;
            }

            string query = $"DELETE FROM NhaXuatBan WHERE MaNhaXuatBan = '{textBoxMaNXB.Text}'";
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
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản để tìm kiếm.");
                return;
            }

            string query = $"SELECT * FROM NhaXuatBan WHERE TenNhaXuatBan COLLATE utf8_general_ci LIKE N'%{textBoxTim.Text}%'";
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang(query);
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhà xuất bản với tên này.", "Không tìm thấy");
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
            textBoxMaNXB.Text = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxTenNXB.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxDiaChi.Text = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
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
            textBoxMaNXB.Clear();
            textBoxTenNXB.Clear();
            textBoxDiaChi.Clear();
            textBoxTim.Clear();
        }
    }
}
