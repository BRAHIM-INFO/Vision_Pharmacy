using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Vision_Pharmacy.Gui.OtherGui
{

    public partial class ToastNotificationForm : Form
    {
        private Label lblMessage;
        private System.Windows.Forms.Timer timerClose;

        public ToastNotificationForm(string message, int duration = 4000)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            Width = 400;
            Height = 60;
            BackColor = Color.White;
            Opacity = 0.95;
            ShowInTaskbar = false;
            TopMost = true;

            // زوايا دائرية
            Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 20, 20)
            );

            lblMessage = new Label()
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                Text = message,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Black,
            };

            Controls.Add(lblMessage);

            // تحديد موقع الإظهار أعلى الشاشة
            int x = Screen.PrimaryScreen.WorkingArea.Width / 2 - Width / 2;
            int y = 20;
            Location = new Point(x, y);

            // المؤقت لإغلاق النافذة
            timerClose = new System.Windows.Forms.Timer();
            timerClose.Interval = duration;
            timerClose.Tick += (s, e) => { Close(); };
            timerClose.Start();
        }

        // API لعمل زوايا دائرية
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
    }
    
}
