using System;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlCapNhat : UserControl
    {
        private UserControlCNSach UserControlCNSach;
        private UserControlCNTheLoai UserControlCNTheLoai;
        private UserControlCNNXB UserControlCNNXB;
        private UserControlCNTacGia UserControlCNTacGia;
        private UserControlCNSinhVien UserControlCNSinhVien;

        public UserControlCapNhat()
        {
            InitializeComponent();
            UserControlCNSach = new UserControlCNSach();
            UserControlCNTheLoai = new UserControlCNTheLoai();
            UserControlCNNXB = new UserControlCNNXB();
            UserControlCNTacGia = new UserControlCNTacGia();
            UserControlCNSinhVien = new UserControlCNSinhVien();
        }

        private void ClearAndShowUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelNen.Controls.Clear();
            panelNen.Controls.Add(userControl);
        }

        private void panelNen_Paint(object sender, PaintEventArgs e)
        {
            UserControlCNSach.Dock = DockStyle.Fill;
            panelNen.Controls.Add(UserControlCNSach);
        }

        private void buttonSach_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlCNSach);
        }

        private void buttonTheLoai_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlCNTheLoai);
        }

        private void buttonNXB_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlCNNXB);
        }

        private void buttonTacGia_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlCNTacGia);
        }

        private void buttonSinhVien_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlCNSinhVien);
        }
    }
}
