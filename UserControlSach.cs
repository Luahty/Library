using System;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlSach : UserControl
    {
        private DatabaseManager dbManager;
        private string baseQuery = @"
            SELECT DISTINCT sh.MaSach, sh.TenSach, sh.UrlBiaSach, tg.TenTacGia 
            FROM Sach sh 
            JOIN TacGia tg ON sh.MaTacGia = tg.MaTacGia";

        private readonly HttpClient httpClient = new HttpClient();

        public UserControlSach()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private async void UserControlSach_Load(object sender, EventArgs e)
        {
            await ReloadData();
        }

        public async Task ReloadData()
        {
            string query = baseQuery;
            await DisplayDataAsync(query);
            textBoxTim.Clear();
        }

        private async Task DisplayDataAsync(string query)
        {
            DataTable dt = null;

            try
            {
                dbManager.myconnect();
                dt = dbManager.taobang(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu: " + ex.Message);
            }
            finally
            {
                dbManager.myclose();
            }

            if (dt != null)
            {
                // Clear the UI on the main thread
                flowLayoutPanel.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Button button = new Button
                    {
                        Width = 195,
                        Height = 330,
                        Text = $"{row["TenSach"]}",
                        TextAlign = ContentAlignment.BottomCenter,
                        ImageAlign = ContentAlignment.TopCenter,
                        TextImageRelation = TextImageRelation.ImageAboveText
                    };

                    string maS = row["MaSach"].ToString();
                    string urlBiaSach = row["UrlBiaSach"].ToString();
                    string imageUrl = $"https://s3.tebi.io/librarymn/book/{urlBiaSach}.jpg";

                    // Load image asynchronously and update UI
                    var image = await LoadImageAsync(imageUrl);
                    this.Invoke((Action)(() => button.Image = image));

                    button.Click += (sender, e) => ShowDetail(maS);

                    // Add buttons to the flowLayoutPanel on the main thread
                    this.Invoke((Action)(() => flowLayoutPanel.Controls.Add(button)));
                }
            }
        }

        private async Task<Image> LoadImageAsync(string imageUrl)
        {
            try
            {
                byte[] imageData = await httpClient.GetByteArrayAsync(imageUrl);
                using (var stream = new System.IO.MemoryStream(imageData))
                {
                    return Image.FromStream(stream);
                }
            }
            catch (Exception)
            {
                // Return a default image on error
                return Properties.Resources.DefaultImage;
            }
        }

        private void ShowDetail(string maSach)
        {
            FormChiTietSach ct = new FormChiTietSach();
            ct.MaSach(maSach);
            ct.Show();
        }

        private async void buttonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTim.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách để tìm kiếm.");
                return;
            }

            string query = $"{baseQuery} AND TenSach COLLATE utf8_general_ci LIKE '%{textBoxTim.Text}%'";
            await DisplayDataAsync(query);
        }

        private async void buttonLamMoi_Click(object sender, EventArgs e)
        {
            await ReloadData();
        }
    }
}
