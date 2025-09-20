using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vision_Pharmacy.Gui.SaleGui
{
    public partial class SaleUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public SaleUserControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            SaleAddForm SaleAddForm = new SaleAddForm(0, this);
            SaleAddForm.ShowDialog();
        }
    }
}
