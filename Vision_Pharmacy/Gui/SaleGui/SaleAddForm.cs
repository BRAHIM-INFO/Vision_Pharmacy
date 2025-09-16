using DevExpress.Xpo.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Office2010.Excel;
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
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.SaleGui;
using Vision_Pharmacy.Gui.CustomerGui;
using static Vision_Pharmacy.Gui.SaleGui.SaleAddForm;
using DevExpress.Utils.Svg; 
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraScheduler.Native;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic; 
using System.Drawing;
using System.IO;
using System.Linq; 
using System.Threading.Tasks;
using System.Windows.Forms; 
using Vision_Pharmacy.Gui.MedicationGui;
using DevExpress.Mvvm.POCO;

namespace Vision_Pharmacy.Gui.SaleGui
{
    public partial class SaleAddForm : DevExpress.XtraEditors.XtraForm 
    {  
        public SaleAddForm(int Id, SaleUserControl SaleUserControl)
        {
            InitializeComponent(); 
        }
    }
}