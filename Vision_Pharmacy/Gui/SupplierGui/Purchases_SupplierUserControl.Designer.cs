namespace Vision_Pharmacy.Gui.SupplierGui
{
    partial class Purchases_SupplierUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchases_SupplierUserControl));
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            DGListeSupplier = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            lblDateDu = new Label();
            DateDu = new DevExpress.XtraEditors.DateEdit();
            lblDateAu = new Label();
            DateAu = new DevExpress.XtraEditors.DateEdit();
            txtSupplier = new ComboBox();
            lblSupplier = new Label();
            pnlTop = new FlowLayoutPanel();
            PicLaterale = new PictureBox();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            lblSup = new Label();
            pnlSet = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DGListeSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateDu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateDu.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateAu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateAu.Properties.CalendarTimeProperties).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            pnlSet.SuspendLayout();
            SuspendLayout();
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
            btnPrint.Location = new Point(35, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(261, 45);
            btnPrint.TabIndex = 15;
            btnPrint.Text = "طباعة قائمة المشتريات";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrintSup_Click;
            // 
            // DGListeSupplier
            // 
            DGListeSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeSupplier.Location = new Point(3, 142);
            DGListeSupplier.MainView = gridView1;
            DGListeSupplier.Name = "DGListeSupplier";
            DGListeSupplier.Size = new Size(1298, 623);
            DGListeSupplier.TabIndex = 16;
            DGListeSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
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
            gridView1.GridControl = DGListeSupplier;
            gridView1.Name = "gridView1";
            // 
            // lblDateDu
            // 
            lblDateDu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateDu.AutoSize = true;
            lblDateDu.BackColor = Color.Transparent;
            lblDateDu.Font = new Font("Cairo Medium", 9F);
            lblDateDu.Location = new Point(871, 0);
            lblDateDu.Margin = new Padding(4, 0, 4, 0);
            lblDateDu.Name = "lblDateDu";
            lblDateDu.RightToLeft = RightToLeft.Yes;
            lblDateDu.Size = new Size(80, 29);
            lblDateDu.TabIndex = 117;
            lblDateDu.Text = "الفترة بين : ";
            // 
            // DateDu
            // 
            DateDu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateDu.EditValue = null;
            DateDu.Location = new Point(959, 2);
            DateDu.Margin = new Padding(4, 2, 4, 2);
            DateDu.Name = "DateDu";
            DateDu.Properties.Appearance.BackColor = Color.White;
            DateDu.Properties.Appearance.Font = new Font("Tahoma", 12F);
            DateDu.Properties.Appearance.Options.UseBackColor = true;
            DateDu.Properties.Appearance.Options.UseFont = true;
            DateDu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateDu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateDu.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            DateDu.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            DateDu.Size = new Size(246, 30);
            DateDu.TabIndex = 116;
            // 
            // lblDateAu
            // 
            lblDateAu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateAu.AutoSize = true;
            lblDateAu.BackColor = Color.Transparent;
            lblDateAu.Font = new Font("Cairo Medium", 9F);
            lblDateAu.Location = new Point(574, 0);
            lblDateAu.Margin = new Padding(4, 0, 4, 0);
            lblDateAu.Name = "lblDateAu";
            lblDateAu.RightToLeft = RightToLeft.Yes;
            lblDateAu.Size = new Size(35, 29);
            lblDateAu.TabIndex = 119;
            lblDateAu.Text = "الى ";
            // 
            // DateAu
            // 
            DateAu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateAu.EditValue = null;
            DateAu.Location = new Point(617, 2);
            DateAu.Margin = new Padding(4, 2, 4, 2);
            DateAu.Name = "DateAu";
            DateAu.Properties.Appearance.BackColor = Color.White;
            DateAu.Properties.Appearance.Font = new Font("Tahoma", 12F);
            DateAu.Properties.Appearance.Options.UseBackColor = true;
            DateAu.Properties.Appearance.Options.UseFont = true;
            DateAu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateAu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateAu.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            DateAu.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            DateAu.Size = new Size(246, 30);
            DateAu.TabIndex = 118;
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplier.BackColor = Color.White;
            txtSupplier.FlatStyle = FlatStyle.System;
            txtSupplier.Font = new Font("Cairo Medium", 10F);
            txtSupplier.FormattingEnabled = true;
            txtSupplier.Location = new Point(303, 2);
            txtSupplier.Margin = new Padding(4, 2, 4, 2);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(263, 40);
            txtSupplier.TabIndex = 120;
            txtSupplier.SelectedValueChanged += txtSupplier_SelectedValueChanged;
            // 
            // lblSupplier
            // 
            lblSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplier.AutoSize = true;
            lblSupplier.BackColor = Color.Transparent;
            lblSupplier.Font = new Font("Cairo Medium", 9F);
            lblSupplier.Location = new Point(1213, 0);
            lblSupplier.Margin = new Padding(4, 0, 4, 0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(81, 29);
            lblSupplier.TabIndex = 121;
            lblSupplier.Text = "اسم المورد";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(lblSup);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1298, 77);
            pnlTop.TabIndex = 122;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Image = Properties.Resources.shopping_basket_15712813;
            PicLaterale.Location = new Point(1215, 3);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 10;
            PicLaterale.TabStop = false;
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1199, 3);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(10, 70);
            SeparatLat.TabIndex = 11;
            // 
            // lblSup
            // 
            lblSup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSup.AutoSize = true;
            lblSup.Font = new Font("Cairo Medium", 12F);
            lblSup.ForeColor = Color.White;
            lblSup.Location = new Point(930, 0);
            lblSup.Name = "lblSup";
            lblSup.Size = new Size(263, 37);
            lblSup.TabIndex = 12;
            lblSup.Text = "قائمة المشتريات من الموردين";
            // 
            // pnlSet
            // 
            pnlSet.Controls.Add(lblSupplier);
            pnlSet.Controls.Add(DateDu);
            pnlSet.Controls.Add(lblDateDu);
            pnlSet.Controls.Add(DateAu);
            pnlSet.Controls.Add(lblDateAu);
            pnlSet.Controls.Add(txtSupplier);
            pnlSet.Controls.Add(btnPrint);
            pnlSet.Dock = DockStyle.Top;
            pnlSet.Location = new Point(0, 77);
            pnlSet.Name = "pnlSet";
            pnlSet.Size = new Size(1298, 59);
            pnlSet.TabIndex = 123;
            // 
            // Purchases_SupplierUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSet);
            Controls.Add(pnlTop);
            Controls.Add(DGListeSupplier);
            Name = "Purchases_SupplierUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1298, 768);
            Load += Purchases_SupplierUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)DGListeSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateDu.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateDu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateAu.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateAu.Properties).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            pnlSet.ResumeLayout(false);
            pnlSet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl DGListeSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label lblDateDu;
        private DevExpress.XtraEditors.DateEdit DateDu;
        private Label lblDateAu;
        private DevExpress.XtraEditors.DateEdit DateAu;
        private ComboBox txtSupplier;
        private Label lblSupplier;
        private FlowLayoutPanel pnlTop;
        private PictureBox PicLaterale;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private Label lblSup;
        private FlowLayoutPanel pnlSet;
    }
}
