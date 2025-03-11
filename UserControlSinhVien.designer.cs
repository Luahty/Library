using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class UserControlSinhVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel panelLamMoi;

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
            this.panelLamMoi = new System.Windows.Forms.Panel();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.roundedCornerLamMoi = new QuanLyThuVien.RoundedCorner(this.components);
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedCornerFLP = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelFLP = new System.Windows.Forms.Panel();
            this.roundedCornerPBT = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelbuttonTim = new System.Windows.Forms.Panel();
            this.buttonTim = new System.Windows.Forms.Button();
            this.roundedCornerPTTim = new QuanLyThuVien.RoundedCorner(this.components);
            this.panelTextBoxTim = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.panelLamMoi.SuspendLayout();
            this.panelFLP.SuspendLayout();
            this.panelbuttonTim.SuspendLayout();
            this.panelTextBoxTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLamMoi
            // 
            this.panelLamMoi.BackColor = System.Drawing.Color.White;
            this.panelLamMoi.Controls.Add(this.buttonLamMoi);
            this.panelLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.panelLamMoi.Location = new System.Drawing.Point(0, 0);
            this.panelLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLamMoi.Name = "panelLamMoi";
            this.panelLamMoi.Size = new System.Drawing.Size(204, 46);
            this.panelLamMoi.TabIndex = 1;
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonLamMoi.Location = new System.Drawing.Point(-3, -3);
            this.buttonLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(210, 52);
            this.buttonLamMoi.TabIndex = 1;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // roundedCornerLamMoi
            // 
            this.roundedCornerLamMoi.CornerRadius = 15;
            this.roundedCornerLamMoi.TargetControl = this.panelLamMoi;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 13);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1123, 426);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // roundedCornerFLP
            // 
            this.roundedCornerFLP.CornerRadius = 15;
            this.roundedCornerFLP.TargetControl = this.panelFLP;
            // 
            // panelFLP
            // 
            this.panelFLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFLP.BackColor = System.Drawing.Color.White;
            this.panelFLP.Controls.Add(this.flowLayoutPanel);
            this.panelFLP.Location = new System.Drawing.Point(0, 51);
            this.panelFLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFLP.Name = "panelFLP";
            this.panelFLP.Size = new System.Drawing.Size(1110, 450);
            this.panelFLP.TabIndex = 8;
            // 
            // roundedCornerPBT
            // 
            this.roundedCornerPBT.CornerRadius = 15;
            this.roundedCornerPBT.TargetControl = this.panelbuttonTim;
            // 
            // panelbuttonTim
            // 
            this.panelbuttonTim.BackColor = System.Drawing.Color.White;
            this.panelbuttonTim.Controls.Add(this.buttonTim);
            this.panelbuttonTim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.panelbuttonTim.Location = new System.Drawing.Point(905, 0);
            this.panelbuttonTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelbuttonTim.Name = "panelbuttonTim";
            this.panelbuttonTim.Size = new System.Drawing.Size(204, 46);
            this.panelbuttonTim.TabIndex = 4;
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonTim.Location = new System.Drawing.Point(-3, -3);
            this.buttonTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(210, 52);
            this.buttonTim.TabIndex = 0;
            this.buttonTim.Text = "Tìm kiếm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // roundedCornerPTTim
            // 
            this.roundedCornerPTTim.CornerRadius = 15;
            this.roundedCornerPTTim.TargetControl = this.panelTextBoxTim;
            // 
            // panelTextBoxTim
            // 
            this.panelTextBoxTim.BackColor = System.Drawing.Color.White;
            this.panelTextBoxTim.Controls.Add(this.label1);
            this.panelTextBoxTim.Controls.Add(this.textBoxTim);
            this.panelTextBoxTim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.panelTextBoxTim.Location = new System.Drawing.Point(210, 0);
            this.panelTextBoxTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTextBoxTim.Name = "panelTextBoxTim";
            this.panelTextBoxTim.Size = new System.Drawing.Size(689, 46);
            this.panelTextBoxTim.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = " 🔍";
            // 
            // textBoxTim
            // 
            this.textBoxTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTim.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBoxTim.Location = new System.Drawing.Point(62, 11);
            this.textBoxTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(628, 31);
            this.textBoxTim.TabIndex = 0;
            // 
            // UserControlSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelFLP);
            this.Controls.Add(this.panelTextBoxTim);
            this.Controls.Add(this.panelbuttonTim);
            this.Controls.Add(this.panelLamMoi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlSinhVien";
            this.Size = new System.Drawing.Size(1109, 502);
            this.Load += new System.EventHandler(this.UserControlSinhVien_Load);
            this.panelLamMoi.ResumeLayout(false);
            this.panelFLP.ResumeLayout(false);
            this.panelbuttonTim.ResumeLayout(false);
            this.panelTextBoxTim.ResumeLayout(false);
            this.panelTextBoxTim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedCorner roundedCornerLamMoi;
        private FlowLayoutPanel flowLayoutPanel;
        private RoundedCorner roundedCornerFLP;
        private RoundedCorner roundedCornerPBT;
        private Panel panelbuttonTim;
        private RoundedCorner roundedCornerPTTim;
        private Panel panelTextBoxTim;
        private Panel panelFLP;
        private Button buttonTim;
        private TextBox textBoxTim;
        private Label label1;
        private Button buttonLamMoi;
    }
}
