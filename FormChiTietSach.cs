using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormChiTietSach : Form
    {
        private DatabaseManager dbManager;

        public FormChiTietSach()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        public void MaSach(string ma)
        {
            string ms = ma;
            dbManager.myconnect();
            string query = $"SELECT sh.MaSach, TenSach, tl.TenTheLoai, tg.TenTacGia, nxb.TenNhaXuatBan, NamXuatBan, UrlBiaSach FROM Sach sh, TacGia tg, NhaXuatBan nxb, TheLoai tl WHERE sh.MaTacGia = tg.MaTacGia AND sh.MaNhaXuatBan = nxb.MaNhaXuatBan AND tl.MaTheLoai = sh.MaTheLoai AND MaSach = '{ms}'";
            DataTable dt = dbManager.taobang(query);
            foreach (DataRow row in dt.Rows)
            {
                string maS = row["MaSach"].ToString();
                string tenS = row["TenSach"].ToString();
                string tg = row["TenTacGia"].ToString();
                string tl = row["TenTheLoai"].ToString();
                string nxb = row["TenNhaXuatBan"].ToString();
                string namxb = row["NamXuatBan"].ToString();
                string urlBiaSach = row["UrlBiaSach"].ToString();
                string imageUrl = $"https://s3.tebi.io/librarymn/book/{urlBiaSach}.jpg";

                // Cập nhật thông tin chi tiết
                labelMaSach.Text = $"Mã sách: {maS}";
                labelTenSach.Text = $"Tên sách: {tenS}";
                labelTacGia.Text = $"Tác giả: {tg}";
                labelTheLoai.Text = $"Thể loại: {tl}";
                labelNhaXuatBan.Text = $"Nhà xuất bản: {nxb}";
                labelNamXuatBan.Text = $"Năm xuất bản: {namxb}";

                // Hiển thị ảnh vào PictureBox
                DisplayImage(imageUrl);
            }
            dbManager.myclose();
        }

        private void DisplayImage(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(url);
                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        pictureBoxUrl.Image = Image.FromStream(stream);  // Gán ảnh vào PictureBox
                        pictureBoxUrl.SizeMode = PictureBoxSizeMode.StretchImage;  // Đảm bảo ảnh hiển thị vừa khít PictureBox
                    }
                }
            }
            catch (Exception)
            {
                // Trả về ảnh gốc (ảnh mặc định) khi có lỗi
                pictureBoxUrl.Image = Properties.Resources.DefaultImage;  // Gán ảnh mặc định từ Resources
                pictureBoxUrl.SizeMode = PictureBoxSizeMode.StretchImage;  // Đảm bảo ảnh mặc định cũng hiển thị vừa khít
            }
        }
    }
}
