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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationUserControl));
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblEmp = new Label();
            btnExcel = new DevExpress.XtraEditors.SimpleButton();
            btnPrintMedic = new DevExpress.XtraEditors.SimpleButton();
            btnAddMedic = new DevExpress.XtraEditors.SimpleButton();
            DGListeMedication = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            PicChange = new PictureBox();
            lblCounter = new Label();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            SuspendLayout();
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1240, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.pill_bottle_15968729;
            pictureBox1.Location = new Point(1250, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 71, 151);
            panel1.Controls.Add(lblEmp);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 70);
            panel1.TabIndex = 27;
            // 
            // lblEmp
            // 
            lblEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Cairo Medium", 12F);
            lblEmp.ForeColor = Color.White;
            lblEmp.Location = new Point(1093, 18);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(128, 37);
            lblEmp.TabIndex = 1;
            lblEmp.Text = "قائمة الأدوية";
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
            btnExcel.Name = "btnExcel";
            btnExcel.RightToLeft = RightToLeft.Yes;
            btnExcel.Size = new Size(137, 45);
            btnExcel.TabIndex = 33;
            btnExcel.Text = "تحميل قائمة";
            btnExcel.ToolTipTitle = "اضافة";
            btnExcel.Click += btnExcel_Click;
            // 
            // btnPrintMedic
            // 
            btnPrintMedic.Appearance.BackColor = Color.Gray;
            btnPrintMedic.Appearance.Font = new Font("Cairo Medium", 10F);
            btnPrintMedic.Appearance.Options.UseBackColor = true;
            btnPrintMedic.Appearance.Options.UseFont = true;
            btnPrintMedic.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnPrintMedic.AppearanceDisabled.Options.UseFont = true;
            btnPrintMedic.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnPrintMedic.AppearanceHovered.Options.UseFont = true;
            btnPrintMedic.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnPrintMedic.AppearancePressed.Options.UseFont = true;
            btnPrintMedic.Cursor = Cursors.Hand;
            btnPrintMedic.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrintMedic.ImageOptions.SvgImage");
            btnPrintMedic.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrintMedic.Location = new Point(3, 76);
            btnPrintMedic.Name = "btnPrintMedic";
            btnPrintMedic.RightToLeft = RightToLeft.Yes;
            btnPrintMedic.Size = new Size(137, 45);
            btnPrintMedic.TabIndex = 31;
            btnPrintMedic.Text = "طباعة";
            btnPrintMedic.ToolTipTitle = "اضافة";
            btnPrintMedic.Click += btnPrintMedic_Click;
            // 
            // btnAddMedic
            // 
            btnAddMedic.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnAddMedic.Appearance.Font = new Font("Cairo Medium", 10F);
            btnAddMedic.Appearance.Options.UseBackColor = true;
            btnAddMedic.Appearance.Options.UseFont = true;
            btnAddMedic.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnAddMedic.AppearanceDisabled.Options.UseFont = true;
            btnAddMedic.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnAddMedic.AppearanceHovered.Options.UseFont = true;
            btnAddMedic.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnAddMedic.AppearancePressed.Options.UseFont = true;
            btnAddMedic.Cursor = Cursors.Hand;
            btnAddMedic.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAddMedic.ImageOptions.SvgImage");
            btnAddMedic.ImageOptions.SvgImageSize = new Size(25, 25);
            btnAddMedic.Location = new Point(289, 76);
            btnAddMedic.Name = "btnAddMedic";
            btnAddMedic.RightToLeft = RightToLeft.Yes;
            btnAddMedic.Size = new Size(137, 45);
            btnAddMedic.TabIndex = 30;
            btnAddMedic.Text = "اضافة";
            btnAddMedic.ToolTipTitle = "اضافة";
            btnAddMedic.Click += btnAddMedic_Click;
            // 
            // DGListeMedication
            // 
            DGListeMedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeMedication.Location = new Point(0, 127);
            DGListeMedication.MainView = gridView1;
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
            gridView1.DoubleClick += gridView1_DoubleClick;
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
            lblCounter.Location = new Point(1225, 86);
            lblCounter.Name = "lblCounter";
            lblCounter.RightToLeft = RightToLeft.Yes;
            lblCounter.Size = new Size(25, 32);
            lblCounter.TabIndex = 120;
            lblCounter.Text = "0";
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
            Controls.Add(panel1);
            Controls.Add(btnPrintMedic);
            Controls.Add(PicChange);
            Controls.Add(btnAddMedic);
            Name = "MedicationUserControl";
            Size = new Size(1330, 760);
            Load += MedicationUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblEmp;
        private DevExpress.XtraGrid.GridControl DGListeMedication;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrintMedic;
        private DevExpress.XtraEditors.SimpleButton btnAddMedic;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private PictureBox PicChange;
        private Label lblCounter;
    }
}
