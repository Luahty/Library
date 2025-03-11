using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlDocSach : UserControl
    {
        private DatabaseManager dbManager;

        public UserControlDocSach()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void UserControlDocSach_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            try
            {
                dbManager.myconnect();
                string query = @"
                SELECT 
                    ds.MaDocSach AS 'Mã đọc sách', 
                    sv.MSSV AS 'MSSV', 
                    ds.MaDauSach AS 'Mã đầu sách', 
                    ds.GhiChu AS 'Ghi chú',
                    ds.GioDoc AS 'Giờ đọc', 
                    ts.GioTra AS 'Giờ trả', 
                    ts.DaTra AS 'Đã trả'
                FROM 
                    DocSach ds
                LEFT JOIN 
                    TraSach ts ON ds.MaDocSach = ts.MaDocSach
                LEFT JOIN 
                    SinhVien sv ON ds.MaSinhVien = sv.MaSinhVien
                ORDER BY 
                    ds.GioDoc DESC";
                DataTable dt = dbManager.taobang(query);
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

        private void buttonDocSach_Click(object sender, EventArgs e)
        {
            DateTime gioDoc = DateTime.Now;

            if (string.IsNullOrEmpty(textBoxMSSV.Text) || string.IsNullOrEmpty(textBoxMaDauSach.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV và mã đầu sách.");
                return;
            }

            try
            {
                dbManager.myconnect();

                // Get MaSinhVien using MSSV
                string querySinhVien = $"SELECT MaSinhVien FROM SinhVien WHERE MSSV = '{int.Parse(textBoxMSSV.Text)}'";
                DataTable svTable = dbManager.taobang(querySinhVien);

                if (svTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên với MSSV này.");
                    return;
                }

                int maSinhVien = Convert.ToInt32(svTable.Rows[0][0]);
                string queryDocSach = $"INSERT INTO DocSach (MaSinhVien, MaDauSach, GioDoc, GhiChu) VALUES ('{maSinhVien}', '{int.Parse(textBoxMaDauSach.Text)}', '{gioDoc.ToString("yyyy-MM-dd HH:mm:ss")}', N'{textBoxGhiChu.Text}')";

                // Thêm dữ liệu vào DocSach
                dbManager.ExecuteNonQuery(queryDocSach);

                // Lấy MaDocSach vừa thêm
                int maDocSach = Convert.ToInt32(dbManager.taobang("SELECT LAST_INSERT_ID()").Rows[0][0]);

                // Thêm dữ liệu vào TraSach
                string queryTraSach = $"INSERT INTO TraSach (MaDocSach, DaTra) VALUES ({maDocSach}, 0)";
                dbManager.ExecuteNonQuery(queryTraSach);

                cleardata();
                displaydata();
                MessageBox.Show("Thêm thành công", "Thêm");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaDocSach.Text))
            {
                MessageBox.Show("Vui lòng chọn để sửa.");
                return;
            }

            if (!ValidateInput(out DateTime gioDoc))
                return;

            try
            {
                dbManager.myconnect();

                // Get MaSinhVien using MSSV
                string querySinhVien = $"SELECT MaSinhVien FROM SinhVien WHERE MSSV = '{int.Parse(textBoxMSSV.Text)}'";
                DataTable svTable = dbManager.taobang(querySinhVien);

                if (svTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên với MSSV này.");
                    return;
                }

                int maSinhVien = Convert.ToInt32(svTable.Rows[0][0]);

                string query = $"UPDATE DocSach SET MaSinhVien = '{maSinhVien}', MaDauSach = '{textBoxMaDauSach.Text}', GioDoc = '{gioDoc.ToString("yyyy-MM-dd HH:mm:ss")}', GhiChu = N'{textBoxGhiChu.Text}' WHERE MaDocSach = '{textBoxMaDocSach.Text}'";
                ExecuteQuery(query, "Cập nhật");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }
        }

        private void buttonTraSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaDocSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách để trả.");
                return;
            }

            try
            {
                dbManager.myconnect();

                // Cập nhật ngày trả và trạng thái trả sách
                string queryTraSach = $"UPDATE TraSach SET GioTra = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', DaTra = 1 WHERE MaDocSach = '{textBoxMaDocSach.Text}'";
                dbManager.ExecuteNonQuery(queryTraSach);

                displaydata();
                MessageBox.Show("Trả sách thành công", "Trả sách");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trả sách: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }
        }

        private void buttonMoi_Click(object sender, EventArgs e)
        {
            displaydata();
            cleardata();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTim.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV để tìm kiếm.");
                return;
            }

            string query = $@"
            SELECT 
                ds.MaDocSach AS 'Mã đọc sách', 
                sv.MSSV AS 'MSSV', 
                ds.MaDauSach AS 'Mã đầu sách', 
                ds.GioDoc AS 'Giờ đọc', 
                ds.GhiChu AS 'Ghi chú',
                ts.GioTra AS 'Ngày trả', 
                ts.DaTra AS 'Đã trả'
            FROM 
                DocSach ds
            LEFT JOIN 
                TraSach ts ON ds.MaDocSach = ts.MaDocSach
            LEFT JOIN 
                SinhVien sv ON ds.MaSinhVien = sv.MaSinhVien
            WHERE 
                sv.MSSV LIKE '%{textBoxTim.Text}%'";

            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang(query);
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên với MSSV này.", "Không tìm thấy");
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

        private bool ValidateInput(out DateTime gioDoc)
        {
            gioDoc = DateTime.MinValue;

            if (string.IsNullOrEmpty(textBoxMSSV.Text) || string.IsNullOrEmpty(textBoxMaDauSach.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV và mã đầu sách.");
                return false;
            }

            if (!DateTime.TryParse(textBoxGioVao.Text, out gioDoc))
            {
                MessageBox.Show("Ngày giờ không hợp lệ.");
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
            textBoxMaDocSach.Clear();
            textBoxMSSV.Clear();
            textBoxMaDauSach.Clear();
            textBoxGioVao.Clear();
            textBoxGhiChu.Clear();
            textBoxTim.Clear();
        }

        private void addtext(int rowIndex)
        {
            textBoxMaDocSach.Text = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxMSSV.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxMaDauSach.Text = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();

            if (DateTime.TryParse(dataGridView.Rows[rowIndex].Cells[4].Value.ToString(), out DateTime gioDoc))
            {
                textBoxGioVao.Text = gioDoc.ToString("yyyy-MM-dd HH:mm:ss");
            }

            textBoxGhiChu.Text = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
