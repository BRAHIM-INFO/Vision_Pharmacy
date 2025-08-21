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
    public partial class NotifictionUser : Form
    {
        public NotifictionUser(string Caption)
        {
            InitializeComponent();
            labelNotifictionCatption.Text = Caption;
            timerhide.Interval = Properties.Settings.Default.NotificationTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void labelNotifictionCatption_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
