namespace Vision_Pharmacy.Gui.MedicationGui
{
    partial class MedicationUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationUserControl));
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            PicLaterale = new PictureBox();
            pnlTop = new Panel();
            lblTitleMedicat = new Label();
            btnExcel = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            DGListeMedication = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            PicChange = new PictureBox();
            lblCounter = new Label();
            toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).BeginInit();
            SuspendLayout();
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.Dock = DockStyle.Right;
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1240, 0);
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
            PicLaterale.Location = new Point(1250, 0);
            PicLaterale.Margin = new Padding(4, 2, 4, 2);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 26;
            PicLaterale.TabStop = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(lblTitleMedicat);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(4, 2, 4, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1330, 70);
            pnlTop.TabIndex = 27;
            // 
            // lblTitleMedicat
            // 
            lblTitleMedicat.AutoSize = true;
            lblTitleMedicat.Dock = DockStyle.Right;
            lblTitleMedicat.Font = new Font("Cairo Medium", 12F);
            lblTitleMedicat.ForeColor = Color.White;
            lblTitleMedicat.Location = new Point(1112, 0);
            lblTitleMedicat.Margin = new Padding(4, 0, 4, 0);
            lblTitleMedicat.Name = "lblTitleMedicat";
            lblTitleMedicat.Size = new Size(128, 37);
            lblTitleMedicat.TabIndex = 1;
            lblTitleMedicat.Text = "قائمة الأدوية";
            // 
            // btnExcel
            // 
            btnExcel.Appearance.BackColor = Color.FromArgb(128, 255, 128);
            btnExcel.Appearance.Font = new Font("Cairo Medium", 10F);
            btnExcel.Appearance.Options.UseBackColor = true;
            btnExcel.Appearance.Options.UseFont = true;
            btnExcel.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnExcel.AppearanceDisabled.Options.UseFont = true;
            btnExcel.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnExcel.AppearanceHovered.Options.UseFont = true;
            btnExcel.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnExcel.AppearancePressed.Options.UseFont = true;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnExcel.ImageOptions.SvgImage");
            btnExcel.ImageOptions.SvgImageSize = new Size(25, 25);
            btnExcel.Location = new Point(146, 76);
            btnExcel.Margin = new Padding(4, 2, 4, 2);
            btnExcel.Name = "btnExcel";
            btnExcel.RightToLeft = RightToLeft.Yes;
            btnExcel.Size = new Size(136, 46);
            btnExcel.TabIndex = 33;
            btnExcel.Text = "تحميل قائمة";
            btnExcel.ToolTipTitle = "اضافة";
            btnExcel.Click += btnExcel_Click;
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
            btnPrint.Location = new Point(4, 76);
            btnPrint.Margin = new Padding(4, 2, 4, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(136, 46);
            btnPrint.TabIndex = 31;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrintMedic_Click;
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
            btnAdd.Location = new Point(289, 76);
            btnAdd.Margin = new Padding(4, 2, 4, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(136, 46);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            btnAdd.Click += btnAddMedic_Click;
            // 
            // DGListeMedication
            // 
            DGListeMedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeMedication.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListeMedication.Location = new Point(0, 127);
            DGListeMedication.MainView = gridView1;
            DGListeMedication.Margin = new Padding(4, 2, 4, 2);
            DGListeMedication.Name = "DGListeMedication";
            DGListeMedication.RightToLeft = RightToLeft.Yes;
            DGListeMedication.Size = new Size(1330, 633);
            DGListeMedication.TabIndex = 32;
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
            gridView1.RowCountChanged += gridView1_RowCountChanged;
            // 
            // PicChange
            // 
            PicChange.BackColor = Color.Transparent;
            PicChange.Cursor = Cursors.Hand;
            PicChange.Image = Properties.Resources.product;
            PicChange.Location = new Point(593, 432);
            PicChange.Margin = new Padding(4, 2, 4, 2);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(14, 10);
            PicChange.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChange.TabIndex = 117;
            PicChange.TabStop = false;
            // 
            // lblCounter
            // 
            lblCounter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            lblCounter.ForeColor = Color.Black;
            lblCounter.Location = new Point(1185, 90);
            lblCounter.Margin = new Padding(4, 0, 4, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.RightToLeft = RightToLeft.Yes;
            lblCounter.Size = new Size(25, 32);
            lblCounter.TabIndex = 120;
            lblCounter.Text = "0";
            // 
            // toastNotificationsManager1
            // 
            toastNotificationsManager1.ApplicationId = "b68012f4-4e35-4104-82c2-36b8508f0629";
            // 
            // MedicationUserControl
            // 
            Appearance.BackColor = Color.WhiteSmoke;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCounter);
            Controls.Add(btnExcel);
            Controls.Add(DGListeMedication);
            Controls.Add(pnlTop);
            Controls.Add(btnPrint);
            Controls.Add(PicChange);
            Controls.Add(btnAdd);
            Margin = new Padding(4, 2, 4, 2);
            Name = "MedicationUserControl";
            Size = new Size(1330, 761);
            Load += MedicationUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private PictureBox PicLaterale;
        private Panel pnlTop;
        private Label lblTitleMedicat;
        private DevExpress.XtraGrid.GridControl DGListeMedication;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private PictureBox PicChange;
        private Label lblCounter;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}
