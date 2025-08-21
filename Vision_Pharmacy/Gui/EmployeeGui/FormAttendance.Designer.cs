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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblEmp = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            btnSaveAttend = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            btnPrintEmp = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            SuspendLayout();
            // 
            // DGListeEmployee
            // 
            DGListeEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeEmployee.Location = new Point(12, 208);
            DGListeEmployee.MainView = gridView2;
            DGListeEmployee.Name = "DGListeEmployee";
            DGListeEmployee.RightToLeft = RightToLeft.Yes;
            DGListeEmployee.Size = new Size(1241, 491);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.tasking_15578464;
            pictureBox1.Location = new Point(1164, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(60, 71, 151);
            panel1.Controls.Add(lblEmp);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 70);
            panel1.TabIndex = 25;
            // 
            // lblEmp
            // 
            lblEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Cairo Medium", 12F);
            lblEmp.ForeColor = Color.White;
            lblEmp.Location = new Point(856, 23);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(292, 37);
            lblEmp.TabIndex = 1;
            lblEmp.Text = "تسجيل الغيابات و حظور الموظفين";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1154, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // btnSaveAttend
            // 
            btnSaveAttend.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnSaveAttend.Appearance.Font = new Font("Cairo Medium", 10F);
            btnSaveAttend.Appearance.Options.UseBackColor = true;
            btnSaveAttend.Appearance.Options.UseFont = true;
            btnSaveAttend.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnSaveAttend.AppearanceDisabled.Options.UseFont = true;
            btnSaveAttend.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnSaveAttend.AppearanceHovered.Options.UseFont = true;
            btnSaveAttend.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnSaveAttend.AppearancePressed.Options.UseFont = true;
            btnSaveAttend.Cursor = Cursors.Hand;
            btnSaveAttend.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSaveAttend.ImageOptions.SvgImage");
            btnSaveAttend.ImageOptions.SvgImageSize = new Size(25, 25);
            btnSaveAttend.Location = new Point(567, 143);
            btnSaveAttend.Name = "btnSaveAttend";
            btnSaveAttend.RightToLeft = RightToLeft.Yes;
            btnSaveAttend.Size = new Size(161, 40);
            btnSaveAttend.TabIndex = 26;
            btnSaveAttend.Text = "حفظ";
            btnSaveAttend.ToolTipTitle = "اضافة";
            btnSaveAttend.Click += btnSaveAttend_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            labelControl2.Appearance.ForeColor = SystemColors.ControlDarkDark;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl2.Location = new Point(319, 105);
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
            labelControl1.Location = new Point(516, 105);
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
            comboBoxMonth.Location = new Point(181, 143);
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
            comboBoxYear.Location = new Point(371, 143);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(190, 40);
            comboBoxYear.TabIndex = 32;
            comboBoxYear.SelectedIndexChanged += comboBoxYear_SelectedIndexChanged;
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
            btnPrintEmp.Location = new Point(12, 143);
            btnPrintEmp.Name = "btnPrintEmp";
            btnPrintEmp.RightToLeft = RightToLeft.Yes;
            btnPrintEmp.Size = new Size(164, 40);
            btnPrintEmp.TabIndex = 33;
            btnPrintEmp.Text = "طباعة";
            btnPrintEmp.ToolTipTitle = "اضافة";
            btnPrintEmp.Click += btnPrintEmp_Click;
            // 
            // FormAttendance
            // 
            Controls.Add(btnPrintEmp);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(labelControl1);
            Controls.Add(labelControl2);
            Controls.Add(btnSaveAttend);
            Controls.Add(panel1);
            Controls.Add(DGListeEmployee);
            Name = "FormAttendance";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1271, 755);
            Load += FormAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.GridControl DGListeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblEmp;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnSaveAttend;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private DevExpress.XtraEditors.SimpleButton btnPrintEmp;
    }
}