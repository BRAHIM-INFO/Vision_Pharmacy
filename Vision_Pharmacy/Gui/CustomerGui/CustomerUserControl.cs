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
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.PurchaseGui;

namespace Vision_Pharmacy.Gui.CustomerGui
{
    public partial class CustomerUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private readonly IDataHelper<Customer> _dataHelper;
        private readonly LoadingUser loading;
        private int RowId;
        private static CustomerUserControl _CustomerUser;
        private List<int> IdList = new List<int>();
        private Label labelEmptyData;
        private string searchItem;
        private RepositoryItemButtonEdit actionButtons;

        // Constructores
        public CustomerUserControl()
        {
            InitializeComponent();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelper = (IDataHelper<Customer>)ContainerConfig.ObjectType("Customer");
            loading = LoadingUser.Instance();
            LoadData();
            gridView1.OptionsBehavior.Editable = false;

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                ApplyArabicResources();
            }
            else
            {
                ApplyEnglishResources();
            }
        }


        #region Events
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            CustomerAddForm customerAdd = new CustomerAddForm(0, this);
            customerAdd.ShowDialog();
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                CustomerAddForm customerAdd = new CustomerAddForm(RowId, this);
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
                    Component = DGListeCustomer
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
                    e.Graph.DrawString(headerText, Color.Black, new RectangleF(240, 10, 600, 120), DevExpress.XtraPrinting.BorderSide.None);// DevExpress.XtraEditors.Controls.BorderSide.None);

                    // 🔹 رسم مستطيل رمادي خلف العنوان باستخدام DrawRect
                    //RectangleF titleRect = new RectangleF(10, 145, 1050, 40);
                    //e.Graph.DrawRect(titleRect, BorderSide.All, Color.White, Color.White);  // ⬅️ مستطيل رمادي مع حدود سوداء

                    // 🔹 عنوان التقرير (منتصف الصفحة)
                    string title = "قائمة الموردين ";
                    if (Properties.Settings.Default.ChangeLang == "Ar") title = "قائمة الموردين ";
                    else title = "CUSTOMERS LIST ";



                    e.Graph.Font = new Font("Cairo Medium", 18, FontStyle.Bold);
                    e.Graph.StringFormat = new BrickStringFormat(DevExpress.Drawing.DXStringAlignment.Far); // ⬅️ محاذاة النص إلى اليمين 
                    e.Graph.DrawString(title, Color.Black, new RectangleF(350, 150, 1250, 45), DevExpress.XtraPrinting.BorderSide.None);
                    //e.Graph.DrawString(title, titleRect);

                    //// 🔹 التاريخ في الزاوية اليمنى
                    string date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    if (Properties.Settings.Default.ChangeLang == "Ar") date = "التاريخ : " + DateTime.Now.ToShortDateString();
                    else date = "Date : " + DateTime.Now.ToShortDateString();

                    e.Graph.Font = new Font("Cairo Medium", 12);
                    e.Graph.DrawString(date, Color.Black, new RectangleF(50, 150, 250, 30), DevExpress.XtraPrinting.BorderSide.None);
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
                if (Properties.Settings.Default.ChangeLang == "Ar")
                    MessageBox.Show("❌ خطأ أثناء الطباعة: " + ex.Message);
                else MessageBox.Show("❌ Error during printing: " + ex.Message);
            }
        }
        public async void LoadData()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelper.IsDbConnect())
            {
                // Loading Data
                DGListeCustomer.DataSource = await Task.Run(() => _dataHelper.GetData());

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
                gridView1.Columns[0].Caption = "المعرف";
                gridView1.Columns[1].Caption = "الاسم الكامل";
                gridView1.Columns[2].Caption = "اسم المورد";
                gridView1.Columns[3].Caption = "العنوان";
                gridView1.Columns[4].Caption = "الهاتف";
                gridView1.Columns[5].Caption = "البريد الإلكتروني";
                gridView1.Columns[6].Caption = "نشط";
                gridView1.Columns[7].Caption = "ملاحظات إضافية";
            }
            else
            {
                gridView1.Columns[0].Caption = "ID";
                gridView1.Columns[1].Caption = "Full Name";
                gridView1.Columns[2].Caption = "Resource Name";
                gridView1.Columns[3].Caption = "Address";
                gridView1.Columns[4].Caption = "Phone";
                gridView1.Columns[5].Caption = "Email";
                gridView1.Columns[6].Caption = "Active";
                gridView1.Columns[7].Caption = "Additional Notes";
            }
        }

        // Singleton Instance
        public static UserControl Instance()
        {
            return _CustomerUser ?? (new CustomerUserControl());
        }
        //Add and Show Empty Label 
        private void ShowLabelIfEmptyData()
        {
            DGListeCustomer.Controls.Add(labelEmptyData);

            if (gridView1.RowCount > 0)
            {
                labelEmptyData.Visible = false;
            }
            else
            {
                labelEmptyData.Visible = true;
            }

        }

        //ملف الموارد العربي
        public void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;

            lblTitleCustom.Text = "قائمة العملاء";
            btnAdd.Text = Resources_Ar.AddButton_User;
            btnPrint.Text = Resources_Ar.PrintButton_User;
            labelEmptyData.Text = Resources_Ar.EmptyDataText;

            DGListeCustomer.RightToLeft = RightToLeft.Yes;


        }

        //ملف الموارد انجليزي
        public void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            lblTitleCustom.Text = "CUSTOMERS LIST";
            btnAdd.Text = Resources_En.AddButton_User;
            btnPrint.Text = Resources_En.PrintButton_User;
            labelEmptyData.Text = Resources_En.EmptyDataText;
            DGListeCustomer.RightToLeft = RightToLeft.No;

        }
        #endregion

        private async void CustomerUserControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
