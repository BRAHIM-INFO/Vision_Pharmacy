using DevExpress.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.Serialization;
using DevExpress.XtraScheduler;
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
        private List<int> IdList;
        private Label labelEmptyData;
        private string searchItem;
        private RepositoryItemButtonEdit actionButtons;


        // Constructores
        public UserUserControl()
        {
            InitializeComponent();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            _dataHelper = (IDataHelper<User>)ContainerConfig.ObjectType("User");
            loading = LoadingUser.Instance();
            LoadData();
 
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

            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                ApplyArabicResources();
            }
            else
            {
                ApplyEnglishResources();
            }
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
                IdList = new List<int>(); SetIDSelcted();
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
            if (Properties.Settings.Default.ChangeLang == "Ar")
            {
                gridView1.Columns[0].Caption = "المعرف";
                gridView1.Columns[1].Caption = "الاسم الكامل";
                gridView1.Columns[2].Caption = "اسم المستخدم";
                gridView1.Columns[3].Caption = "كلمة السر";
                gridView1.Columns[4].Caption = "الصلاحية";
            }
            else
            {
                gridView1.Columns[0].Caption = "ID";
                gridView1.Columns[1].Caption = "Full Name";
                gridView1.Columns[2].Caption = "User Name";
                gridView1.Columns[3].Caption = "Password";
                gridView1.Columns[4].Caption = "Permission";
            }
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


        //ملف الموارد العربي
        public void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;
            PicLaterale.Dock = DockStyle.Right;
            SeparatLat.Dock = DockStyle.Right;
            lblTitle.Dock = DockStyle.Right;

            btnPrint.Location = new Point(3, 76);
            btnAdd.Location = new Point(146, 76);

            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            lblTitle.Text = Resources_Ar.TitleUser;
            btnAdd.Text = Resources_Ar.AddButton_User;
            btnPrint.Text = Resources_Ar.PrintButton_User;
            labelEmptyData.Text = Resources_Ar.EmptyDataText;

            gridControl1.RightToLeft = RightToLeft.Yes;
        }

        //ملف الموارد انجليزي
        public void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            PicLaterale.Dock = DockStyle.Left;
            SeparatLat.Dock = DockStyle.Left;
            lblTitle.Dock = DockStyle.Left;

            btnPrint.Location = new Point(this.Size.Width - 140, 76);
            btnAdd.Location = new Point(this.Size.Width - 283, 76);

            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            lblTitle.Text = Resources_En.TitleUser;
            btnAdd.Text = Resources_En.AddButton_User;
            btnPrint.Text = Resources_En.PrintButton_User;
            labelEmptyData.Text = Resources_En.EmptyDataText;

            gridControl1.RightToLeft = RightToLeft.No;
        }

        private async void UserUserControl_Load(object sender, EventArgs e)
        {
            loading.Show();
            if (_dataHelper.IsDbConnect())
            {
                gridControl1.DataSource = await Task.Run(() => _dataHelper.GetData()); // تحميل البيانات بشكل غير متزامن
                SetDataGridViewColumns();
                var view = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.MainView;
                view.OptionsView.ShowGroupPanel = false;

                // عمود الأزرار
                GridColumn colAction = view.Columns.AddVisible("Action", "الإجراءات");
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



                gridControl1.RepositoryItems.Add(actionButtons);
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

        /// <summary>
        ///  اجراءات الأزرار في عمود الإجراءات )عرض، تعديل، حذف(
        private void ActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.MainView;


            var row = view.GetFocusedRow() as Customer;
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
                            UserAddForm UserAddForm = new UserAddForm(RowId, this, false);
                            UserAddForm.btnSave.Visible = false; // إخفاء زر الحفظ
                            UserAddForm.ShowDialog();
                            return;

                        }
                    case "edit":
                        {
                            if (gridView1.RowCount > 0)
                            {
                                RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                                UserAddForm UserAddForm = new UserAddForm(RowId, this, false);
                                UserAddForm.ShowDialog();
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
                                    IdList = new List<int>(); SetIDSelcted();
                                    if (MessageBox.Show($"هل تريد حذف {row.FullName}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                UserAddForm UserAddForm = new UserAddForm(RowId, this, false);
                UserAddForm.btnSave.Visible = false; // إخفاء زر الحفظ
                UserAddForm.ShowDialog();
            }
            else if (idx == 1)
            {
                if (gridView1.RowCount > 0)
                {
                    RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                    UserAddForm UserAddForm = new UserAddForm(RowId, this, false);
                    UserAddForm.ShowDialog();
                }
                else
                {
                    MessageCollection.ShowEmptyDataMessage();
                }
            }

            else if (idx == 2)
                if (MessageBox.Show($"هل تريد حذف {row.FullName}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (gridView1.RowCount > 0)
                        {
                            IdList = new List<int>(); SetIDSelcted();
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

        }
    }
}
