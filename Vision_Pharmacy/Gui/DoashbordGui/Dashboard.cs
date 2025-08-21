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
using Vision_Pharmacy.Code;

namespace Vision_Pharmacy.Gui.DoashbordGui
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        AllClasses AllClasses = new AllClasses();
        public Dashboard()
        {
            InitializeComponent();
            // إعدادات أولية للنموذج
           AllClasses.RoundPanelCorners(PnlClients, 25); // 15 مثل bunifu
           AllClasses.RoundPanelCorners(pnl_Session, 25); // 15 مثل bunifu
           AllClasses.RoundPanelCorners(pnl_Cases, 25); // 15 مثل bunifu
           AllClasses.RoundPanelCorners(pnl_RH, 25); // 15 مثل bunifu
        }
    }
}
