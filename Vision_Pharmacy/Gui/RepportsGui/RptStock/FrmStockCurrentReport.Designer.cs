namespace Vision_Pharmacy.Gui.RepportsGui.RptStock
{
    partial class FrmStockCurrentReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockCurrentReport));
            flowLayoutPanel1 = new FlowLayoutPanel();
            PicLaterale = new PictureBox();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            lblTitleMedicat = new Label();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            DGListeMedication = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            txtTotalAmount = new TextBox();
            label32 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(60, 71, 151);
            flowLayoutPanel1.Controls.Add(PicLaterale);
            flowLayoutPanel1.Controls.Add(SeparatLat);
            flowLayoutPanel1.Controls.Add(lblTitleMedicat);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1509, 74);
            flowLayoutPanel1.TabIndex = 122;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Image = Properties.Resources.pill_bottle_15968729;
            PicLaterale.Location = new Point(1425, 2);
            PicLaterale.Margin = new Padding(4, 2, 4, 2);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(80, 70);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 26;
            PicLaterale.TabStop = false;
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 10;
            SeparatLat.Location = new Point(1407, 2);
            SeparatLat.Margin = new Padding(4, 2, 4, 2);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(10, 70);
            SeparatLat.TabIndex = 1;
            // 
            // lblTitleMedicat
            // 
            lblTitleMedicat.AutoSize = true;
            lblTitleMedicat.Font = new Font("Cairo Medium", 12F);
            lblTitleMedicat.ForeColor = Color.White;
            lblTitleMedicat.Location = new Point(1251, 0);
            lblTitleMedicat.Margin = new Padding(4, 0, 4, 0);
            lblTitleMedicat.Name = "lblTitleMedicat";
            lblTitleMedicat.Size = new Size(148, 37);
            lblTitleMedicat.TabIndex = 1;
            lblTitleMedicat.Text = "تقرير الجرد العام";
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
            btnPrint.Location = new Point(13, 631);
            btnPrint.Margin = new Padding(4, 2, 4, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(245, 46);
            btnPrint.TabIndex = 31;
            btnPrint.Text = "طباعة التقرير";
            btnPrint.ToolTipTitle = "طباعة التقرير";
            // 
            // DGListeMedication
            // 
            DGListeMedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeMedication.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListeMedication.Location = new Point(0, 76);
            DGListeMedication.MainView = gridView1;
            DGListeMedication.Margin = new Padding(4, 2, 4, 2);
            DGListeMedication.Name = "DGListeMedication";
            DGListeMedication.RightToLeft = RightToLeft.Yes;
            DGListeMedication.Size = new Size(1506, 542);
            DGListeMedication.TabIndex = 124;
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
            // txtTotalAmount
            // 
            txtTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTotalAmount.BackColor = Color.Black;
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.Font = new Font("Technology", 38F, FontStyle.Bold);
            txtTotalAmount.ForeColor = Color.Lime;
            txtTotalAmount.Location = new Point(990, 620);
            txtTotalAmount.Margin = new Padding(4, 2, 4, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.RightToLeft = RightToLeft.No;
            txtTotalAmount.Size = new Size(514, 64);
            txtTotalAmount.TabIndex = 126;
            txtTotalAmount.Text = "0.00";
            txtTotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label32.AutoSize = true;
            label32.BackColor = SystemColors.Control;
            label32.Font = new Font("Cairo Medium", 12F, FontStyle.Bold);
            label32.ForeColor = Color.Black;
            label32.Location = new Point(746, 638);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(236, 37);
            label32.TabIndex = 125;
            label32.Text = "المبلغ الاجمالي للمخزون";
            // 
            // FrmStockCurrentReport
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 686);
            Controls.Add(btnPrint);
            Controls.Add(txtTotalAmount);
            Controls.Add(label32);
            Controls.Add(DGListeMedication);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStockCurrentReport";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تقرير الجرد العام";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox PicLaterale;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private Label lblTitleMedicat;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl DGListeMedication;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TextBox txtTotalAmount;
        private Label label32;
    }
}