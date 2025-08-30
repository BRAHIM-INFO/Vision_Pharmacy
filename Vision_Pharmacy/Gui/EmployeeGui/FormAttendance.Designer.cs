namespace Vision_Pharmacy.Gui.EmployeeGui
{
    partial class FormAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttendance));
            DGListeEmployee = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            PicLaterale = new PictureBox();
            lblTitleAttend = new Label();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            MonthDu = new DevExpress.XtraEditors.LabelControl();
            YearDu = new DevExpress.XtraEditors.LabelControl();
            txtMonthDu = new ComboBox();
            comboBoxYear = new ComboBox();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            pnlTop = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            pnlTop.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGListeEmployee
            // 
            DGListeEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeEmployee.Location = new Point(0, 140);
            DGListeEmployee.MainView = gridView2;
            DGListeEmployee.Name = "DGListeEmployee";
            DGListeEmployee.Size = new Size(1271, 615);
            DGListeEmployee.TabIndex = 23;
            DGListeEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Appearance.CustomizationFormHint.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.CustomizationFormHint.Options.UseFont = true;
            gridView2.Appearance.DetailTip.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.DetailTip.Options.UseFont = true;
            gridView2.Appearance.EvenRow.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.EvenRow.Options.UseFont = true;
            gridView2.Appearance.FilterPanel.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.FilterPanel.Options.UseFont = true;
            gridView2.Appearance.FocusedCell.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.FocusedCell.Options.UseFont = true;
            gridView2.Appearance.FocusedRow.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.FocusedRow.Options.UseFont = true;
            gridView2.Appearance.FooterPanel.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.FooterPanel.Options.UseFont = true;
            gridView2.Appearance.GroupFooter.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.GroupFooter.Options.UseFont = true;
            gridView2.Appearance.GroupPanel.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.GroupPanel.Options.UseFont = true;
            gridView2.Appearance.GroupRow.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.GroupRow.Options.UseFont = true;
            gridView2.Appearance.HeaderPanel.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            gridView2.Appearance.HideSelectionRow.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.HideSelectionRow.Options.UseFont = true;
            gridView2.Appearance.HotTrackedRow.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.HotTrackedRow.Options.UseFont = true;
            gridView2.Appearance.NoSearchResults.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.NoSearchResults.Options.UseFont = true;
            gridView2.Appearance.OddRow.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.OddRow.Options.UseFont = true;
            gridView2.Appearance.Preview.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.Preview.Options.UseFont = true;
            gridView2.Appearance.Row.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.Row.Options.UseFont = true;
            gridView2.Appearance.SelectedRow.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.SelectedRow.Options.UseFont = true;
            gridView2.Appearance.TopNewRow.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.TopNewRow.Options.UseFont = true;
            gridView2.Appearance.ViewCaption.Font = new Font("Cairo Medium", 10F);
            gridView2.Appearance.ViewCaption.Options.UseFont = true;
            gridView2.GridControl = DGListeEmployee;
            gridView2.Name = "gridView2";
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Transparent;
            PicLaterale.Image = Properties.Resources.tasking_15578464;
            PicLaterale.Location = new Point(1188, 3);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 24;
            PicLaterale.TabStop = false;
            // 
            // lblTitleAttend
            // 
            lblTitleAttend.AutoSize = true;
            lblTitleAttend.Font = new Font("Cairo Medium", 12F);
            lblTitleAttend.ForeColor = Color.White;
            lblTitleAttend.Location = new Point(874, 0);
            lblTitleAttend.Name = "lblTitleAttend";
            lblTitleAttend.Size = new Size(292, 37);
            lblTitleAttend.TabIndex = 1;
            lblTitleAttend.Text = "تسجيل الغيابات و حظور الموظفين";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1172, 3);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(10, 70);
            SeparatLat.TabIndex = 1;
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
            btnSave.ImageOptions.SvgImageSize = new Size(25, 25);
            btnSave.Location = new Point(612, 8);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(144, 40);
            btnSave.TabIndex = 26;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "اضافة";
            btnSave.Click += btnSaveAttend_Click;
            // 
            // MonthDu
            // 
            MonthDu.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            MonthDu.Appearance.ForeColor = SystemColors.ControlDarkDark;
            MonthDu.Appearance.Options.UseFont = true;
            MonthDu.Appearance.Options.UseForeColor = true;
            MonthDu.Appearance.Options.UseTextOptions = true;
            MonthDu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            MonthDu.Location = new Point(368, 8);
            MonthDu.Name = "MonthDu";
            MonthDu.Size = new Size(46, 32);
            MonthDu.TabIndex = 29;
            MonthDu.Text = "الشهر";
            // 
            // YearDu
            // 
            YearDu.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            YearDu.Appearance.ForeColor = SystemColors.ControlDarkDark;
            YearDu.Appearance.Options.UseFont = true;
            YearDu.Appearance.Options.UseForeColor = true;
            YearDu.Appearance.Options.UseTextOptions = true;
            YearDu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            YearDu.Location = new Point(561, 8);
            YearDu.Name = "YearDu";
            YearDu.Size = new Size(45, 32);
            YearDu.TabIndex = 30;
            YearDu.Text = "السنة";
            // 
            // txtMonthDu
            // 
            txtMonthDu.FlatStyle = FlatStyle.System;
            txtMonthDu.Font = new Font("Cairo Medium", 10F);
            txtMonthDu.FormattingEnabled = true;
            txtMonthDu.Location = new Point(178, 8);
            txtMonthDu.Name = "txtMonthDu";
            txtMonthDu.Size = new Size(184, 40);
            txtMonthDu.TabIndex = 31;
            txtMonthDu.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FlatStyle = FlatStyle.System;
            comboBoxYear.Font = new Font("Cairo Medium", 10F);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(420, 8);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(135, 40);
            comboBoxYear.TabIndex = 32;
            comboBoxYear.SelectedIndexChanged += comboBoxYear_SelectedIndexChanged;
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
            btnPrint.Location = new Point(8, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(164, 40);
            btnPrint.TabIndex = 33;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrintEmp_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(lblTitleAttend);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1271, 76);
            pnlTop.TabIndex = 34;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnPrint);
            flowLayoutPanel1.Controls.Add(txtMonthDu);
            flowLayoutPanel1.Controls.Add(MonthDu);
            flowLayoutPanel1.Controls.Add(comboBoxYear);
            flowLayoutPanel1.Controls.Add(YearDu);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 76);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.RightToLeft = RightToLeft.No;
            flowLayoutPanel1.Size = new Size(1271, 56);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // FormAttendance
            // 
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlTop);
            Controls.Add(DGListeEmployee);
            Name = "FormAttendance";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1271, 755);
            Load += FormAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraGrid.GridControl DGListeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private PictureBox PicLaterale;
        private Label lblTitleAttend;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl MonthDu;
        private DevExpress.XtraEditors.LabelControl YearDu;
        private ComboBox txtMonthDu;
        private ComboBox comboBoxYear;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private FlowLayoutPanel pnlTop;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}