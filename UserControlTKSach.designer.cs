using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlTKSach
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTT = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTim = new System.Windows.Forms.Panel();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.panelXem = new System.Windows.Forms.Panel();
            this.buttonXem = new System.Windows.Forms.Button();
            this.panelBTTim = new System.Windows.Forms.Panel();
            this.buttonTim = new System.Windows.Forms.Button();
            this.panelSV = new System.Windows.Forms.Panel();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.labelSoNguoiDoc = new System.Windows.Forms.Label();
            this.labelNhaXuatBan = new System.Windows.Forms.Label();
            this.labelTacGia = new System.Windows.Forms.Label();
            this.labelTenSach = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.roundedCornerTT = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerXem = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerBTTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerPDGV = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerSV = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelTim.SuspendLayout();
            this.panelXem.SuspendLayout();
            this.panelBTTim.SuspendLayout();
            this.panelSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTT
            // 
            this.panelTT.BackColor = System.Drawing.Color.White;
            this.panelTT.Controls.Add(this.chart1);
            this.panelTT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panelTT.Location = new System.Drawing.Point(1, 0);
            this.panelTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(626, 393);
            this.panelTT.TabIndex = 19;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(-17, 10);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(668, 383);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart Doc Sach";
            // 
            // panelTim
            // 
            this.panelTim.BackColor = System.Drawing.Color.White;
            this.panelTim.Controls.Add(this.textBoxTim);
            this.panelTim.Location = new System.Drawing.Point(823, 1);
            this.panelTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTim.Name = "panelTim";
            this.panelTim.Size = new System.Drawing.Size(167, 46);
            this.panelTim.TabIndex = 25;
            // 
            // textBoxTim
            // 
            this.textBoxTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTim.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBoxTim.Location = new System.Drawing.Point(0, 10);
            this.textBoxTim.Multiline = true;
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(163, 28);
            this.textBoxTim.TabIndex = 9;
            // 
            // panelXem
            // 
            this.panelXem.BackColor = System.Drawing.Color.White;
            this.panelXem.Controls.Add(this.buttonXem);
            this.panelXem.Location = new System.Drawing.Point(633, 1);
            this.panelXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelXem.Name = "panelXem";
            this.panelXem.Size = new System.Drawing.Size(184, 46);
            this.panelXem.TabIndex = 20;
            // 
            // buttonXem
            // 
            this.buttonXem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonXem.Location = new System.Drawing.Point(-3, -3);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(193, 52);
            this.buttonXem.TabIndex = 6;
            this.buttonXem.Text = "Làm mới";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
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
            // panelSV
            // 
            this.panelSV.BackColor = System.Drawing.Color.White;
            this.panelSV.Controls.Add(this.labelTheLoai);
            this.panelSV.Controls.Add(this.labelSoNguoiDoc);
            this.panelSV.Controls.Add(this.labelNhaXuatBan);
            this.panelSV.Controls.Add(this.labelTacGia);
            this.panelSV.Controls.Add(this.labelTenSach);
            this.panelSV.Location = new System.Drawing.Point(633, 51);
            this.panelSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSV.Name = "panelSV";
            this.panelSV.Size = new System.Drawing.Size(479, 342);
            this.panelSV.TabIndex = 22;
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheLoai.Location = new System.Drawing.Point(39, 150);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(97, 30);
            this.labelTheLoai.TabIndex = 4;
            this.labelTheLoai.Text = "Thể loại:";
            // 
            // labelSoNguoiDoc
            // 
            this.labelSoNguoiDoc.AutoSize = true;
            this.labelSoNguoiDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoNguoiDoc.Location = new System.Drawing.Point(39, 270);
            this.labelSoNguoiDoc.Name = "labelSoNguoiDoc";
            this.labelSoNguoiDoc.Size = new System.Drawing.Size(150, 30);
            this.labelSoNguoiDoc.TabIndex = 3;
            this.labelSoNguoiDoc.Text = "Số người đọc:";
            // 
            // labelNhaXuatBan
            // 
            this.labelNhaXuatBan.AutoSize = true;
            this.labelNhaXuatBan.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhaXuatBan.Location = new System.Drawing.Point(39, 210);
            this.labelNhaXuatBan.Name = "labelNhaXuatBan";
            this.labelNhaXuatBan.Size = new System.Drawing.Size(157, 30);
            this.labelNhaXuatBan.TabIndex = 2;
            this.labelNhaXuatBan.Text = "Nhà xuất bản: ";
            // 
            // labelTacGia
            // 
            this.labelTacGia.AutoSize = true;
            this.labelTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTacGia.Location = new System.Drawing.Point(39, 90);
            this.labelTacGia.Name = "labelTacGia";
            this.labelTacGia.Size = new System.Drawing.Size(91, 30);
            this.labelTacGia.TabIndex = 1;
            this.labelTacGia.Text = "Tác giả: ";
            // 
            // labelTenSach
            // 
            this.labelTenSach.AutoSize = true;
            this.labelTenSach.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSach.Location = new System.Drawing.Point(39, 30);
            this.labelTenSach.Name = "labelTenSach";
            this.labelTenSach.Size = new System.Drawing.Size(108, 30);
            this.labelTenSach.TabIndex = 0;
            this.labelTenSach.Text = "Tên sách: ";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(-100, -2);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView.RowHeadersWidth = 99;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(1233, 307);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // panelDGV
            // 
            this.panelDGV.BackColor = System.Drawing.Color.White;
            this.panelDGV.Controls.Add(this.dataGridView);
            this.panelDGV.Location = new System.Drawing.Point(1, 397);
            this.panelDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(1109, 287);
            this.panelDGV.TabIndex = 18;
            // 
            // roundedCornerTT
            // 
            this.roundedCornerTT.CornerRadius = 15;
            this.roundedCornerTT.TargetControl = this.panelTT;
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
            // roundedCornerPDGV
            // 
            this.roundedCornerPDGV.CornerRadius = 15;
            this.roundedCornerPDGV.TargetControl = this.panelDGV;
            // 
            // roundedCornerSV
            // 
            this.roundedCornerSV.CornerRadius = 15;
            this.roundedCornerSV.TargetControl = this.panelSV;
            // 
            // UserControlTKSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelTim);
            this.Controls.Add(this.panelXem);
            this.Controls.Add(this.panelBTTim);
            this.Controls.Add(this.panelSV);
            this.Controls.Add(this.panelDGV);
            this.Controls.Add(this.panelTT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlTKSach";
            this.Size = new System.Drawing.Size(1109, 684);
            this.Load += new System.EventHandler(this.UserControlMuonDoc_Load);
            this.panelTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelTim.ResumeLayout(false);
            this.panelTim.PerformLayout();
            this.panelXem.ResumeLayout(false);
            this.panelBTTim.ResumeLayout(false);
            this.panelSV.ResumeLayout(false);
            this.panelSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelDGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedCorner roundedCornerTT;
        private Panel panelTT;
        private RoundedCorner roundedCornerTim;
        private Panel panelTim;
        private TextBox textBoxTim;
        private Panel panelXem;
        private Button buttonXem;
        private RoundedCorner roundedCornerXem;
        private Panel panelBTTim;
        private Button buttonTim;
        private RoundedCorner roundedCornerBTTim;
        private Panel panelSV;
        private DataGridView dataGridView;
        private Panel panelDGV;
        private RoundedCorner roundedCornerPDGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private RoundedCorner roundedCornerSV;
        private Label labelTenSach;
        private Label labelTheLoai;
        private Label labelSoNguoiDoc;
        private Label labelNhaXuatBan;
        private Label labelTacGia;
    }
}
