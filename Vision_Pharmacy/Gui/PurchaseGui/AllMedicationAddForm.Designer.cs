namespace Vision_Pharmacy.Gui.PurchaseGui
{
    partial class AllMedicationAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllMedicationAddForm));
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lblSupForm = new Label();
            DGListePurchase = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            label6 = new Label();
            txtTotalAmount = new TextBox();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            panel2 = new Panel();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListePurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Controls.Add(separatorControl1);
            flowLayoutPanel2.Controls.Add(lblSupForm);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1379, 64);
            flowLayoutPanel2.TabIndex = 67;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.drugstore_17347470;
            pictureBox2.Location = new Point(1303, 2);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1285, 2);
            separatorControl1.Margin = new Padding(4, 2, 4, 2);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 55);
            separatorControl1.TabIndex = 1;
            // 
            // lblSupForm
            // 
            lblSupForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupForm.AutoSize = true;
            lblSupForm.Font = new Font("Cairo Medium", 12F);
            lblSupForm.ForeColor = Color.Black;
            lblSupForm.Location = new Point(940, 0);
            lblSupForm.Margin = new Padding(4, 0, 4, 0);
            lblSupForm.Name = "lblSupForm";
            lblSupForm.Size = new Size(337, 37);
            lblSupForm.TabIndex = 1;
            lblSupForm.Text = "ادارة المشتريات >  قائمة كل المشتريات";
            // 
            // DGListePurchase
            // 
            DGListePurchase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListePurchase.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListePurchase.Location = new Point(0, 65);
            DGListePurchase.MainView = gridView1;
            DGListePurchase.Margin = new Padding(4, 2, 4, 2);
            DGListePurchase.Name = "DGListePurchase";
            DGListePurchase.Size = new Size(1379, 516);
            DGListePurchase.TabIndex = 89;
            DGListePurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.CustomizationFormHint.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            gridView1.Appearance.DetailTip.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.DetailTip.Options.UseFont = true;
            gridView1.Appearance.EvenRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.EvenRow.Options.UseFont = true;
            gridView1.Appearance.FilterPanel.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.FilterPanel.Options.UseFont = true;
            gridView1.Appearance.FocusedCell.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.FocusedCell.Options.UseFont = true;
            gridView1.Appearance.FocusedRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.FocusedRow.Options.UseFont = true;
            gridView1.Appearance.FooterPanel.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.FooterPanel.Options.UseFont = true;
            gridView1.Appearance.GroupFooter.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.GroupFooter.Options.UseFont = true;
            gridView1.Appearance.GroupPanel.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.GroupRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.GroupRow.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HideSelectionRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            gridView1.Appearance.HotTrackedRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            gridView1.Appearance.NoSearchResults.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.NoSearchResults.Options.UseFont = true;
            gridView1.Appearance.OddRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.OddRow.Options.UseFont = true;
            gridView1.Appearance.Preview.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.Preview.Options.UseFont = true;
            gridView1.Appearance.Row.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.SelectedRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.SelectedRow.Options.UseFont = true;
            gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.TopNewRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.TopNewRow.Options.UseFont = true;
            gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.ViewCaption.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.GridControl = DGListePurchase;
            gridView1.Name = "gridView1";
            gridView1.ColumnFilterChanged += gridView1_ColumnFilterChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Dock = DockStyle.Right;
            label6.Font = new Font("Cairo Medium", 16F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(1072, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(307, 50);
            label6.TabIndex = 94;
            label6.Text = "السعر الفاتورة  الاجمالي";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.Black;
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.Dock = DockStyle.Right;
            txtTotalAmount.Font = new Font("Technology", 45F);
            txtTotalAmount.ForeColor = Color.Lime;
            txtTotalAmount.Location = new Point(360, 0);
            txtTotalAmount.Margin = new Padding(4, 2, 4, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.RightToLeft = RightToLeft.No;
            txtTotalAmount.Size = new Size(712, 75);
            txtTotalAmount.TabIndex = 95;
            txtTotalAmount.Text = "0.00";
            txtTotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrint.Appearance.BackColor = Color.Gray;
            btnPrint.Appearance.Font = new Font("Cairo Medium", 12F);
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
            btnPrint.Location = new Point(4, 585);
            btnPrint.Margin = new Padding(4, 2, 4, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(248, 47);
            btnPrint.TabIndex = 96;
            btnPrint.Text = "طباعة القائمة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrint_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(txtTotalAmount);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 637);
            panel2.Name = "panel2";
            panel2.Size = new Size(1379, 94);
            panel2.TabIndex = 92;
            // 
            // AllMedicationAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrint);
            Controls.Add(panel2);
            Controls.Add(DGListePurchase);
            Controls.Add(flowLayoutPanel2);
            Name = "AllMedicationAddForm";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1379, 731);
            Load += AllMedicationAddForm_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListePurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Label lblSupForm;
        private DevExpress.XtraGrid.GridControl DGListePurchase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label label6;
        private TextBox txtTotalAmount;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private Panel panel2;
    }
}