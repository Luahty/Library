using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlCNTacGia
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
            this.textBoxQuocGia = new System.Windows.Forms.TextBox();
            this.textBoxTenTacGia = new System.Windows.Forms.TextBox();
            this.textBoxMaTacGia = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonMoi = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.roundedCornerPDGV = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTT = new System.Windows.Forms.Panel();
            this.labelTenTacGia = new System.Windows.Forms.Label();
            this.labelQuocGia = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelMaTacGia = new System.Windows.Forms.Label();
            this.textBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.roundedCornerTT = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaTacGia = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerNgaySinh = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerQuocGia = new QuanLyThuVien.RoundedCorner(this.components);
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
            this.roundedCornerTenTacGia = new QuanLyThuVien.RoundedCorner(this.components);
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
            this.dataGridView.Size = new System.Drawing.Size(1233, 383);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // textBoxQuocGia
            // 
            this.textBoxQuocGia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxQuocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuocGia.Location = new System.Drawing.Point(582, 112);
            this.textBoxQuocGia.Multiline = true;
            this.textBoxQuocGia.Name = "textBoxQuocGia";
            this.textBoxQuocGia.Size = new System.Drawing.Size(195, 28);
            this.textBoxQuocGia.TabIndex = 8;
            // 
            // textBoxTenTacGia
            // 
            this.textBoxTenTacGia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTenTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenTacGia.Location = new System.Drawing.Point(189, 114);
            this.textBoxTenTacGia.Multiline = true;
            this.textBoxTenTacGia.Name = "textBoxTenTacGia";
            this.textBoxTenTacGia.Size = new System.Drawing.Size(195, 28);
            this.textBoxTenTacGia.TabIndex = 5;
            // 
            // textBoxMaTacGia
            // 
            this.textBoxMaTacGia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMaTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaTacGia.Location = new System.Drawing.Point(189, 49);
            this.textBoxMaTacGia.Multiline = true;
            this.textBoxMaTacGia.Name = "textBoxMaTacGia";
            this.textBoxMaTacGia.Size = new System.Drawing.Size(195, 28);
            this.textBoxMaTacGia.TabIndex = 4;
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
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonThem.Location = new System.Drawing.Point(-3, -3);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(289, 52);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSua.Location = new System.Drawing.Point(-3, -3);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(289, 52);
            this.buttonSua.TabIndex = 4;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.Location = new System.Drawing.Point(-3, -3);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(289, 52);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonMoi
            // 
            this.buttonMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonMoi.Location = new System.Drawing.Point(-3, -3);
            this.buttonMoi.Name = "buttonMoi";
            this.buttonMoi.Size = new System.Drawing.Size(289, 52);
            this.buttonMoi.TabIndex = 6;
            this.buttonMoi.Text = "Làm mới";
            this.buttonMoi.UseVisualStyleBackColor = true;
            this.buttonMoi.Click += new System.EventHandler(this.buttonMoi_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonTim.Location = new System.Drawing.Point(-3, -3);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(124, 52);
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
            this.panelDGV.Size = new System.Drawing.Size(1109, 370);
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
            this.panelTT.Controls.Add(this.labelTenTacGia);
            this.panelTT.Controls.Add(this.labelQuocGia);
            this.panelTT.Controls.Add(this.labelNgaySinh);
            this.panelTT.Controls.Add(this.labelMaTacGia);
            this.panelTT.Controls.Add(this.textBoxQuocGia);
            this.panelTT.Controls.Add(this.textBoxNgaySinh);
            this.panelTT.Controls.Add(this.textBoxTenTacGia);
            this.panelTT.Controls.Add(this.textBoxMaTacGia);
            this.panelTT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelTT.Location = new System.Drawing.Point(-2, 0);
            this.panelTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(822, 255);
            this.panelTT.TabIndex = 11;
            // 
            // labelTenTacGia
            // 
            this.labelTenTacGia.AutoSize = true;
            this.labelTenTacGia.Location = new System.Drawing.Point(45, 112);
            this.labelTenTacGia.Name = "labelTenTacGia";
            this.labelTenTacGia.Size = new System.Drawing.Size(108, 28);
            this.labelTenTacGia.TabIndex = 15;
            this.labelTenTacGia.Text = "Tên tác giả:";
            // 
            // labelQuocGia
            // 
            this.labelQuocGia.AutoSize = true;
            this.labelQuocGia.Location = new System.Drawing.Point(444, 112);
            this.labelQuocGia.Name = "labelQuocGia";
            this.labelQuocGia.Size = new System.Drawing.Size(95, 28);
            this.labelQuocGia.TabIndex = 14;
            this.labelQuocGia.Text = "Quốc gia:";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(444, 48);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(103, 28);
            this.labelNgaySinh.TabIndex = 13;
            this.labelNgaySinh.Text = "Ngày sinh:";
            // 
            // labelMaTacGia
            // 
            this.labelMaTacGia.AutoSize = true;
            this.labelMaTacGia.Location = new System.Drawing.Point(45, 49);
            this.labelMaTacGia.Name = "labelMaTacGia";
            this.labelMaTacGia.Size = new System.Drawing.Size(107, 28);
            this.labelMaTacGia.TabIndex = 10;
            this.labelMaTacGia.Text = "Mã tác giả:";
            // 
            // textBoxNgaySinh
            // 
            this.textBoxNgaySinh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNgaySinh.Location = new System.Drawing.Point(582, 49);
            this.textBoxNgaySinh.Multiline = true;
            this.textBoxNgaySinh.Name = "textBoxNgaySinh";
            this.textBoxNgaySinh.Size = new System.Drawing.Size(195, 28);
            this.textBoxNgaySinh.TabIndex = 7;
            // 
            // roundedCornerTT
            // 
            this.roundedCornerTT.CornerRadius = 15;
            this.roundedCornerTT.TargetControl = this.panelTT;
            // 
            // roundedCornerMaTacGia
            // 
            this.roundedCornerMaTacGia.CornerRadius = 15;
            this.roundedCornerMaTacGia.TargetControl = this.textBoxMaTacGia;
            // 
            // roundedCornerNgaySinh
            // 
            this.roundedCornerNgaySinh.CornerRadius = 15;
            this.roundedCornerNgaySinh.TargetControl = this.textBoxNgaySinh;
            // 
            // roundedCornerQuocGia
            // 
            this.roundedCornerQuocGia.CornerRadius = 15;
            this.roundedCornerQuocGia.TargetControl = this.textBoxQuocGia;
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
            // roundedCornerTenTacGia
            // 
            this.roundedCornerTenTacGia.CornerRadius = 15;
            this.roundedCornerTenTacGia.TargetControl = this.textBoxTenTacGia;
            // 
            // roundedCornerThem
            // 
            this.roundedCornerThem.CornerRadius = 15;
            this.roundedCornerThem.TargetControl = this.panelThem;
            // 
            // UserControlCNTacGia
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
            this.Name = "UserControlCNTacGia";
            this.Size = new System.Drawing.Size(1109, 633);
            this.Load += new System.EventHandler(this.UserControlCNTacGia_Load);
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
        private TextBox textBoxTenTacGia;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonMoi;
        private Button buttonTim;
        private TextBox textBoxTim;
        private TextBox textBoxQuocGia;
        private Panel panelDGV;
        private RoundedCorner roundedCornerPDGV;
        private Panel panelTT;
        private RoundedCorner roundedCornerTT;
        private TextBox textBoxMaTacGia;
        private RoundedCorner roundedCornerNgaySinh;
        private RoundedCorner roundedCornerMaTacGia;
        private RoundedCorner roundedCornerQuocGia;
        private Label labelMaTacGia;
        private Label labelQuocGia;
        private Label labelNgaySinh;
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
        private Label labelTenTacGia;
        private TextBox textBoxNgaySinh;
        private RoundedCorner roundedCornerTenTacGia;
        private RoundedCorner roundedCornerThem;
    }
}

