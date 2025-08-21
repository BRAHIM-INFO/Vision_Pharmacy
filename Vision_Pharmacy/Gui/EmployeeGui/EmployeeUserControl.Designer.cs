namespace Vision_Pharmacy.Gui.EmployeeGui
{
    partial class EmployeeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUserControl));
            DGListeEmployee = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnPrintEmp = new DevExpress.XtraEditors.SimpleButton();
            btnAddEmp = new DevExpress.XtraEditors.SimpleButton();
            pictureBox1 = new PictureBox();
            btnEditEmp = new DevExpress.XtraEditors.SimpleButton();
            btnDeleteEmp = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            lblEmp = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            SuspendLayout();
            // 
            // DGListeEmployee
            // 
            DGListeEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeEmployee.Location = new Point(12, 157);
            DGListeEmployee.MainView = gridView1;
            DGListeEmployee.Name = "DGListeEmployee";
            DGListeEmployee.RightToLeft = RightToLeft.Yes;
            DGListeEmployee.Size = new Size(1289, 552);
            DGListeEmployee.TabIndex = 22;
            DGListeEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
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
            gridView1.GridControl = DGListeEmployee;
            gridView1.Name = "gridView1";
            // 
            // btnPrintEmp
            // 
            btnPrintEmp.Appearance.BackColor = Color.Gray;
            btnPrintEmp.Appearance.Font = new Font("Cairo Medium", 10F);
            btnPrintEmp.Appearance.Options.UseBackColor = true;
            btnPrintEmp.Appearance.Options.UseFont = true;
            btnPrintEmp.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnPrintEmp.AppearanceDisabled.Options.UseFont = true;
            btnPrintEmp.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnPrintEmp.AppearanceHovered.Options.UseFont = true;
            btnPrintEmp.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnPrintEmp.AppearancePressed.Options.UseFont = true;
            btnPrintEmp.Cursor = Cursors.Hand;
            btnPrintEmp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrintEmp.ImageOptions.SvgImage");
            btnPrintEmp.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrintEmp.Location = new Point(12, 104);
            btnPrintEmp.Name = "btnPrintEmp";
            btnPrintEmp.RightToLeft = RightToLeft.Yes;
            btnPrintEmp.Size = new Size(137, 45);
            btnPrintEmp.TabIndex = 21;
            btnPrintEmp.Text = "طباعة";
            btnPrintEmp.ToolTipTitle = "اضافة";
            btnPrintEmp.Click += btnPrintEmp_Click;
            // 
            // btnAddEmp
            // 
            btnAddEmp.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnAddEmp.Appearance.Font = new Font("Cairo Medium", 10F);
            btnAddEmp.Appearance.Options.UseBackColor = true;
            btnAddEmp.Appearance.Options.UseFont = true;
            btnAddEmp.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnAddEmp.AppearanceDisabled.Options.UseFont = true;
            btnAddEmp.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnAddEmp.AppearanceHovered.Options.UseFont = true;
            btnAddEmp.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnAddEmp.AppearancePressed.Options.UseFont = true;
            btnAddEmp.Cursor = Cursors.Hand;
            btnAddEmp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAddEmp.ImageOptions.SvgImage");
            btnAddEmp.ImageOptions.SvgImageSize = new Size(25, 25);
            btnAddEmp.Location = new Point(441, 104);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.RightToLeft = RightToLeft.Yes;
            btnAddEmp.Size = new Size(137, 45);
            btnAddEmp.TabIndex = 20;
            btnAddEmp.Text = "اضافة";
            btnAddEmp.ToolTipTitle = "اضافة";
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.hr_19008748;
            pictureBox1.Location = new Point(1226, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnEditEmp
            // 
            btnEditEmp.Appearance.BackColor = Color.FromArgb(18, 128, 146);
            btnEditEmp.Appearance.Font = new Font("Cairo Medium", 10F);
            btnEditEmp.Appearance.Options.UseBackColor = true;
            btnEditEmp.Appearance.Options.UseFont = true;
            btnEditEmp.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnEditEmp.AppearanceDisabled.Options.UseFont = true;
            btnEditEmp.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnEditEmp.AppearanceHovered.Options.UseFont = true;
            btnEditEmp.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnEditEmp.AppearancePressed.Options.UseFont = true;
            btnEditEmp.Cursor = Cursors.Hand;
            btnEditEmp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnEditEmp.ImageOptions.SvgImage");
            btnEditEmp.ImageOptions.SvgImageSize = new Size(25, 25);
            btnEditEmp.Location = new Point(298, 104);
            btnEditEmp.Name = "btnEditEmp";
            btnEditEmp.RightToLeft = RightToLeft.Yes;
            btnEditEmp.Size = new Size(137, 45);
            btnEditEmp.TabIndex = 19;
            btnEditEmp.Text = "تعديل";
            btnEditEmp.ToolTipTitle = "اضافة";
            btnEditEmp.Click += btnEditEmp_Click;
            // 
            // btnDeleteEmp
            // 
            btnDeleteEmp.Appearance.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteEmp.Appearance.Font = new Font("Cairo Medium", 10F);
            btnDeleteEmp.Appearance.Options.UseBackColor = true;
            btnDeleteEmp.Appearance.Options.UseFont = true;
            btnDeleteEmp.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnDeleteEmp.AppearanceDisabled.Options.UseFont = true;
            btnDeleteEmp.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnDeleteEmp.AppearanceHovered.Options.UseFont = true;
            btnDeleteEmp.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnDeleteEmp.AppearancePressed.Options.UseFont = true;
            btnDeleteEmp.Cursor = Cursors.Hand;
            btnDeleteEmp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDeleteEmp.ImageOptions.SvgImage");
            btnDeleteEmp.ImageOptions.SvgImageSize = new Size(25, 25);
            btnDeleteEmp.Location = new Point(155, 104);
            btnDeleteEmp.Name = "btnDeleteEmp";
            btnDeleteEmp.RightToLeft = RightToLeft.Yes;
            btnDeleteEmp.Size = new Size(137, 45);
            btnDeleteEmp.TabIndex = 18;
            btnDeleteEmp.Text = "حذف";
            btnDeleteEmp.ToolTipTitle = "اضافة";
            btnDeleteEmp.Click += btnDeleteEmp_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(60, 71, 151);
            panel1.Controls.Add(lblEmp);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(9, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 70);
            panel1.TabIndex = 17;
            // 
            // lblEmp
            // 
            lblEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Cairo Medium", 12F);
            lblEmp.ForeColor = Color.White;
            lblEmp.Location = new Point(1043, 23);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(156, 37);
            lblEmp.TabIndex = 1;
            lblEmp.Text = "قائمة الموظفين";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1216, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // EmployeeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DGListeEmployee);
            Controls.Add(btnPrintEmp);
            Controls.Add(btnAddEmp);
            Controls.Add(btnEditEmp);
            Controls.Add(btnDeleteEmp);
            Controls.Add(panel1);
            Name = "EmployeeUserControl";
            Size = new Size(1324, 727);
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl DGListeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrintEmp;
        private DevExpress.XtraEditors.SimpleButton btnAddEmp;
        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnEditEmp;
        private DevExpress.XtraEditors.SimpleButton btnDeleteEmp;
        private Panel panel1;
        private Label lblEmp;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}
