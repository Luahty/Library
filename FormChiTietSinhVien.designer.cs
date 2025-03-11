using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class FormChiTietSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMaThéV = new System.Windows.Forms.Label();
            this.labelHoTenSV = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.labelCCCD = new System.Windows.Forms.Label();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panelNoiDung = new System.Windows.Forms.Panel();
            this.roundedCornerTieuDe = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerNoiDung = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTieuDe.SuspendLayout();
            this.panelNoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaThéV
            // 
            this.labelMaThéV.AutoSize = true;
            this.labelMaThéV.Location = new System.Drawing.Point(22, 30);
            this.labelMaThéV.Name = "labelMaThéV";
            this.labelMaThéV.Size = new System.Drawing.Size(94, 28);
            this.labelMaThéV.TabIndex = 0;
            this.labelMaThéV.Text = "Số thứ tự";
            // 
            // labelHoTenSV
            // 
            this.labelHoTenSV.AutoSize = true;
            this.labelHoTenSV.Location = new System.Drawing.Point(22, 90);
            this.labelHoTenSV.Name = "labelHoTenSV";
            this.labelHoTenSV.Size = new System.Drawing.Size(152, 28);
            this.labelHoTenSV.TabIndex = 1;
            this.labelHoTenSV.Text = "Họ tên sinh viên";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(22, 150);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(99, 28);
            this.labelNgaySinh.TabIndex = 2;
            this.labelNgaySinh.Text = "Ngày sinh";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Location = new System.Drawing.Point(22, 210);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(45, 28);
            this.labelLop.TabIndex = 3;
            this.labelLop.Text = "Lớp";
            // 
            // labelCCCD
            // 
            this.labelCCCD.AutoSize = true;
            this.labelCCCD.Location = new System.Drawing.Point(22, 270);
            this.labelCCCD.Name = "labelCCCD";
            this.labelCCCD.Size = new System.Drawing.Size(146, 28);
            this.labelCCCD.TabIndex = 4;
            this.labelCCCD.Text = "Mã số sinh viên";
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.White;
            this.panelTieuDe.Controls.Add(this.labelTieuDe);
            this.panelTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.panelTieuDe.Location = new System.Drawing.Point(7, 7);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(473, 58);
            this.panelTieuDe.TabIndex = 6;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Location = new System.Drawing.Point(130, 10);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(258, 38);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "Thông tin sinh viên";
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.BackColor = System.Drawing.Color.White;
            this.panelNoiDung.Controls.Add(this.labelMaThéV);
            this.panelNoiDung.Controls.Add(this.labelHoTenSV);
            this.panelNoiDung.Controls.Add(this.labelNgaySinh);
            this.panelNoiDung.Controls.Add(this.labelCCCD);
            this.panelNoiDung.Controls.Add(this.labelLop);
            this.panelNoiDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelNoiDung.Location = new System.Drawing.Point(7, 71);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(473, 359);
            this.panelNoiDung.TabIndex = 7;
            // 
            // roundedCornerTieuDe
            // 
            this.roundedCornerTieuDe.CornerRadius = 15;
            this.roundedCornerTieuDe.TargetControl = this.panelTieuDe;
            // 
            // roundedCornerNoiDung
            // 
            this.roundedCornerNoiDung.CornerRadius = 15;
            this.roundedCornerNoiDung.TargetControl = this.panelNoiDung;
            // 
            // FormChiTietSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(487, 436);
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.panelTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormChiTietSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.panelNoiDung.ResumeLayout(false);
            this.panelNoiDung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelMaThéV;
        private Label labelHoTenSV;
        private Label labelNgaySinh;
        private Label labelLop;
        private Label labelCCCD;
        private Panel panelTieuDe;
        private Panel panelNoiDung;
        private RoundedCorner roundedCornerTieuDe;
        private RoundedCorner roundedCornerNoiDung;
        private Label labelTieuDe;
    }
}

