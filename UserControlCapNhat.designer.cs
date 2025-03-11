using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlCapNhat
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
            this.panelNen = new System.Windows.Forms.Panel();
            this.panelSach = new System.Windows.Forms.Panel();
            this.buttonSach = new System.Windows.Forms.Button();
            this.roundedCornerNen = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerSach = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTheLoai = new System.Windows.Forms.Panel();
            this.buttonTheLoai = new System.Windows.Forms.Button();
            this.panelNXB = new System.Windows.Forms.Panel();
            this.buttonNXB = new System.Windows.Forms.Button();
            this.panelTacGia = new System.Windows.Forms.Panel();
            this.buttonTacGia = new System.Windows.Forms.Button();
            this.panelSinhVien = new System.Windows.Forms.Panel();
            this.buttonSinhVien = new System.Windows.Forms.Button();
            this.roundedCornerTheLoai = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerNXB = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTacGia = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerSinhVien = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelSach.SuspendLayout();
            this.panelTheLoai.SuspendLayout();
            this.panelNXB.SuspendLayout();
            this.panelTacGia.SuspendLayout();
            this.panelSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.Color.White;
            this.panelNen.Location = new System.Drawing.Point(0, 51);
            this.panelNen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(1109, 632);
            this.panelNen.TabIndex = 5;
            this.panelNen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNen_Paint);
            // 
            // panelSach
            // 
            this.panelSach.BackColor = System.Drawing.Color.White;
            this.panelSach.Controls.Add(this.buttonSach);
            this.panelSach.Location = new System.Drawing.Point(0, 0);
            this.panelSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSach.Name = "panelSach";
            this.panelSach.Size = new System.Drawing.Size(217, 46);
            this.panelSach.TabIndex = 0;
            // 
            // buttonSach
            // 
            this.buttonSach.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSach.Location = new System.Drawing.Point(-3, -3);
            this.buttonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSach.Name = "buttonSach";
            this.buttonSach.Size = new System.Drawing.Size(223, 52);
            this.buttonSach.TabIndex = 0;
            this.buttonSach.Text = "Sách";
            this.buttonSach.UseVisualStyleBackColor = true;
            this.buttonSach.Click += new System.EventHandler(this.buttonSach_Click);
            // 
            // roundedCornerNen
            // 
            this.roundedCornerNen.CornerRadius = 15;
            this.roundedCornerNen.TargetControl = this.panelNen;
            // 
            // roundedCornerSach
            // 
            this.roundedCornerSach.CornerRadius = 15;
            this.roundedCornerSach.TargetControl = this.panelSach;
            // 
            // panelTheLoai
            // 
            this.panelTheLoai.BackColor = System.Drawing.Color.White;
            this.panelTheLoai.Controls.Add(this.buttonTheLoai);
            this.panelTheLoai.Location = new System.Drawing.Point(223, 0);
            this.panelTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTheLoai.Name = "panelTheLoai";
            this.panelTheLoai.Size = new System.Drawing.Size(217, 46);
            this.panelTheLoai.TabIndex = 1;
            // 
            // buttonTheLoai
            // 
            this.buttonTheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonTheLoai.Location = new System.Drawing.Point(-3, -3);
            this.buttonTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTheLoai.Name = "buttonTheLoai";
            this.buttonTheLoai.Size = new System.Drawing.Size(223, 52);
            this.buttonTheLoai.TabIndex = 1;
            this.buttonTheLoai.Text = "Thể loại";
            this.buttonTheLoai.UseVisualStyleBackColor = true;
            this.buttonTheLoai.Click += new System.EventHandler(this.buttonTheLoai_Click);
            // 
            // panelNXB
            // 
            this.panelNXB.BackColor = System.Drawing.Color.White;
            this.panelNXB.Controls.Add(this.buttonNXB);
            this.panelNXB.Location = new System.Drawing.Point(446, 0);
            this.panelNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNXB.Name = "panelNXB";
            this.panelNXB.Size = new System.Drawing.Size(217, 46);
            this.panelNXB.TabIndex = 2;
            // 
            // buttonNXB
            // 
            this.buttonNXB.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonNXB.Location = new System.Drawing.Point(-3, -3);
            this.buttonNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNXB.Name = "buttonNXB";
            this.buttonNXB.Size = new System.Drawing.Size(223, 52);
            this.buttonNXB.TabIndex = 2;
            this.buttonNXB.Text = "Nhà xuất bản";
            this.buttonNXB.UseVisualStyleBackColor = true;
            this.buttonNXB.Click += new System.EventHandler(this.buttonNXB_Click);
            // 
            // panelTacGia
            // 
            this.panelTacGia.BackColor = System.Drawing.Color.White;
            this.panelTacGia.Controls.Add(this.buttonTacGia);
            this.panelTacGia.Location = new System.Drawing.Point(669, 0);
            this.panelTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTacGia.Name = "panelTacGia";
            this.panelTacGia.Size = new System.Drawing.Size(217, 46);
            this.panelTacGia.TabIndex = 3;
            // 
            // buttonTacGia
            // 
            this.buttonTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonTacGia.Location = new System.Drawing.Point(-3, -3);
            this.buttonTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTacGia.Name = "buttonTacGia";
            this.buttonTacGia.Size = new System.Drawing.Size(223, 52);
            this.buttonTacGia.TabIndex = 3;
            this.buttonTacGia.Text = "Tác giả";
            this.buttonTacGia.UseVisualStyleBackColor = true;
            this.buttonTacGia.Click += new System.EventHandler(this.buttonTacGia_Click);
            // 
            // panelSinhVien
            // 
            this.panelSinhVien.BackColor = System.Drawing.Color.White;
            this.panelSinhVien.Controls.Add(this.buttonSinhVien);
            this.panelSinhVien.Location = new System.Drawing.Point(892, 0);
            this.panelSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSinhVien.Name = "panelSinhVien";
            this.panelSinhVien.Size = new System.Drawing.Size(217, 46);
            this.panelSinhVien.TabIndex = 4;
            // 
            // buttonSinhVien
            // 
            this.buttonSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSinhVien.Location = new System.Drawing.Point(-3, -3);
            this.buttonSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSinhVien.Name = "buttonSinhVien";
            this.buttonSinhVien.Size = new System.Drawing.Size(223, 52);
            this.buttonSinhVien.TabIndex = 4;
            this.buttonSinhVien.Text = "Sinh viên";
            this.buttonSinhVien.UseVisualStyleBackColor = true;
            this.buttonSinhVien.Click += new System.EventHandler(this.buttonSinhVien_Click);
            // 
            // roundedCornerTheLoai
            // 
            this.roundedCornerTheLoai.CornerRadius = 15;
            this.roundedCornerTheLoai.TargetControl = this.panelTheLoai;
            // 
            // roundedCornerNXB
            // 
            this.roundedCornerNXB.CornerRadius = 15;
            this.roundedCornerNXB.TargetControl = this.panelNXB;
            // 
            // roundedCornerTacGia
            // 
            this.roundedCornerTacGia.CornerRadius = 15;
            this.roundedCornerTacGia.TargetControl = this.panelTacGia;
            // 
            // roundedCornerSinhVien
            // 
            this.roundedCornerSinhVien.CornerRadius = 15;
            this.roundedCornerSinhVien.TargetControl = this.panelSinhVien;
            // 
            // UserControlCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelTacGia);
            this.Controls.Add(this.panelNXB);
            this.Controls.Add(this.panelTheLoai);
            this.Controls.Add(this.panelSinhVien);
            this.Controls.Add(this.panelSach);
            this.Controls.Add(this.panelNen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlCapNhat";
            this.Size = new System.Drawing.Size(1109, 683);
            this.panelSach.ResumeLayout(false);
            this.panelTheLoai.ResumeLayout(false);
            this.panelNXB.ResumeLayout(false);
            this.panelTacGia.ResumeLayout(false);
            this.panelSinhVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNen;
        private Panel panelSach;
        private RoundedCorner roundedCornerNen;
        private RoundedCorner roundedCornerSach;
        private Panel panelTheLoai;
        private Panel panelNXB;
        private Panel panelTacGia;
        private Panel panelSinhVien;
        private RoundedCorner roundedCornerTheLoai;
        private RoundedCorner roundedCornerNXB;
        private RoundedCorner roundedCornerTacGia;
        private RoundedCorner roundedCornerSinhVien;
        private Button buttonTheLoai;
        private Button buttonNXB;
        private Button buttonTacGia;
        private Button buttonSinhVien;
        private Button buttonSach;
    }
}
