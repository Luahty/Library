using System;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class UserControlThongKe : UserControl
    {
        private UserControlTKSach UserControlTKSach;
        private UserControlTKTheLoai UserControlTKTheLoai;

        public UserControlThongKe()
        {
            InitializeComponent();
            UserControlTKSach = new UserControlTKSach();
            UserControlTKTheLoai = new UserControlTKTheLoai();
        }

        private void ClearAndShowUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelNen.Controls.Clear();
            panelNen.Controls.Add(userControl);
        }

        private void panelNen_Paint(object sender, PaintEventArgs e)
        {
            UserControlTKTheLoai.Dock = DockStyle.Fill;
            panelNen.Controls.Add(UserControlTKTheLoai);
        }

        private void buttonTKTheLoai_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlTKTheLoai);
        }

        private void buttonTKSach_Click(object sender, EventArgs e)
        {
            ClearAndShowUC(UserControlTKSach);
        }
    }
}
