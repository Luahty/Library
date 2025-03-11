using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlDocSach
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

        #region Component Designer generated code

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
            this.panelTT = new System.Windows.Forms.Panel();
            this.labelGhiChu = new System.Windows.Forms.Label();
            this.labelGioVao = new System.Windows.Forms.Label();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.labelMaDauSach = new System.Windows.Forms.Label();
            this.labelMaDocSach = new System.Windows.Forms.Label();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.textBoxGioVao = new System.Windows.Forms.TextBox();
            this.textBoxMaDauSach = new System.Windows.Forms.TextBox();
            this.textBoxMSSV = new System.Windows.Forms.TextBox();
            this.textBoxMaDocSach = new System.Windows.Forms.TextBox();
            this.panelTim = new System.Windows.Forms.Panel();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.panelXem = new System.Windows.Forms.Panel();
            this.buttonMoi = new System.Windows.Forms.Button();
            this.panelBTTim = new System.Windows.Forms.Panel();
            this.buttonTim = new System.Windows.Forms.Button();
            this.panelCapNhat = new System.Windows.Forms.Panel();
            this.buttonSua = new System.Windows.Forms.Button();
            this.panelThem = new System.Windows.Forms.Panel();
            this.buttonDocSach = new System.Windows.Forms.Button();
            this.panelXoa = new System.Windows.Forms.Panel();
            this.buttonTraSach = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.roundedCornerTT = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaMuonDoc = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerGioMuon = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerGhiChu = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaDauSach = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaTheSV = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerXem = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerBTTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerCN = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerXoa = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerPDGV = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerThem = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTT.SuspendLayout();
            this.panelTim.SuspendLayout();
            this.panelXem.SuspendLayout();
            this.panelBTTim.SuspendLayout();
            this.panelCapNhat.SuspendLayout();
            this.panelThem.SuspendLayout();
            this.panelXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTT
            // 
            this.panelTT.BackColor = System.Drawing.Color.White;
            this.panelTT.Controls.Add(this.labelGhiChu);
            this.panelTT.Controls.Add(this.labelGioVao);
            this.panelTT.Controls.Add(this.labelMSSV);
            this.panelTT.Controls.Add(this.labelMaDauSach);
            this.panelTT.Controls.Add(this.labelMaDocSach);
            this.panelTT.Controls.Add(this.textBoxGhiChu);
            this.panelTT.Controls.Add(this.textBoxGioVao);
            this.panelTT.Controls.Add(this.textBoxMaDauSach);
            this.panelTT.Controls.Add(this.textBoxMSSV);
            this.panelTT.Controls.Add(this.textBoxMaDocSach);
            this.panelTT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelTT.Location = new System.Drawing.Point(1, 0);
            this.panelTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(822, 255);
            this.panelTT.TabIndex = 19;
            // 
            // labelGhiChu
            // 
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Location = new System.Drawing.Point(28, 178);
            this.labelGhiChu.Name = "labelGhiChu";
            this.labelGhiChu.Size = new System.Drawing.Size(82, 28);
            this.labelGhiChu.TabIndex = 15;
            this.labelGhiChu.Text = "Ghi chú:";
            // 
            // labelGioVao
            // 
            this.labelGioVao.AutoSize = true;
            this.labelGioVao.Location = new System.Drawing.Point(444, 48);
            this.labelGioVao.Name = "labelGioVao";
            this.labelGioVao.Size = new System.Drawing.Size(85, 28);
            this.labelGioVao.TabIndex = 13;
            this.labelGioVao.Text = "Giờ đọc:";
            // 
            // labelMSSV
            // 
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.Location = new System.Drawing.Point(444, 112);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(68, 28);
            this.labelMSSV.TabIndex = 12;
            this.labelMSSV.Text = "MSSV:";
            // 
            // labelMaDauSach
            // 
            this.labelMaDauSach.AutoSize = true;
            this.labelMaDauSach.Location = new System.Drawing.Point(28, 112);
            this.labelMaDauSach.Name = "labelMaDauSach";
            this.labelMaDauSach.Size = new System.Drawing.Size(125, 28);
            this.labelMaDauSach.TabIndex = 11;
            this.labelMaDauSach.Text = "Mã đầu sách:";
            // 
            // labelMaDocSach
            // 
            this.labelMaDocSach.AutoSize = true;
            this.labelMaDocSach.Location = new System.Drawing.Point(28, 49);
            this.labelMaDocSach.Name = "labelMaDocSach";
            this.labelMaDocSach.Size = new System.Drawing.Size(125, 28);
            this.labelMaDocSach.TabIndex = 10;
            this.labelMaDocSach.Text = "Mã đọc sách:";
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGhiChu.Location = new System.Drawing.Point(189, 178);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(588, 28);
            this.textBoxGhiChu.TabIndex = 9;
            // 
            // textBoxGioVao
            // 
            this.textBoxGioVao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxGioVao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGioVao.Location = new System.Drawing.Point(582, 49);
            this.textBoxGioVao.Multiline = true;
            this.textBoxGioVao.Name = "textBoxGioVao";
            this.textBoxGioVao.Size = new System.Drawing.Size(195, 28);
            this.textBoxGioVao.TabIndex = 7;
            // 
            // textBoxMaDauSach
            // 
            this.textBoxMaDauSach.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMaDauSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaDauSach.Location = new System.Drawing.Point(189, 114);
            this.textBoxMaDauSach.Multiline = true;
            this.textBoxMaDauSach.Name = "textBoxMaDauSach";
            this.textBoxMaDauSach.Size = new System.Drawing.Size(195, 28);
            this.textBoxMaDauSach.TabIndex = 6;
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMSSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMSSV.Location = new System.Drawing.Point(582, 112);
            this.textBoxMSSV.Multiline = true;
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.Size = new System.Drawing.Size(195, 28);
            this.textBoxMSSV.TabIndex = 5;
            // 
            // textBoxMaDocSach
            // 
            this.textBoxMaDocSach.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMaDocSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaDocSach.Location = new System.Drawing.Point(189, 49);
            this.textBoxMaDocSach.Multiline = true;
            this.textBoxMaDocSach.Name = "textBoxMaDocSach";
            this.textBoxMaDocSach.Size = new System.Drawing.Size(195, 28);
            this.textBoxMaDocSach.TabIndex = 4;
            // 
            // panelTim
            // 
            this.panelTim.BackColor = System.Drawing.Color.White;
            this.panelTim.Controls.Add(this.textBoxTim);
            this.panelTim.Location = new System.Drawing.Point(829, 0);
            this.panelTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTim.Name = "panelTim";
            this.panelTim.Size = new System.Drawing.Size(161, 46);
            this.panelTim.TabIndex = 25;
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
            // panelXem
            // 
            this.panelXem.BackColor = System.Drawing.Color.White;
            this.panelXem.Controls.Add(this.buttonMoi);
            this.panelXem.Location = new System.Drawing.Point(829, 52);
            this.panelXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelXem.Name = "panelXem";
            this.panelXem.Size = new System.Drawing.Size(283, 47);
            this.panelXem.TabIndex = 20;
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
            // panelBTTim
            // 
            this.panelBTTim.BackColor = System.Drawing.Color.White;
            this.panelBTTim.Controls.Add(this.buttonTim);
            this.panelBTTim.Location = new System.Drawing.Point(994, 1);
            this.panelBTTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBTTim.Name = "panelBTTim";
            this.panelBTTim.Size = new System.Drawing.Size(118, 46);
            this.panelBTTim.TabIndex = 21;
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
            // panelCapNhat
            // 
            this.panelCapNhat.BackColor = System.Drawing.Color.White;
            this.panelCapNhat.Controls.Add(this.buttonSua);
            this.panelCapNhat.Location = new System.Drawing.Point(829, 156);
            this.panelCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCapNhat.Name = "panelCapNhat";
            this.panelCapNhat.Size = new System.Drawing.Size(283, 47);
            this.panelCapNhat.TabIndex = 24;
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSua.Location = new System.Drawing.Point(-3, -3);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(289, 52);
            this.buttonSua.TabIndex = 4;
            this.buttonSua.Text = "Chỉnh sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // panelThem
            // 
            this.panelThem.BackColor = System.Drawing.Color.White;
            this.panelThem.Controls.Add(this.buttonDocSach);
            this.panelThem.Location = new System.Drawing.Point(829, 104);
            this.panelThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(283, 47);
            this.panelThem.TabIndex = 22;
            // 
            // buttonDocSach
            // 
            this.buttonDocSach.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonDocSach.Location = new System.Drawing.Point(-3, -3);
            this.buttonDocSach.Name = "buttonDocSach";
            this.buttonDocSach.Size = new System.Drawing.Size(289, 52);
            this.buttonDocSach.TabIndex = 3;
            this.buttonDocSach.Text = "Đọc sách";
            this.buttonDocSach.UseVisualStyleBackColor = true;
            this.buttonDocSach.Click += new System.EventHandler(this.buttonDocSach_Click);
            // 
            // panelXoa
            // 
            this.panelXoa.BackColor = System.Drawing.Color.White;
            this.panelXoa.Controls.Add(this.buttonTraSach);
            this.panelXoa.Location = new System.Drawing.Point(829, 208);
            this.panelXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelXoa.Name = "panelXoa";
            this.panelXoa.Size = new System.Drawing.Size(283, 47);
            this.panelXoa.TabIndex = 23;
            // 
            // buttonTraSach
            // 
            this.buttonTraSach.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonTraSach.Location = new System.Drawing.Point(-3, -3);
            this.buttonTraSach.Name = "buttonTraSach";
            this.buttonTraSach.Size = new System.Drawing.Size(289, 52);
            this.buttonTraSach.TabIndex = 5;
            this.buttonTraSach.Text = "Trả sách";
            this.buttonTraSach.UseVisualStyleBackColor = true;
            this.buttonTraSach.Click += new System.EventHandler(this.buttonTraSach_Click);
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
            this.dataGridView.Size = new System.Drawing.Size(1233, 444);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // panelDGV
            // 
            this.panelDGV.BackColor = System.Drawing.Color.White;
            this.panelDGV.Controls.Add(this.dataGridView);
            this.panelDGV.Location = new System.Drawing.Point(1, 260);
            this.panelDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1109, 424);
            this.panelDGV.TabIndex = 18;
            // 
            // roundedCornerTT
            // 
            this.roundedCornerTT.CornerRadius = 15;
            this.roundedCornerTT.TargetControl = this.panelTT;
            // 
            // roundedCornerMaMuonDoc
            // 
            this.roundedCornerMaMuonDoc.CornerRadius = 15;
            this.roundedCornerMaMuonDoc.TargetControl = this.textBoxMaDocSach;
            // 
            // roundedCornerGioMuon
            // 
            this.roundedCornerGioMuon.CornerRadius = 15;
            this.roundedCornerGioMuon.TargetControl = this.textBoxGioVao;
            // 
            // roundedCornerGhiChu
            // 
            this.roundedCornerGhiChu.CornerRadius = 15;
            this.roundedCornerGhiChu.TargetControl = this.textBoxGhiChu;
            // 
            // roundedCornerMaDauSach
            // 
            this.roundedCornerMaDauSach.CornerRadius = 15;
            this.roundedCornerMaDauSach.TargetControl = this.textBoxMaDauSach;
            // 
            // roundedCornerMaTheSV
            // 
            this.roundedCornerMaTheSV.CornerRadius = 15;
            this.roundedCornerMaTheSV.TargetControl = this.textBoxMSSV;
            // 
            // roundedCornerTim
            // 
            this.roundedCornerTim.CornerRadius = 15;
            this.roundedCornerTim.TargetControl = this.panelTim;
            // 
            // roundedCornerXem
            // 
            this.roundedCornerXem.CornerRadius = 15;
            this.roundedCornerXem.TargetControl = this.panelXem;
            // 
            // roundedCornerBTTim
            // 
            this.roundedCornerBTTim.CornerRadius = 15;
            this.roundedCornerBTTim.TargetControl = this.panelBTTim;
            // 
            // roundedCornerCN
            // 
            this.roundedCornerCN.CornerRadius = 15;
            this.roundedCornerCN.TargetControl = this.panelCapNhat;
            // 
            // roundedCornerXoa
            // 
            this.roundedCornerXoa.CornerRadius = 15;
            this.roundedCornerXoa.TargetControl = this.panelXoa;
            // 
            // roundedCornerPDGV
            // 
            this.roundedCornerPDGV.CornerRadius = 15;
            this.roundedCornerPDGV.TargetControl = this.panelDGV;
            // 
            // roundedCornerThem
            // 
            this.roundedCornerThem.CornerRadius = 15;
            this.roundedCornerThem.TargetControl = this.panelThem;
            // 
            // UserControlDocSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelTim);
            this.Controls.Add(this.panelXem);
            this.Controls.Add(this.panelBTTim);
            this.Controls.Add(this.panelCapNhat);
            this.Controls.Add(this.panelThem);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelXoa);
            this.Controls.Add(this.panelTT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlDocSach";
            this.Size = new System.Drawing.Size(1109, 684);
            this.Load += new System.EventHandler(this.UserControlDocSach_Load);
            this.panelTT.ResumeLayout(false);
            this.panelTT.PerformLayout();
            this.panelTim.ResumeLayout(false);
            this.panelTim.PerformLayout();
            this.panelXem.ResumeLayout(false);
            this.panelBTTim.ResumeLayout(false);
            this.panelCapNhat.ResumeLayout(false);
            this.panelThem.ResumeLayout(false);
            this.panelXoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelDGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedCorner roundedCornerTT;
        private Panel panelTT;
        private Label labelGhiChu;
        private Label labelGioVao;
        private Label labelMSSV;
        private Label labelMaDauSach;
        private Label labelMaDocSach;
        private TextBox textBoxGhiChu;
        private TextBox textBoxGioVao;
        private TextBox textBoxMaDauSach;
        private TextBox textBoxMSSV;
        private TextBox textBoxMaDocSach;
        private RoundedCorner roundedCornerMaMuonDoc;
        private RoundedCorner roundedCornerGioMuon;
        private RoundedCorner roundedCornerGhiChu;
        private RoundedCorner roundedCornerMaDauSach;
        private RoundedCorner roundedCornerMaTheSV;
        private RoundedCorner roundedCornerTim;
        private Panel panelTim;
        private TextBox textBoxTim;
        private Panel panelXem;
        private Button buttonMoi;
        private RoundedCorner roundedCornerXem;
        private Panel panelBTTim;
        private Button buttonTim;
        private RoundedCorner roundedCornerBTTim;
        private Panel panelCapNhat;
        private Button buttonSua;
        private Panel panelThem;
        private Button buttonDocSach;
        private RoundedCorner roundedCornerCN;
        private RoundedCorner roundedCornerXoa;
        private Panel panelXoa;
        private Button buttonTraSach;
        private DataGridView dataGridView;
        private Panel panelDGV;
        private RoundedCorner roundedCornerPDGV;
        private RoundedCorner roundedCornerThem;
    }
}
