using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlThongKe
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
            this.panelTKTheLoai = new System.Windows.Forms.Panel();
            this.buttonTKTheLoai = new System.Windows.Forms.Button();
            this.panelTKSach = new System.Windows.Forms.Panel();
            this.buttonTKSach = new System.Windows.Forms.Button();
            this.roundedCornerNen = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTKTheLoai = new QuanLyThuVien.RoundedCorner(this.components);
            this.roundedCornerTKSach = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTKTheLoai.SuspendLayout();
            this.panelTKSach.SuspendLayout();
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
            // panelTKTheLoai
            // 
            this.panelTKTheLoai.BackColor = System.Drawing.Color.White;
            this.panelTKTheLoai.Controls.Add(this.buttonTKTheLoai);
            this.panelTKTheLoai.Location = new System.Drawing.Point(0, 0);
            this.panelTKTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTKTheLoai.Name = "panelTKTheLoai";
            this.panelTKTheLoai.Size = new System.Drawing.Size(553, 46);
            this.panelTKTheLoai.TabIndex = 0;
            // 
            // buttonTKTheLoai
            // 
            this.buttonTKTheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonTKTheLoai.Location = new System.Drawing.Point(-3, -3);
            this.buttonTKTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTKTheLoai.Name = "buttonTKTheLoai";
            this.buttonTKTheLoai.Size = new System.Drawing.Size(557, 52);
            this.buttonTKTheLoai.TabIndex = 0;
            this.buttonTKTheLoai.Text = "Thể loại đọc nhiều nhất";
            this.buttonTKTheLoai.UseVisualStyleBackColor = true;
            this.buttonTKTheLoai.Click += new System.EventHandler(this.buttonTKTheLoai_Click);
            // 
            // panelTKSach
            // 
            this.panelTKSach.BackColor = System.Drawing.Color.White;
            this.panelTKSach.Controls.Add(this.buttonTKSach);
            this.panelTKSach.Location = new System.Drawing.Point(556, 0);
            this.panelTKSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTKSach.Name = "panelTKSach";
            this.panelTKSach.Size = new System.Drawing.Size(553, 46);
            this.panelTKSach.TabIndex = 2;
            // 
            // buttonTKSach
            // 
            this.buttonTKSach.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonTKSach.Location = new System.Drawing.Point(-3, -3);
            this.buttonTKSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTKSach.Name = "buttonTKSach";
            this.buttonTKSach.Size = new System.Drawing.Size(557, 52);
            this.buttonTKSach.TabIndex = 2;
            this.buttonTKSach.Text = "Sách đọc nhiều nhất";
            this.buttonTKSach.UseVisualStyleBackColor = true;
            this.buttonTKSach.Click += new System.EventHandler(this.buttonTKSach_Click);
            // 
            // roundedCornerNen
            // 
            this.roundedCornerNen.CornerRadius = 15;
            this.roundedCornerNen.TargetControl = this.panelNen;
            // 
            // roundedCornerTKTheLoai
            // 
            this.roundedCornerTKTheLoai.CornerRadius = 15;
            this.roundedCornerTKTheLoai.TargetControl = this.panelTKTheLoai;
            // 
            // roundedCornerTKSach
            // 
            this.roundedCornerTKSach.CornerRadius = 15;
            this.roundedCornerTKSach.TargetControl = this.panelTKSach;
            // 
            // UserControlThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelTKSach);
            this.Controls.Add(this.panelTKTheLoai);
            this.Controls.Add(this.panelNen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlThongKe";
            this.Size = new System.Drawing.Size(1109, 683);
            this.panelTKTheLoai.ResumeLayout(false);
            this.panelTKSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNen;
        private Panel panelTKTheLoai;
        private RoundedCorner roundedCornerNen;
        private RoundedCorner roundedCornerTKTheLoai;
        private Panel panelTKSach;
        private RoundedCorner roundedCornerTKSach;
        private Button buttonTKSach;
        private Button buttonTKTheLoai;
    }
}
