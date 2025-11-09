using Vision_Pharmacy.Gui.PurchaseGui;

namespace Vision_Pharmacy.Gui.SaleGui
{
    partial class SaleUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleUserControl));
            lblTitlePurchase = new Label();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            PicLaterale = new PictureBox();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            DGListeSale = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            lblCounter = new Label();
            pnlTop = new FlowLayoutPanel();
            pnlSet = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListeSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            pnlTop.SuspendLayout();
            pnlSet.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitlePurchase
            // 
            lblTitlePurchase.AutoSize = true;
            lblTitlePurchase.Font = new Font("Cairo Medium", 12F);
            lblTitlePurchase.ForeColor = Color.White;
            lblTitlePurchase.Location = new Point(1093, 0);
            lblTitlePurchase.Margin = new Padding(4, 0, 4, 0);
            lblTitlePurchase.Name = "lblTitlePurchase";
            lblTitlePurchase.Size = new Size(143, 37);
            lblTitlePurchase.TabIndex = 1;
            lblTitlePurchase.Text = "قائمة المبيعات";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1244, 2);
            SeparatLat.Margin = new Padding(4, 2, 4, 2);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(10, 70);
            SeparatLat.TabIndex = 1;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Image = Properties.Resources.trolley_9284599;
            PicLaterale.Location = new Point(1262, 2);
            PicLaterale.Margin = new Padding(4, 2, 4, 2);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 26;
            PicLaterale.TabStop = false;
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
            btnPrint.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrint.Location = new Point(4, 2);
            btnPrint.Margin = new Padding(4, 2, 4, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(136, 46);
            btnPrint.TabIndex = 35;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrint_Click;
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
            btnAdd.Location = new Point(148, 2);
            btnAdd.Margin = new Padding(4, 2, 4, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(136, 46);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            btnAdd.Click += btnAdd_Click_1;
            // 
            // DGListeSale
            // 
            DGListeSale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeSale.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListeSale.Location = new Point(0, 132);
            DGListeSale.MainView = gridView1;
            DGListeSale.Margin = new Padding(4, 2, 4, 2);
            DGListeSale.Name = "DGListeSale";
            DGListeSale.RightToLeft = RightToLeft.Yes;
            DGListeSale.Size = new Size(1346, 646);
            DGListeSale.TabIndex = 36;
            DGListeSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
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
            gridView1.GridControl = DGListeSale;
            gridView1.Name = "gridView1";
            gridView1.RowCountChanged += gridView1_RowCountChanged;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Cairo Medium", 12F);
            lblCounter.ForeColor = Color.Black;
            lblCounter.Location = new Point(292, 0);
            lblCounter.Margin = new Padding(4, 0, 4, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(28, 37);
            lblCounter.TabIndex = 37;
            lblCounter.Text = "0";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(lblTitlePurchase);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(4, 2, 4, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1346, 74);
            pnlTop.TabIndex = 38;
            // 
            // pnlSet
            // 
            pnlSet.Controls.Add(btnPrint);
            pnlSet.Controls.Add(btnAdd);
            pnlSet.Controls.Add(lblCounter);
            pnlSet.Dock = DockStyle.Top;
            pnlSet.Location = new Point(0, 74);
            pnlSet.Margin = new Padding(4, 2, 4, 2);
            pnlSet.Name = "pnlSet";
            pnlSet.RightToLeft = RightToLeft.No;
            pnlSet.Size = new Size(1346, 53);
            pnlSet.TabIndex = 39;
            // 
            // SaleUserControl
            // 
            Appearance.BackColor = Color.WhiteSmoke;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSet);
            Controls.Add(pnlTop);
            Controls.Add(DGListeSale);
            Margin = new Padding(4, 2, 4, 2);
            Name = "SaleUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1346, 780);
            Load += SaleUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListeSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlSet.ResumeLayout(false);
            pnlSet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitlePurchase;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private PictureBox PicLaterale;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl DGListeSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label lblCounter;
        private FlowLayoutPanel pnlTop;
        private FlowLayoutPanel pnlSet;
    }
}
