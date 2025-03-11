using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlCNNXB
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
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxTenNXB = new System.Windows.Forms.TextBox();
            this.textBoxMaNXB = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonMoi = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.panelTT = new System.Windows.Forms.Panel();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelTenNXB = new System.Windows.Forms.Label();
            this.labelMaNXB = new System.Windows.Forms.Label();
            this.panelTim = new System.Windows.Forms.Panel();
            this.panelXem = new System.Windows.Forms.Panel();
            this.panelBTTim = new System.Windows.Forms.Panel();
            this.panelThem = new System.Windows.Forms.Panel();
            this.panelCapNhat = new System.Windows.Forms.Panel();
            this.panelXoa = new System.Windows.Forms.Panel();
            this.roundedCornerPDGV = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTT = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerMaNXB = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerDiaChi = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTenNXB = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerXem = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerBTTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerCN = new QuanLyThuVien.RoundedCorner(this.components);
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
            this.dataGridView.Size = new System.Drawing.Size(1233, 393);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiaChi.Location = new System.Drawing.Point(189, 114);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(588, 28);
            this.textBoxDiaChi.TabIndex = 6;
            // 
            // textBoxTenNXB
            // 
            this.textBoxTenNXB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTenNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenNXB.Location = new System.Drawing.Point(582, 49);
            this.textBoxTenNXB.Multiline = true;
            this.textBoxTenNXB.Name = "textBoxTenNXB";
            this.textBoxTenNXB.Size = new System.Drawing.Size(195, 28);
            this.textBoxTenNXB.TabIndex = 5;
            // 
            // textBoxMaNXB
            // 
            this.textBoxMaNXB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMaNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaNXB.Location = new System.Drawing.Point(189, 49);
            this.textBoxMaNXB.Multiline = true;
            this.textBoxMaNXB.Name = "textBoxMaNXB";
            this.textBoxMaNXB.Size = new System.Drawing.Size(195, 28);
            this.textBoxMaNXB.TabIndex = 4;
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
            this.panelDGV.Size = new System.Drawing.Size(1109, 374);
            this.panelDGV.TabIndex = 10;
            // 
            // panelTT
            // 
            this.panelTT.BackColor = System.Drawing.Color.White;
            this.panelTT.Controls.Add(this.labelDiaChi);
            this.panelTT.Controls.Add(this.labelTenNXB);
            this.panelTT.Controls.Add(this.labelMaNXB);
            this.panelTT.Controls.Add(this.textBoxDiaChi);
            this.panelTT.Controls.Add(this.textBoxTenNXB);
            this.panelTT.Controls.Add(this.textBoxMaNXB);
            this.panelTT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelTT.Location = new System.Drawing.Point(-2, 0);
            this.panelTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(822, 255);
            this.panelTT.TabIndex = 11;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(19, 114);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(75, 28);
            this.labelDiaChi.TabIndex = 12;
            this.labelDiaChi.Text = "Địa chỉ:";
            // 
            // labelTenNXB
            // 
            this.labelTenNXB.AutoSize = true;
            this.labelTenNXB.Location = new System.Drawing.Point(413, 49);
            this.labelTenNXB.Name = "labelTenNXB";
            this.labelTenNXB.Size = new System.Drawing.Size(162, 28);
            this.labelTenNXB.TabIndex = 11;
            this.labelTenNXB.Text = "Tên nhà xuất bản:";
            // 
            // labelMaNXB
            // 
            this.labelMaNXB.AutoSize = true;
            this.labelMaNXB.Location = new System.Drawing.Point(19, 49);
            this.labelMaNXB.Name = "labelMaNXB";
            this.labelMaNXB.Size = new System.Drawing.Size(161, 28);
            this.labelMaNXB.TabIndex = 10;
            this.labelMaNXB.Text = "Mã nhà xuất bản:";
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
            // roundedCornerPDGV
            // 
            this.roundedCornerPDGV.CornerRadius = 15;
            this.roundedCornerPDGV.TargetControl = this.panelDGV;
            // 
            // roundedCornerTT
            // 
            this.roundedCornerTT.CornerRadius = 15;
            this.roundedCornerTT.TargetControl = this.panelTT;
            // 
            // roundedCornerMaNXB
            // 
            this.roundedCornerMaNXB.CornerRadius = 15;
            this.roundedCornerMaNXB.TargetControl = this.textBoxMaNXB;
            // 
            // roundedCornerDiaChi
            // 
            this.roundedCornerDiaChi.CornerRadius = 15;
            this.roundedCornerDiaChi.TargetControl = this.textBoxDiaChi;
            // 
            // roundedCornerTenNXB
            // 
            this.roundedCornerTenNXB.CornerRadius = 15;
            this.roundedCornerTenNXB.TargetControl = this.textBoxTenNXB;
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
            // roundedCornerThem
            // 
            this.roundedCornerThem.CornerRadius = 15;
            this.roundedCornerThem.TargetControl = this.panelThem;
            // 
            // UserControlCNNXB
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
            this.Name = "UserControlCNNXB";
            this.Size = new System.Drawing.Size(1109, 633);
            this.Load += new System.EventHandler(this.UserControlCNNXB_Load);
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
        private TextBox textBoxDiaChi;
        private TextBox textBoxTenNXB;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonMoi;
        private Button buttonTim;
        private TextBox textBoxTim;
        private TextBox textBoxMaNXB;
        private Panel panelDGV;
        private RoundedCorner roundedCornerPDGV;
        private Panel panelTT;
        private RoundedCorner roundedCornerTT;
        private RoundedCorner roundedCornerDiaChi;
        private RoundedCorner roundedCornerTenNXB;
        private RoundedCorner roundedCornerMaNXB;
        private Label labelDiaChi;
        private Label labelTenNXB;
        private Label labelMaNXB;
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

