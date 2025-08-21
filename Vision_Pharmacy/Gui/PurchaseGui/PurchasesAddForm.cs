using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
using static Vision_Pharmacy.Gui.PurchaseGui.XtraForm1;

namespace Vision_Pharmacy.Gui.PurchaseGui
{
    public partial class PurchasesAddForm : DevExpress.XtraEditors.XtraForm
    {

        // Fields
        private readonly int id;
        private readonly PurchaseUserControl PurchaseUserControl;
        private readonly IDataHelper<Suppliers> _dataHelper;
        private IDataHelper<Purchase> _dataHelperPurchase;
        private IDataHelper<Medication> _dataHelperMedication;
        private readonly LoadingUser loading;
        private Purchase Purchase;
        private int RowId;
        private static SupplierUserControl _supplierUser;
        private List<int> IdList = new List<int>();
        private string searchItem;
        AllClasses AllClasses = new AllClasses();
        private int ResultAddOrEdit;

        // قائمة الأدوية
        List<Medication> medications = new List<Medication>(); 
        private RepositoryItemButtonEdit actionButtons;

        public PurchasesAddForm(int Id, PurchaseUserControl PurchaseUserControl)
        {
            InitializeComponent();
            AllClasses.RoundButtonCorners(btnAdd, 15); 

            _dataHelperPurchase = (IDataHelper<Purchase>)ContainerConfig.ObjectType("Purchase");
            _dataHelper = (IDataHelper<Suppliers>)ContainerConfig.ObjectType("Supplier");
            _dataHelperMedication = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            loading = LoadingUser.Instance();
            LoadDataSupplier(); // تحميل بيانات الموردين عند فتح النموذج
            // Set Property Instance
            id = Id;
            this.PurchaseUserControl = PurchaseUserControl;
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
            }


            // تهيئة حقل المجموع الكلي
            txtTotalAmount.Text = "0.00";
        }

        #region Methods

        public async void LoadDataSupplier()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelper.IsDbConnect())
            {
                txtSupplier.Items.Clear();
                foreach (var item in await Task.Run(() => _dataHelper.GetData()))
                {
                    txtSupplier.Items.Add(item.Name);
                }
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide();
        }
        private async void AddData()
        {
            // Set Data
            SetDataForAdd();
            // Send data and get result
            ResultAddOrEdit = await Task.Run(() => _dataHelperPurchase.Add(Purchase));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
                //PurchaseUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }
        private async void EditData()
        {
            // Set Data
            SetDataForEdit();
            ResultAddOrEdit = await Task.Run(() => _dataHelperPurchase.Edit(Purchase));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                // PurchaseUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }
        private void ClearFileds()
        {
            txtFactureNum.Text = string.Empty;
            txtSupplier.Text = string.Empty;
            txtPurchaseDate.Text = string.Empty;
            txtTypePaimt.Text = string.Empty;
            DGListeCustomer.DataSource = null;
        }
        private async void SetDataToFileds()
        {
            if (_dataHelperPurchase.IsDbConnect())
            {
                Purchase = await Task.Run(() => _dataHelperPurchase.Find(id));
                txtFactureNum.Text = Purchase.FactureNum;
                txtPurchaseDate.Text = Purchase.FactureDate.ToShortDateString();
                txtTypePaimt.Text = Purchase.TypePaimt;
                txtSupplier.Text = Purchase.SupplierId.ToString(); // إذا كان المورد غير موجود، نعرض نصًا فارغًا
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            Purchase = null;
        }

        private void SetDataForAdd()
        {
            // الحصول على GridView من GridControl (بالاسم)
            DevExpress.XtraGrid.Views.Grid.GridView view = DGListeCustomer.Views[0] as DevExpress.XtraGrid.Views.Grid.GridView;

            List<Medication> data = new List<Medication>();
            if (view != null)
            {

                for (int i = 0; i < view.RowCount - 1; i++)
                {
                    // لو الـ DataSource هو List<Medication> مباشرة
                    var row = view.GetRow(i) as Medication;
                    if (row != null)
                    {
                        data.Add(row);
                    }
                }

                // الآن عندك القائمة data
            }

            Purchase = new Purchase();
            Purchase.TypePaimt = txtTypePaimt.Text;
            Purchase.FactureNum = txtFactureNum.Text;
            Purchase.FactureDate = DateTime.Parse(txtPurchaseDate.Text);
            //البحث على المورد بالاسم
            if (!string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                Suppliers Sup = _dataHelper.Search(txtSupplier.Text).First();
                Purchase.SupplierId = Sup.Id; // ربط بالمفتاح الأجنبي فقط 
            }
             Purchase.TotalAmount = decimal.Parse(txtTotalAmount.Text);

        }
        private void SetDataForEdit()
        {
            var data = DGListeCustomer.DataSource as List<Medication>;

            //foreach (var med in data)
            //{
            //    if (!string.IsNullOrWhiteSpace(med.Name) &&
            //        MedicationsList.All(m => !m.Name.Equals(med.Name, StringComparison.OrdinalIgnoreCase)))
            //    {
            //        MedicationsList.Add(med);
            //    }
            //}

            Purchase = new Purchase
            {

                Id = this.id,
                TypePaimt = txtTypePaimt.Text,
                FactureNum = txtFactureNum.Text,
                 //Supplier = new Suppliers
                //{
                //    Name = txtSupplier.Text
                //},
                 TotalAmount = decimal.Parse(txtTotalAmount.Text),
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (txtFactureNum.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region
        //Event Handlers

        // عند إدخال اسم دواء
        private void GridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var view = sender as GridView;

            if (view.FocusedColumn.FieldName == "Name")
            {
                string medName = e.Value?.ToString();
                var med = medications.FirstOrDefault(m => m.Name.Equals(medName, StringComparison.OrdinalIgnoreCase));

                if (med != null)
                {
                    view.SetRowCellValue(view.FocusedRowHandle, "Name", med.Name);
                    view.SetRowCellValue(view.FocusedRowHandle, "Barcode", med.Barcode);
                    view.SetRowCellValue(view.FocusedRowHandle, "BatchNumber", med.BatchNumber);
                    view.SetRowCellValue(view.FocusedRowHandle, "GenericName", med.GenericName);
                    view.SetRowCellValue(view.FocusedRowHandle, "Manufacturer", med.Manufacturer);
                    view.SetRowCellValue(view.FocusedRowHandle, "QuantityInStock", med.QuantityInStock);
                    view.SetRowCellValue(view.FocusedRowHandle, "MinimumStockLevel", med.MinimumStockLevel);
                    view.SetRowCellValue(view.FocusedRowHandle, "PurchasePrice", med.PurchasePrice);
                    view.SetRowCellValue(view.FocusedRowHandle, "SalePrice", med.SalePrice);
                    view.SetRowCellValue(view.FocusedRowHandle, "Form", med.Form);
                    view.SetRowCellValue(view.FocusedRowHandle, "Strength", med.Strength);
                    view.SetRowCellValue(view.FocusedRowHandle, "Category", med.Category);
                    view.SetRowCellValue(view.FocusedRowHandle, "Unite", med.Unite);
                    view.SetRowCellValue(view.FocusedRowHandle, "ExpiryDate", med.ExpiryDate);
                    view.SetRowCellValue(view.FocusedRowHandle, "RequiresPrescription", med.RequiresPrescription);
                    view.SetRowCellValue(view.FocusedRowHandle, "LocationInStore", med.LocationInStore);
                    view.SetRowCellValue(view.FocusedRowHandle, "Discount", med.Discount);
                    view.SetRowCellValue(view.FocusedRowHandle, "Notes", med.Notes);
                    view.SetRowCellValue(view.FocusedRowHandle, "IsActive", med.IsActive);
                    //view.SetRowCellValue(view.FocusedRowHandle, "SupplierName", med.SupplierName);
                }
            }
            else
            if (view.FocusedColumn.FieldName == "Barcode")
            {

                string medBarcode = e.Value?.ToString();
                var med = medications.FirstOrDefault(m => m.Barcode.Equals(medBarcode, StringComparison.OrdinalIgnoreCase));

                if (med != null)
                {
                    view.SetRowCellValue(view.FocusedRowHandle, "Name", med.Name);
                    view.SetRowCellValue(view.FocusedRowHandle, "Barcode", med.Barcode);
                    view.SetRowCellValue(view.FocusedRowHandle, "BatchNumber", med.BatchNumber);
                    view.SetRowCellValue(view.FocusedRowHandle, "GenericName", med.GenericName);
                    view.SetRowCellValue(view.FocusedRowHandle, "Manufacturer", med.Manufacturer);
                    view.SetRowCellValue(view.FocusedRowHandle, "QuantityInStock", med.QuantityInStock);
                    view.SetRowCellValue(view.FocusedRowHandle, "MinimumStockLevel", med.MinimumStockLevel);
                    view.SetRowCellValue(view.FocusedRowHandle, "PurchasePrice", med.PurchasePrice);
                    view.SetRowCellValue(view.FocusedRowHandle, "SalePrice", med.SalePrice);
                    view.SetRowCellValue(view.FocusedRowHandle, "Form", med.Form);
                    view.SetRowCellValue(view.FocusedRowHandle, "Strength", med.Strength);
                    view.SetRowCellValue(view.FocusedRowHandle, "Category", med.Category);
                    view.SetRowCellValue(view.FocusedRowHandle, "Unite", med.Unite);
                    view.SetRowCellValue(view.FocusedRowHandle, "ExpiryDate", med.ExpiryDate);
                    view.SetRowCellValue(view.FocusedRowHandle, "RequiresPrescription", med.RequiresPrescription);
                    view.SetRowCellValue(view.FocusedRowHandle, "LocationInStore", med.LocationInStore);
                    view.SetRowCellValue(view.FocusedRowHandle, "Discount", med.Discount);
                    view.SetRowCellValue(view.FocusedRowHandle, "Notes", med.Notes);
                    view.SetRowCellValue(view.FocusedRowHandle, "IsActive", med.IsActive);
                    //view.SetRowCellValue(view.FocusedRowHandle, "SupplierName", med.SupplierName);
                    view.SetRowCellValue(view.FocusedRowHandle, "Image", med.Image);
                }
                else
                {
                    MedicationAddForm customerAdd = new MedicationAddForm(medBarcode, txtSupplier.Text);
                    customerAdd.ShowDialog();
                }
            }
        }
         
        // حساب المجموع لكل سطر
        private void GridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Total" && e.IsGetData)
            {
                var view = sender as GridView;
                int qty = Convert.ToInt32(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "QuantityInStock") ?? 0);
                decimal price = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PurchasePrice") ?? 0m);
                e.Value = qty * price;
            }
        }

        private void UpdateGrandTotal()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                object val = gridView1.GetRowCellValue(i, "Total");
                if (val != null && decimal.TryParse(val.ToString(), out decimal rowTotal))
                {
                    total += rowTotal;
                }
            }
            txtTotalAmount.Text = total.ToString("N2"); // عرض بصيغة عملة
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            // قائمة الأدوية
            medications = _dataHelperMedication.GetData().ToList();

            DGListeCustomer.DataSource = new BindingList<Medication>();

            var view = gridView1;
            view.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;

            // عناوين الأعمدة
            view.Columns["Id"].Visible = false;
            view.Columns["Name"].Caption = "اسم الدواء";
            view.Columns["Barcode"].Caption = "باركود";
            view.Columns["QuantityInStock"].Caption = "الكمية";
            view.Columns["SalePrice"].Caption = "سعر البيع";
            view.Columns["GenericName"].Caption = "الاسم العلمي";
            view.Columns["GenericName"].OptionsColumn.ReadOnly = true;
            view.Columns["Manufacturer"].Caption = "الشركة المصنعة";
            view.Columns["Manufacturer"].OptionsColumn.ReadOnly = true;
            view.Columns["Form"].Caption = "الشكل الصيدلي";
            view.Columns["Form"].OptionsColumn.ReadOnly = true;
            view.Columns["Strength"].Caption = "التركيز";
            view.Columns["Strength"].OptionsColumn.ReadOnly = true;
            view.Columns["Category"].Caption = "التصنيف";
            view.Columns["Category"].OptionsColumn.ReadOnly = true;
            view.Columns["Unite"].Caption = "الوحدة";
            view.Columns["Unite"].OptionsColumn.ReadOnly = true;
            view.Columns["PurchasePrice"].Caption = "سعر الشراء";
            view.Columns["MinimumStockLevel"].Caption = "الحد الأدنى";
            view.Columns["ExpiryDate"].Caption = "تاريخ انتهاء الصلاحية";
            view.Columns["BatchNumber"].Caption = "رقم الدفعة";
            view.Columns["SupplierName"].Visible = false;
            view.Columns["RequiresPrescription"].Caption = "وصفة طبية؟";
            view.Columns["RequiresPrescription"].OptionsColumn.ReadOnly = true;
            view.Columns["DateAdded"].Visible = false;
            view.Columns["Notes"].Visible = false;
            view.Columns["SupplierId"].Visible = false;
            view.Columns["LocationInStore"].Caption = "مكان التخزين";
            view.Columns["Discount"].Caption = "الخصم";
            view.Columns["IsActive"].Visible = false;
            view.Columns["Image"].Visible = false; // إخفاء عمود الصورة

            // عمود المجموع كـ Unbound Column
            var totalCol = view.Columns.AddField("Total");
            totalCol.Caption = "المجموع";
            totalCol.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            totalCol.OptionsColumn.ReadOnly = true;
            totalCol.Visible = true;

            // محرر رقمي يقبل , و .
            var numericEdit = new RepositoryItemTextEdit();
            numericEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            numericEdit.Mask.EditMask = "n2";
            numericEdit.Mask.UseMaskAsDisplayFormat = true;
            numericEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            numericEdit.ParseEditValue += (s, ea) =>
            {
                if (ea.Value != null)
                {
                    string str = ea.Value.ToString().Replace(',', '.');
                    if (decimal.TryParse(str, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal val))
                    {
                        ea.Value = val;
                        ea.Handled = true;
                    }
                }
            };
            view.Columns["QuantityInStock"].ColumnEdit = numericEdit;
            view.Columns["PurchasePrice"].ColumnEdit = numericEdit;

            // AutoComplete لاسم الدواء
            var repoCombo = new RepositoryItemComboBox
            {
                TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard,
                AutoComplete = true
            };
            repoCombo.Items.AddRange(medications.Select(m => m.Name).ToList());
            view.Columns["Name"].ColumnEdit = repoCombo;

            // AutoComplete لباركود الدواء
            var repoComboBarcode = new RepositoryItemComboBox
            {
                TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard,
                AutoComplete = true
            };
            repoComboBarcode.Items.AddRange(medications.Select(m => m.Barcode).ToList());
            view.Columns["Barcode"].ColumnEdit = repoComboBarcode;

            // زر الحذف
            var deleteButton = new RepositoryItemButtonEdit();
            deleteButton.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete;
            deleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            deleteButton.ButtonClick += (s, eBtn) =>
            {
                var viewGrid = gridView1;
                int rowHandle = viewGrid.FocusedRowHandle;
                if (rowHandle >= 0)
                {
                    // رسالة التأكيد
                    var result = MessageBox.Show("هل تريد حذف هذا السطر؟",
                                                 "تأكيد الحذف",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        viewGrid.DeleteRow(rowHandle);
                        UpdateGrandTotal(); // تحديث المجموع بعد الحذف
                    }
                }
            };
            var deleteCol = view.Columns.AddField("Delete");
            deleteCol.Caption = "حذف";
            deleteCol.Visible = true;
            deleteCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            deleteCol.ColumnEdit = deleteButton;
            deleteCol.OptionsColumn.AllowEdit = true;
            deleteCol.Width = 30;

            // الأحداث
            view.ValidatingEditor += GridView1_ValidatingEditor;
            view.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            view.CellValueChanged += (s, ea) => UpdateGrandTotal();
            view.RowCountChanged += (s, ea) => UpdateGrandTotal();


            //*******************************************
            // بيانات تجريبية
            //var data = new List<Person>
            //{
            //   new Person{ Id=1, Name="Ali"},
            //   new Person{ Id=2, Name="Sami"},
            //   new Person{ Id=3, Name="Karim"},
            //};

            //DGListeCustomer.DataSource = data;

            var viewx = (DevExpress.XtraGrid.Views.Grid.GridView)DGListeCustomer.MainView;
            viewx.OptionsView.ShowGroupPanel = false;

            // عمود الأزرار
            GridColumn colAction = viewx.Columns.AddVisible("Action", "الإجراءات");
            colAction.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            colAction.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            colAction.Width = 25;

            // RepositoryItemButtonEdit واحد بثلاثة أزرار
            actionButtons = new RepositoryItemButtonEdit
            {
                TextEditStyle = TextEditStyles.HideTextEditor
            };

            // زر عرض
            var btnviewx = new EditorButton(ButtonPredefines.Glyph);
            //btnviewx.ImageOptions.SvgImage = DevExpress.Utils.Svg.SvgImage.FromFile("icons/view.svg");
            btnviewx.Tag = "viewx";                       // مفتاح تمييز
            actionButtons.Buttons.Add(btnviewx);

            // زر تعديل
            var btnEdit = new EditorButton(ButtonPredefines.Glyph);
            //btnEdit.ImageOptions.SvgImage = DevExpress.Utils.Svg.SvgImage.FromFile("icons/edit.svg");
            btnEdit.Tag = "edit";                       // مفتاح تمييز
            actionButtons.Buttons.Add(btnEdit);

            // زر حذف
            var btnDelete = new EditorButton(ButtonPredefines.Glyph);
            //btnDelete.ImageOptions.SvgImage = DevExpress.Utils.Svg.SvgImage.FromFile("icons/delete.svg");
            btnDelete.Tag = "delete";                   // مفتاح تمييز
            actionButtons.Buttons.Add(btnDelete);

            DGListeCustomer.RepositoryItems.Add(actionButtons);
            colAction.ColumnEdit = actionButtons;

            // حدث النقر
            actionButtons.ButtonClick += ActionButtons_ButtonClick;
            //*********************************************
        }
        #endregion

        private void ActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.Grid.GridView)DGListeCustomer.MainView;
            var row = view.GetFocusedRow() as Medication;
            if (row == null) return;

            // 1) التمييز بالـ Tag (الأفضل)
            var tag = e.Button.Tag as string;
            if (!string.IsNullOrEmpty(tag))
            {
                switch (tag)
                {
                    case "view":
                        MessageBox.Show($"👁 عرض: {row.Name}");
                        return;

                    case "edit":
                        MessageBox.Show($"✏ تعديل: {row.Name}");
                        return;

                    case "delete":
                        if (MessageBox.Show($"هل تريد حذف {row.Name}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            view.DeleteRow(view.FocusedRowHandle);
                        return;
                }
            }

            // 2) فfallback بالفهرس داخل نفس الـ Repository (لو لأي سبب الـ Tag ماوصل)
            var repo = (RepositoryItemButtonEdit)sender;
            int idx = repo.Buttons.IndexOf(e.Button); // 0=view, 1=edit, 2=delete
            if (idx == 0)
                MessageBox.Show($"👁 عرض: {row.Name}");
            else if (idx == 1)
                MessageBox.Show($"✏ تعديل: {row.Name}");
            else if (idx == 2)
            {
                if (MessageBox.Show($"هل تريد حذف {row.Name}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    view.DeleteRow(view.FocusedRowHandle);
            }
        }
         

        private void txtFactureNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPurchaseDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtTypePaimt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت الـ "ding"
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}