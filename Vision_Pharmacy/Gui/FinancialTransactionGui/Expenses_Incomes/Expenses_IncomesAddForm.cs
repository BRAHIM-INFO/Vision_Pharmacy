using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.OtherGui;
using Vision_Pharmacy.Gui.CustomerGui; 

namespace Vision_Pharmacy.Gui.FinancialTransaction.Expenses
{
    public partial class Expenses_IncomesAddForm : DevExpress.XtraEditors.XtraForm
    {
        // تعريف المتغيرات للمنزلقات
        #region 
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public AllClasses allClasses = new AllClasses();
        #endregion

        // Fileds
        private readonly int id;
        private readonly FinancialTransactionUserControl FinancialTransactionUserControl;
        private readonly LoadingUser loading;
        private IDataHelper<FinancialTransactions> _dataHelper;
        private FinancialTransactions FinancialTransactions;
        private int ResultAddOrEdit;
        AllClasses AllClasses = new AllClasses();
        string operationType = "Income";

        public Expenses_IncomesAddForm(int Id, FinancialTransactionUserControl FinancialTransactionUserControl)
        {
            InitializeComponent();
            AllClasses.RoundPanelCornersForm(this, 25); // 15 مثل bunifu

            // Set Property Instance 
            this.FinancialTransactionUserControl = FinancialTransactionUserControl;
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<FinancialTransactions>)ContainerConfig.ObjectType("FinancialTransactions");
            
            id = Id;
            if (id > 0)
            {
                SetDataToFileds();
            }
            else
            {
                txtExpenseIncomeID.Text = GenerateFactureNum();
                txtExpenseIncomeID.HideSelection = true; 
            }



            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                ApplyArabicResources();
            }
            else
            {
                ApplyEnglishResources();
            }
        }

        private void ExpendesAddForm_Load(object sender, EventArgs e)
        {

        }

        // اريد جعل FactureNum تولد اوتوماتيكيا بشكل 01-2025 / 02-2025
        public string GenerateFactureNum()
        {
            int currentYear = DateTime.Now.Year;

            // نجيب آخر فاتورة لنفس السنة
            var lastFacture = _dataHelper.GetData()
                .Where(p => p.TransactionDate.Year == currentYear)
                .OrderByDescending(p => p.Id)
                .FirstOrDefault();

            int nextNumber = 1;

            if (lastFacture != null && !string.IsNullOrEmpty(lastFacture.TransactionNum))
            {
                string[] parts = lastFacture.TransactionNum.Split('-');
                if (parts.Length == 2 && int.TryParse(parts[0], out int lastNumber))
                {
                    nextNumber = lastNumber + 1;
                }
            }

            return $"{nextNumber:D2}-{currentYear}";
        }
         
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Methods 
         
        private async void AddData()
        {
            // Set Data
            SetDataForAdd();
            // Send data and get result
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Add(FinancialTransactions));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
                if (FinancialTransactionUserControl != null) FinancialTransactionUserControl.LoadData();
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
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Edit(FinancialTransactions));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notification
                MessageCollection.ShowEditNotification();
                // Updat View
                FinancialTransactionUserControl.LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }

        private void ClearFileds()
        {
            txtDescription.Text = string.Empty;
            txtExpenseIncomeID.Text = string.Empty; 
            txtTypePaimt.Text = string.Empty;
            txtTypeOperatInc.Checked = true;
        }

        private async void SetDataToFileds()
        {
            if (_dataHelper.IsDbConnect())
            { 
                FinancialTransactions = await Task.Run(() => _dataHelper.Find(id));
                txtDescription.Text = FinancialTransactions.TransactionDescription;
                txtExpenseIncomeID.Text = FinancialTransactions.TransactionNum; 
                txtTypePaimt.Text =       FinancialTransactions.PaymentMethod;
                txtMontant.Text = FinancialTransactions.Amount.ToString();
                txtDate.Text = FinancialTransactions.TransactionDate.ToShortDateString();

                if (FinancialTransactions.TransactionType == "مداخيل")
                    txtTypeOperatInc.Checked = true;
                else if (FinancialTransactions.TransactionType == "مصروفات")
                    txtTypeOperatExp.Checked = true; 
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            FinancialTransactions = null;
        }
        private void SetDataForAdd()
        {
            if (txtTypeOperatInc.Checked)
                operationType = "مداخيل";
            else if (txtTypeOperatExp.Checked)
                operationType = "مصروفات"; 

            FinancialTransactions = new Vision_Pharmacy.Core.FinancialTransactions
            {
                Amount = decimal.Parse(txtMontant.Text),
                TransactionDescription = txtDescription.Text,
                TransactionDate = DateTime.Now,
                TransactionName = txtTransactionName.Text,
                TransactionNum = txtExpenseIncomeID.Text,
                TransactionType = operationType,
                PaymentMethod = txtTypePaimt.Text
            };


        }
        private void SetDataForEdit()
        {
            if (txtTypeOperatInc.Checked)
                operationType = "مداخيل";
            else if (txtTypeOperatExp.Checked)
                operationType = "مصروفات";

            FinancialTransactions = new Vision_Pharmacy.Core.FinancialTransactions
            {
                Id = this.id,
                Amount = decimal.Parse(txtMontant.Text),
                TransactionDescription = txtDescription.Text,
                TransactionDate = DateTime.Now,
                TransactionName = txtTransactionName.Text,
                TransactionNum = txtExpenseIncomeID.Text,
                TransactionType = operationType,
                PaymentMethod = txtTypePaimt.Text
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (txtTransactionName.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //ملف ترجمة الى اللغة العربية
        private void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

             lblDate.Text = "التاريخ";
            lblExpenseIncomeID.Text = "رقم العملية *";
            lblTypeOperat.Text = "نوع العملية *";
            lblTypePaimt.Text = "طريقة الدفع *";
            lblMontant.Text = "المبلغ *";
            txtDescription.Text = "الوصف";
            lbltitle.Text = "ادارة المالية >  المصروفات و المداخيل";
            lblTransactionName.Text = "اسم العملية *";
            txtTransactionName.PlaceholderText = "اسم العملية *";
            txtExpenseIncomeID.PlaceholderText = "رقم العملية *"; 
            txtMontant.PlaceholderText = "المبلغ *";
            txtDescription.PlaceholderText = "الوصف";
            txtTypeOperatInc.Text = "مداخيل";
            txtTypeOperatExp.Text = "مصروفات";
            buttonSaveSup.Text = "حفظ البيانات";
        }

        //ملف ترجمة الى اللغة الانجليزية
        private void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;
            lblDate.Text = "Date";
            lblExpenseIncomeID.Text = "Transaction ID *";
            lblTypeOperat.Text = "Transaction Type *";
            lblTypePaimt.Text = "Payment Method *";
            lblMontant.Text = "Amount *";
            txtDescription.Text = "Description";
            lbltitle.Text = "Financial Management > Expenses & Incomes";
            lblTransactionName.Text = "Transaction Name *";
            txtTransactionName.PlaceholderText = "Transaction Name *";
            txtExpenseIncomeID.PlaceholderText = "Transaction ID *"; 
            txtMontant.PlaceholderText = "Amount *";
            txtDescription.PlaceholderText = "Description";
            txtTypeOperatInc.Text = "Income";
            txtTypeOperatExp.Text = "Expense";
            buttonSaveSup.Text = "Save Data";
        }

        #endregion

        private void buttonSaveSup_Click(object sender, EventArgs e)
        {
            // check requirments of fileds
            if (IsRequiredFiledEmpty())
            {
                MessageCollection.ShowEmptyFields();
            }
            else
            {
                loading.Show();
                // Check if add or edit
                if (id == 0)
                {
                    // Add
                    AddData();
                }
                else
                {
                    // Edit
                    EditData();
                }
                loading.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}