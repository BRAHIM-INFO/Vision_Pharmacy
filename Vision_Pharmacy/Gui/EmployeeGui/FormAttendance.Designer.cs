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
            pnlTop = new Panel();
            lblTitleAttend = new Label();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            SuspendLayout();
            // 
            // DGListeEmployee
            // 
            DGListeEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeEmployee.Location = new Point(0, 122);
            DGListeEmployee.MainView = gridView2;
            DGListeEmployee.Name = "DGListeEmployee";
            DGListeEmployee.RightToLeft = RightToLeft.Yes;
            DGListeEmployee.Size = new Size(1271, 633);
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
            PicLaterale.Dock = DockStyle.Right;
            PicLaterale.Image = Properties.Resources.tasking_15578464;
            PicLaterale.Location = new Point(1191, 0);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 24;
            PicLaterale.TabStop = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(lblTitleAttend);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1271, 70);
            pnlTop.TabIndex = 25;
            // 
            // lblTitleAttend
            // 
            lblTitleAttend.AutoSize = true;
            lblTitleAttend.Dock = DockStyle.Right;
            lblTitleAttend.Font = new Font("Cairo Medium", 12F);
            lblTitleAttend.ForeColor = Color.White;
            lblTitleAttend.Location = new Point(889, 0);
            lblTitleAttend.Name = "lblTitleAttend";
            lblTitleAttend.Size = new Size(292, 37);
            lblTitleAttend.TabIndex = 1;
            lblTitleAttend.Text = "تسجيل الغيابات و حظور الموظفين";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.Dock = DockStyle.Right;
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1181, 0);
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
            btnSave.Location = new Point(611, 76);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(144, 40);
            btnSave.TabIndex = 26;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "اضافة";
            btnSave.Click += btnSaveAttend_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            labelControl2.Appearance.ForeColor = SystemColors.ControlDarkDark;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl2.Location = new Point(365, 79);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(46, 32);
            labelControl2.TabIndex = 29;
            labelControl2.Text = "الشهر";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            labelControl1.Appearance.ForeColor = SystemColors.ControlDarkDark;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.Location = new Point(558, 79);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(45, 32);
            labelControl1.TabIndex = 30;
            labelControl1.Text = "السنة";
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FlatStyle = FlatStyle.System;
            comboBoxMonth.Font = new Font("Cairo Medium", 10F);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(172, 76);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(184, 40);
            comboBoxMonth.TabIndex = 31;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FlatStyle = FlatStyle.System;
            comboBoxYear.Font = new Font("Cairo Medium", 10F);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(417, 76);
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
            btnPrint.Location = new Point(3, 76);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(164, 40);
            btnPrint.TabIndex = 33;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrintEmp_Click;
            // 
            // FormAttendance
            // 
            Controls.Add(btnPrint);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(labelControl1);
            Controls.Add(labelControl2);
            Controls.Add(btnSave);
            Controls.Add(pnlTop);
            Controls.Add(DGListeEmployee);
            Name = "FormAttendance";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1271, 755);
            Load += FormAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.GridControl DGListeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private PictureBox PicLaterale;
        private Panel pnlTop;
        private Label lblTitleAttend;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}