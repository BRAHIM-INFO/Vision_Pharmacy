using DevExpress.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraReports.UI;
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
using Vision_Pharmacy.Gui.UserGui; 
namespace Vision_Pharmacy.Gui.SupplierGui
{
    public partial class SupplierUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private readonly IDataHelper<Suppliers> _dataHelper;
        private readonly LoadingUser loading;
        private int RowId;
        private static SupplierUserControl _supplierUser;
        private List<int> IdList = new List<int>();
        private Label labelEmptyData;
        private string searchItem;

        // Constructores
        public SupplierUserControl()
        {
            InitializeComponent();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelper = (IDataHelper<Suppliers>)ContainerConfig.ObjectType("Supplier");
            loading = LoadingUser.Instance();
            LoadData();
            gridView1.OptionsBehavior.Editable = false;
        }


        #region Events
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            SupplierAddForm customerAdd = new SupplierAddForm(0, this);
            customerAdd.ShowDialog();
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                SupplierAddForm customerAdd = new SupplierAddForm(RowId, this);
                customerAdd.ShowDialog();
            }
            else
            {
                MessageCollection.ShowEmptyDataMessage();
            } 
        }

        private void btnDeleteSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    SetIDSelcted();
                    var result = MessageCollection.DeleteActtion();
                    if (result == true)
                    {
                        loading.Show();
                        if (_dataHelper.IsDbConnect())
                        {
                            if (IdList.Count > 0)
                            {
                                for (int i = 0; i < IdList.Count; i++)
                                {
                                    RowId = IdList[i];
                                    _dataHelper.Delete(RowId);
                                }
                                LoadData();
                                MessageCollection.ShowDeletNotification();
                            }
                            else
                            {
                                MessageCollection.ShowSlectRowsNotification();

                            }

                        }
                        else
                        {
                            MessageCollection.ShowServerMessage();
                        }
                    }
                }
                else
                {
                    MessageCollection.ShowEmptyDataMessage();

                }
            }
            catch
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        private void btnPrintSup_Click(object sender, EventArgs e)
        {
            PrintGridControl();
        //    var view = DGListeSupplier.MainView as GridView;
        //    if (view == null)
        //        return;

            //    // إعدادات RTL
            //    view.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            //    view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

            //    PrintingSystem ps = new PrintingSystem();
            //    PrintableComponentLink link = new PrintableComponentLink(ps)
            //    {
            //        Component = DGListeSupplier,
            //        Landscape = false,
            //     };

            //    var headerFooter = link.PageHeaderFooter as PageHeaderFooter;
            //    if (headerFooter != null)
            //    {
            //        headerFooter.Header.Content.Clear();
            //        headerFooter.Header.Content.AddRange(new string[] {
            //    "صيدلية الشفاء\nالعنوان: شارع الاستقلال\nالهاتف: 0550000000", // اليسار (يظهر كيمين في RTL)
            //    "",
            //    ""
            //});
            //        headerFooter.Header.Font = new Font("Cairo Medium", 12, FontStyle.Bold);
            //        headerFooter.Header.LineAlignment = BrickAlignment.Near;
            //    }

            //    link.CreateDocument();
            //    link.ShowPreview();

            //PrintingSystem ps = new PrintingSystem();
            //PrintableComponentLink link = new PrintableComponentLink(ps)
            //{
            //    Component = DGListeSupplier
            //};

            //link.CreateDocument(); // يجب استدعاؤه قبل المعاينة

            //// عرض نافذة المعاينة
            //link.ShowPreview(); // ✅ هذا الصحيح، وليس ReportPrintTool
        }
        #endregion


        // Methods
        #region Methods 
        private void PrintGridControl()
        {
            try
            {
                // 1️⃣ إنشاء نظام الطباعة ورابط الطباعة
                PrintingSystem printingSystem = new PrintingSystem();
                PrintableComponentLink printableLink = new PrintableComponentLink(printingSystem)
                {
                    Component = DGListeSupplier
                };

                // 2️⃣ إعداد رأس الصفحة مع النصوص والصورة
                printableLink.CreateMarginalHeaderArea += (sender, e) =>
                {
                    // 🔹 تحميل الصورة (تأكد من تغيير المسار إلى مسار الصورة الصحيح)
                    Image logo = Image.FromFile("LOGO.jpg"); // ⬅️ ضع مسار الصورة الصحيح هنا

                    // 🔹 رسم الصورة في الزاوية اليسرى
                    RectangleF imageRect = new RectangleF(10, 10, 230, 100);
                    e.Graph.DrawImage(logo, imageRect);

                    // 🔹 نصوص الرأس (اسم الشركة والإدارات)
                    string headerText = "صيدلية الشفاء" +"\n" + "العنوان : بغداد - العراق" + "\n" + "الهاتف : 05632135215313\nMAGASIN CENTRAL DU PDR";
                    e.Graph.Font = new Font("Cairo Medium", 12, FontStyle.Bold); // ⬅️ استخدام خط "Cairo Medium"
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين
                    e.Graph.DrawString(headerText, Color.Black, new RectangleF(240, 10, 600, 120), BorderSide.None);

                    // 🔹 رسم مستطيل رمادي خلف العنوان باستخدام DrawRect
                    //RectangleF titleRect = new RectangleF(10, 145, 1050, 40);
                    //e.Graph.DrawRect(titleRect, BorderSide.All, Color.White, Color.White);  // ⬅️ مستطيل رمادي مع حدود سوداء

                    // 🔹 عنوان التقرير (منتصف الصفحة)
                    string title = "قائمة الموردين ";
                    e.Graph.Font = new Font("Cairo Medium", 18, FontStyle.Bold);
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين 
                    e.Graph.DrawString(title, Color.Black, new RectangleF(350, 150, 1250, 45), BorderSide.None);
                    //e.Graph.DrawString(title, titleRect);

                    //// 🔹 التاريخ في الزاوية اليمنى
                    string date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    e.Graph.Font = new Font("Cairo Medium", 12);
                    e.Graph.DrawString(date, Color.Black, new RectangleF(750, 150, 200, 30), BorderSide.None);
                };

                // 3️⃣ إعداد التذييل في أسفل الصفحة
                //printableLink.CreateMarginalFooterArea += (sender, e) =>
                //{
                //    // 🔹 المبلغ الكلي في الأسفل
                //    string totalAmount = "MONTANT TOTAL: ";
                //    e.Graph.Font = new Font("Cairo Medium", 14, FontStyle.Bold);
                //    e.Graph.DrawString(totalAmount, Color.Black, new RectangleF(650, 10, 200, 45), BorderSide.None);
                //};

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
                MessageBox.Show("❌ خطأ أثناء الطباعة: " + ex.Message);
            }
        }
        public async void LoadData()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelper.IsDbConnect())
            {
                // Loading Data
                DGListeSupplier.DataSource = await Task.Run(() => _dataHelper.GetData());

                SetDataGridViewColumns();
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();

            // Show Empty Label Data
            ShowLabelIfEmptyData();
        }

        // Get a List of Id for selcted rows
        private void SetIDSelcted()
        {
            foreach (int rowHandle in gridView1.GetSelectedRows())
            {
                object value = gridView1.GetRowCellValue(rowHandle, "Id");
                if (value != null && int.TryParse(value.ToString(), out int id))
                {
                    IdList.Add(id);
                }
            }

        }
        private void SetDataGridViewColumns()
        {
            try
            {
                gridView1.Columns[0].Caption = "المعرف";
                gridView1.Columns[1].Caption = "الاسم الكامل";
                gridView1.Columns[2].Caption = "اسم المورد";
                gridView1.Columns[3].Caption = "العنوان";
                gridView1.Columns[4].Caption = "الهاتف";
                gridView1.Columns[5].Caption = "البريد الإلكتروني"; 
                gridView1.Columns[6].Caption = "نشط";
                gridView1.Columns[7].Caption = "ملاحظات إضافية"; 
            }
            catch
            {
                // تجاهل الخطأ (يفضل تسجيله)
            } 
            // Hide Columns
        }

        // Singleton Instance
        public static UserControl Instance()
        {
            return _supplierUser ?? (new SupplierUserControl());
        }
        //Add and Show Empty Label 
        private void ShowLabelIfEmptyData()
        {
            DGListeSupplier.Controls.Add(labelEmptyData);

            if (gridView1.RowCount > 0)
            {
                labelEmptyData.Visible = false;
            }
            else
            {
                labelEmptyData.Visible = true;
            }

        }



        #endregion

    }
}
