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
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            PicLaterale = new PictureBox();
            btnEditEmp = new DevExpress.XtraEditors.SimpleButton();
            btnDeleteEmp = new DevExpress.XtraEditors.SimpleButton();
            pnlTop = new Panel();
            lblTitleEmp = new Label();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            SuspendLayout();
            // 
            // DGListeEmployee
            // 
            DGListeEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeEmployee.Location = new Point(0, 127);
            DGListeEmployee.MainView = gridView1;
            DGListeEmployee.Name = "DGListeEmployee";
            DGListeEmployee.RightToLeft = RightToLeft.Yes;
            DGListeEmployee.Size = new Size(1324, 600);
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
            // btnPrint
            // 
            btnPrint.Appearance.BackColor = Color.Gray;
            btnPrint.Appearance.Font = new Font("Cairo Medium", 10F);
            btnPrint.Appearance.Options.UseBackColor = true;
            btnPrint.Appearance.Options.UseFont = true;
            btnPrint.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnPrint.AppearanceDisabled.Options.UseFont = true;
            btnPrint.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnPrint.AppearanceHovered.Options.UseFont = true;
            btnPrint.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnPrint.AppearancePressed.Options.UseFont = true;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrint.ImageOptions.SvgImage");
            btnPrint.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrint.Location = new Point(10, 76);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(137, 45);
            btnPrint.TabIndex = 21;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrintEmp_Click;
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnAdd.Appearance.Font = new Font("Cairo Medium", 10F);
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnAdd.AppearanceDisabled.Options.UseFont = true;
            btnAdd.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnAdd.AppearanceHovered.Options.UseFont = true;
            btnAdd.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnAdd.AppearancePressed.Options.UseFont = true;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAdd.ImageOptions.SvgImage");
            btnAdd.ImageOptions.SvgImageSize = new Size(25, 25);
            btnAdd.Location = new Point(439, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(137, 45);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            btnAdd.Click += btnAddEmp_Click;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Dock = DockStyle.Right;
            PicLaterale.Image = Properties.Resources.hr_19008748;
            PicLaterale.Location = new Point(1244, 0);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 16;
            PicLaterale.TabStop = false;
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
            btnEditEmp.Location = new Point(296, 76);
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
            btnDeleteEmp.Location = new Point(153, 76);
            btnDeleteEmp.Name = "btnDeleteEmp";
            btnDeleteEmp.RightToLeft = RightToLeft.Yes;
            btnDeleteEmp.Size = new Size(137, 45);
            btnDeleteEmp.TabIndex = 18;
            btnDeleteEmp.Text = "حذف";
            btnDeleteEmp.ToolTipTitle = "اضافة";
            btnDeleteEmp.Click += btnDeleteEmp_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(lblTitleEmp);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1324, 70);
            pnlTop.TabIndex = 17;
            // 
            // lblTitleEmp
            // 
            lblTitleEmp.AutoSize = true;
            lblTitleEmp.Dock = DockStyle.Right;
            lblTitleEmp.Font = new Font("Cairo Medium", 12F);
            lblTitleEmp.ForeColor = Color.White;
            lblTitleEmp.Location = new Point(1078, 0);
            lblTitleEmp.Name = "lblTitleEmp";
            lblTitleEmp.Size = new Size(156, 37);
            lblTitleEmp.TabIndex = 1;
            lblTitleEmp.Text = "قائمة الموظفين";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.Dock = DockStyle.Right;
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1234, 0);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(10, 70);
            SeparatLat.TabIndex = 1;
            // 
            // EmployeeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DGListeEmployee);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(btnEditEmp);
            Controls.Add(btnDeleteEmp);
            Controls.Add(pnlTop);
            Name = "EmployeeUserControl";
            Size = new Size(1324, 727);
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl DGListeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private PictureBox PicLaterale;
        private DevExpress.XtraEditors.SimpleButton btnEditEmp;
        private DevExpress.XtraEditors.SimpleButton btnDeleteEmp;
        private Panel pnlTop;
        private Label lblTitleEmp;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
    }
}
