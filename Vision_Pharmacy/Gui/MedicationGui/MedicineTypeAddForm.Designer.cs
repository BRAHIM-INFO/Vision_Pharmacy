using Vision_Pharmacy.Properties;

namespace Vision_Pharmacy.Gui.MedicationGui
{
    partial class MedicineTypeAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineTypeAddForm));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel1 = new Panel();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            textBoxName = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControl1.Location = new Point(12, 121);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RightToLeft = RightToLeft.Yes;
            gridControl1.Size = new Size(799, 272);
            gridControl1.TabIndex = 9;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.CustomizationFormHint.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            gridView1.Appearance.DetailTip.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.DetailTip.Options.UseFont = true;
            gridView1.Appearance.EvenRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.EvenRow.Options.UseFont = true;
            gridView1.Appearance.FilterPanel.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.FilterPanel.Options.UseFont = true;
            gridView1.Appearance.FocusedCell.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.FocusedCell.Options.UseFont = true;
            gridView1.Appearance.FocusedRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.FocusedRow.Options.UseFont = true;
            gridView1.Appearance.FooterPanel.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.FooterPanel.Options.UseFont = true;
            gridView1.Appearance.GroupFooter.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.GroupFooter.Options.UseFont = true;
            gridView1.Appearance.GroupPanel.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.GroupRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.GroupRow.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HideSelectionRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            gridView1.Appearance.HotTrackedRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            gridView1.Appearance.NoSearchResults.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.NoSearchResults.Options.UseFont = true;
            gridView1.Appearance.OddRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.OddRow.Options.UseFont = true;
            gridView1.Appearance.Preview.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.Preview.Options.UseFont = true;
            gridView1.Appearance.Row.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Appearance.SelectedRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.SelectedRow.Options.UseFont = true;
            gridView1.Appearance.TopNewRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.TopNewRow.Options.UseFont = true;
            gridView1.Appearance.ViewCaption.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 246, 255);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 70);
            panel1.TabIndex = 19;
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(822, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Resources.pill_bottle_15968729;
            pictureBox2.Location = new Point(771, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cairo Medium", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(621, 25);
            label5.Name = "label5";
            label5.Size = new Size(144, 37);
            label5.TabIndex = 2;
            label5.Text = "الشكل الصيدلي";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxName.Font = new Font("Cairo Medium", 10F);
            textBoxName.Location = new Point(101, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(567, 39);
            textBoxName.TabIndex = 20;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Cairo Medium", 10F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(74, 83);
            label6.Name = "label6";
            label6.Size = new Size(21, 32);
            label6.TabIndex = 22;
            label6.Text = "*";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cairo Medium", 10F);
            label1.Location = new Point(13, 79);
            label1.Name = "label1";
            label1.Size = new Size(59, 32);
            label1.TabIndex = 21;
            label1.Text = "الاسم:";
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnSave.Appearance.Font = new Font("Cairo Medium", 10F);
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearanceDisabled.Options.UseFont = true;
            btnSave.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearanceHovered.Options.UseFont = true;
            btnSave.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearancePressed.Options.UseFont = true;
            btnSave.Cursor = Cursors.Hand;
            btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSave.ImageOptions.SvgImage");
            btnSave.ImageOptions.SvgImageSize = new Size(20, 20);
            btnSave.Location = new Point(674, 76);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(137, 39);
            btnSave.TabIndex = 23;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "حفظ";
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Appearance.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Appearance.Font = new Font("Cairo Medium", 10F);
            btnDelete.Appearance.Options.UseBackColor = true;
            btnDelete.Appearance.Options.UseFont = true;
            btnDelete.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnDelete.AppearanceDisabled.Options.UseFont = true;
            btnDelete.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnDelete.AppearanceHovered.Options.UseFont = true;
            btnDelete.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnDelete.AppearancePressed.Options.UseFont = true;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDelete.ImageOptions.SvgImage");
            btnDelete.ImageOptions.SvgImageSize = new Size(20, 20);
            btnDelete.Location = new Point(674, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.Yes;
            btnDelete.Size = new Size(137, 37);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "حذف";
            btnDelete.ToolTipTitle = "اضافة";
            btnDelete.Click += btnDelete_Click;
            // 
            // MedicineTypeAddForm
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 444);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(gridControl1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MedicineTypeAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الشكل الصيدلي";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Panel panel1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox textBoxName;
        private Label label6;
        private Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}