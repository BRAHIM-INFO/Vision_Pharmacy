using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vision_Pharmacy.Gui.OtherGui
{
    public partial class WaitFormGui : Form
    {
        public WaitFormGui()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides
        private static WaitFormGui _Instacne;
        
        public static WaitFormGui Instance()
        {
            return _Instacne ?? (_Instacne = new WaitFormGui());
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}