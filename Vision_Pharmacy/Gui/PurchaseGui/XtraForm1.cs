using DevExpress.Utils.Svg;
using DevExpress.Xpo.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision_Pharmacy.Code;
using Vision_Pharmacy.Core;
using Vision_Pharmacy.Data;
using Vision_Pharmacy.Gui.MedicationGui;
using Vision_Pharmacy.Gui.OtherGui;

namespace Vision_Pharmacy.Gui.PurchaseGui
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {

        private readonly IDataHelper<Medication> _dataHelper;
        private readonly LoadingUser loading;
        private RepositoryItemButtonEdit actionButtons;
        private Label labelEmptyData;
        AllClasses AllClasses;
        private List<int> IdList = new List<int>();
        private int RowId;
        public XtraForm1()
        {
            InitializeComponent();
            loading = LoadingUser.Instance();
            _dataHelper = (IDataHelper<Medication>)ContainerConfig.ObjectType("Medication");
            labelEmptyData = ComponentsObject.Instance().LabelEmptyData();
            AllClasses = new AllClasses();
            AllClasses.RoundButtonCorners(btnAddPurch, 15);
            AllClasses.RoundButtonCorners(btnEditPurch, 15);
            AllClasses.RoundButtonCorners(btnDeletePurch, 15);
            AllClasses.RoundButtonCorners(btnPrintPurch, 15);
        }
        private void SetDataGridViewColumns()
        {
            try
            {
                gridView1.Columns[0].Visible = false; // Hide Column
                gridView1.Columns[1].Caption = "باركود الدواء";
                gridView1.Columns[2].Caption = "اسم الدواء";
                gridView1.Columns[3].Caption = "الاسم العلمي";
                gridView1.Columns[4].Visible = false; // Hide Column
                gridView1.Columns[5].Caption = "الشكل الصيدلي";
                gridView1.Columns[6].Caption = "التركيز";
                gridView1.Columns[7].Caption = "التصنيف";
                gridView1.Columns[8].Caption = "سعر الشراء";
                gridView1.Columns[9].Caption = "سعر البيع";
                gridView1.Columns[10].Caption = "الوحدة";
                gridView1.Columns[11].Caption = "كمية المتوفرة";
                gridView1.Columns[12].Caption = "الحد الأدنى للتنبيه";
                gridView1.Columns[13].Caption = "تاريخ انتهاء الصلاحية";
                gridView1.Columns[14].Visible = false; // Hide Column
                gridView1.Columns[15].Caption = "المورد الرئيسي";
                gridView1.Columns[16].Visible = false; // Hide Column
                gridView1.Columns[17].Visible = false; // Hide Column
                gridView1.Columns[18].Visible = false; // Hide Column
                gridView1.Columns[19].Visible = false; // Hide Column
                gridView1.Columns[20].Caption = "مكان التخزين";
                gridView1.Columns[21].Visible = false; // Hide Column
                gridView1.Columns[22].Visible = false; // Hide Column
                gridView1.Columns[23].Visible = false; // Hide Column
            }
            catch
            {
                // تجاهل الخطأ (يفضل تسجيله)
            }
            // Hide Columns
        }
        
        private async void XtraForm1_Load(object sender, EventArgs e)
        {
            loading.Show();
            if (_dataHelper.IsDbConnect())
            {
                DGListeMedication.DataSource = await Task.Run(() => _dataHelper.GetData()); // تحميل البيانات بشكل غير متزامن
                SetDataGridViewColumns();
                var view = (DevExpress.XtraGrid.Views.Grid.GridView)DGListeMedication.MainView;
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
            loading.Hide();
        }

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
                        MessageBox.Show($"👁 عرض: {row.Name}");
                        return;

                    case "edit":
                        {
                            if (gridView1.RowCount > 0)
                            {
                                RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                                MedicationAddForm customerAdd = new MedicationAddForm("", "");// RowId, this);
                                customerAdd.ShowDialog();
                            }
                            else
                            {
                                MessageCollection.ShowEmptyDataMessage();
                            }  
                            
                            // هنا يمكنك فتح نموذج تعديل الدواء
                            MessageBox.Show($"✏ تعديل: {row.Name}");
                            return;
                        }
                      

                    case "delete":
                        {
                            try
                            {
                                if (gridView1.RowCount > 0)
                                {
                                    SetIDSelcted();
                                //var result = MessageCollection.DeleteActtion();
                                //if (result == true)
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
                            //if (MessageBox.Show($"هل تريد حذف {row.Name}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            //    view.DeleteRow(view.FocusedRowHandle);

                            return;
                        }
                      
                }
            }

            // 2) فfallback بالفهرس داخل نفس الـ Repository (لو لأي سبب الـ Tag ماوصل)
            var repo = (RepositoryItemButtonEdit)sender;
            int idx = repo.Buttons.IndexOf(e.Button); // 0=view, 1=edit, 2=delete
            if (idx == 0)
                // زر عرض
                MessageBox.Show($"👁 عرض: {row.Name}");

            else if (idx == 1)
            {
                if (gridView1.RowCount > 0)
                {
                    RowId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
                    MedicationAddForm customerAdd = new MedicationAddForm("", "");// RowId, this);
                    customerAdd.ShowDialog();
                }
                else
                {
                    MessageCollection.ShowEmptyDataMessage();
                }
                // زر تعديل
                MessageBox.Show($"✏ تعديل: {row.Name}");
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
                    //view.DeleteRow(view.FocusedRowHandle);
                    //if (MessageBox.Show($"هل تريد حذف {row.Name}؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    //    view.DeleteRow(view.FocusedRowHandle);
                }

        }


    }
}