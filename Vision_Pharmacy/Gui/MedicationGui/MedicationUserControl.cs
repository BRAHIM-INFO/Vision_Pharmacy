using ClosedXML.Excel;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraReports.UI;
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
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.UserGui; 

namespace Vision_Pharmacy.Gui.MedicationGui
{
    public partial class MedicationUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private readonly IDataHelper<Medication> _dataHelper;
        private readonly LoadingUser loading;
        private int RowId;
        private static MedicationUserControl _MedicationUser;
        private List<int> IdList = new List<int>();
        private Label labelEmptyData;
        private string searchItem;
        private RepositoryItemButtonEdit actionButtons;
        AllClasses AllClasses = new AllClasses();
        // Constructores
        public MedicationUserControl()
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelper = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            LoadData();
            AllClasses.RoundButtonCorners(btnAdd, 15);
            AllClasses.RoundButtonCorners(btnExcel, 15);
            AllClasses.RoundButtonCorners(btnPrint, 15);
            //gridView1.OptionsBehavior.Editable = false;
            MessageBox.Show(Properties.Settings.Default.ChangeLang);
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                ApplyArabicResources();
            }
            else
            {
                ApplyEnglishResources();
            }

        }

        //Event Handlers
        #region
        // <summary>
        /// Singleton Instance
        /// 
        private void btnAddMedic_Click(object sender, EventArgs e)
        {
            MedicationAddForm customerAdd = new MedicationAddForm(0, this);
            customerAdd.ShowDialog();
        }

        private void btnPrintMedic_Click(object sender, EventArgs e)
        {
            PrintGridControl();
        }

        /// <summary>
        ///  زر استيراد بيانات الأدوية من ملف Excel
        private void btnExcel_Click(object sender, EventArgs e)
        {
            string excelPath = @"D:\\LISTE MEDICATIONS 2025.xlsx"; // ملف الإكسل
            ImportMedications(excelPath);
        }

        // <summary>
        /// تحديث عدد الأدوية في التسمية عند تغيير عدد الصفوف في GridView
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ChangeLang == "Ar")
                lblCounter.Text = $"عدد الأدوية: {gridView1.RowCount}";
            else lblCounter.Text = $"Medications Count: {gridView1.RowCount}";
        }

        /// <summary>
        ///     
        private async void MedicationUserControl_Load(object sender, EventArgs e)
        {
            loading.Show();
            if (_dataHelper.IsDbConnect())
            {
                DGListeMedication.DataSource = await Task.Run(() => _dataHelper.GetData()); // تحميل البيانات بشكل غير متزامن
                //SetDataGridViewColumns();
                var view = (DevExpress.XtraGrid.Views.Grid.GridView)DGListeMedication.MainView;
                view.OptionsView.ShowGroupPanel = false;

                // عمود الأزرار
                GridColumn colAction = view.Columns.AddVisible("Action", "الإجراءات");
                if (Properties.Settings.Default.ChangeLang == "Ar")
                    colAction.Caption = "الإجراءات";
                else colAction.Caption = "Actions";
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
                btnDelete.Tag = "delete";
                actionButtons.Buttons.Add(btnDelete);


                // زر تعديل
                var btnEdit = new EditorButton(ButtonPredefines.Glyph);
                btnEdit.ImageOptions.SvgImage = SvgImage.FromStream(new MemoryStream(Properties.Resources.edit));
                btnEdit.Tag = "edit";
                actionButtons.Buttons.Add(btnEdit);


                // زر عرض
                var btnView = new EditorButton(ButtonPredefines.Glyph);
                btnView.ImageOptions.SvgImage = SvgImage.FromStream(new MemoryStream(Properties.Resources.view));
                btnView.Tag = "view";
                actionButtons.Buttons.Add(btnView);



                DGListeMedication.RepositoryItems.Add(actionButtons);
                colAction.ColumnEdit = actionButtons;

                // حدث النقر
                actionButtons.ButtonClick += ActionButtons_ButtonClick;
            }
            else
            {
                MessageCollection.ShowServerMessage();
                return;
            }

            // نفترض عندك قائمة الأدوية المنتهية
            var expiredMeds = _dataHelper.GetData()
                .Where(m => m.ExpiryDate <= DateTime.Now)
                .ToList();

            if (expiredMeds.Any())
            {
                // نبني النص على شكل قائمة
                string message = "الأدوية المنتهية الصلاحية:\n";
                if (Properties.Settings.Default.ChangeLang == "Ar")
                    message = "الأدوية المنتهية الصلاحية:\n";
                else message = "Expired Medications:\n";
                foreach (var med in expiredMeds)
                {
                    if (Properties.Settings.Default.ChangeLang == "Ar")
                        message += $"- {med.Name} (انتهى في {med.ExpiryDate:dd-MM-yyyy})\n";
                    else message += $"- {med.Name} (Expired on {med.ExpiryDate:dd-MM-yyyy})\n";
                }

                // نظهر الـ Notification
                ShowNotification(message);
            }


            // عند الفحص
            //var expiredMeds = _dataHelper.GetData()
            //     .Where(m => m.ExpiryDate < DateTime.Today)
            //     .ToList(); 

            //if (expiredMeds.Any())
            //{
            //    ShowNotification($"⚠️ لديك {expiredMeds.Count} دواء منتهي الصلاحية!");
            //}

            loading.Hide();
        }


        private void ShowNotification(string message)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Warning; // يمكنك استبداله بأيقونة مخصصة
            if (Properties.Settings.Default.ChangeLang == "Ar")
                notifyIcon.BalloonTipTitle = "تنبيه صلاحية الأدوية";
            else notifyIcon.BalloonTipTitle = "Medication Expiry Alert";
            notifyIcon.BalloonTipText = message;
            notifyIcon.ShowBalloonTip(5000); // يظهر 5 ثواني
        }

        /// <summary>
        ///  اجراءات الأزرار في عمود الإجراءات )عرض، تعديل، حذف(
        private void ActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.Grid.GridView)DGListeMedication.MainView;


            var row = view.GetFocusedRow() as Medication;
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
                            MedicationAddForm customerAdd = new MedicationAddForm(RowId, this);
                            customerAdd.buttonSaveSup.Visible = false; // إخفاء زر الحفظ
                            customerAdd.ShowDialog();
                            return;

                        }
                    case "edit":
                        {
                            if (gridView1.RowCount > 0)
                            {
                                RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                                MedicationAddForm customerAdd = new MedicationAddForm(RowId, this);
                                customerAdd.ShowDialog();
                                this.Load += MedicationUserControl_Load;
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
                                if (gridView1.RowCount > 0)
                                {
                                    SetIDSelcted();
                                    if (MessageBox.Show($"هل تريد حذف {row.Name}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

                                                MedicationUserControl_Load(sender, e); // إعادة تحميل البيانات
                                                //LoadData();
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
                MedicationAddForm customerAdd = new MedicationAddForm(RowId, this);
                customerAdd.buttonSaveSup.Visible = false; // إخفاء زر الحفظ
                customerAdd.ShowDialog();
            }
            else if (idx == 1)
            {
                if (gridView1.RowCount > 0)
                {
                    RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                    MedicationAddForm customerAdd = new MedicationAddForm(RowId, this);
                    customerAdd.ShowDialog();
                    this.Load += MedicationUserControl_Load;
                }
                else
                {
                    MessageCollection.ShowEmptyDataMessage();
                }
            }

            else if (idx == 2)
                if (MessageBox.Show($"هل تريد حذف {row.Name}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                                        MedicationUserControl_Load(sender, e); // إعادة تحميل البيانات

                                        // LoadData();
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
                DGListeMedication.DataSource = await Task.Run(() => _dataHelper.GetData()); 
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
                gridView1.Columns[1].Caption = "باركود الدواء";
                gridView1.Columns[2].Caption = "اسم الدواء";
                gridView1.Columns[3].Caption = "الاسم العلمي";
                gridView1.Columns[4].Visible = false; // Hide Column
                gridView1.Columns[5].Visible = false; // Hide Column
                gridView1.Columns[6].Caption = "الشكل الصيدلي";
                gridView1.Columns[7].Caption = "التركيز";
                gridView1.Columns[8].Caption = "التصنيف";
                gridView1.Columns[9].Caption = "الوحدة"; 
                gridView1.Columns[10].Caption = "سعر الشراء";
                gridView1.Columns[11].Caption = "سعر البيع";  
                gridView1.Columns[12].Caption = "كمية المتوفرة";
                gridView1.Columns[13].Caption = "الحد الأدنى للتنبيه";
                gridView1.Columns[14].Visible = false; // Hide Column
                gridView1.Columns[14].Caption = "تاريخ انتهاء الصلاحية";
                gridView1.Columns[14].Visible = false; // Hide Column
                gridView1.Columns[15].Visible = false; // Hide Column
                gridView1.Columns[16].Visible = false; // Hide Column
                gridView1.Columns[17].Caption = "مكان التخزين";
                gridView1.Columns[18].Visible = false; // Hide Column
                gridView1.Columns[19].Visible = false; // Hide Column  
            }
            else
            {
                gridView1.Columns[0].Visible = false; // Hide Column
                gridView1.Columns[1].Caption = "Drug Barcode";
                gridView1.Columns[2].Caption = "Drug Name";
                gridView1.Columns[3].Caption = "Generic Name";
                gridView1.Columns[4].Visible = false; // Hide Column
                gridView1.Columns[5].Visible = false; // Hide Column
                gridView1.Columns[6].Caption = "Dosage Form";
                gridView1.Columns[7].Caption = "Concentration";
                gridView1.Columns[8].Caption = "Classification";
                gridView1.Columns[9].Caption = "Unit";
                gridView1.Columns[10].Caption = "Purchase Price";
                gridView1.Columns[11].Caption = "Sale Price";
                gridView1.Columns[12].Caption = "Available Quantity";
                gridView1.Columns[13].Caption = "Alert Minimum";
                gridView1.Columns[14].Visible = false; // Hide Column
                gridView1.Columns[14].Caption = "Expiration Date";
                gridView1.Columns[14].Visible = false; // Hide Column
                gridView1.Columns[15].Visible = false; // Hide Column
                gridView1.Columns[16].Visible = false; // Hide Column
                gridView1.Columns[17].Caption = "Storage Location";
                gridView1.Columns[18].Visible = false; // Hide Column 
                gridView1.Columns[19].Visible = false; // Hide Column
            } 
        }

        // Singleton Instance
        public static UserControl Instance()
        {
            return _MedicationUser ?? (new MedicationUserControl());
        }

        //Add and Show Empty Label 
        private void ShowLabelIfEmptyData()
        {
            DGListeMedication.Controls.Add(labelEmptyData);

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
                    Component = DGListeMedication
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
                    string title = "قائمة الموظفين ";
                    if (Properties.Settings.Default.ChangeLang == "Ar")
                        title = "قائمة الأدوية";
                    else title = "Medications List";
                    e.Graph.Font = new Font("Cairo Medium", 18, FontStyle.Bold);
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين 
                    e.Graph.DrawString(title, Color.Black, new RectangleF(350, 150, 1250, 45), DevExpress.XtraPrinting.BorderSide.None);
                    //e.Graph.DrawString(title, titleRect);

                    //// 🔹 التاريخ في الزاوية اليمنى
                    string date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    if (Properties.Settings.Default.ChangeLang == "Ar")
                        date = "التاريخ : " + DateTime.Now.ToShortDateString();
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

        /// <summary>
        /// استيراد بيانات الأدوية من ملف Excel
        ///  
        public void ImportMedications(string excelPath)
        {
            using (var context = new DBContext())
            {
                // إنشاء قاعدة البيانات إذا لم تكن موجودة
                context.Database.EnsureCreated();

                using (var workbook = new XLWorkbook(excelPath))
                {
                    var ws = workbook.Worksheet(1); // الورقة الأولى
                    int lastRow = ws.LastRowUsed().RowNumber();
                    byte[] imageBytes = ImageHelper.ImageToByteArray(PicChange);

                    for (int row = 2; row <= lastRow; row++) // نبدأ من الصف الثاني
                    {
                        var medication = new Medication();
                        {
                            //medication.Id = ws.Cell(row, 1).GetValue<int>();
                            medication.Barcode = ws.Cell(row, 2).GetValue<string>();
                            medication.Name = ws.Cell(row, 3).GetValue<string>();
                            medication.GenericName = ws.Cell(row, 4).GetValue<string>();
                            medication.Manufacturer = ws.Cell(row, 5).GetValue<string>();
                            medication.BatchNumber = ws.Cell(row, 6).GetValue<string>();
                            medication.Form = ws.Cell(row, 7).GetValue<string>();
                            medication.Strength = ws.Cell(row, 8).GetValue<string>();
                            medication.Category = ws.Cell(row, 9).GetValue<string>();
                            medication.Unite = ws.Cell(row, 10).GetValue<string>();
                            medication.PurchasePrice = ws.Cell(row, 11).GetValue<decimal>();
                            medication.SalePrice = ws.Cell(row, 12).GetValue<decimal>();
                            medication.QuantityInStock = ws.Cell(row, 13).GetValue<int>();
                            medication.MinimumStockLevel = ws.Cell(row, 14).GetValue<int>();
                            medication.Discount = ws.Cell(row, 15).GetValue<double>();
                            medication.ExpiryDate = ws.Cell(row, 16).GetDateTime();
                            medication.DateAdded = ws.Cell(row, 17).GetDateTime();
                            medication.RequiresPrescription = ws.Cell(row, 18).GetValue<bool>();
                            //medication.SupplierName = ws.Cell(row, 19).GetValue<string>();
                            medication.LocationInStore = ws.Cell(row, 20).GetValue<string>();
                            medication.IsActive = ws.Cell(row, 21).GetValue<bool>();
                            medication.Image = imageBytes;
                            medication.Notes = "";
                            //medication.SupplierId = 0; // Assuming you have a way to get the SupplierId

                        }
                        ;

                        // نتأكد أن الدواء غير موجود قبل الإضافة (حسب الباركود أو Id)
                        if (!context.Medication.Any(m => m.Id == medication.Id))
                        {
                            _dataHelper.Add(medication);

                            //context.Medication.Add(medication);
                        }
                    }
                }

                //context.SaveChanges();
                if (Properties.Settings.Default.ChangeLang == "Ar")
                    MessageBox.Show("✅ تم استيراد بيانات الأدوية بنجاح!");
                else MessageBox.Show("✅ Medications data imported successfully!");
            }
        }

        #endregion


        //ملف الموارد العربي
        public void ApplyArabicResources()
        {
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            DGListeMedication.RightToLeft = System.Windows.Forms.RightToLeft.Yes; 
             

            lblTitleMedicat.Text = "قائمة الأدوية";
            btnAdd.Text = Resources_Ar.AddButton_User;
            btnPrint.Text = Resources_Ar.PrintButton_User;
            btnExcel.Text = "تحميل قائمة";
            labelEmptyData.Text = Resources_Ar.EmptyDataText; 
        }

        //ملف الموارد انجليزي
        public void ApplyEnglishResources()
        {
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            DGListeMedication.RightToLeft = System.Windows.Forms.RightToLeft.No; 
            
            btnExcel.Text = "Load List"; 
            lblTitleMedicat.Text = "Medications List";
            btnAdd.Text = Resources_En.AddButton_User;
            btnPrint.Text = Resources_En.PrintButton_User;
            labelEmptyData.Text = Resources_En.EmptyDataText;
        }


    }
}
