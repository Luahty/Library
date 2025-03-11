using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlCNTheLoai
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
            this.textBoxTenTheLoai = new System.Windows.Forms.TextBox();
            this.textBoxMaTheLoai = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonMoi = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.roundedCornerPDGV = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTT = new System.Windows.Forms.Panel();
            this.labelMoTa = new System.Windows.Forms.Label();
            this.textBoxMoTa = new System.Windows.Forms.TextBox();
            this.labelTenSach = new System.Windows.Forms.Label();
            this.labelMaSach = new System.Windows.Forms.Label();
            this.roundedCornerTT = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaTheLoai = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTenTheLoai = new QuanLyThuVien.RoundedCorner(this.components);
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
            this.roundedCornerMoTa = new QuanLyThuVien.RoundedCorner(this.components);
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
            this.dataGridView.Size = new System.Drawing.Size(1233, 422);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // textBoxTenTheLoai
            // 
            this.textBoxTenTheLoai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTenTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenTheLoai.Location = new System.Drawing.Point(582, 49);
            this.textBoxTenTheLoai.Multiline = true;
            this.textBoxTenTheLoai.Name = "textBoxTenTheLoai";
            this.textBoxTenTheLoai.Size = new System.Drawing.Size(195, 28);
            this.textBoxTenTheLoai.TabIndex = 5;
            // 
            // textBoxMaTheLoai
            // 
            this.textBoxMaTheLoai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMaTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaTheLoai.Location = new System.Drawing.Point(189, 49);
            this.textBoxMaTheLoai.Multiline = true;
            this.textBoxMaTheLoai.Name = "textBoxMaTheLoai";
            this.textBoxMaTheLoai.Size = new System.Drawing.Size(195, 28);
            this.textBoxMaTheLoai.TabIndex = 4;
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
            this.buttonMoi.Click += new System.EventHandler(this.buttonSua_Click);
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
            this.panelDGV.Size = new System.Drawing.Size(1109, 392);
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
            this.panelTT.Controls.Add(this.labelMoTa);
            this.panelTT.Controls.Add(this.textBoxMoTa);
            this.panelTT.Controls.Add(this.labelTenSach);
            this.panelTT.Controls.Add(this.labelMaSach);
            this.panelTT.Controls.Add(this.textBoxTenTheLoai);
            this.panelTT.Controls.Add(this.textBoxMaTheLoai);
            this.panelTT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelTT.Location = new System.Drawing.Point(-2, 0);
            this.panelTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(822, 255);
            this.panelTT.TabIndex = 11;
            // 
            // labelMoTa
            // 
            this.labelMoTa.AutoSize = true;
            this.labelMoTa.Location = new System.Drawing.Point(45, 114);
            this.labelMoTa.Name = "labelMoTa";
            this.labelMoTa.Size = new System.Drawing.Size(68, 28);
            this.labelMoTa.TabIndex = 13;
            this.labelMoTa.Text = "Mô tả:";
            // 
            // textBoxMoTa
            // 
            this.textBoxMoTa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMoTa.Location = new System.Drawing.Point(189, 114);
            this.textBoxMoTa.Multiline = true;
            this.textBoxMoTa.Name = "textBoxMoTa";
            this.textBoxMoTa.Size = new System.Drawing.Size(588, 28);
            this.textBoxMoTa.TabIndex = 12;
            // 
            // labelTenSach
            // 
            this.labelTenSach.AutoSize = true;
            this.labelTenSach.Location = new System.Drawing.Point(444, 48);
            this.labelTenSach.Name = "labelTenSach";
            this.labelTenSach.Size = new System.Drawing.Size(115, 28);
            this.labelTenSach.TabIndex = 11;
            this.labelTenSach.Text = "Tên thể loại:";
            // 
            // labelMaSach
            // 
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Location = new System.Drawing.Point(45, 49);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(114, 28);
            this.labelMaSach.TabIndex = 10;
            this.labelMaSach.Text = "Mã thể loại:";
            // 
            // roundedCornerTT
            // 
            this.roundedCornerTT.CornerRadius = 15;
            this.roundedCornerTT.TargetControl = this.panelTT;
            // 
            // roundedCornerMaTheLoai
            // 
            this.roundedCornerMaTheLoai.CornerRadius = 15;
            this.roundedCornerMaTheLoai.TargetControl = this.textBoxMaTheLoai;
            // 
            // roundedCornerTenTheLoai
            // 
            this.roundedCornerTenTheLoai.CornerRadius = 15;
            this.roundedCornerTenTheLoai.TargetControl = this.textBoxTenTheLoai;
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
            // roundedCornerMoTa
            // 
            this.roundedCornerMoTa.CornerRadius = 15;
            this.roundedCornerMoTa.TargetControl = this.textBoxMoTa;
            // 
            // roundedCornerThem
            // 
            this.roundedCornerThem.CornerRadius = 15;
            this.roundedCornerThem.TargetControl = this.panelThem;
            // 
            // UserControlCNTheLoai
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
            this.Name = "UserControlCNTheLoai";
            this.Size = new System.Drawing.Size(1109, 653);
            this.Load += new System.EventHandler(this.UserControlCNTheLoai_Load);
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
        private TextBox textBoxTenTheLoai;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonMoi;
        private Button buttonTim;
        private TextBox textBoxTim;
        private TextBox textBoxMaTheLoai;
        private Panel panelDGV;
        private RoundedCorner roundedCornerPDGV;
        private Panel panelTT;
        private RoundedCorner roundedCornerTT;
        private RoundedCorner roundedCornerMaTheLoai;
        private RoundedCorner roundedCornerTenTheLoai;
        private Label labelTenSach;
        private Label labelMaSach;
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
        private Label labelMoTa;
        private TextBox textBoxMoTa;
        private RoundedCorner roundedCornerMoTa;
        private RoundedCorner roundedCornerThem;
    }
}

