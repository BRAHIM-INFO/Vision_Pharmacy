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
            btnExportPDF = new Button();
            DGListeEmployee = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblEmp = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            btnSavePayroll = new DevExpress.XtraEditors.SimpleButton();
            btnCalculatee = new DevExpress.XtraEditors.SimpleButton();
            btnPrintPayroll = new DevExpress.XtraEditors.SimpleButton();
            btnPrintFiche = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonth.Font = new Font("Cairo Medium", 10F);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(357, 127);
            comboBoxMonth.Margin = new Padding(5);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(132, 40);
            comboBoxMonth.TabIndex = 0;
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.Font = new Font("Cairo Medium", 10F);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(499, 127);
            comboBoxYear.Margin = new Padding(5);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(132, 40);
            comboBoxYear.TabIndex = 1;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(1215, 103);
            btnExportPDF.Margin = new Padding(5);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(120, 39);
            btnExportPDF.TabIndex = 4;
            btnExportPDF.Text = "تصدير PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // DGListeEmployee
            // 
            DGListeEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeEmployee.EmbeddedNavigator.Margin = new Padding(3, 4, 3, 4);
            DGListeEmployee.Location = new Point(15, 177);
            DGListeEmployee.MainView = gridView1;
            DGListeEmployee.Margin = new Padding(3, 4, 3, 4);
            DGListeEmployee.Name = "DGListeEmployee";
            DGListeEmployee.RightToLeft = RightToLeft.Yes;
            DGListeEmployee.Size = new Size(1355, 513);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.hr_19008748;
            pictureBox1.Location = new Point(1275, 0);
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
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1355, 70);
            panel1.TabIndex = 25;
            // 
            // lblEmp
            // 
            lblEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Cairo Medium", 12F);
            lblEmp.ForeColor = Color.White;
            lblEmp.Location = new Point(1049, 22);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(205, 37);
            lblEmp.TabIndex = 1;
            lblEmp.Text = "قائمة رواتب الموظفين";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1265, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // btnSavePayroll
            // 
            btnSavePayroll.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnSavePayroll.Appearance.Font = new Font("Cairo Medium", 10F);
            btnSavePayroll.Appearance.Options.UseBackColor = true;
            btnSavePayroll.Appearance.Options.UseFont = true;
            btnSavePayroll.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnSavePayroll.AppearanceDisabled.Options.UseFont = true;
            btnSavePayroll.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnSavePayroll.AppearanceHovered.Options.UseFont = true;
            btnSavePayroll.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnSavePayroll.AppearancePressed.Options.UseFont = true;
            btnSavePayroll.Cursor = Cursors.Hand;
            btnSavePayroll.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSavePayroll.ImageOptions.SvgImage");
            btnSavePayroll.ImageOptions.SvgImageSize = new Size(25, 25);
            btnSavePayroll.Location = new Point(806, 127);
            btnSavePayroll.Name = "btnSavePayroll";
            btnSavePayroll.RightToLeft = RightToLeft.Yes;
            btnSavePayroll.Size = new Size(152, 40);
            btnSavePayroll.TabIndex = 27;
            btnSavePayroll.Text = "حفظ";
            btnSavePayroll.ToolTipTitle = "اضافة";
            btnSavePayroll.Click += btnSavePayroll_Click;
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
            btnCalculatee.Location = new Point(639, 127);
            btnCalculatee.Name = "btnCalculatee";
            btnCalculatee.RightToLeft = RightToLeft.Yes;
            btnCalculatee.Size = new Size(161, 40);
            btnCalculatee.TabIndex = 28;
            btnCalculatee.Text = "حساب الرواتب";
            btnCalculatee.ToolTipTitle = "اضافة";
            btnCalculatee.Click += btnCalculatee_Click;
            // 
            // btnPrintPayroll
            // 
            btnPrintPayroll.Appearance.BackColor = Color.Gray;
            btnPrintPayroll.Appearance.Font = new Font("Cairo Medium", 10F);
            btnPrintPayroll.Appearance.Options.UseBackColor = true;
            btnPrintPayroll.Appearance.Options.UseFont = true;
            btnPrintPayroll.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnPrintPayroll.AppearanceDisabled.Options.UseFont = true;
            btnPrintPayroll.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnPrintPayroll.AppearanceHovered.Options.UseFont = true;
            btnPrintPayroll.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnPrintPayroll.AppearancePressed.Options.UseFont = true;
            btnPrintPayroll.Cursor = Cursors.Hand;
            btnPrintPayroll.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrintPayroll.ImageOptions.SvgImage");
            btnPrintPayroll.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrintPayroll.Location = new Point(15, 127);
            btnPrintPayroll.Name = "btnPrintPayroll";
            btnPrintPayroll.RightToLeft = RightToLeft.Yes;
            btnPrintPayroll.Size = new Size(164, 40);
            btnPrintPayroll.TabIndex = 34;
            btnPrintPayroll.Text = "طباعة القائمة";
            btnPrintPayroll.ToolTipTitle = "اضافة";
            btnPrintPayroll.Click += btnPrintPayroll_Click;
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
            btnPrintFiche.Location = new Point(185, 127);
            btnPrintFiche.Name = "btnPrintFiche";
            btnPrintFiche.RightToLeft = RightToLeft.Yes;
            btnPrintFiche.Size = new Size(164, 40);
            btnPrintFiche.TabIndex = 35;
            btnPrintFiche.Text = "طباعة كشف راتب";
            btnPrintFiche.ToolTipTitle = "اضافة";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            labelControl1.Appearance.ForeColor = SystemColors.ControlDarkDark;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.Location = new Point(586, 99);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(45, 32);
            labelControl1.TabIndex = 37;
            labelControl1.Text = "السنة";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            labelControl2.Appearance.ForeColor = SystemColors.ControlDarkDark;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl2.Location = new Point(443, 99);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(46, 32);
            labelControl2.TabIndex = 36;
            labelControl2.Text = "الشهر";
            // 
            // FormPayroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrintFiche);
            Controls.Add(btnPrintPayroll);
            Controls.Add(btnCalculatee);
            Controls.Add(btnSavePayroll);
            Controls.Add(panel1);
            Controls.Add(DGListeEmployee);
            Controls.Add(btnExportPDF);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(labelControl1);
            Controls.Add(labelControl2);
            Margin = new Padding(5);
            Name = "FormPayroll";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1387, 709);
            Load += FormPayroll_Load;
            ((System.ComponentModel.ISupportInitialize)DGListeEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        /// <summary>
        /// متغير خاص للمكونات
        /// </summary>

        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Button btnExportPDF;
        private DevExpress.XtraGrid.GridControl DGListeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblEmp;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnSavePayroll;
        private DevExpress.XtraEditors.SimpleButton btnCalculatee;
        private DevExpress.XtraEditors.SimpleButton btnPrintPayroll;
        private DevExpress.XtraEditors.SimpleButton btnPrintFiche;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}