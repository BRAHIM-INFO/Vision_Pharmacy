namespace Vision_Pharmacy.Gui.EmployeeGui
{
    partial class FormPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayroll));
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            DGListeEmployee = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            PicLaterale = new PictureBox();
            lblTitlePay = new Label();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCalculatee = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnPrintFiche = new DevExpress.XtraEditors.SimpleButton();
            lblYear = new DevExpress.XtraEditors.LabelControl();
            lblMonths = new DevExpress.XtraEditors.LabelControl();
            topLabel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            topLabel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonth.Font = new Font("Cairo Medium", 10F);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(332, 5);
            comboBoxMonth.Margin = new Padding(5);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(116, 40);
            comboBoxMonth.TabIndex = 0;
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.Font = new Font("Cairo Medium", 10F);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(510, 5);
            comboBoxYear.Margin = new Padding(5);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(105, 40);
            comboBoxYear.TabIndex = 1;
            // 
            // DGListeEmployee
            // 
            DGListeEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeEmployee.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
            DGListeEmployee.Location = new Point(3, 126);
            DGListeEmployee.MainView = gridView1;
            DGListeEmployee.Margin = new Padding(3, 4, 3, 4);
            DGListeEmployee.Name = "DGListeEmployee";
            DGListeEmployee.Size = new Size(1384, 579);
            DGListeEmployee.TabIndex = 23;
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
            gridView1.DetailHeight = 437;
            gridView1.GridControl = DGListeEmployee;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 914;
            gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Image = Properties.Resources.hr_19008748;
            PicLaterale.Location = new Point(1304, 3);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 24;
            PicLaterale.TabStop = false;
            // 
            // lblTitlePay
            // 
            lblTitlePay.AutoSize = true;
            lblTitlePay.Font = new Font("Cairo Medium", 12F);
            lblTitlePay.ForeColor = Color.White;
            lblTitlePay.Location = new Point(1077, 0);
            lblTitlePay.Name = "lblTitlePay";
            lblTitlePay.Size = new Size(205, 37);
            lblTitlePay.TabIndex = 1;
            lblTitlePay.Text = "قائمة رواتب الموظفين";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1288, 3);
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
            btnSave.Location = new Point(824, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(140, 40);
            btnSave.TabIndex = 27;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "اضافة";
            btnSave.Click += btnSavePayroll_Click;
            // 
            // btnCalculatee
            // 
            btnCalculatee.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnCalculatee.Appearance.Font = new Font("Cairo Medium", 10F);
            btnCalculatee.Appearance.Options.UseBackColor = true;
            btnCalculatee.Appearance.Options.UseFont = true;
            btnCalculatee.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnCalculatee.AppearanceDisabled.Options.UseFont = true;
            btnCalculatee.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnCalculatee.AppearanceHovered.Options.UseFont = true;
            btnCalculatee.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnCalculatee.AppearancePressed.Options.UseFont = true;
            btnCalculatee.Cursor = Cursors.Hand;
            btnCalculatee.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCalculatee.ImageOptions.SvgImage");
            btnCalculatee.ImageOptions.SvgImageSize = new Size(25, 25);
            btnCalculatee.Location = new Point(674, 3);
            btnCalculatee.Name = "btnCalculatee";
            btnCalculatee.RightToLeft = RightToLeft.Yes;
            btnCalculatee.Size = new Size(144, 40);
            btnCalculatee.TabIndex = 28;
            btnCalculatee.Text = "حساب الرواتب";
            btnCalculatee.ToolTipTitle = "اضافة";
            btnCalculatee.Click += btnCalculatee_Click;
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
            btnPrint.Location = new Point(3, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(151, 40);
            btnPrint.TabIndex = 34;
            btnPrint.Text = "طباعة القائمة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrintPayroll_Click;
            // 
            // btnPrintFiche
            // 
            btnPrintFiche.Appearance.BackColor = Color.Gray;
            btnPrintFiche.Appearance.Font = new Font("Cairo Medium", 10F);
            btnPrintFiche.Appearance.Options.UseBackColor = true;
            btnPrintFiche.Appearance.Options.UseFont = true;
            btnPrintFiche.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnPrintFiche.AppearanceDisabled.Options.UseFont = true;
            btnPrintFiche.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnPrintFiche.AppearanceHovered.Options.UseFont = true;
            btnPrintFiche.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnPrintFiche.AppearancePressed.Options.UseFont = true;
            btnPrintFiche.Cursor = Cursors.Hand;
            btnPrintFiche.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrintFiche.ImageOptions.SvgImage");
            btnPrintFiche.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrintFiche.Location = new Point(160, 3);
            btnPrintFiche.Name = "btnPrintFiche";
            btnPrintFiche.RightToLeft = RightToLeft.Yes;
            btnPrintFiche.Size = new Size(164, 40);
            btnPrintFiche.TabIndex = 35;
            btnPrintFiche.Text = "طباعة كشف راتب";
            btnPrintFiche.ToolTipTitle = "اضافة";
            // 
            // lblYear
            // 
            lblYear.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            lblYear.Appearance.ForeColor = SystemColors.ControlDarkDark;
            lblYear.Appearance.Options.UseFont = true;
            lblYear.Appearance.Options.UseForeColor = true;
            lblYear.Appearance.Options.UseTextOptions = true;
            lblYear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblYear.Location = new Point(623, 3);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(45, 32);
            lblYear.TabIndex = 37;
            lblYear.Text = "السنة";
            // 
            // lblMonths
            // 
            lblMonths.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            lblMonths.Appearance.ForeColor = SystemColors.ControlDarkDark;
            lblMonths.Appearance.Options.UseFont = true;
            lblMonths.Appearance.Options.UseForeColor = true;
            lblMonths.Appearance.Options.UseTextOptions = true;
            lblMonths.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblMonths.Location = new Point(456, 3);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(46, 32);
            lblMonths.TabIndex = 36;
            lblMonths.Text = "الشهر";
            // 
            // topLabel
            // 
            topLabel.BackColor = Color.FromArgb(60, 71, 151);
            topLabel.Controls.Add(PicLaterale);
            topLabel.Controls.Add(SeparatLat);
            topLabel.Controls.Add(lblTitlePay);
            topLabel.Dock = DockStyle.Top;
            topLabel.Location = new Point(0, 0);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(1387, 76);
            topLabel.TabIndex = 38;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnPrint);
            flowLayoutPanel1.Controls.Add(btnPrintFiche);
            flowLayoutPanel1.Controls.Add(comboBoxMonth);
            flowLayoutPanel1.Controls.Add(lblMonths);
            flowLayoutPanel1.Controls.Add(comboBoxYear);
            flowLayoutPanel1.Controls.Add(lblYear);
            flowLayoutPanel1.Controls.Add(btnCalculatee);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.No;
            flowLayoutPanel1.Size = new Size(1387, 46);
            flowLayoutPanel1.TabIndex = 39;
            // 
            // FormPayroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(topLabel);
            Controls.Add(DGListeEmployee);
            Margin = new Padding(5);
            Name = "FormPayroll";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1387, 709);
            Load += FormPayroll_Load;
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            topLabel.ResumeLayout(false);
            topLabel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        /// <summary>
        /// متغير خاص للمكونات
        /// </summary>

        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private DevExpress.XtraGrid.GridControl DGListeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private PictureBox PicLaterale;
        private Label lblTitlePay;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCalculatee;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnPrintFiche;
        private DevExpress.XtraEditors.LabelControl lblYear;
        private DevExpress.XtraEditors.LabelControl lblMonths;
        private FlowLayoutPanel topLabel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}