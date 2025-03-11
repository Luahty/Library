using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelNen = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogoText = new System.Windows.Forms.Label();
            this.panelSach = new System.Windows.Forms.Panel();
            this.buttonSach = new System.Windows.Forms.Button();
            this.panelSinhVien = new System.Windows.Forms.Panel();
            this.buttonSinhVien = new System.Windows.Forms.Button();
            this.panelCapNhat = new System.Windows.Forms.Panel();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.panelDocSach = new System.Windows.Forms.Panel();
            this.buttonDocSach = new System.Windows.Forms.Button();
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.panelThoat = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.roundedCornerNen = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerLogo = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerSach = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerSinhVien = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerCapNhat = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerDocSach = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerThongKe = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerThoat = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelLogo.SuspendLayout();
            this.panelSach.SuspendLayout();
            this.panelSinhVien.SuspendLayout();
            this.panelCapNhat.SuspendLayout();
            this.panelDocSach.SuspendLayout();
            this.panelThongKe.SuspendLayout();
            this.panelThoat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNen.BackColor = System.Drawing.Color.White;
            this.panelNen.Location = new System.Drawing.Point(217, 6);
            this.panelNen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1109, 670);
            this.panelNen.TabIndex = 8;
            this.panelNen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNen_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.labelLogoText);
            this.panelLogo.Location = new System.Drawing.Point(8, 6);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(203, 162);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đọc sách";
            // 
            // labelLogoText
            // 
            this.labelLogoText.AutoSize = true;
            this.labelLogoText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLogoText.Location = new System.Drawing.Point(49, 38);
            this.labelLogoText.Name = "labelLogoText";
            this.labelLogoText.Size = new System.Drawing.Size(104, 35);
            this.labelLogoText.TabIndex = 0;
            this.labelLogoText.Text = "Quản lý";
            // 
            // panelSach
            // 
            this.panelSach.BackColor = System.Drawing.Color.White;
            this.panelSach.Controls.Add(this.buttonSach);
            this.panelSach.Location = new System.Drawing.Point(8, 342);
            this.panelSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSach.Name = "panelSach";
            this.panelSach.Size = new System.Drawing.Size(203, 80);
            this.panelSach.TabIndex = 2;
            // 
            // buttonSach
            // 
            this.buttonSach.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonSach.Location = new System.Drawing.Point(-3, -2);
            this.buttonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSach.Name = "buttonSach";
            this.buttonSach.Size = new System.Drawing.Size(209, 84);
            this.buttonSach.TabIndex = 0;
            this.buttonSach.Text = "Xem sách";
            this.buttonSach.UseVisualStyleBackColor = true;
            this.buttonSach.Click += new System.EventHandler(this.buttonXemSach_Click);
            // 
            // panelSinhVien
            // 
            this.panelSinhVien.BackColor = System.Drawing.Color.White;
            this.panelSinhVien.Controls.Add(this.buttonSinhVien);
            this.panelSinhVien.Location = new System.Drawing.Point(8, 426);
            this.panelSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSinhVien.Name = "panelSinhVien";
            this.panelSinhVien.Size = new System.Drawing.Size(203, 80);
            this.panelSinhVien.TabIndex = 4;
            // 
            // buttonSinhVien
            // 
            this.buttonSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonSinhVien.Location = new System.Drawing.Point(-3, -2);
            this.buttonSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSinhVien.Name = "buttonSinhVien";
            this.buttonSinhVien.Size = new System.Drawing.Size(209, 85);
            this.buttonSinhVien.TabIndex = 0;
            this.buttonSinhVien.Text = "Sinh viên";
            this.buttonSinhVien.UseVisualStyleBackColor = true;
            this.buttonSinhVien.Click += new System.EventHandler(this.buttonSinhVien_Click);
            // 
            // panelCapNhat
            // 
            this.panelCapNhat.BackColor = System.Drawing.Color.White;
            this.panelCapNhat.Controls.Add(this.buttonCapNhat);
            this.panelCapNhat.Location = new System.Drawing.Point(8, 510);
            this.panelCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCapNhat.Name = "panelCapNhat";
            this.panelCapNhat.Size = new System.Drawing.Size(203, 80);
            this.panelCapNhat.TabIndex = 5;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonCapNhat.Location = new System.Drawing.Point(-3, -2);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(209, 85);
            this.buttonCapNhat.TabIndex = 0;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // panelDocSach
            // 
            this.panelDocSach.BackColor = System.Drawing.Color.White;
            this.panelDocSach.Controls.Add(this.buttonDocSach);
            this.panelDocSach.Location = new System.Drawing.Point(8, 258);
            this.panelDocSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDocSach.Name = "panelDocSach";
            this.panelDocSach.Size = new System.Drawing.Size(203, 80);
            this.panelDocSach.TabIndex = 2;
            // 
            // buttonDocSach
            // 
            this.buttonDocSach.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonDocSach.Location = new System.Drawing.Point(-3, -2);
            this.buttonDocSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDocSach.Name = "buttonDocSach";
            this.buttonDocSach.Size = new System.Drawing.Size(209, 85);
            this.buttonDocSach.TabIndex = 0;
            this.buttonDocSach.Text = "Đọc sách";
            this.buttonDocSach.UseVisualStyleBackColor = true;
            this.buttonDocSach.Click += new System.EventHandler(this.buttonDocSach_Click);
            // 
            // panelThongKe
            // 
            this.panelThongKe.BackColor = System.Drawing.Color.White;
            this.panelThongKe.Controls.Add(this.buttonThongKe);
            this.panelThongKe.Location = new System.Drawing.Point(8, 174);
            this.panelThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(203, 80);
            this.panelThongKe.TabIndex = 1;
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonThongKe.Location = new System.Drawing.Point(-3, -2);
            this.buttonThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(209, 85);
            this.buttonThongKe.TabIndex = 0;
            this.buttonThongKe.Text = "Thống kê";
            this.buttonThongKe.UseVisualStyleBackColor = true;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // panelThoat
            // 
            this.panelThoat.BackColor = System.Drawing.Color.White;
            this.panelThoat.Controls.Add(this.buttonThoat);
            this.panelThoat.Location = new System.Drawing.Point(8, 594);
            this.panelThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThoat.Name = "panelThoat";
            this.panelThoat.Size = new System.Drawing.Size(203, 80);
            this.panelThoat.TabIndex = 7;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonThoat.Location = new System.Drawing.Point(-3, -2);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(209, 85);
            this.buttonThoat.TabIndex = 0;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // roundedCornerNen
            // 
            this.roundedCornerNen.CornerRadius = 15;
            this.roundedCornerNen.TargetControl = this.panelNen;
            // 
            // roundedCornerLogo
            // 
            this.roundedCornerLogo.CornerRadius = 15;
            this.roundedCornerLogo.TargetControl = this.panelLogo;
            // 
            // roundedCornerSach
            // 
            this.roundedCornerSach.CornerRadius = 15;
            this.roundedCornerSach.TargetControl = this.panelSach;
            // 
            // roundedCornerSinhVien
            // 
            this.roundedCornerSinhVien.CornerRadius = 15;
            this.roundedCornerSinhVien.TargetControl = this.panelSinhVien;
            // 
            // roundedCornerCapNhat
            // 
            this.roundedCornerCapNhat.CornerRadius = 15;
            this.roundedCornerCapNhat.TargetControl = this.panelCapNhat;
            // 
            // roundedCornerDocSach
            // 
            this.roundedCornerDocSach.CornerRadius = 15;
            this.roundedCornerDocSach.TargetControl = this.panelDocSach;
            // 
            // roundedCornerThongKe
            // 
            this.roundedCornerThongKe.CornerRadius = 15;
            this.roundedCornerThongKe.TargetControl = this.panelThongKe;
            // 
            // roundedCornerThoat
            // 
            this.roundedCornerThoat.CornerRadius = 15;
            this.roundedCornerThoat.TargetControl = this.panelThoat;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1333, 682);
            this.Controls.Add(this.panelThoat);
            this.Controls.Add(this.panelThongKe);
            this.Controls.Add(this.panelDocSach);
            this.Controls.Add(this.panelCapNhat);
            this.Controls.Add(this.panelSinhVien);
            this.Controls.Add(this.panelSach);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng Quản lý sách";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelSach.ResumeLayout(false);
            this.panelSinhVien.ResumeLayout(false);
            this.panelCapNhat.ResumeLayout(false);
            this.panelDocSach.ResumeLayout(false);
            this.panelThongKe.ResumeLayout(false);
            this.panelThoat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNen;
        private QuanLyThuVien.RoundedCorner roundedCornerNen;
        private Panel panelLogo;
        private Panel panelSach;
        private RoundedCorner roundedCornerLogo;
        private RoundedCorner roundedCornerSach;
        private Panel panelSinhVien;
        private RoundedCorner roundedCornerSinhVien;
        private Panel panelCapNhat;
        private RoundedCorner roundedCornerCapNhat;
        private Panel panelDocSach;
        private RoundedCorner roundedCornerDocSach;
        private Button buttonDocSach;
        private Button buttonSach;
        private Button buttonSinhVien;
        private Button buttonCapNhat;
        private Label labelLogoText;
        private Label label1;
        private Panel panelThongKe;
        private Button buttonThongKe;
        private RoundedCorner roundedCornerThongKe;
        private Panel panelThoat;
        private Button buttonThoat;
        private RoundedCorner roundedCornerThoat;
    }
}