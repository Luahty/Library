using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormChiTietSinhVien : Form
    {
        private DatabaseManager dbManager;

        public FormChiTietSinhVien()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        public void MaSinhVien(string ma)
        {
            string ms = ma;
            dbManager.myconnect();
            string query = $"select * from SinhVien where MaSinhVien = '{ms}'";
            DataTable dt = dbManager.taobang(query);
            foreach (DataRow row in dt.Rows)
            {
                string maSV = row["MaSinhVien"].ToString();
                string tenSV = row["HoTen"].ToString();
                string ns = row["NgaySinh"].ToString();
                DateTime.TryParse(ns, out DateTime ngaySinh);
                string lop = row["Lop"].ToString();
                string mssv = row["MSSV"].ToString();
                labelMaThéV.Text = $"Số thứ tự: {maSV}";
                labelHoTenSV.Text = $"Họ tên sinh viên: {tenSV}";
                labelNgaySinh.Text = $"Ngày sinh: {ngaySinh.ToString("dd/MM/yyyy")}";
                labelLop.Text = $"Lớp: {lop}";
                labelCCCD.Text = $"Mã số sinh viên: {mssv}";
            };
            dbManager.myclose();
        }
    }
}
