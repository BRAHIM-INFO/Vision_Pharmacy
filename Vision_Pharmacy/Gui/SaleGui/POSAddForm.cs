using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DocumentFormat.OpenXml.Office2010.Excel;
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
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.SupplierGui;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrintingLinks;


namespace Vision_Pharmacy.Gui.SaleGui
{
    public partial class POSAddForm : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IDataHelper<Customer> _dataHelperCustomer;
        private IDataHelper<Sale> _dataHelperSale;
        private IDataHelper<Medication> _dataHelperMedication;
        private IDataHelper<Doctor> _dataHelperDoctor;
        DataTable dtPurchases = new DataTable();
        private readonly LoadingUser loading;
        private Label labelEmptyData;

        // في أعلى الفورم:
        private List<Medication> _meds;
        private Dictionary<string, Medication> _medByBarcode;

        private Sale Sale;
        private Customer Customer;
        private int RowId;
        private static SupplierUserControl _supplierUser;
        private List<int> IdList;
        private string searchItem;
        AllClasses AllClasses = new AllClasses();
        private int ResultAddOrEdit;
        DataTable dtSales = new DataTable();




        public POSAddForm()
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelperSale = (IDataHelper<Sale>)ContainerConfig.ObjectType("Sale");
            _dataHelperCustomer = (IDataHelper<Customer>)ContainerConfig.ObjectType("Customer");
            _dataHelperMedication = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            _dataHelperDoctor = (IDataHelper<Doctor>)ContainerConfig.ObjectType("Doctor");

            LoadDataDoctors();
            LoadDataCustomer();
            AutoCompleteBarcode();
            GenerateItemMedication();
            txtMontantHT.KeyPress += OnlyNumericTextBox;
            txtDescount.KeyPress += OnlyNumericTextBox;
            this.txtDescount.TextChanged += new System.EventHandler(this.txtDescount_TextChanged);

            // Set Property Instance
            txtFactureNum.Text = GenerateFactureNum();
            txtFactureNum.HideSelection = true;
            txtCustomer.Focus();


        }

        // اريد جعل FactureNum تولد اوتوماتيكيا بشكل 01-2025 / 02-2025
        public string GenerateFactureNum()
        {
            int currentYear = DateTime.Now.Year;

            // نجيب آخر فاتورة لنفس السنة
            var lastFacture = _dataHelperSale.GetData()
                .Where(p => p.FactureDate.Year == currentYear)
                .OrderByDescending(p => p.Id)
                .FirstOrDefault();

            int nextNumber = 1;

            if (lastFacture != null && !string.IsNullOrEmpty(lastFacture.FactureNum))
            {
                string[] parts = lastFacture.FactureNum.Split('-');
                if (parts.Length == 2 && int.TryParse(parts[0], out int lastNumber))
                {
                    nextNumber = lastNumber + 1;
                }
            }

            return $"{nextNumber:D2}-{currentYear}";
        }

        // جلب بيانات الموردين
        public async void LoadDataCustomer()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperCustomer.IsDbConnect())
            {
                txtCustomer.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperCustomer.GetData()))
                {
                    txtCustomer.Items.Add(item.FullName);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        // جلب بيانات الأطباء
        public async void LoadDataDoctors()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperDoctor.IsDbConnect())
            {
                txtDoctors.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperDoctor.GetData()))
                {
                    txtDoctors.Items.Add(item.FullName);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }

        public async void GenerateItemMedication()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelperDoctor.IsDbConnect())
            {
                txtDoctors.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelperMedication.GetData()))
                {
                    txtGenericName.Items.Add(item.GenericName);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }
        // تحميل الباركودات من الداتا 
        private async void AutoCompleteBarcode()
        {
            // حمّل الأدوية من الداتا (نفس أسلوبك مع Task.Run)
            _meds = await Task.Run(() => _dataHelperMedication.GetData());

            // جهّز قائمة الباركود
            var barcodes = _meds
                .Where(m => !string.IsNullOrWhiteSpace(m.Barcode))
                .Select(m => m.Barcode.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();

            // اضبط AutoComplete لـ Barcodetxt
            var ac = new AutoCompleteStringCollection();
            ac.AddRange(barcodes);
            Barcodetxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Barcodetxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Barcodetxt.AutoCompleteCustomSource = ac;

            // قاموس للوصول السريع بالباركود
            _medByBarcode = _meds
                .Where(m => !string.IsNullOrWhiteSpace(m.Barcode))
                .GroupBy(m => m.Barcode.Trim(), StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.First(), StringComparer.OrdinalIgnoreCase);
        }

        // إنشاء Panel لكل دواء
        public void CreateMedicinePanel(Medication med)
        {
            // هنا يمكنك إضافة الكود لإنشاء Panel لكل دواء
            Label label4 = new Label
            {
                AutoSize = true,
                Font = new Font("Cairo Medium", 8F),
                ForeColor = System.Drawing.Color.Black,
                Location = new Point(105, 90),
                Margin = new Padding(4, 0, 4, 0),
                Name = "label4",
                Size = new Size(66, 26),
                TabIndex = 48,
                Text = $"Qty : {med.QuantityInStock}"
            };

            Label label3 = new Label
            {
                AutoSize = true,
                Font = new Font("Cairo Medium", 8F),
                ForeColor = System.Drawing.Color.Black,
                Location = new Point(105, 63),
                Margin = new Padding(4, 0, 4, 0),
                Name = "label3",
                Size = new Size(101, 26),
                TabIndex = 47,
                Text = $"SalePrice : {med.SalePrice}"
            };

            Label label2 = new Label
            {
                AutoSize = true,
                Font = new Font("Cairo Medium", 8F),
                ForeColor = System.Drawing.Color.Black,
                Location = new Point(105, 36),
                Margin = new Padding(4, 0, 4, 0),
                Name = "label2",
                Size = new Size(174, 26),
                TabIndex = 46,
                Text = med.GenericName
            };

            Random rnd = new Random();

            List<Image> medImages = new List<Image>
            {
                Properties.Resources.MED_01,
                Properties.Resources.MED_02,
                Properties.Resources.MED_03,
                Properties.Resources.MED_04,
                Properties.Resources.MED_05,
                Properties.Resources.MED_06,
                Properties.Resources.MED_07,
                Properties.Resources.MED_08,
                Properties.Resources.MED_09
                // أضف ما تشاء
            };

            PictureBox pictureBox1 = new PictureBox
            {
                Image = medImages[rnd.Next(medImages.Count)], // يختار صورة عشوائية,
                Location = new Point(8, 9),
                Margin = new Padding(4),
                Name = "pictureBox1",
                Size = new Size(94, 105),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 45,
                TabStop = false,
            };

            Label label1 = new Label
            {
                AutoSize = true,
                Font = new Font("Cairo Medium", 8F),
                ForeColor = System.Drawing.Color.Black,
                Location = new Point(101, 4),
                Margin = new Padding(4, 0, 4, 0),
                Name = "label1",
                Size = new Size(77, 26),
                TabIndex = 38,
                Text = med.Name
            };

            Panel panel1 = new Panel
            {
                BackColor = System.Drawing.Color.AliceBlue,
                BorderStyle = BorderStyle.Fixed3D,
                Cursor = Cursors.Hand,
                ForeColor = System.Drawing.Color.White,
                Location = new Point(4, 4),
                Margin = new Padding(4),
                Name = "panel1",
                Size = new Size(266, 128),
                TabIndex = 44,
                Tag = med, // نربط الدواء باللوحة
            };

            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            pnlListMedic.Controls.Add(panel1);
            panel1.Click += MedPanel_Click; // ربط حدث النقر
        }

        // تحميل البيانات عند فتح النموذج
        private void POSAddForm_Load(object sender, EventArgs e)
        {
            // إنشاء جدول جديد
            DataTable dtSales = new DataTable();
            dtSales.Columns.Add("Barcode", typeof(string));
            dtSales.Columns.Add("Name", typeof(string));
            dtSales.Columns.Add("Quantity", typeof(int));
            dtSales.Columns.Add("SalePrice", typeof(decimal));
            dtSales.Columns.Add("Total", typeof(decimal));

            // ربطه بـ gridControl
            DGListeSale.DataSource = dtSales;

            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                col.OptionsColumn.AllowEdit = false;

            gridView1.Columns["Quantity"].OptionsColumn.AllowEdit = true;

            var view = gridView1;
            view.OptionsBehavior.Editable = true;
            view.OptionsView.ShowGroupPanel = false;
            view.Columns["Quantity"].OptionsColumn.AllowEdit = true;

            // عمود الأزرار
            GridColumn colAction = view.Columns.AddVisible("Action", "🗑️");
            colAction.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            colAction.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            colAction.Width = 20; // عرض العمود

            // RepositoryItemButtonEdit واحد بثلاثة أزرار
            RepositoryItemButtonEdit actionButtons = new RepositoryItemButtonEdit();
            // أفرغ الأزرار الافتراضية
            actionButtons.Buttons.Clear();
            //زر حذف
            var btnDelete = new EditorButton(ButtonPredefines.Glyph);
            btnDelete.ImageOptions.SvgImage = SvgImage.FromStream(new MemoryStream(Properties.Resources.delete));
            btnDelete.Tag = "delete";
            actionButtons.Buttons.Add(btnDelete);
            DGListeSale.RepositoryItems.Add(actionButtons);
            colAction.ColumnEdit = actionButtons;

            actionButtons.ButtonClick += BtnDelete_ButtonClick;

            var meds = _dataHelperMedication.GetData();
            // تنظيف الـPanelContainer
            pnlListMedic.Controls.Clear();
            foreach (var med in meds)
            {
                CreateMedicinePanel(med);
            }
        }

        // حدث النقر على لوحة الدواء
        private void MedPanel_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            Panel pnl = ctrl is Panel ? (Panel)ctrl : (Panel)ctrl.Parent;
            var med = (Medication)pnl.Tag;

            // تحقق إن كان موجود مسبقًا في الـGrid
            var dt = (DataTable)DGListeSale.DataSource;
            var existingRow = dt.AsEnumerable().FirstOrDefault(r => r.Field<string>("Barcode") == med.Barcode);

            if (existingRow != null)
            {
                // زيادة الكمية +1 وتحديث المجموع
                int qty = existingRow.Field<int>("Quantity");
                qty++;
                existingRow.SetField("Quantity", qty);
                existingRow.SetField("Total", qty * med.SalePrice);
            }
            else
            {
                // إضافة صف جديد
                DataRow row = dt.NewRow();
                row["Barcode"] = med.Barcode;
                row["Name"] = med.Name;
                row["Quantity"] = 1;
                row["SalePrice"] = med.SalePrice;
                row["Total"] = med.SalePrice;
                dt.Rows.Add(row);
            }

            // تحديث الإجمالي الكلي أسفل الجدول
            UpdateTotalAmount();
        }

        // السماح فقط بالأرقام في حقول النص
        private void OnlyNumericTextBox(object sender, KeyPressEventArgs e)
        {
            // السماح فقط بالأرقام، المفتاح Backspace، والنقطة العشرية (, أو .)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // تجاهل المفتاح
            }

            TextBox txt = sender as TextBox;

            // السماح بفاصلة عشرية واحدة فقط
            if ((e.KeyChar == '.' || e.KeyChar == ',') && txt.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        // 
        private void UpdateTotalAfterDiscount()
        {
            decimal montantHT = 0;
            decimal discount = 0;

            decimal.TryParse(txtMontantHT.Text, out montantHT);
            decimal.TryParse(txtDescount.Text, out discount);

            // 🔹 إذا كان الخصم نسبة مئوية (%)
            decimal discountValue = montantHT * (discount / 100);

            // 🔹 المجموع النهائي بعد الخصم
            decimal totalAmount = montantHT - discountValue;

            txtTotalAmount.Text = totalAmount.ToString("N2");
        }

        // تحديث المبلغ الإجمالي
        private void UpdateTotalAmount()
        {
            var dt = (DataTable)DGListeSale.DataSource;
            decimal total = dt.AsEnumerable().Sum(r => r.Field<decimal>("Total"));
            txtMontantHT.Text = $"{total:N2}";
            txtDescount.Text = "0";
            UpdateTotalAfterDiscount();
        }

        // 🗑️ حذف صف عند الضغط على زر الحذف
        private void BtnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = gridView1;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                view.DeleteRow(rowHandle);

                UpdateTotalAmount();
                //txtTotalAmount.Text = "0.00";
            }
        }

        private void txtDescount_TextChanged(object sender, EventArgs e)
        {
            // نجرب تحويل النص إلى رقم
            if (decimal.TryParse(txtMontantHT.Text, out decimal montantHT) &&
                decimal.TryParse(txtDescount.Text, out decimal discount))
            {
                // نضمن أن التخفيض لا يكون أكبر من المبلغ الأصلي
                if (discount > montantHT)
                {
                    discount = montantHT;
                    txtDescount.Text = discount.ToString();
                    txtDescount.SelectionStart = txtDescount.Text.Length; // لتجنب إعادة كتابة النص
                }

                // حساب المبلغ بعد التخفيض
                decimal total = montantHT - discount;
                txtTotalAmount.Text = total.ToString("0.00"); // صيغة رقمية بمئتين
            }
            else
            {
                // إذا كان النص غير رقمي نجعل الإجمالي يساوي المبلغ الأصلي
                txtTotalAmount.Text = txtMontantHT.Text;
            }
        }

        private void Barcodetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var meds = _dataHelperMedication.GetData().Where(x => x.Barcode == Barcodetxt.Text);
                // تنظيف الـPanelContainer
                pnlListMedic.Controls.Clear();
                foreach (var med in meds)
                {
                    CreateMedicinePanel(med);
                    chkAll.Checked = false;
                }
            }
        }

        private void txtGenericName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var meds = _dataHelperMedication.GetData().Where(x => x.GenericName == txtGenericName.Text);
            // تنظيف الـPanelContainer
            pnlListMedic.Controls.Clear();
            chkAll.Checked = false;
            foreach (var med in meds)
            {
                CreateMedicinePanel(med);

            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            txtGenericName.Text = "";
            Barcodetxt.Text = "";
            var meds = _dataHelperMedication.GetData();
            // تنظيف الـPanelContainer
            pnlListMedic.Controls.Clear();
            foreach (var med in meds)
            {
                CreateMedicinePanel(med);
            }
        }

        // التحقق من الحقول المطلوبة فارغة
        private bool IsRequiredFiledEmpty()
        {
            if (txtCustomer.Text == string.Empty & txtTypePaimt.Text == string.Empty & txtDoctors.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void SetDataForAdd()
        {
            Customer = _dataHelperCustomer.GetData().FirstOrDefault(s => s.FullName == txtCustomer.Text);
            if (Customer == null)
            {
                if (Properties.Settings.Default.ChangeLang == "Ar")
                    MessageBox.Show("العميل غير موجودة في قاعدة البيانات. يرجى إضافته أولاً.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("The invoice does not exist in the database. Please add it first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 1. إنشاء الفاتورة من TextBox
            Sale = new Sale();
            // 2. المرور على الأصناف في GridControl
            var view = DGListeSale.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null)
            {
                for (int i = 0; i < view.RowCount; i++)
                {
                    if (!view.IsDataRow(i)) continue;

                    Sale.FactureNum = txtFactureNum.Text;
                    Sale.FactureDate = DateTime.Parse(txtSaleDate.Text);
                    Sale.TypePaimt = txtTypePaimt.Text;
                    Sale.TotalAmount = decimal.TryParse(txtTotalAmount.Text, out var total) ? total : 0;
                    Sale.CustomerName = txtCustomer.Text;
                    Sale.DoctorName = txtDoctors.Text;
                    Sale.CustomerId = Customer.Id;
                    Sale.Notes = "";
                    Sale.Discount = decimal.TryParse(txtDescount.Text, out var discount) ? discount : 0;

                    Sale.Barcode = view.GetRowCellValue(i, "Barcode")?.ToString();
                    Sale.SalePrice = view.GetRowCellValue(i, "SalePrice") != null ?
                                            Convert.ToDecimal(view.GetRowCellValue(i, "SalePrice")) : 0;
                    Sale.Quantity = view.GetRowCellValue(i, "Quantity") != null ?
                                        Convert.ToInt32(view.GetRowCellValue(i, "Quantity")) : 0;

                    // 3. تحديث جدول Medication
                    // 1. جلب الدواء من قاعدة البيانات عبر الباركود
                    var med = _dataHelperMedication.GetData().FirstOrDefault(m => m.Barcode == Sale.Barcode);
                    if (med != null)
                    {
                        int oldQty = med.QuantityInStock;
                        decimal salePrice = med.SalePrice; // السعر الحالي للبيع

                        int soldQty = Sale.Quantity; // الكمية المباعة (من GridControl)

                        // التحقق من توفر الكمية
                        if (soldQty <= oldQty)
                        {
                            // طرح الكمية المباعة من المخزون
                            med.QuantityInStock = oldQty - soldQty;

                            // (اختياري) يمكنك تسجيل الربح أو الهامش إن أردت:
                            decimal purchasePrice = med.PurchasePrice;
                            decimal totalRevenue = soldQty * salePrice;
                            decimal totalCost = soldQty * purchasePrice;
                            decimal profit = totalRevenue - totalCost;

                            // يمكنك حفظ هذا الربح في جدول آخر مثلاً Reports أو SalesHistory
                            // أو فقط عرضه للمستخدم في الواجهة
                        }
                        else
                        {
                            MessageBox.Show($"الكمية غير كافية في المخزون! الكمية المتوفرة: {oldQty}",
                                            "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("الدواء غير موجود في قاعدة البيانات!",
                                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    _dataHelperMedication.Edit(med);
                    _dataHelperSale.Add(Sale);
                    Sale = new Sale();
                }
            }
        }

        private async void AddData()
        {
            // Set Data
            SetDataForAdd();
            // Send data and get result

            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();

                // Updat View
                // if (SaleUserControl != null) SaleUserControl.LoadData();
            }
            else // End with database error
            {
                // MessageCollection.ShowServerMessage();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // check requirments of fileds
            if (IsRequiredFiledEmpty())
            {
                MessageCollection.ShowEmptyFields();
            }
            else
            {
                loading.Show();
                // Add
                AddData();
                loading.Hide();

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // إنشاء PrintingSystem
            PrintingSystem ps = new PrintingSystem();
            CompositeLink compositeLink = new CompositeLink(ps);

            // إنشاء رابط للـ Grid
            PrintableComponentLink gridLink = new PrintableComponentLink(ps)
            {
                Component = DGListeSale,
                Landscape = true
            };

            // إنشاء رابط مخصص لأسفل الصفحة (Footer)
            PrintableComponentLink footerLink = new PrintableComponentLink(ps);
            footerLink.CreateDetailArea += FooterLink_CreateDetailArea;

            // دمج اللينكات
            compositeLink.Links.Add(gridLink);
            compositeLink.Links.Add(footerLink);

            // عرض المعاينة قبل الطباعة
            compositeLink.ShowPreviewDialog();
        }

        private void FooterLink_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            // إعداد نصوص الفاتورة من الأسفل
            string montantHT = txtMontantHT.Text;
            string discount = txtDescount.Text;
            string total = txtTotalAmount.Text;
            string client = txtCustomer.Text;
            string doctor = txtDoctors.Text;
            string date = txtSaleDate.Text;
            string payment = txtTypePaimt.Text;

            // رسم النصوص في التقرير
            e.Graph.DrawString($"المبلغ: {montantHT}", System.Drawing.Color.Black, new RectangleF(0, 0, 300, 25), DevExpress.XtraPrinting.BorderSide.None);// BorderSide.None);
            e.Graph.DrawString($"التخفيض: {discount}", System.Drawing.Color.Black, new RectangleF(0, 25, 300, 25), DevExpress.XtraPrinting.BorderSide.None);
            e.Graph.DrawString($"الإجمالي: {total}", System.Drawing.Color.Black, new RectangleF(0, 50, 300, 25),    DevExpress.XtraPrinting.BorderSide.None);

            e.Graph.DrawString($"طريقة الدفع: {payment}", System.Drawing.Color.Black, new RectangleF(350, 0, 300, 25), DevExpress.XtraPrinting.BorderSide.None);
            e.Graph.DrawString($"العميل: {client}", System.Drawing.Color.Black, new RectangleF(350, 25, 300, 25), DevExpress.XtraPrinting.BorderSide.None);
            e.Graph.DrawString($"الطبيب: {doctor}", System.Drawing.Color.Black, new RectangleF(350, 50, 300, 25), DevExpress.XtraPrinting.BorderSide.None);
            e.Graph.DrawString($"تاريخ البيع: {date}", System.Drawing.Color.Black, new RectangleF(700, 0, 300, 25), DevExpress.XtraPrinting.BorderSide.None);
        }
    }
}
