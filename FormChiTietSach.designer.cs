using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class FormChiTietSach
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
            this.labelMaSach = new System.Windows.Forms.Label();
            this.labelTenSach = new System.Windows.Forms.Label();
            this.labelTacGia = new System.Windows.Forms.Label();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.labelNhaXuatBan = new System.Windows.Forms.Label();
            this.labelNamXuatBan = new System.Windows.Forms.Label();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.panelNoiDung = new System.Windows.Forms.Panel();
            this.roundedCornerTieuDe = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerNoiDung = new QuanLyThuVien.RoundedCorner(this.components);
            this.pictureBoxUrl = new System.Windows.Forms.PictureBox();
            this.panelTieuDe.SuspendLayout();
            this.panelNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaSach
            // 
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Location = new System.Drawing.Point(22, 30);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(83, 28);
            this.labelMaSach.TabIndex = 0;
            this.labelMaSach.Text = "Mã sách";
            // 
            // labelTenSach
            // 
            this.labelTenSach.AutoSize = true;
            this.labelTenSach.Location = new System.Drawing.Point(22, 83);
            this.labelTenSach.Name = "labelTenSach";
            this.labelTenSach.Size = new System.Drawing.Size(84, 28);
            this.labelTenSach.TabIndex = 1;
            this.labelTenSach.Text = "Tên sách";
            // 
            // labelTacGia
            // 
            this.labelTacGia.AutoSize = true;
            this.labelTacGia.Location = new System.Drawing.Point(22, 136);
            this.labelTacGia.Name = "labelTacGia";
            this.labelTacGia.Size = new System.Drawing.Size(71, 28);
            this.labelTacGia.TabIndex = 2;
            this.labelTacGia.Text = "Tác giả";
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Location = new System.Drawing.Point(22, 189);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(80, 28);
            this.labelTheLoai.TabIndex = 3;
            this.labelTheLoai.Text = "Thể loại";
            // 
            // labelNhaXuatBan
            // 
            this.labelNhaXuatBan.AutoSize = true;
            this.labelNhaXuatBan.Location = new System.Drawing.Point(22, 242);
            this.labelNhaXuatBan.Name = "labelNhaXuatBan";
            this.labelNhaXuatBan.Size = new System.Drawing.Size(128, 28);
            this.labelNhaXuatBan.TabIndex = 4;
            this.labelNhaXuatBan.Text = "Nhà xuất bản";
            // 
            // labelNamXuatBan
            // 
            this.labelNamXuatBan.AutoSize = true;
            this.labelNamXuatBan.Location = new System.Drawing.Point(22, 295);
            this.labelNamXuatBan.Name = "labelNamXuatBan";
            this.labelNamXuatBan.Size = new System.Drawing.Size(134, 28);
            this.labelNamXuatBan.TabIndex = 5;
            this.labelNamXuatBan.Text = "Năm xuất bản";
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.White;
            this.panelTieuDe.Controls.Add(this.labelTieuDe);
            this.panelTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.panelTieuDe.Location = new System.Drawing.Point(7, 7);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(615, 58);
            this.panelTieuDe.TabIndex = 6;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Location = new System.Drawing.Point(221, 11);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(203, 38);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "Thông tin sách";
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.BackColor = System.Drawing.Color.White;
            this.panelNoiDung.Controls.Add(this.pictureBoxUrl);
            this.panelNoiDung.Controls.Add(this.labelMaSach);
            this.panelNoiDung.Controls.Add(this.labelTenSach);
            this.panelNoiDung.Controls.Add(this.labelNamXuatBan);
            this.panelNoiDung.Controls.Add(this.labelTacGia);
            this.panelNoiDung.Controls.Add(this.labelNhaXuatBan);
            this.panelNoiDung.Controls.Add(this.labelTheLoai);
            this.panelNoiDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelNoiDung.Location = new System.Drawing.Point(7, 71);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(615, 361);
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
            // pictureBoxUrl
            // 
            this.pictureBoxUrl.Location = new System.Drawing.Point(393, 30);
            this.pictureBoxUrl.Name = "pictureBoxUrl";
            this.pictureBoxUrl.Size = new System.Drawing.Size(195, 297);
            this.pictureBoxUrl.TabIndex = 6;
            this.pictureBoxUrl.TabStop = false;
            // 
            // FormChiTietSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(628, 439);
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.panelTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FormChiTietSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sách";
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.panelNoiDung.ResumeLayout(false);
            this.panelNoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelMaSach;
        private Label labelTenSach;
        private Label labelTacGia;
        private Label labelTheLoai;
        private Label labelNhaXuatBan;
        private Label labelNamXuatBan;
        private Panel panelTieuDe;
        private Panel panelNoiDung;
        private RoundedCorner roundedCornerTieuDe;
        private RoundedCorner roundedCornerNoiDung;
        private Label labelTieuDe;
        private PictureBox pictureBoxUrl;
    }
}

