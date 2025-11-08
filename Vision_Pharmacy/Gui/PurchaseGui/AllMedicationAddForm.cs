using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler.Native;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.SupplierGui;

namespace Vision_Pharmacy.Gui.PurchaseGui
{
    public partial class AllMedicationAddForm : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private readonly int id;
        private IDataHelper<Purchase> _dataHelperPurchase;
        private IDataHelper<Medication> _dataHelperMedication;


        public AllMedicationAddForm()
        {
            InitializeComponent();

            _dataHelperPurchase = (IDataHelper<Purchase>)ContainerConfig.ObjectType("Purchase");
            _dataHelperMedication = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
        }

        public class PurchaseListView
        {
            public string FactureNum { get; set; }
            public DateTime FactureDate { get; set; }
            public string SupplierName { get; set; }
            public string Barcode { get; set; }
            public string Name { get; set; }
            public string GenericName { get; set; }
            public int QuantityInStock { get; set; }
            public decimal PurchasePrice { get; set; }
            public decimal SalePrice { get; set; }
            // حقل محسوب تلقائيًا لكل سطر
            public decimal Total => QuantityInStock * PurchasePrice;
        }

        private decimal GetTotalAmount(List<PurchaseListView> purchasesList)
        {
            return purchasesList.Sum(p => p.Total);
        }


        private void AllMedicationAddForm_Load(object sender, EventArgs e)
        {
            var purchasesList = (from p in _dataHelperPurchase.GetData()
                                 join m in _dataHelperMedication.GetData()
                                 on p.Barcode equals m.Barcode
                                 select new PurchaseListView
                                 {
                                     FactureNum = p.FactureNum,
                                     FactureDate = p.FactureDate,
                                     SupplierName = p.SupplierName,
                                     Barcode = p.Barcode,
                                     Name = m.Name,
                                     GenericName = m.GenericName,
                                     QuantityInStock = m.QuantityInStock,
                                     PurchasePrice = p.PurchasePrice,
                                     SalePrice = p.SalePrice

                                 }).ToList();

            DGListePurchase.DataSource = purchasesList;

            gridView1.Columns["Barcode"].Caption = "الباركود";
            gridView1.Columns["Name"].Caption = "اسم الدواء";
            gridView1.Columns["GenericName"].Caption = "الاسم العلمي";
            gridView1.Columns["QuantityInStock"].Caption = "الكمية المتوفرة";
            gridView1.Columns["PurchasePrice"].Caption = "سعر الشراء";
            gridView1.Columns["SalePrice"].Caption = "سعر البيع";
            gridView1.Columns["FactureNum"].Caption = "رقم الفاتورة";
            gridView1.Columns["FactureDate"].Caption = "تاريخ الفاتورة";
            gridView1.Columns["SupplierName"].Caption = "المورد";
            gridView1.Columns["Total"].Caption = "المجموع";

            decimal totalAmount = GetTotalAmount(purchasesList);
            txtTotalAmount.Text = totalAmount.ToString("N2");

            // gridView1.Columns["Total"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // gridView1.Columns["Total"].SummaryItem.DisplayFormat = "الإجمالي: {0:N2}";



        }

        // تحديث السعر الاجمالي 
        private void UpdateFilteredTotal()
        {
            decimal total = 0;

            // gridView1.DataRowCount يعطي عدد الصفوف الظاهرة فقط بعد الفلترة
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                total += Convert.ToDecimal(gridView1.GetRowCellValue(i, "Total"));
            }

            txtTotalAmount.Text = total.ToString("N2");
        }


        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            UpdateFilteredTotal();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintGridControl();
        }

        private void PrintGridControl()
        {
            try
            {
                // 1️⃣ إنشاء نظام الطباعة ورابط الطباعة
                PrintingSystem printingSystem = new PrintingSystem();
                PrintableComponentLink printableLink = new PrintableComponentLink(printingSystem)
                {
                    Component = DGListePurchase
                };

                // 2️⃣ إعداد رأس الصفحة مع النصوص والصورة
                printableLink.CreateMarginalHeaderArea += (sender, e) =>
                {
                    // 🔹 تحميل الصورة (تأكد من تغيير المسار إلى مسار الصورة الصحيح)
                    Image logo = Properties.Resources.logo_2025; // ⬅️ ضع مسار الصورة الصحيح هنا

                    // 🔹 رسم الصورة في الزاوية اليسرى
                    RectangleF imageRect = new RectangleF(10, 10, 230, 150);
                    e.Graph.DrawImage(logo, imageRect);

                    // 🔹 نصوص الرأس (اسم الشركة والإدارات)
                    string headerText = Properties.Settings.Default.CompanyName + "\n" + Properties.Settings.Default.CompanyAdress + "\n" + Properties.Settings.Default.CompanyEmail + "\n" + " رقم الهاتف : " + Properties.Settings.Default.CompanyTel;
                    e.Graph.Font = new Font("Cairo Medium", 12, FontStyle.Bold); // ⬅️ استخدام خط "Cairo Medium"
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين
                    e.Graph.DrawString(headerText, Color.Black, new RectangleF(240, 10, 600, 120), DevExpress.XtraPrinting.BorderSide.None);

                    // 🔹 رسم مستطيل رمادي خلف العنوان باستخدام DrawRect
                    //RectangleF titleRect = new RectangleF(10, 145, 1050, 40);
                    //e.Graph.DrawRect(titleRect, BorderSide.All, Color.White, Color.White);  // ⬅️ مستطيل رمادي مع حدود سوداء

                    // 🔹 عنوان التقرير (منتصف الصفحة)
                    string title = "قائمة كل المشتريات ";
                    if (Properties.Settings.Default.ChangeLang == "Ar") title = "قائمة كل المشتريات ";
                    else title = "Purchases All List";
                    e.Graph.Font = new Font("Cairo Medium", 18, FontStyle.Bold);
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين 
                    e.Graph.DrawString(title, Color.Black, new RectangleF(350, 150, 1250, 45), DevExpress.XtraPrinting.BorderSide.None);
                    //e.Graph.DrawString(title, titleRect);

                    //// 🔹 التاريخ في الزاوية اليمنى
                    string date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    if (Properties.Settings.Default.ChangeLang == "Ar") date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    else date = "Date : " + DateTime.Now.ToShortDateString();

                    e.Graph.Font = new Font("Cairo Medium", 12);
                    e.Graph.DrawString(date, Color.Black, new RectangleF(10, 170, 250, 30), DevExpress.XtraPrinting.BorderSide.None);
                };

                // 4️⃣ تعيين إعدادات الورق (A4 - أفقي) مع هوامش إضافية
                printableLink.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
                printableLink.Landscape = true;
                printableLink.Margins = new System.Drawing.Printing.Margins(20, 20, 230, 80); // ⬅️ زيادة الهامش العلوي لمنع التداخل
                printableLink.RightToLeftLayout = true; // ⬅️ تفعيل RTL
                // 5️⃣ عرض معاينة الطباعة
                printableLink.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                if (Properties.Settings.Default.ChangeLang == "Ar")
                    MessageBox.Show("❌ خطأ أثناء الطباعة: " + ex.Message);
                else MessageBox.Show("❌ Error during printing: " + ex.Message);
            }
        }
    }
}