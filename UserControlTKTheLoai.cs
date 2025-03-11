using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;


namespace QuanLyThuVien
{
    public partial class UserControlTKTheLoai : UserControl
    {
        private DatabaseManager dbManager;
        private string hoTen;
        private string tenSach;
        private string tenTheLoai;
        private string tenTacGia;
        private string gioVao;
        private string ghiChu;
        private string tenNhaXuatBan;
        private string baseQuery = @"
            SELECT  sv.HoTen AS 'Họ và tên', 
                    s.TenSach AS 'Tên sách', 
                    tl.TenTheLoai AS 'Thể loại', 
                    tg.TenTacGia AS 'Tác giả', 
                    nxb.TenNhaXuatBan AS 'Nhà xuất bản', 
                    md.GioDoc AS 'Giờ đọc', 
                    md.GhiChu AS 'Ghi chú' 
            FROM DocSach md 
            JOIN SinhVien sv ON md.MaSinhVien = sv.MaSinhVien 
            JOIN DauSach ds ON md.MaDauSach = ds.MaDauSach 
            JOIN Sach s ON ds.MaSach = s.MaSach 
            JOIN TheLoai tl ON s.MaTheLoai = tl.MaTheLoai 
            JOIN TacGia tg ON s.MaTacGia = tg.MaTacGia 
            JOIN NhaXuatBan nxb ON s.MaNhaXuatBan = nxb.MaNhaXuatBan";

        public UserControlTKTheLoai()
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
                SELECT  tl.TenTheLoai AS TheLoai, 
                        COUNT(md.MaDocSach) AS SoLuongDoc
                FROM DocSach md
                JOIN Sach ds ON md.MaDauSach = ds.MaSach
                JOIN TheLoai tl ON ds.MaTheLoai = tl.MaTheLoai
                GROUP BY tl.TenTheLoai
                ORDER BY SoLuongDoc DESC";

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

                Series pieSeries = new Series("Số người đọc");
                pieSeries.ChartType = SeriesChartType.Pie;
                chart1.Series.Add(pieSeries);

                // Thêm dữ liệu vào biểu đồ tròn
                foreach (DataRow row in dt.Rows)
                {
                    string theLoai = row["TheLoai"].ToString();
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
                DataTable dt = dbManager.taobang(baseQuery);
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
                MessageBox.Show("Vui lòng nhập tên sinh viên để tìm kiếm.");
                return;
            }

            string query = $"{baseQuery} AND HoTen COLLATE utf8_general_ci LIKE '%{textBoxTim.Text}%'";
            try
            {
                dbManager.myconnect();
                DataTable dt = dbManager.taobang(query);
                dataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên với tên này.", "Không tìm thấy");
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
            hoTen = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            tenSach = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            tenTheLoai = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            tenTacGia = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            tenNhaXuatBan = dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            if (DateTime.TryParse(dataGridView.Rows[rowIndex].Cells[5].Value.ToString(), out DateTime hVao))
            {
                gioVao = hVao.ToString("HH:mm dd/MM/yyyy");
            }
            ghiChu = dataGridView.Rows[rowIndex].Cells[6].Value.ToString();

            // Truy vấn thêm thông tin MSSV, Lớp, Số lần đọc sách, và thể loại yêu thích
            string querySinhVien = @"
                SELECT sv.MSSV AS 'MSSV',
                       sv.Lop AS 'Lớp',
                       COUNT(md.MaDocSach) AS 'Số lần đọc sách',
                       (SELECT tl.TenTheLoai 
                        FROM DocSach md2 
                        JOIN DauSach ds2 ON md2.MaDauSach = ds2.MaDauSach 
                        JOIN Sach s2 ON ds2.MaSach = s2.MaSach 
                        JOIN TheLoai tl ON s2.MaTheLoai = tl.MaTheLoai 
                        WHERE md2.MaSinhVien = sv.MaSinhVien 
                        GROUP BY tl.TenTheLoai 
                        ORDER BY COUNT(md2.MaDocSach) DESC 
                        LIMIT 1) AS 'Thể loại yêu thích'
                FROM SinhVien sv
                JOIN DocSach md ON sv.MaSinhVien = md.MaSinhVien
                WHERE sv.HoTen = @HoTen
                GROUP BY sv.MaSinhVien, sv.Lop";

            try
            {
                dbManager.myconnect();
                DataTable dtSinhVien = dbManager.taobang(querySinhVien, new MySqlParameter("@HoTen", hoTen));

                if (dtSinhVien.Rows.Count > 0)
                {
                    DataRow row = dtSinhVien.Rows[0];
                    string mssv = row["MSSV"].ToString();
                    string lop = row["Lớp"].ToString();
                    string soLanDoc = row["Số lần đọc sách"].ToString();
                    string theLoaiYeuThich = row["Thể loại yêu thích"].ToString();

                    // Hiển thị thông tin trên các label
                    labelHoTen.Text = $"Họ và tên: {hoTen}";
                    labelMssv.Text = $"MSSV: {mssv}";
                    labelLop.Text = $"Lớp: {lop}";
                    labelSlDoc.Text = $"Số lần đọc sách: {soLanDoc}";
                    labelTLYThich.Text = $"Thể loại yêu thích: {theLoaiYeuThich}";
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
            labelHoTen.Text = "Họ và tên: (chọn sv trong bảng)";
            labelMssv.Text = "MSSV: trống";
            labelLop.Text = "Lớp: trống";
            labelSlDoc.Text = "Số lần đọc sách: trống";
            labelTLYThich.Text = "Thể loại yêu thích: trống";
            textBoxTim.Clear();
        }
    }
}
