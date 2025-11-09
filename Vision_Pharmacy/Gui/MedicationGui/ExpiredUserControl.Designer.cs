namespace Vision_Pharmacy.Gui.MedicationGui
{
    partial class ExpiredUserControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredUserControl));
            lblTitleExpired = new Label();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            PicLaterale = new PictureBox();
            DGListeMedication = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            labelExpired = new Label();
            _timer = new System.Windows.Forms.Timer(components);
            comboBoxExpiry = new ComboBox();
            dateTimeExpired = new DateTimePicker();
            lblDate = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleExpired
            // 
            lblTitleExpired.AutoSize = true;
            lblTitleExpired.BackColor = Color.Transparent;
            lblTitleExpired.Font = new Font("Cairo Medium", 12F);
            lblTitleExpired.ForeColor = Color.Black;
            lblTitleExpired.Location = new Point(889, 0);
            lblTitleExpired.Name = "lblTitleExpired";
            lblTitleExpired.Size = new Size(218, 30);
            lblTitleExpired.TabIndex = 1;
            lblTitleExpired.Text = "قائمة الأدوية المنتهية الصلاحية";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 8;
            SeparatLat.Location = new Point(1113, 2);
            SeparatLat.Margin = new Padding(3, 2, 3, 2);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(9, 57);
            SeparatLat.TabIndex = 1;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Image = Properties.Resources.pill_bottle_15968729;
            PicLaterale.Location = new Point(1125, 0);
            PicLaterale.Margin = new Padding(0);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(69, 57);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 26;
            PicLaterale.TabStop = false;
            // 
            // DGListeMedication
            // 
            DGListeMedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeMedication.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            DGListeMedication.Location = new Point(1, 102);
            DGListeMedication.MainView = gridView1;
            DGListeMedication.Margin = new Padding(3, 2, 3, 2);
            DGListeMedication.Name = "DGListeMedication";
            DGListeMedication.Size = new Size(1193, 470);
            DGListeMedication.TabIndex = 33;
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
            btnPrint.Click += btnPrintMedic_Click;
            // 
            // labelExpired
            // 
            labelExpired.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelExpired.AutoSize = true;
            labelExpired.Font = new Font("Cairo Medium", 10F);
            labelExpired.ForeColor = Color.Teal;
            labelExpired.Location = new Point(1155, 573);
            labelExpired.Name = "labelExpired";
            labelExpired.RightToLeft = RightToLeft.No;
            labelExpired.Size = new Size(18, 26);
            labelExpired.TabIndex = 121;
            labelExpired.Text = "-";
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
            flowLayoutPanel1.Size = new Size(1194, 57);
            flowLayoutPanel1.TabIndex = 125;
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
            flowLayoutPanel2.Size = new Size(1194, 41);
            flowLayoutPanel2.TabIndex = 126;
            // 
            // ExpiredUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelExpired);
            Controls.Add(DGListeMedication);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpiredUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1194, 609);
            Load += ExpiredUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitleExpired;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private PictureBox PicLaterale;
        private DevExpress.XtraGrid.GridControl DGListeMedication;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private Label labelExpired;
        private System.Windows.Forms.Timer _timer;
        private ComboBox comboBoxExpiry;
        private DateTimePicker dateTimeExpired;
        private Label lblDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
