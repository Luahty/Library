using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;


namespace QuanLyThuVien
{
    public partial class UserControlTKSach : UserControl
    {
        private DatabaseManager dbManager;
        private string tenSach;
        private string tenTheLoai;
        private string tenTacGia;
        private string tenNhaXuatBan;
        private string soNguoiDoc;
        private string baseQuery = @"
            SELECT  s.TenSach AS 'Tên sách', 
                    tl.TenTheLoai AS 'Thể loại', 
                    tg.TenTacGia AS 'Tác giả', 
                    nxb.TenNhaXuatBan AS 'Nhà xuất bản', 
                    COUNT(md.MaDocSach) AS 'Số lần đọc' 
            FROM DocSach md 
            JOIN DauSach ds ON md.MaDauSach = ds.MaDauSach 
            JOIN Sach s ON ds.MaSach = s.MaSach 
            JOIN TheLoai tl ON s.MaTheLoai = tl.MaTheLoai 
            JOIN TacGia tg ON s.MaTacGia = tg.MaTacGia 
            JOIN NhaXuatBan nxb ON s.MaNhaXuatBan = nxb.MaNhaXuatBan";

        public UserControlTKSach()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void UserControlMuonDoc_Load(object sender, EventArgs e)
        {
            displaydata();  // Hiển thị dữ liệu
            LoadChartData();  // Tải dữ liệu biểu đồ
            cleardata();
        }
        private void LoadChartData()
        {
            // Truy vấn để lấy số lượng sách theo thể loại
            string query = @"
                SELECT ds.TenSach, COUNT(md.MaDocSach) AS SoLuongDoc
                FROM DocSach md 
                JOIN Sach ds ON md.MaDauSach = ds.MaSach 
                GROUP BY ds.TenSach 
                ORDER BY SoLuongDoc DESC
                LIMIT 5";

            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang(query);

                // Kiểm tra dữ liệu
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị biểu đồ.");
                    return;
                }

                // Cấu hình biểu đồ tròn
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                chart1.ChartAreas.Add(new ChartArea("MainArea"));

                Series pieSeries = new Series("Số lần đọc");
                pieSeries.ChartType = SeriesChartType.Column;
                chart1.Series.Add(pieSeries);

                // Thêm dữ liệu vào biểu đồ tròn
                foreach (DataRow row in dt.Rows)
                {
                    string theLoai = row["TenSach"].ToString();
                    int soLuongDoc = Convert.ToInt32(row["SoLuongDoc"]);
                    pieSeries.Points.AddXY(theLoai, soLuongDoc);
                }

                // Hiển thị giá trị trực tiếp trên biểu đồ tròn
                pieSeries.IsValueShownAsLabel = true;

                // Làm mới biểu đồ
                chart1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu biểu đồ: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }
        }

        private void displaydata()
        {
            try
            {
                dbManager.myconnect();
                string query = $"{baseQuery} GROUP BY s.TenSach ORDER BY COUNT(md.MaDocSach) DESC";
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

        private void buttonXem_Click(object sender, EventArgs e)
        {
            displaydata();  // Hiển thị dữ liệu
            LoadChartData();  // Tải dữ liệu biểu đồ
            cleardata();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTim.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách để tìm kiếm.");
                return;
            }

            string query = $"{baseQuery} AND s.TenSach COLLATE utf8_general_ci LIKE '%{textBoxTim.Text}%' GROUP BY s.TenSach ORDER BY COUNT(md.MaDocSach) DESC";
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

                LoadChartData();
            }
        }

        private void addtext(int rowIndex)
        {
            tenSach = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            tenTheLoai = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            tenTacGia = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            tenNhaXuatBan = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            soNguoiDoc = dataGridView.Rows[rowIndex].Cells[4].Value.ToString();

            // Truy vấn thêm thông tin MSSV, Lớp, Số lần đọc sách, và thể loại yêu thích
            string querySach = baseQuery;

            try
            {
                dbManager.myconnect();
                DataTable dtSach = dbManager.taobang(querySach, new MySqlParameter("@TenSach", tenSach));

                if (dtSach.Rows.Count > 0)
                {

                    // Hiển thị thông tin trên các label
                    labelTenSach.Text = $"Tên sách: {tenSach}";
                    labelTacGia.Text = $"Tác giả: {tenTacGia}";
                    labelTheLoai.Text = $"Thể loại: {tenTheLoai}";
                    labelNhaXuatBan.Text = $"Nhà xuất bản: {tenNhaXuatBan}";
                    labelSoNguoiDoc.Text = $"Số lần đọc: {soNguoiDoc}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin sinh viên: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }
        }
        private void cleardata()
        {
            labelTenSach.Text = "Tên sách: (chọn sách trong bảng)";
            labelTacGia.Text = "Tác giả: trống";
            labelTheLoai.Text = "Thể loại: trống";
            labelNhaXuatBan.Text = "Nhà xuất bản: trống";
            labelSoNguoiDoc.Text = "Số lần đọc: trống";
            textBoxTim.Clear();
;        }
    }
}
