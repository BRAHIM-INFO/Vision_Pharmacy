using DevExpress.Xpo.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
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
using Vision_Pharmacy.Gui.EmployeeGui;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.MedicationGui
{
    public partial class CategoryAddForm : DevExpress.XtraEditors.XtraForm
    {
        // Fileds  
        private int RowId; 
        private List<int> IdList = new List<int>();
        private Label labelEmptyData; 
        private readonly int id;
        private readonly LoadingUser loading;
        private IDataHelper<Category> _dataHelper;
        private Category Category;
        private int ResultAddOrEdit; 
        public CategoryAddForm()
        {
            InitializeComponent(); 
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Category>)ContainerConfig.ObjectType("Category");
            // Set DataFileds for Edit void
            if (id > 0)
            {
                SetDataToFileds();
            }
        }

        private void CategoryAddForm_Load(object sender, EventArgs e)
        {
            LoadData();
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
         
        private void btnDelete_Click(object sender, EventArgs e)
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

    }
}