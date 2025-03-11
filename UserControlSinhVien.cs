using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlSinhVien : UserControl
    {
        private DatabaseManager dbManager;
        private string baseQuery = "SELECT * FROM SinhVien";

        public UserControlSinhVien()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void UserControlSinhVien_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        public void ReloadData()
        {
            string query = baseQuery;
            displaydata(query);
        }

        private void displaydata(string query)        {
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
                flowLayoutPanel.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Button button = new Button
                    {
                        BackColor = SystemColors.Control,
                        Width = 195,
                        Height = 140,
                        Text = $"{row["MSSV"]}\n\n{row["HoTen"]}"
                    };

                    string maSV = row["MaSinhVien"].ToString();
                    button.Click += (sender, e) => ShowDetail(maSV);

                    flowLayoutPanel.Controls.Add(button);
                }
            }
        }

        private void ShowDetail(string maSinhVien)
        {
            FormChiTietSinhVien ct = new FormChiTietSinhVien();
            ct.MaSinhVien(maSinhVien);
            ct.Show();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTim.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên để tìm kiếm.");
                return;
            }

            string query = $"{baseQuery} WHERE MSSV COLLATE utf8_general_ci LIKE N'%{textBoxTim.Text}%'";
            displaydata(query);
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            ReloadData();
            textBoxTim.Clear();
        }
    }
}
