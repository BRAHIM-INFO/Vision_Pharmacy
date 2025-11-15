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

namespace Vision_Pharmacy.Gui.PurchaseGui.Reintegrations
{
    public partial class ReintegrationsUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ReintegrationsUserControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReintegrationAddForm ReintegrationAddForm = new ReintegrationAddForm();
            ReintegrationAddForm.ShowDialog();
        }
    }
}
