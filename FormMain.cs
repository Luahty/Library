using System;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormMain : Form
    {
        private UserControlDocSach UserControlDocSach;
        private UserControlSach UserControlSach;
        private UserControlSinhVien UserControlSinhVien;
        private UserControlCapNhat UserControlCapNhat;
        private UserControlThongKe UserControlThongKe;

        public FormMain()
        {
            InitializeComponent();
            UserControlDocSach = new UserControlDocSach();
            UserControlSach = new UserControlSach();
            UserControlSinhVien = new UserControlSinhVien();
            UserControlCapNhat = new UserControlCapNhat();
            UserControlThongKe = new UserControlThongKe();
        }

        private void ClearAndShowUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelNen.Controls.Clear();
            panelNen.Controls.Add(userControl);
        }

        private void panelNen_Paint(object sender, PaintEventArgs e)
        {
            UserControlThongKe.Dock = DockStyle.Fill;
            panelNen.Controls.Add(UserControlThongKe);
        }

        private void buttonDocSach_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlDocSach);
        }

        private void buttonXemSach_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlSach);
            UserControlSach.ReloadData();
        }

        private void buttonSinhVien_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlSinhVien);
            UserControlSinhVien.ReloadData();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlCapNhat);
        }
        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlThongKe);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát khỏi toàn bộ ứng dụng
        }
    }
}