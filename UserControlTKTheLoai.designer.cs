using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlTKTheLoai
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTT = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTim = new System.Windows.Forms.Panel();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.panelXem = new System.Windows.Forms.Panel();
            this.buttonXem = new System.Windows.Forms.Button();
            this.panelBTTim = new System.Windows.Forms.Panel();
            this.buttonTim = new System.Windows.Forms.Button();
            this.panelSV = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelMssv = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.labelSlDoc = new System.Windows.Forms.Label();
            this.labelTLYThich = new System.Windows.Forms.Label();
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-17, 10);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(668, 383);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart Doc Sach";
            // 
            // panelTim
            // 
            this.panelTim.BackColor = System.Drawing.Color.White;
            this.panelTim.Controls.Add(this.textBoxTim);
            this.panelTim.Location = new System.Drawing.Point(823, 0);
            this.panelTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTim.Name = "panelTim";
            this.panelTim.Size = new System.Drawing.Size(167, 46);
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
            this.panelSV.Controls.Add(this.labelTLYThich);
            this.panelSV.Controls.Add(this.labelSlDoc);
            this.panelSV.Controls.Add(this.labelLop);
            this.panelSV.Controls.Add(this.labelMssv);
            this.panelSV.Controls.Add(this.labelHoTen);
            this.panelSV.Location = new System.Drawing.Point(633, 51);
            this.panelSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSV.Name = "panelSV";
            this.panelSV.Size = new System.Drawing.Size(479, 342);
            this.panelSV.TabIndex = 22;
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
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(39, 30);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(126, 31);
            this.labelHoTen.TabIndex = 0;
            this.labelHoTen.Text = "Họ và tên: ";
            // 
            // labelMssv
            // 
            this.labelMssv.AutoSize = true;
            this.labelMssv.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMssv.Location = new System.Drawing.Point(39, 90);
            this.labelMssv.Name = "labelMssv";
            this.labelMssv.Size = new System.Drawing.Size(88, 31);
            this.labelMssv.TabIndex = 1;
            this.labelMssv.Text = "MSSV: ";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLop.Location = new System.Drawing.Point(39, 150);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(65, 31);
            this.labelLop.TabIndex = 2;
            this.labelLop.Text = "Lớp: ";
            // 
            // labelSlDoc
            // 
            this.labelSlDoc.AutoSize = true;
            this.labelSlDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlDoc.Location = new System.Drawing.Point(39, 210);
            this.labelSlDoc.Name = "labelSlDoc";
            this.labelSlDoc.Size = new System.Drawing.Size(181, 31);
            this.labelSlDoc.TabIndex = 3;
            this.labelSlDoc.Text = "Số lần đọc sách:";
            // 
            // labelTLYThich
            // 
            this.labelTLYThich.AutoSize = true;
            this.labelTLYThich.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTLYThich.Location = new System.Drawing.Point(39, 270);
            this.labelTLYThich.Name = "labelTLYThich";
            this.labelTLYThich.Size = new System.Drawing.Size(202, 31);
            this.labelTLYThich.TabIndex = 4;
            this.labelTLYThich.Text = "Thể loại yêu thích:";
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
            // UserControlQuanLy
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
            this.Name = "UserControlQuanLy";
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
        private Label labelHoTen;
        private Label labelTLYThich;
        private Label labelSlDoc;
        private Label labelLop;
        private Label labelMssv;
    }
}
