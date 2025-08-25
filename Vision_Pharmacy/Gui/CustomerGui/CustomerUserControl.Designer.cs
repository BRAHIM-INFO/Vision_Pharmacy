using Vision_Pharmacy.Properties;

namespace Vision_Pharmacy.Gui.CustomerGui
{
    partial class CustomerUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUserControl));
            DGListeCustomer = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            PicLaterale = new PictureBox();
            btnEditSup = new DevExpress.XtraEditors.SimpleButton();
            btnDeleteSup = new DevExpress.XtraEditors.SimpleButton();
            pnlTop = new Panel();
            lblTitleCustom = new Label();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)DGListeCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            SuspendLayout();
            // 
            // DGListeCustomer
            // 
            DGListeCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeCustomer.Location = new Point(3, 127);
            DGListeCustomer.MainView = gridView1;
            DGListeCustomer.Name = "DGListeCustomer";
            DGListeCustomer.RightToLeft = RightToLeft.Yes;
            DGListeCustomer.Size = new Size(1303, 539);
            DGListeCustomer.TabIndex = 15;
            DGListeCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
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
            gridView1.GridControl = DGListeCustomer;
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
            btnPrint.Location = new Point(3, 76);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(137, 45);
            btnPrint.TabIndex = 14;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrintSup_Click;
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
            btnAdd.Location = new Point(432, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(137, 45);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            btnAdd.Click += btnAddSup_Click;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Dock = DockStyle.Right;
            PicLaterale.Image = Resources.trolley_9284599;
            PicLaterale.Location = new Point(1226, 0);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 9;
            PicLaterale.TabStop = false;
            // 
            // btnEditSup
            // 
            btnEditSup.Appearance.BackColor = Color.FromArgb(18, 128, 146);
            btnEditSup.Appearance.Font = new Font("Cairo Medium", 10F);
            btnEditSup.Appearance.Options.UseBackColor = true;
            btnEditSup.Appearance.Options.UseFont = true;
            btnEditSup.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnEditSup.AppearanceDisabled.Options.UseFont = true;
            btnEditSup.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnEditSup.AppearanceHovered.Options.UseFont = true;
            btnEditSup.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnEditSup.AppearancePressed.Options.UseFont = true;
            btnEditSup.Cursor = Cursors.Hand;
            btnEditSup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnEditSup.ImageOptions.SvgImage");
            btnEditSup.ImageOptions.SvgImageSize = new Size(25, 25);
            btnEditSup.Location = new Point(289, 76);
            btnEditSup.Name = "btnEditSup";
            btnEditSup.RightToLeft = RightToLeft.Yes;
            btnEditSup.Size = new Size(137, 45);
            btnEditSup.TabIndex = 12;
            btnEditSup.Text = "تعديل";
            btnEditSup.ToolTipTitle = "اضافة";
            btnEditSup.Click += btnEditSup_Click;
            // 
            // btnDeleteSup
            // 
            btnDeleteSup.Appearance.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteSup.Appearance.Font = new Font("Cairo Medium", 10F);
            btnDeleteSup.Appearance.Options.UseBackColor = true;
            btnDeleteSup.Appearance.Options.UseFont = true;
            btnDeleteSup.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnDeleteSup.AppearanceDisabled.Options.UseFont = true;
            btnDeleteSup.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnDeleteSup.AppearanceHovered.Options.UseFont = true;
            btnDeleteSup.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnDeleteSup.AppearancePressed.Options.UseFont = true;
            btnDeleteSup.Cursor = Cursors.Hand;
            btnDeleteSup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDeleteSup.ImageOptions.SvgImage");
            btnDeleteSup.ImageOptions.SvgImageSize = new Size(25, 25);
            btnDeleteSup.Location = new Point(146, 76);
            btnDeleteSup.Name = "btnDeleteSup";
            btnDeleteSup.RightToLeft = RightToLeft.Yes;
            btnDeleteSup.Size = new Size(137, 45);
            btnDeleteSup.TabIndex = 11;
            btnDeleteSup.Text = "حذف";
            btnDeleteSup.ToolTipTitle = "اضافة";
            btnDeleteSup.Click += btnDeleteSup_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(lblTitleCustom);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1306, 70);
            pnlTop.TabIndex = 10;
            // 
            // lblTitleCustom
            // 
            lblTitleCustom.AutoSize = true;
            lblTitleCustom.Dock = DockStyle.Right;
            lblTitleCustom.Font = new Font("Cairo Medium", 12F);
            lblTitleCustom.ForeColor = Color.White;
            lblTitleCustom.Location = new Point(1082, 0);
            lblTitleCustom.Name = "lblTitleCustom";
            lblTitleCustom.Size = new Size(134, 37);
            lblTitleCustom.TabIndex = 1;
            lblTitleCustom.Text = "قائمة العملاء";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.Dock = DockStyle.Right;
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1216, 0);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(10, 70);
            SeparatLat.TabIndex = 1;
            // 
            // CustomerUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DGListeCustomer);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(btnEditSup);
            Controls.Add(btnDeleteSup);
            Controls.Add(pnlTop);
            Name = "CustomerUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1306, 666);
            ((System.ComponentModel.ISupportInitialize)DGListeCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl DGListeCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private PictureBox PicLaterale;
        private DevExpress.XtraEditors.SimpleButton btnEditSup;
        private DevExpress.XtraEditors.SimpleButton btnDeleteSup;
        private Panel pnlTop;
        private Label lblTitleCustom;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
    }
}
