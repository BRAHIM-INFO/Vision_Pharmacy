using DevExpress.Utils.Svg;
using DevExpress.Xpo.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
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
using Vision_Pharmacy.Gui.EmployeeGui;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.MedicationGui
{
    public partial class CategoryAddForm : DevExpress.XtraEditors.XtraForm
    {
        // Fileds  
        private int RowId; 
        private List<int> IdList;
        private Label labelEmptyData; 
        private readonly int id;
        private readonly LoadingUser loading;
        private IDataHelper<Category> _dataHelper;
        private Category Category;
        private int ResultAddOrEdit;
        private RepositoryItemButtonEdit actionButtons;
        public CategoryAddForm()
        {
            InitializeComponent();
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Category>)ContainerConfig.ObjectType("Category");
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
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

        private async void CategoryAddForm_Load(object sender, EventArgs e)
        {
            loading.Show();
            if (_dataHelper.IsDbConnect())
            {
                gridControl1.DataSource = await Task.Run(() => _dataHelper.GetData()); // تحميل البيانات بشكل غير متزامن
                
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
            LoadData();
        }

        /// <summary>
        ///  اجراءات الأزرار في عمود الإجراءات )عرض، تعديل، حذف(
        private void ActionButtons_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var view = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.MainView;


            var row = view.GetFocusedRow() as Category;
            if (row == null) return;

            // 1) التمييز بالـ Tag (الأفضل)
            var tag = e.Button.Tag as string;
            if (!string.IsNullOrEmpty(tag))
            {
                switch (tag)
                { 
                    case "delete":
                        {
                            try
                            {
                                if (gridView1.RowCount > 0)
                                {
                                    IdList = new List<int>(); SetIDSelcted();
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
                if (MessageBox.Show($"هل تريد حذف {row.Name}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                // Check if add or edit
                if (id == 0)
                {
                    // Add
                    AddData();
                } 
                loading.Hide();
            }
        }
         
        

        #region Methods 
        public async void LoadData()
        {
            loading.Show();
            // Check if connection is available
            if (_dataHelper.IsDbConnect())
            {
                // Loading Data
                gridControl1.DataSource = await Task.Run(() => _dataHelper.GetData());
                gridView1.Columns[0].Visible = false;
            }
            else
            {
                MessageCollection.ShowServerMessage();
            }
            loading.Hide(); 
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

        private async void AddData()
        {
            // Set Data
            SetDataForAdd();
            // Send data and get result
            ResultAddOrEdit = await Task.Run(() => _dataHelper.Add(Category));
            // check the result of proccess
            if (ResultAddOrEdit == 1) // Seccessfuly
            {
                // Show Notifiction
                MessageCollection.ShowAddNotification();
                ClearFileds();
                // Updat View
                LoadData();
            }
            else // End with database error
            {
                MessageCollection.ShowServerMessage();
            }
        }
         
        private void ClearFileds()
        {
            textBoxName.Text = string.Empty;
        }

        private async void SetDataToFileds()
        {
            if (_dataHelper.IsDbConnect())
            {
                Category = await Task.Run(() => _dataHelper.Find(id));
                textBoxName.Text = Category.Name.ToString();
            }
            else
            {
                MessageCollection.ShowServerMessage();

            }
            Category = null;
        }
        private void SetDataForAdd()
        {
            Category = new Category
            {
                Name = textBoxName.Text
            };


        }
        private void SetDataForEdit()
        {
            Category = new Category
            {
                Id = this.id,
                Name = textBoxName.Text
            };
        }
        private bool IsRequiredFiledEmpty()
        {
            if (textBoxName.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        #endregion

        //ملف ترجمة الى اللغة العربية
        private void ApplyArabicResources()
        {
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            flowLayoutPanel2.RightToLeft = RightToLeft.No;
            this.Text = "التصنيف";

            lbltop.Text = "التصنيف";
            label1.Text = "الاسم"; 

            btnSave.Text = "حفظ"; 
            labelEmptyData.Text = Resources_Ar.EmptyDataText; 
        }


        //ملف ترجمة الى اللغة الانجليزية
        private void ApplyEnglishResources()
        {
            this.RightToLeft = RightToLeft.No;
            this.RightToLeftLayout = false;
            flowLayoutPanel2.RightToLeft = RightToLeft.Yes;
            this.Text = "Category";
            lbltop.Text = "Category";
            label1.Text = "Name"; 
            btnSave.Text = "Save"; 
            labelEmptyData.Text = Resources_En.EmptyDataText;
        }

    }
}