using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision_Pharmacy.Code
{
    public class AllClasses
    {

        //تحديد الحواف (Rounded Corners) في DevExpress Panel
        public void RoundPanelCorners(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        //تحديد الحواف (Rounded Corners) في DevExpress SimpleButton 
        public void RoundButtonCorners(SimpleButton simpleButton , int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(simpleButton.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(simpleButton.Width - radius, simpleButton.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, simpleButton.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            simpleButton.Region = new Region(path);
        }

        //تحديد الحواف (Rounded Corners) في DevExpress Panel
        public void RoundPictCorners(PictureBox panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures(); 
            panel.Region = new Region(path);
        }
         
        public void RoundPanelCornersForm(DevExpress.XtraEditors.XtraForm panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        // الحصول على اسم الشهر باللغة العربية بناءً على رقم الشهر
        public static string GetArabicMonthName(int monthNumber) 
        {
            string[] arabicMonths = new string[]
            {
        "جانفي", "فيفري", "مارس", "أفريل", "ماي", "جوان",
        "جويلية", "أوت", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"
            };

            if (monthNumber >= 1 && monthNumber <= 12)
                return arabicMonths[monthNumber - 1];
            else
                return "شهر غير صالح";
        }

        public static string GetEnglishMonthName(int monthNumber)
        {
            if (monthNumber < 1 || monthNumber > 12)
                return "Invalid Month";

            return System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames[monthNumber - 1];
        }


        public static int GetMonthNumber(string monthName)
        {
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;

            for (int i = 0; i < months.Length; i++)
            {
                if (months[i].Equals(monthName, StringComparison.InvariantCultureIgnoreCase))
                {
                    return i + 1; // لأن الفهرس يبدأ من 0
                }
            }

            return -1; // إذا لم يوجد الشهر
        }


    }
}
