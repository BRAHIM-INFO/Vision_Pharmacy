
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Code
{
    public class ComponentsObject
    {
        private static ComponentsObject _ClassObject;
        private Label labelEmptyData;
        protected ComponentsObject()
        {

        }
        // Singleton Instance
        public static ComponentsObject Instance()
        {
            return _ClassObject ?? (new ComponentsObject());
        }
        // Create Label for Empty Value
        public Label LabelEmptyData()
        {
            labelEmptyData = new Label();
            labelEmptyData.Visible = false;
            labelEmptyData.AutoSize = false;
            labelEmptyData.Dock = DockStyle.Bottom;
            labelEmptyData.Size = new System.Drawing.Size(300, 80);
            if (Properties.Settings.Default.ChangeLang == "Ar")
                labelEmptyData.Text = Resources_Ar.EmptyDataText;
            else labelEmptyData.Text = Resources_En.EmptyDataText;
            labelEmptyData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelEmptyData.Font = new System.Drawing.Font("Cairo Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            return labelEmptyData;
        }
    }
}
