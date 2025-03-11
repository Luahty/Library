using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public class RoundedCorner : Component
    {
        private Control targetControl;
        private int cornerRadius = 15;

        public RoundedCorner()
        {
        }

        public RoundedCorner(IContainer container)
        {
            container.Add(this);
        }

        public Control TargetControl
        {
            get => targetControl;
            set
            {
                targetControl = value;
                targetControl.SizeChanged += (sender, eventArgs) =>
                {
                    UpdateControlRegion();
                };
                UpdateControlRegion();
            }
        }

        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                cornerRadius = value;
                UpdateControlRegion();
            }
        }

        private void UpdateControlRegion()
        {
            if (targetControl != null)
            {
                IntPtr regionHandle = CreateRoundRectRgn(0, 0, targetControl.Width, targetControl.Height, cornerRadius, cornerRadius);
                Region region = Region.FromHrgn(regionHandle);
                targetControl.Region = region;
                DeleteObject(regionHandle); // Clean up GDI resources
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
    }
}
