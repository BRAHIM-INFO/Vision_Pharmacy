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
            pnlTop = new Panel();
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
            label7 = new Label();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(lblTitleExpired);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(4, 2, 4, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1393, 70);
            pnlTop.TabIndex = 28;
            // 
            // lblTitleExpired
            // 
            lblTitleExpired.AutoSize = true;
            lblTitleExpired.Dock = DockStyle.Right;
            lblTitleExpired.Font = new Font("Cairo Medium", 12F);
            lblTitleExpired.ForeColor = Color.White;
            lblTitleExpired.Location = new Point(1026, 0);
            lblTitleExpired.Margin = new Padding(4, 0, 4, 0);
            lblTitleExpired.Name = "lblTitleExpired";
            lblTitleExpired.Size = new Size(277, 37);
            lblTitleExpired.TabIndex = 1;
            lblTitleExpired.Text = "قائمة الأدوية المنتهية الصلاحية";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.Dock = DockStyle.Right;
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1303, 0);
            SeparatLat.Margin = new Padding(4, 2, 4, 2);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(10, 70);
            SeparatLat.TabIndex = 1;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Dock = DockStyle.Right;
            PicLaterale.Image = Properties.Resources.pill_bottle_15968729;
            PicLaterale.Location = new Point(1313, 0);
            PicLaterale.Margin = new Padding(4, 2, 4, 2);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 26;
            PicLaterale.TabStop = false;
            // 
            // DGListeMedication
            // 
            DGListeMedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeMedication.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListeMedication.Location = new Point(1, 124);
            DGListeMedication.MainView = gridView1;
            DGListeMedication.Margin = new Padding(4, 2, 4, 2);
            DGListeMedication.Name = "DGListeMedication";
            DGListeMedication.RightToLeft = RightToLeft.Yes;
            DGListeMedication.Size = new Size(1392, 579);
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
            gridView1.GridControl = DGListeMedication;
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
            btnPrint.Location = new Point(4, 74);
            btnPrint.Margin = new Padding(4, 2, 4, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(136, 46);
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
            labelExpired.Location = new Point(1348, 705);
            labelExpired.Margin = new Padding(4, 0, 4, 0);
            labelExpired.Name = "labelExpired";
            labelExpired.RightToLeft = RightToLeft.No;
            labelExpired.Size = new Size(21, 32);
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
            comboBoxExpiry.Location = new Point(1107, 83);
            comboBoxExpiry.Margin = new Padding(4, 2, 4, 2);
            comboBoxExpiry.Name = "comboBoxExpiry";
            comboBoxExpiry.RightToLeft = RightToLeft.Yes;
            comboBoxExpiry.Size = new Size(265, 37);
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
            dateTimeExpired.Location = new Point(846, 82);
            dateTimeExpired.Name = "dateTimeExpired";
            dateTimeExpired.Size = new Size(153, 30);
            dateTimeExpired.TabIndex = 123;
            dateTimeExpired.ValueChanged += dateTimeExpired_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Cairo Medium", 10F);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(1005, 88);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(95, 34);
            label7.TabIndex = 124;
            label7.Text = "تاريخ محدد";
            // 
            // ExpiredUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(dateTimeExpired);
            Controls.Add(comboBoxExpiry);
            Controls.Add(labelExpired);
            Controls.Add(btnPrint);
            Controls.Add(DGListeMedication);
            Controls.Add(pnlTop);
            Name = "ExpiredUserControl";
            Size = new Size(1393, 750);
            Load += ExpiredUserControl_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
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
        private Label label7;
    }
}
