namespace Vision_Pharmacy.Gui.RepportsGui.RptStock
{
    partial class FrmStockExpiredReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockExpiredReport));
            flowLayoutPanel1 = new FlowLayoutPanel();
            PicLaterale = new PictureBox();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            lblTitleExpired = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            dateTimeExpired = new DateTimePicker();
            lblDate = new Label();
            comboBoxExpiry = new ComboBox();
            DGListeMedication = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelExpired = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(PicLaterale);
            flowLayoutPanel1.Controls.Add(SeparatLat);
            flowLayoutPanel1.Controls.Add(lblTitleExpired);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1175, 57);
            flowLayoutPanel1.TabIndex = 126;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Image = Properties.Resources.pill_bottle_15968729;
            PicLaterale.Location = new Point(1106, 0);
            PicLaterale.Margin = new Padding(0);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(69, 57);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 26;
            PicLaterale.TabStop = false;
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 8;
            SeparatLat.Location = new Point(1094, 2);
            SeparatLat.Margin = new Padding(3, 2, 3, 2);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(9, 57);
            SeparatLat.TabIndex = 1;
            // 
            // lblTitleExpired
            // 
            lblTitleExpired.AutoSize = true;
            lblTitleExpired.BackColor = Color.Transparent;
            lblTitleExpired.Font = new Font("Cairo Medium", 12F);
            lblTitleExpired.ForeColor = Color.Black;
            lblTitleExpired.Location = new Point(880, 0);
            lblTitleExpired.Name = "lblTitleExpired";
            lblTitleExpired.Size = new Size(208, 30);
            lblTitleExpired.TabIndex = 1;
            lblTitleExpired.Text = "تقرير الأدوية المنتهية الصلاحية";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnPrint);
            flowLayoutPanel2.Controls.Add(dateTimeExpired);
            flowLayoutPanel2.Controls.Add(lblDate);
            flowLayoutPanel2.Controls.Add(comboBoxExpiry);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 57);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.RightToLeft = RightToLeft.No;
            flowLayoutPanel2.Size = new Size(1175, 41);
            flowLayoutPanel2.TabIndex = 127;
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
            btnPrint.Location = new Point(3, 2);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(117, 37);
            btnPrint.TabIndex = 34;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrint_Click;
            // 
            // dateTimeExpired
            // 
            dateTimeExpired.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimeExpired.Font = new Font("Tahoma", 11F);
            dateTimeExpired.Format = DateTimePickerFormat.Short;
            dateTimeExpired.Location = new Point(126, 2);
            dateTimeExpired.Margin = new Padding(3, 2, 3, 2);
            dateTimeExpired.Name = "dateTimeExpired";
            dateTimeExpired.Size = new Size(132, 25);
            dateTimeExpired.TabIndex = 123;
            dateTimeExpired.ValueChanged += dateTimeExpired_ValueChanged;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.Font = new Font("Cairo Medium", 10F);
            lblDate.ForeColor = Color.FromArgb(64, 64, 64);
            lblDate.Location = new Point(264, 0);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.Yes;
            lblDate.Size = new Size(81, 28);
            lblDate.TabIndex = 124;
            lblDate.Text = "تاريخ محدد";
            // 
            // comboBoxExpiry
            // 
            comboBoxExpiry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxExpiry.BackColor = Color.White;
            comboBoxExpiry.DisplayMember = "اخر 30 يوم";
            comboBoxExpiry.FlatStyle = FlatStyle.System;
            comboBoxExpiry.Font = new Font("Cairo Medium", 9F);
            comboBoxExpiry.FormattingEnabled = true;
            comboBoxExpiry.Items.AddRange(new object[] { "اخر 30 يوم", "الشهر الماضي", "الشهر الحالي", "العام الماضي", "العام الحالي", "فترة محددة" });
            comboBoxExpiry.Location = new Point(351, 2);
            comboBoxExpiry.Margin = new Padding(3, 2, 3, 2);
            comboBoxExpiry.Name = "comboBoxExpiry";
            comboBoxExpiry.RightToLeft = RightToLeft.Yes;
            comboBoxExpiry.Size = new Size(228, 31);
            comboBoxExpiry.TabIndex = 122;
            comboBoxExpiry.Text = "اخر 30 يوم";
            comboBoxExpiry.ValueMember = "اخر 30 يوم";
            comboBoxExpiry.SelectedIndexChanged += comboBoxExpiry_SelectedIndexChanged;
            // 
            // DGListeMedication
            // 
            DGListeMedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeMedication.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            DGListeMedication.Location = new Point(0, 102);
            DGListeMedication.MainView = gridView1;
            DGListeMedication.Margin = new Padding(3, 2, 3, 2);
            DGListeMedication.Name = "DGListeMedication";
            DGListeMedication.Size = new Size(1175, 507);
            DGListeMedication.TabIndex = 128;
            DGListeMedication.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
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
            gridView1.DetailHeight = 284;
            gridView1.GridControl = DGListeMedication;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // labelExpired
            // 
            labelExpired.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelExpired.AutoSize = true;
            labelExpired.Font = new Font("Cairo Medium", 10F);
            labelExpired.ForeColor = Color.Teal;
            labelExpired.Location = new Point(12, 614);
            labelExpired.Name = "labelExpired";
            labelExpired.RightToLeft = RightToLeft.No;
            labelExpired.Size = new Size(18, 26);
            labelExpired.TabIndex = 129;
            labelExpired.Text = "-";
            // 
            // FrmStockExpiredReport
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 646);
            Controls.Add(labelExpired);
            Controls.Add(DGListeMedication);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmStockExpiredReport";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تقرير المخزون الحالي";
            Load += FrmStockExpiredReport_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox PicLaterale;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private Label lblTitleExpired;
        private FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DateTimePicker dateTimeExpired;
        private Label lblDate;
        private ComboBox comboBoxExpiry;
        private DevExpress.XtraGrid.GridControl DGListeMedication;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label labelExpired;
    }
}