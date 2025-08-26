namespace Vision_Pharmacy.Gui.SupplierGui
{
    partial class SupplierUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierUserControl));
            DGListeSupplier = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            lblSup = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pnlSet = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DGListeSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSet.SuspendLayout();
            SuspendLayout();
            // 
            // DGListeSupplier
            // 
            DGListeSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeSupplier.Location = new Point(3, 136);
            DGListeSupplier.MainView = gridView1;
            DGListeSupplier.Name = "DGListeSupplier";
            DGListeSupplier.RightToLeft = RightToLeft.Yes;
            DGListeSupplier.Size = new Size(1303, 527);
            DGListeSupplier.TabIndex = 15;
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
            btnAdd.Location = new Point(146, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(137, 45);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            btnAdd.Click += btnAddSup_Click;
            // 
            // lblSup
            // 
            lblSup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSup.AutoSize = true;
            lblSup.Font = new Font("Cairo Medium", 12F);
            lblSup.ForeColor = Color.White;
            lblSup.Location = new Point(1058, 0);
            lblSup.Name = "lblSup";
            lblSup.Size = new Size(143, 37);
            lblSup.TabIndex = 1;
            lblSup.Text = "قائمة الموردين";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1207, 3);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(60, 71, 151);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(separatorControl1);
            flowLayoutPanel1.Controls.Add(lblSup);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1306, 77);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Image = Properties.Resources.trolley_9284599;
            pictureBox1.Location = new Point(1223, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pnlSet
            // 
            pnlSet.Controls.Add(btnPrint);
            pnlSet.Controls.Add(btnAdd);
            pnlSet.Dock = DockStyle.Top;
            pnlSet.Location = new Point(0, 77);
            pnlSet.Name = "pnlSet";
            pnlSet.RightToLeft = RightToLeft.No;
            pnlSet.Size = new Size(1306, 53);
            pnlSet.TabIndex = 17;
            // 
            // SupplierUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSet);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(DGListeSupplier);
            Name = "SupplierUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1306, 666);
            Load += SupplierUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)DGListeSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSet.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl DGListeSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private Label lblSup;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel pnlSet;
    }
}
