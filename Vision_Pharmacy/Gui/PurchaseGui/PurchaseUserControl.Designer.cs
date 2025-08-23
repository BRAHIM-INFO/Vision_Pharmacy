namespace Vision_Pharmacy.Gui.PurchaseGui
{
    partial class PurchaseUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseUserControl));
            panel1 = new Panel();
            lblEmp = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox1 = new PictureBox();
            btnPrintPurch = new DevExpress.XtraEditors.SimpleButton();
            btnAddPurch = new DevExpress.XtraEditors.SimpleButton();
            DGListePurchase = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            lblCounter = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListePurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 71, 151);
            panel1.Controls.Add(lblEmp);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1346, 70);
            panel1.TabIndex = 28;
            // 
            // lblEmp
            // 
            lblEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Cairo Medium", 12F);
            lblEmp.ForeColor = Color.White;
            lblEmp.Location = new Point(1085, 18);
            lblEmp.Margin = new Padding(4, 0, 4, 0);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(155, 37);
            lblEmp.TabIndex = 1;
            lblEmp.Text = "قائمة المشتريات";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1256, 0);
            separatorControl1.Margin = new Padding(4, 2, 4, 2);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.trolley_9284599;
            pictureBox1.Location = new Point(1266, 0);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnPrintPurch
            // 
            btnPrintPurch.Appearance.BackColor = Color.Gray;
            btnPrintPurch.Appearance.Font = new Font("Cairo Medium", 10F);
            btnPrintPurch.Appearance.Options.UseBackColor = true;
            btnPrintPurch.Appearance.Options.UseFont = true;
            btnPrintPurch.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnPrintPurch.AppearanceDisabled.Options.UseFont = true;
            btnPrintPurch.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnPrintPurch.AppearanceHovered.Options.UseFont = true;
            btnPrintPurch.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnPrintPurch.AppearancePressed.Options.UseFont = true;
            btnPrintPurch.Cursor = Cursors.Hand;
            btnPrintPurch.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrintPurch.ImageOptions.SvgImage");
            btnPrintPurch.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrintPurch.Location = new Point(4, 75);
            btnPrintPurch.Margin = new Padding(4, 2, 4, 2);
            btnPrintPurch.Name = "btnPrintPurch";
            btnPrintPurch.RightToLeft = RightToLeft.Yes;
            btnPrintPurch.Size = new Size(136, 46);
            btnPrintPurch.TabIndex = 35;
            btnPrintPurch.Text = "طباعة";
            btnPrintPurch.ToolTipTitle = "اضافة";
            btnPrintPurch.Click += btnPrintPurch_Click;
            // 
            // btnAddPurch
            // 
            btnAddPurch.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnAddPurch.Appearance.Font = new Font("Cairo Medium", 10F);
            btnAddPurch.Appearance.Options.UseBackColor = true;
            btnAddPurch.Appearance.Options.UseFont = true;
            btnAddPurch.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnAddPurch.AppearanceDisabled.Options.UseFont = true;
            btnAddPurch.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnAddPurch.AppearanceHovered.Options.UseFont = true;
            btnAddPurch.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnAddPurch.AppearancePressed.Options.UseFont = true;
            btnAddPurch.Cursor = Cursors.Hand;
            btnAddPurch.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAddPurch.ImageOptions.SvgImage");
            btnAddPurch.ImageOptions.SvgImageSize = new Size(25, 25);
            btnAddPurch.Location = new Point(147, 75);
            btnAddPurch.Margin = new Padding(4, 2, 4, 2);
            btnAddPurch.Name = "btnAddPurch";
            btnAddPurch.RightToLeft = RightToLeft.Yes;
            btnAddPurch.Size = new Size(136, 46);
            btnAddPurch.TabIndex = 34;
            btnAddPurch.Text = "اضافة";
            btnAddPurch.ToolTipTitle = "اضافة";
            btnAddPurch.Click += btnAddPurch_Click;
            // 
            // DGListePurchase
            // 
            DGListePurchase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListePurchase.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListePurchase.Location = new Point(0, 126);
            DGListePurchase.MainView = gridView1;
            DGListePurchase.Margin = new Padding(4, 2, 4, 2);
            DGListePurchase.Name = "DGListePurchase";
            DGListePurchase.RightToLeft = RightToLeft.Yes;
            DGListePurchase.Size = new Size(1346, 652);
            DGListePurchase.TabIndex = 36;
            DGListePurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
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
            gridView1.GridControl = DGListePurchase;
            gridView1.Name = "gridView1"; 
            gridView1.RowCountChanged += gridView1_RowCountChanged;
            // 
            // lblCounter
            // 
            lblCounter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Cairo Medium", 12F);
            lblCounter.ForeColor = Color.Black;
            lblCounter.Location = new Point(1183, 84);
            lblCounter.Margin = new Padding(4, 0, 4, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(28, 37);
            lblCounter.TabIndex = 37;
            lblCounter.Text = "0";
            // 
            // PurchaseUserControl
            // 
            Appearance.BackColor = Color.WhiteSmoke;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCounter);
            Controls.Add(DGListePurchase);
            Controls.Add(btnPrintPurch);
            Controls.Add(btnAddPurch);
            Controls.Add(panel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "PurchaseUserControl";
            Size = new Size(1346, 780);
            Load += PurchaseUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListePurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblEmp;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPurch;
        private DevExpress.XtraEditors.SimpleButton btnAddPurch;
        private DevExpress.XtraGrid.GridControl DGListePurchase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label lblCounter;
    }
}
