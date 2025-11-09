using ClosedXML.Excel;
using DevExpress.CodeParser;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
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
using Vision_Pharmacy.Gui.CustomerGui;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.PurchaseGui
{
    public partial class PurchaseUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private readonly IDataHelper<Purchase> _dataHelper;
        private IDataHelper<Medication> _dataHelperMedication;
        private readonly LoadingUser loading;
        private int RowId;
        private static PurchaseUserControl _PurchaseUserControl;
        private List<int> IdList;
        private System.Windows.Forms.Label labelEmptyData;
        private string searchItem;
        private RepositoryItemButtonEdit actionButtons;
        AllClasses AllClasses = new AllClasses();
        public PurchaseUserControl()
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelper = (IDataHelper<Purchase>)ContainerConfig.ObjectType("Purchase");
            _dataHelperMedication = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            AllClasses.RoundButtonCorners(btnAdd, 15);
            AllClasses.RoundButtonCorners(btnPrint, 15);
            LoadData();
             
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                ApplyArabicResources();
            }
            else
            {
                ApplyEnglishResources();
            }

        }


        private void btnAddPurch_Click(object sender, EventArgs e)
        {
            purchAddForm purchUserControl = new purchAddForm(0, this);
            purchUserControl.ShowDialog();
            //PurchaseAddForm PurchaseAddForm = new PurchaseAddForm(0, this);
            //PurchaseAddForm.ShowDialog();
        }


        //Event Handlers
        #region 
        public void DeleteFacture(string factureNum)
        {
            try
            {
                var factureItem = _dataHelper.GetData().Where(p => p.FactureNum == factureNum).ToList();
                // إرجاع الكميات إلى جدول Medication
                foreach (var item in factureItem)
                {
                    var medication = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == item.Barcode);
                    if (medication != null)
                    {
                        medication.QuantityInStock -= item.Quantity;
                        if (medication.QuantityInStock < 0)
                            medication.QuantityInStock = 0; // تجنب القيم السالبة 

                    }
                    _dataHelperMedication.Edit(medication); // تحديث الكمية في جدول Medication
                    _dataHelper.Delete(item.Id);
                    RecalculateMedicationPrice(item.Barcode);
                } 
            }
            catch (Exception ex)
            {
                // في حالة حدوث خطأ، يمكن تسجيله أو إظهاره للمستخدم
            }
        }
         
        public void RecalculateMedicationPrice(string barcode)
        {
            var factureItem = _dataHelper.GetData().Where(p => p.Barcode == barcode).ToList();
            var medication = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == barcode);
            if (medication == null) return;
            if (factureItem.Any())
            { 
                // مجموع التكاليف
                decimal totalCost = factureItem.Sum(p => p.Quantity * p.PurchasePrice);

                // مجموع الكمية
                int totalQty = factureItem.Sum(p => p.Quantity);

                // السعر المرجح
                medication.PurchasePrice = totalQty > 0 ? totalCost / totalQty : 0;

                // الكمية الإجمالية
                medication.QuantityInStock = totalQty;


                // مجموع التكاليف
                decimal totalCostSal = factureItem.Sum(p => p.Quantity * p.SalePrice);

                // مجموع الكمية
                int totalQtySal = factureItem.Sum(p => p.Quantity);

                // السعر المرجح
                medication.SalePrice = totalQtySal > 0 ? totalCostSal / totalQtySal : 0;

                // الكمية الإجمالية
                medication.QuantityInStock = totalQtySal;
            }
            else
            {
                // إذا ما بقات حتى فاتورة → صفر
                medication.SalePrice = 0;
                medication.PurchasePrice = 0;
                medication.QuantityInStock = 0; 
            }

            _dataHelperMedication.Edit(medication); // تحديث الكمية والسعر في جدول Medication

            //using (var db = new AppDbContext())
            //    {
            //        // نجيب جميع الفواتير المتبقية لهذا المنتج
            //        //var purchases = db.Purchases
            //        //                  .Where(p => p.Barcode == barcode)
            //        //                  .ToList();

            //        //var medication = db.Medications.FirstOrDefault(m => m.Barcode == barcode);
            //        //if (medication == null) return;

            //        if (purchases.Any())
            //        {
            //            // مجموع التكاليف
            //            decimal totalCost = purchases.Sum(p => p.Quantity * p.PurchasePrice);

            //            // مجموع الكمية
            //            int totalQty = purchases.Sum(p => p.Quantity);

            //            // السعر المرجح
            //            medication.PurchasePrice = totalQty > 0 ? totalCost / totalQty : 0;

            //            // الكمية الإجمالية
            //            medication.QuantityInStock = totalQty;
            //        }
            //        else
            //        {
            //            // إذا ما بقات حتى فاتورة → صفر
            //            medication.PurchasePrice = 0;
            //            medication.QuantityInStock = 0;
            //        }

            //        db.SaveChanges();
            //    }
        }

        /// <summary>
        ///  اجراءات الأزرار في عمود الإجراءات )عرض، تعديل، حذف(
        private void ActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.Grid.GridView)DGListePurchase.MainView;
            var row = view.GetFocusedRow() as Purchase;
            if (row == null) return;

            // 1) التمييز بالـ Tag (الأفضل)
            var tag = e.Button.Tag as string;
            if (!string.IsNullOrEmpty(tag))
            {
                switch (tag)
                {
                    case "view":
                        {
                            // عرض تفاصيل الدواء
                            RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                            purchAddForm customerAdd = new purchAddForm(RowId, this);
                            customerAdd.btnSave.Visible = false; // إخفاء زر الحفظ
                            customerAdd.ShowDialog();
                            return;

                        }
                    case "edit":
                        {
                            if (gridView1.RowCount > 0)
                            {
                                RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                                purchAddForm customerAdd = new purchAddForm(RowId, this);
                                customerAdd.ShowDialog();
                            }
                            else
                            {
                                MessageCollection.ShowEmptyDataMessage();
                            }
                            return;
                        }
                    case "delete":
                        {
                            try
                            {

                                if (MessageBox.Show($"هل تريد حذف فاتورة رقم :  {row.FactureNum}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    loading.Show();
                                    DeleteFacture(row.FactureNum);
                                }

                            }
                            catch
                            {
                                MessageCollection.ShowServerMessage();
                            }
                            loading.Hide();
                            return;
                        }
                }
            }

            // 2) فfallback بالفهرس داخل نفس الـ Repository (لو لأي سبب الـ Tag ماوصل)
            var repo = (RepositoryItemButtonEdit)sender;
            int idx = repo.Buttons.IndexOf(e.Button); // 0=view, 1=edit, 2=delete
            if (idx == 0)
            {
                // عرض تفاصيل الدواء
                RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                purchAddForm customerAdd = new purchAddForm(RowId, this);
                customerAdd.btnSave.Visible = false; // إخفاء زر الحفظ
                customerAdd.ShowDialog();
            }
            else if (idx == 1)
            {
                if (gridView1.RowCount > 0)
                {
                    RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                    purchAddForm customerAdd = new purchAddForm(RowId, this);
                    customerAdd.ShowDialog();
                }
                else
                {
                    MessageCollection.ShowEmptyDataMessage();
                }
            }

            else if (idx == 2)
            {
                if (MessageBox.Show($"هل تريد حذف فاتورة رقم :  {row.FactureNum}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                  DeleteFacture(row.FactureNum);
                }
            } 
        }

        #endregion


        // Methods 
        #region Methods
        public async void LoadData()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelper.IsDbConnect())
            {
                // Loading Data
                DGListePurchase.DataSource = await Task.Run(() => _dataHelper.GetData());

                // Set DataGridView Columns
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
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                gridView1.Columns[0].Visible = false; // Hide Column
                gridView1.Columns[1].Caption = "تاريخ الفاتورة";
                gridView1.Columns[2].Caption = "رقم الفاتورة";
                gridView1.Columns[3].Caption = "نوع الدفع";
                gridView1.Columns[4].Caption = "باركود الدواء";
                gridView1.Columns[5].Visible = false; // Hide Column 
                gridView1.Columns[6].Caption = "الكمية";
                gridView1.Columns[7].Caption = "سعر الشراء";
                gridView1.Columns[8].Caption = "سعر البيع";
                gridView1.Columns[9].Caption = "مجموع";
                gridView1.Columns[10].Caption = "المورد الرئيسي";
                gridView1.Columns[11].Caption = "مبلغ الفاتورة";
                gridView1.Columns[12].Visible = false; // Hide Column 
            }
            else
            {
                gridView1.Columns[0].Visible = false; // Hide Column
                gridView1.Columns[1].Caption = "Invoice Date";
                gridView1.Columns[2].Caption = "Invoice Number";
                gridView1.Columns[3].Caption = "Payment Type";
                gridView1.Columns[4].Caption = "Medicine Barcode";
                gridView1.Columns[5].Visible = false; // Hide Column
                gridView1.Columns[6].Caption = "Quantity";
                gridView1.Columns[7].Caption = "Purchase Price";
                gridView1.Columns[8].Caption = "Sales Price";
                gridView1.Columns[9].Caption = "Total";
                gridView1.Columns[10].Caption = "Master Supplier";
                gridView1.Columns[11].Caption = "Invoice Amount";
                gridView1.Columns[12].Visible = false; // Hide Column
            }
        }

        // Singleton Instance
        public static UserControl Instance()
        {
            return _PurchaseUserControl ?? (new PurchaseUserControl());
        }

        //Add and Show Empty Label 
        private void ShowLabelIfEmptyData()
        {
            DGListePurchase.Controls.Add(labelEmptyData);

            if (gridView1.RowCount > 0)
            {
                labelEmptyData.Visible = false;
            }
            else
            {
                labelEmptyData.Visible = true;
            }

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
                    string title = "قائمة الفواتير المشتريات ";
                    if (Properties.Settings.Default.ChangeLang == "Ar") title = "قائمة الفواتير المشتريات ";
                    else title = "Purchase Invoices List ";
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
         
        #endregion

        private void btnPrintPurch_Click(object sender, EventArgs e)
        {
            PrintGridControl();
        }

        // <summary>
        /// تحديث عدد الأدوية في التسمية عند تغيير عدد الصفوف في GridView
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
                lblCounter.Text = $"عدد الفواتير: {gridView1.RowCount}";  
            else
                lblCounter.Text = $"Number of Purchases: {gridView1.RowCount}"; 
        }

        private async void PurchaseUserControl_Load(object sender, EventArgs e)
        {
            loading.Show();
            if (_dataHelper.IsDbConnect())
            {
                DGListePurchase.DataSource = await Task.Run(() => _dataHelper.GetData().GroupBy(p => p.FactureNum).Select(g => g.First()).ToList());


                // تحميل البيانات بشكل غير متزامن
                //SetDataGridViewColumns();
                var view = (DevExpress.XtraGrid.Views.Grid.GridView)DGListePurchase.MainView;
                view.OptionsView.ShowGroupPanel = false;
                GridColumn colAction;
                    
                    // عمود الأزرار
                if (Properties.Settings.Default.ChangeLang == "Ar")
                     colAction = view.Columns.AddVisible("Action", "الإجراءات");
                else colAction = view.Columns.AddVisible("Action", "Action");
                colAction.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                colAction.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
                colAction.Width = 100; // عرض العمود

                // RepositoryItemButtonEdit واحد بثلاثة أزرار
                actionButtons = new RepositoryItemButtonEdit
                {
                    TextEditStyle = TextEditStyles.HideTextEditor
                };
                // أفرغ الأزرار الافتراضية
                actionButtons.Buttons.Clear();
                //زر حذف
                var btnDelete = new EditorButton(ButtonPredefines.Glyph);
                btnDelete.ImageOptions.SvgImage = SvgImage.FromStream(new MemoryStream(Properties.Resources.delete));
                btnDelete.Tag = "delete";                   // مفتاح تمييز
                actionButtons.Buttons.Add(btnDelete);


                // زر تعديل
                var btnEdit = new EditorButton(ButtonPredefines.Glyph);
                btnEdit.ImageOptions.SvgImage = SvgImage.FromStream(new MemoryStream(Properties.Resources.edit));
                btnEdit.Tag = "edit";                       // مفتاح تمييز
                actionButtons.Buttons.Add(btnEdit);

                // زر عرض
                var btnView = new EditorButton(ButtonPredefines.Glyph);
                btnView.ImageOptions.SvgImage = SvgImage.FromStream(new MemoryStream(Properties.Resources.view));
                btnView.Tag = "view";                       // مفتاح تمييز
                actionButtons.Buttons.Add(btnView);

                DGListePurchase.RepositoryItems.Add(actionButtons);
                colAction.ColumnEdit = actionButtons;

                // حدث النقر
                actionButtons.ButtonClick += ActionButtons_ButtonClick;
            }
            else
            {
                MessageCollection.ShowServerMessage();
                return;
            }
            loading.Hide();
        }

        //ملف الموارد العربي
        public void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;
            pnlTop.RightToLeft = RightToLeft.Yes;
            pnlSet.RightToLeft = RightToLeft.No;
             
            lblTitlePurchase.Text = "قائمة المشتريات";
            btnAdd.Text = Resources_Ar.AddButton_User;
            btnPrint.Text = Resources_Ar.PrintButton_User;
            labelEmptyData.Text = Resources_Ar.EmptyDataText;

            DGListePurchase.RightToLeft = RightToLeft.Yes;
        }

        //ملف الموارد انجليزي
        public void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            pnlTop.RightToLeft = RightToLeft.No;
            pnlSet.RightToLeft = RightToLeft.Yes;

            lblTitlePurchase.Text = "Purchase List";
            //lblTitlePurchase.Text = Resources_En.TitlePurchase;
            btnAdd.Text = Resources_En.AddButton_User;
            btnPrint.Text = Resources_En.PrintButton_User;
            labelEmptyData.Text = Resources_En.EmptyDataText;

            DGListePurchase.RightToLeft = RightToLeft.No;
        }
    }
}
