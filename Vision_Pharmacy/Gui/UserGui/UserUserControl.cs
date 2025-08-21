using DevExpress.XtraEditors;
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
using Vision_Pharmacy.Data.EFSqlServer;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.UserGui
{
    public partial class UserUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields
        private readonly IDataHelper<User> _dataHelper;
        private readonly LoadingUser loading;
        private int RowId;
        private static UserUserControl _userUser;
        private List<int> IdList = new List<int>();
        private Label labelEmptyData;
        private string searchItem;


        // Constructores
        public UserUserControl()
        {
            InitializeComponent();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelper = (IDataHelper<User>)ContainerConfig.ObjectType("User");
            loading = LoadingUser.Instance();
            LoadData();
            gridView1.OptionsBehavior.Editable = false;

            //DataTable table = new DataTable();
            //table.Columns.Add("ID", typeof(int));
            //table.Columns.Add("الاسم", typeof(string));
            //table.Columns.Add("الوظيفة", typeof(string));

            //table.Rows.Add(1, "أحمد", "مبرمج");
            //table.Rows.Add(2, "سارة", "محاسبة");
            //table.Rows.Add(3, "ليلى", "مصممة");
            //table.Rows.Add(4, "يوسف", "مدير");

            //gridControl1.DataSource = table;

            // تفعيل البحث
            gridView1.OptionsFind.AlwaysVisible = true;
            gridView1.OptionsFind.ShowClearButton = true;
            gridView1.OptionsFind.ShowFindButton = true;
        }


        //events
        #region
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserAddForm UserAdd = new UserAddForm(0, this, false);
            UserAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0])); //dataGridView.CurrentRow.Cells[0].Value);
                UserAddForm UserAdd = new UserAddForm(RowId, this, false);
                UserAdd.Show();
            }
            else
            {
                MessageCollection.ShowEmptyDataMessage();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
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
            //}
            //catch
            //{
            //    MessageCollection.ShowServerMessage();
            //}
            loading.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

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
                gridControl1.DataSource = await Task.Run(() => _dataHelper.GetData());
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

        //public async void LoadDataForSearch()
        //{
        //    if (textBoxSearch.Text == string.Empty)
        //    {
        //        LoadData();
        //    }
        //    else
        //    {
        //        loading.Show();
        //        searchItem = textBoxSearch.Text;
        //        // Check if connection is available
        //        if (_dataHelper.IsDbConnect())
        //        {
        //            // Loading Data
        //            dataGridView.DataSource = await Task.Run(() => _dataHelper.Search(searchItem));
        //            SetDataGridViewColumns();
        //        }
        //        else
        //        {
        //            MessageCollection.ShowServerMessage();
        //        }
        //        loading.Hide();
        //    }
        //    // Show Empty Label Data
        //    ShowLabelIfEmptyData();

        //}

        // Get a List of Id for selcted rows
        private void SetIDSelcted()
        {
            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            //    if (row.Selected) IdList.Add(Convert.ToInt32(row.Cells[0].Value));
            //}

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
                gridView1.Columns[2].Caption = "اسم المستخدم";
                gridView1.Columns[3].Caption = "كلمة السر";
                gridView1.Columns[4].Caption = "الصلاحية";
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
            return _userUser ?? (new UserUserControl());
        }
        //Add and Show Empty Label 
        private void ShowLabelIfEmptyData()
        {
            gridControl1.Controls.Add(labelEmptyData);

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
