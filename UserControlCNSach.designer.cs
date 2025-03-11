using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlCNSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxMaNhaXuatBan = new System.Windows.Forms.TextBox();
            this.textBoxMaTheLoai = new System.Windows.Forms.TextBox();
            this.textBoxNamXuatBan = new System.Windows.Forms.TextBox();
            this.textBoxTacGia = new System.Windows.Forms.TextBox();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.textBoxUrlBiaSach = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonMoi = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.roundedCornerPDGV = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTT = new System.Windows.Forms.Panel();
            this.labelUrlBiaSach = new System.Windows.Forms.Label();
            this.labelNXB = new System.Windows.Forms.Label();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.labelNamXB = new System.Windows.Forms.Label();
            this.labelTacGia = new System.Windows.Forms.Label();
            this.labelTenSach = new System.Windows.Forms.Label();
            this.roundedCornerTT = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaSach = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTheLoai = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaTacGia = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerNamXB = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTenSach = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaNXB = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTim = new System.Windows.Forms.Panel();
            this.panelXem = new System.Windows.Forms.Panel();
            this.roundedCornerXem = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelBTTim = new System.Windows.Forms.Panel();
            this.roundedCornerBTTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelThem = new System.Windows.Forms.Panel();
            this.panelCapNhat = new System.Windows.Forms.Panel();
            this.roundedCornerCN = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelXoa = new System.Windows.Forms.Panel();
            this.roundedCornerXoa = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerThem = new QuanLyThuVien.RoundedCorner(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelDGV.SuspendLayout();
            this.panelTT.SuspendLayout();
            this.panelTim.SuspendLayout();
            this.panelXem.SuspendLayout();
            this.panelBTTim.SuspendLayout();
            this.panelThem.SuspendLayout();
            this.panelCapNhat.SuspendLayout();
            this.panelXoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(-100, -2);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersWidth = 99;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(1233, 391);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // textBoxMaNhaXuatBan
            // 
            this.textBoxMaNhaXuatBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMaNhaXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaNhaXuatBan.Location = new System.Drawing.Point(582, 112);
            this.textBoxMaNhaXuatBan.Multiline = true;
            this.textBoxMaNhaXuatBan.Name = "textBoxMaNhaXuatBan";
            this.textBoxMaNhaXuatBan.Size = new System.Drawing.Size(195, 28);
            this.textBoxMaNhaXuatBan.TabIndex = 8;
            // 
            // textBoxMaTheLoai
            // 
            this.textBoxMaTheLoai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMaTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaTheLoai.Location = new System.Drawing.Point(582, 49);
            this.textBoxMaTheLoai.Multiline = true;
            this.textBoxMaTheLoai.Name = "textBoxMaTheLoai";
            this.textBoxMaTheLoai.Size = new System.Drawing.Size(195, 28);
            this.textBoxMaTheLoai.TabIndex = 7;
            // 
            // textBoxNamXuatBan
            // 
            this.textBoxNamXuatBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxNamXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamXuatBan.Location = new System.Drawing.Point(189, 178);
            this.textBoxNamXuatBan.Multiline = true;
            this.textBoxNamXuatBan.Name = "textBoxNamXuatBan";
            this.textBoxNamXuatBan.Size = new System.Drawing.Size(195, 28);
            this.textBoxNamXuatBan.TabIndex = 6;
            // 
            // textBoxTacGia
            // 
            this.textBoxTacGia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTacGia.Location = new System.Drawing.Point(189, 114);
            this.textBoxTacGia.Multiline = true;
            this.textBoxTacGia.Name = "textBoxTacGia";
            this.textBoxTacGia.Size = new System.Drawing.Size(195, 28);
            this.textBoxTacGia.TabIndex = 5;
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenSach.Location = new System.Drawing.Point(189, 49);
            this.textBoxTenSach.Multiline = true;
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.Size = new System.Drawing.Size(195, 28);
            this.textBoxTenSach.TabIndex = 4;
            // 
            // textBoxTim
            // 
            this.textBoxTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTim.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBoxTim.Location = new System.Drawing.Point(-2, 10);
            this.textBoxTim.Multiline = true;
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(165, 28);
            this.textBoxTim.TabIndex = 9;
            // 
            // textBoxUrlBiaSach
            // 
            this.textBoxUrlBiaSach.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUrlBiaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUrlBiaSach.Location = new System.Drawing.Point(582, 175);
            this.textBoxUrlBiaSach.Multiline = true;
            this.textBoxUrlBiaSach.Name = "textBoxUrlBiaSach";
            this.textBoxUrlBiaSach.Size = new System.Drawing.Size(195, 28);
            this.textBoxUrlBiaSach.TabIndex = 9;
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonThem.Location = new System.Drawing.Point(-2, -2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(287, 50);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSua.Location = new System.Drawing.Point(-2, -2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(287, 50);
            this.buttonSua.TabIndex = 4;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.Location = new System.Drawing.Point(-2, -2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(287, 50);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonMoi
            // 
            this.buttonMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonMoi.Location = new System.Drawing.Point(-2, -2);
            this.buttonMoi.Name = "buttonMoi";
            this.buttonMoi.Size = new System.Drawing.Size(287, 50);
            this.buttonMoi.TabIndex = 6;
            this.buttonMoi.Text = "Làm mới";
            this.buttonMoi.UseVisualStyleBackColor = true;
            this.buttonMoi.Click += new System.EventHandler(this.buttonMoi_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonTim.Location = new System.Drawing.Point(-2, -2);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(122, 50);
            this.buttonTim.TabIndex = 8;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // panelDGV
            // 
            this.panelDGV.BackColor = System.Drawing.Color.White;
            this.panelDGV.Controls.Add(this.dataGridView);
            this.panelDGV.Location = new System.Drawing.Point(0, 261);
            this.panelDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1109, 373);
            this.panelDGV.TabIndex = 10;
            // 
            // roundedCornerPDGV
            // 
            this.roundedCornerPDGV.CornerRadius = 15;
            this.roundedCornerPDGV.TargetControl = this.panelDGV;
            // 
            // panelTT
            // 
            this.panelTT.BackColor = System.Drawing.Color.White;
            this.panelTT.Controls.Add(this.labelUrlBiaSach);
            this.panelTT.Controls.Add(this.labelNXB);
            this.panelTT.Controls.Add(this.labelTheLoai);
            this.panelTT.Controls.Add(this.labelNamXB);
            this.panelTT.Controls.Add(this.labelTacGia);
            this.panelTT.Controls.Add(this.labelTenSach);
            this.panelTT.Controls.Add(this.textBoxUrlBiaSach);
            this.panelTT.Controls.Add(this.textBoxMaNhaXuatBan);
            this.panelTT.Controls.Add(this.textBoxMaTheLoai);
            this.panelTT.Controls.Add(this.textBoxNamXuatBan);
            this.panelTT.Controls.Add(this.textBoxTacGia);
            this.panelTT.Controls.Add(this.textBoxTenSach);
            this.panelTT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelTT.Location = new System.Drawing.Point(-2, 0);
            this.panelTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(822, 255);
            this.panelTT.TabIndex = 11;
            // 
            // labelUrlBiaSach
            // 
            this.labelUrlBiaSach.AutoSize = true;
            this.labelUrlBiaSach.Location = new System.Drawing.Point(444, 178);
            this.labelUrlBiaSach.Name = "labelUrlBiaSach";
            this.labelUrlBiaSach.Size = new System.Drawing.Size(111, 28);
            this.labelUrlBiaSach.TabIndex = 15;
            this.labelUrlBiaSach.Text = "Url ảnh bìa:";
            // 
            // labelNXB
            // 
            this.labelNXB.AutoSize = true;
            this.labelNXB.Location = new System.Drawing.Point(444, 112);
            this.labelNXB.Name = "labelNXB";
            this.labelNXB.Size = new System.Drawing.Size(132, 28);
            this.labelNXB.TabIndex = 14;
            this.labelNXB.Text = "Nhà xuất bản:";
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Location = new System.Drawing.Point(444, 48);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(84, 28);
            this.labelTheLoai.TabIndex = 13;
            this.labelTheLoai.Text = "Thể loại:";
            // 
            // labelNamXB
            // 
            this.labelNamXB.AutoSize = true;
            this.labelNamXB.Location = new System.Drawing.Point(45, 178);
            this.labelNamXB.Name = "labelNamXB";
            this.labelNamXB.Size = new System.Drawing.Size(138, 28);
            this.labelNamXB.TabIndex = 12;
            this.labelNamXB.Text = "Năm xuất bản:";
            // 
            // labelTacGia
            // 
            this.labelTacGia.AutoSize = true;
            this.labelTacGia.Location = new System.Drawing.Point(45, 114);
            this.labelTacGia.Name = "labelTacGia";
            this.labelTacGia.Size = new System.Drawing.Size(71, 28);
            this.labelTacGia.TabIndex = 11;
            this.labelTacGia.Text = "Tác giả";
            // 
            // labelTenSach
            // 
            this.labelTenSach.AutoSize = true;
            this.labelTenSach.Location = new System.Drawing.Point(45, 49);
            this.labelTenSach.Name = "labelTenSach";
            this.labelTenSach.Size = new System.Drawing.Size(88, 28);
            this.labelTenSach.TabIndex = 10;
            this.labelTenSach.Text = "Tên sách:";
            // 
            // roundedCornerTT
            // 
            this.roundedCornerTT.CornerRadius = 15;
            this.roundedCornerTT.TargetControl = this.panelTT;
            // 
            // roundedCornerMaSach
            // 
            this.roundedCornerMaSach.CornerRadius = 15;
            this.roundedCornerMaSach.TargetControl = this.textBoxTenSach;
            // 
            // roundedCornerTheLoai
            // 
            this.roundedCornerTheLoai.CornerRadius = 15;
            this.roundedCornerTheLoai.TargetControl = this.textBoxMaTheLoai;
            // 
            // roundedCornerMaTacGia
            // 
            this.roundedCornerMaTacGia.CornerRadius = 15;
            this.roundedCornerMaTacGia.TargetControl = this.textBoxUrlBiaSach;
            // 
            // roundedCornerNamXB
            // 
            this.roundedCornerNamXB.CornerRadius = 15;
            this.roundedCornerNamXB.TargetControl = this.textBoxNamXuatBan;
            // 
            // roundedCornerTenSach
            // 
            this.roundedCornerTenSach.CornerRadius = 15;
            this.roundedCornerTenSach.TargetControl = this.textBoxTacGia;
            // 
            // roundedCornerMaNXB
            // 
            this.roundedCornerMaNXB.CornerRadius = 15;
            this.roundedCornerMaNXB.TargetControl = this.textBoxMaNhaXuatBan;
            // 
            // roundedCornerTim
            // 
            this.roundedCornerTim.CornerRadius = 15;
            this.roundedCornerTim.TargetControl = this.panelTim;
            // 
            // panelTim
            // 
            this.panelTim.BackColor = System.Drawing.Color.White;
            this.panelTim.Controls.Add(this.textBoxTim);
            this.panelTim.Location = new System.Drawing.Point(826, 0);
            this.panelTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTim.Name = "panelTim";
            this.panelTim.Size = new System.Drawing.Size(161, 46);
            this.panelTim.TabIndex = 17;
            // 
            // panelXem
            // 
            this.panelXem.BackColor = System.Drawing.Color.White;
            this.panelXem.Controls.Add(this.buttonMoi);
            this.panelXem.Location = new System.Drawing.Point(826, 52);
            this.panelXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelXem.Name = "panelXem";
            this.panelXem.Size = new System.Drawing.Size(283, 47);
            this.panelXem.TabIndex = 12;
            // 
            // roundedCornerXem
            // 
            this.roundedCornerXem.CornerRadius = 15;
            this.roundedCornerXem.TargetControl = this.panelXem;
            // 
            // panelBTTim
            // 
            this.panelBTTim.BackColor = System.Drawing.Color.White;
            this.panelBTTim.Controls.Add(this.buttonTim);
            this.panelBTTim.Location = new System.Drawing.Point(991, 1);
            this.panelBTTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBTTim.Name = "panelBTTim";
            this.panelBTTim.Size = new System.Drawing.Size(118, 46);
            this.panelBTTim.TabIndex = 13;
            // 
            // roundedCornerBTTim
            // 
            this.roundedCornerBTTim.CornerRadius = 15;
            this.roundedCornerBTTim.TargetControl = this.panelBTTim;
            // 
            // panelThem
            // 
            this.panelThem.BackColor = System.Drawing.Color.White;
            this.panelThem.Controls.Add(this.buttonThem);
            this.panelThem.Location = new System.Drawing.Point(826, 104);
            this.panelThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(283, 47);
            this.panelThem.TabIndex = 13;
            // 
            // panelCapNhat
            // 
            this.panelCapNhat.BackColor = System.Drawing.Color.White;
            this.panelCapNhat.Controls.Add(this.buttonSua);
            this.panelCapNhat.Location = new System.Drawing.Point(826, 156);
            this.panelCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCapNhat.Name = "panelCapNhat";
            this.panelCapNhat.Size = new System.Drawing.Size(283, 47);
            this.panelCapNhat.TabIndex = 16;
            // 
            // roundedCornerCN
            // 
            this.roundedCornerCN.CornerRadius = 15;
            this.roundedCornerCN.TargetControl = this.panelCapNhat;
            // 
            // panelXoa
            // 
            this.panelXoa.BackColor = System.Drawing.Color.White;
            this.panelXoa.Controls.Add(this.buttonXoa);
            this.panelXoa.Location = new System.Drawing.Point(826, 208);
            this.panelXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelXoa.Name = "panelXoa";
            this.panelXoa.Size = new System.Drawing.Size(283, 47);
            this.panelXoa.TabIndex = 16;
            // 
            // roundedCornerXoa
            // 
            this.roundedCornerXoa.CornerRadius = 15;
            this.roundedCornerXoa.TargetControl = this.panelXoa;
            // 
            // roundedCornerThem
            // 
            this.roundedCornerThem.CornerRadius = 15;
            this.roundedCornerThem.TargetControl = this.panelThem;
            // 
            // UserControlCNSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelTim);
            this.Controls.Add(this.panelXoa);
            this.Controls.Add(this.panelCapNhat);
            this.Controls.Add(this.panelThem);
            this.Controls.Add(this.panelBTTim);
            this.Controls.Add(this.panelXem);
            this.Controls.Add(this.panelTT);
            this.Controls.Add(this.panelDGV);
            this.Name = "UserControlCNSach";
            this.Size = new System.Drawing.Size(1109, 633);
            this.Load += new System.EventHandler(this.UserControlCNSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelDGV.ResumeLayout(false);
            this.panelTT.ResumeLayout(false);
            this.panelTT.PerformLayout();
            this.panelTim.ResumeLayout(false);
            this.panelTim.PerformLayout();
            this.panelXem.ResumeLayout(false);
            this.panelBTTim.ResumeLayout(false);
            this.panelThem.ResumeLayout(false);
            this.panelCapNhat.ResumeLayout(false);
            this.panelXoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private TextBox textBoxMaTheLoai;
        private TextBox textBoxNamXuatBan;
        private TextBox textBoxTacGia;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonMoi;
        private Button buttonTim;
        private TextBox textBoxTim;
        private TextBox textBoxTenSach;
        private TextBox textBoxMaNhaXuatBan;
        private Panel panelDGV;
        private RoundedCorner roundedCornerPDGV;
        private Panel panelTT;
        private RoundedCorner roundedCornerTT;
        private TextBox textBoxUrlBiaSach;
        private RoundedCorner roundedCornerMaSach;
        private RoundedCorner roundedCornerTheLoai;
        private RoundedCorner roundedCornerMaTacGia;
        private RoundedCorner roundedCornerNamXB;
        private RoundedCorner roundedCornerTenSach;
        private RoundedCorner roundedCornerMaNXB;
        private Label labelNamXB;
        private Label labelTacGia;
        private Label labelTenSach;
        private Label labelUrlBiaSach;
        private Label labelNXB;
        private Label labelTheLoai;
        private RoundedCorner roundedCornerTim;
        private Panel panelXem;
        private RoundedCorner roundedCornerXem;
        private Panel panelBTTim;
        private RoundedCorner roundedCornerBTTim;
        private Panel panelThem;
        private Panel panelCapNhat;
        private RoundedCorner roundedCornerCN;
        private Panel panelXoa;
        private RoundedCorner roundedCornerXoa;
        private Panel panelTim;
        private RoundedCorner roundedCornerThem;
    }
}

