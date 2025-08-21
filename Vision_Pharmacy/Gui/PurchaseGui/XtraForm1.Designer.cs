namespace Vision_Pharmacy.Gui.PurchaseGui
{
    partial class XtraForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            DGListeMedication = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnPrintPurch = new DevExpress.XtraEditors.SimpleButton();
            btnAddPurch = new DevExpress.XtraEditors.SimpleButton();
            btnEditPurch = new DevExpress.XtraEditors.SimpleButton();
            btnDeletePurch = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            lblEmp = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGListeMedication
            // 
            DGListeMedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeMedication.Location = new Point(24, 156);
            DGListeMedication.MainView = gridView1;
            DGListeMedication.Name = "DGListeMedication";
            DGListeMedication.RightToLeft = RightToLeft.Yes;
            DGListeMedication.Size = new Size(1317, 410);
            DGListeMedication.TabIndex = 0;
            DGListeMedication.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = DGListeMedication;
            gridView1.Name = "gridView1";
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
            btnPrintPurch.Location = new Point(22, 85);
            btnPrintPurch.Name = "btnPrintPurch";
            btnPrintPurch.RightToLeft = RightToLeft.Yes;
            btnPrintPurch.Size = new Size(137, 45);
            btnPrintPurch.TabIndex = 39;
            btnPrintPurch.Text = "طباعة";
            btnPrintPurch.ToolTipTitle = "اضافة";
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
            btnAddPurch.Location = new Point(451, 85);
            btnAddPurch.Name = "btnAddPurch";
            btnAddPurch.RightToLeft = RightToLeft.Yes;
            btnAddPurch.Size = new Size(137, 45);
            btnAddPurch.TabIndex = 38;
            btnAddPurch.Text = "اضافة";
            btnAddPurch.ToolTipTitle = "اضافة";
            // 
            // btnEditPurch
            // 
            btnEditPurch.Appearance.BackColor = Color.FromArgb(18, 128, 146);
            btnEditPurch.Appearance.Font = new Font("Cairo Medium", 10F);
            btnEditPurch.Appearance.Options.UseBackColor = true;
            btnEditPurch.Appearance.Options.UseFont = true;
            btnEditPurch.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnEditPurch.AppearanceDisabled.Options.UseFont = true;
            btnEditPurch.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnEditPurch.AppearanceHovered.Options.UseFont = true;
            btnEditPurch.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnEditPurch.AppearancePressed.Options.UseFont = true;
            btnEditPurch.Cursor = Cursors.Hand;
            btnEditPurch.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnEditPurch.ImageOptions.SvgImage");
            btnEditPurch.ImageOptions.SvgImageSize = new Size(25, 25);
            btnEditPurch.Location = new Point(308, 85);
            btnEditPurch.Name = "btnEditPurch";
            btnEditPurch.RightToLeft = RightToLeft.Yes;
            btnEditPurch.Size = new Size(137, 45);
            btnEditPurch.TabIndex = 37;
            btnEditPurch.Text = "تعديل";
            btnEditPurch.ToolTipTitle = "اضافة";
            // 
            // btnDeletePurch
            // 
            btnDeletePurch.Appearance.BackColor = Color.FromArgb(192, 0, 0);
            btnDeletePurch.Appearance.Font = new Font("Cairo Medium", 10F);
            btnDeletePurch.Appearance.Options.UseBackColor = true;
            btnDeletePurch.Appearance.Options.UseFont = true;
            btnDeletePurch.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnDeletePurch.AppearanceDisabled.Options.UseFont = true;
            btnDeletePurch.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnDeletePurch.AppearanceHovered.Options.UseFont = true;
            btnDeletePurch.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnDeletePurch.AppearancePressed.Options.UseFont = true;
            btnDeletePurch.Cursor = Cursors.Hand;
            btnDeletePurch.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDeletePurch.ImageOptions.SvgImage");
            btnDeletePurch.ImageOptions.SvgImageSize = new Size(25, 25);
            btnDeletePurch.Location = new Point(165, 85);
            btnDeletePurch.Name = "btnDeletePurch";
            btnDeletePurch.RightToLeft = RightToLeft.Yes;
            btnDeletePurch.Size = new Size(137, 45);
            btnDeletePurch.TabIndex = 36;
            btnDeletePurch.Text = "حذف";
            btnDeletePurch.ToolTipTitle = "اضافة";
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
            panel1.Size = new Size(1353, 70);
            panel1.TabIndex = 40;
            // 
            // lblEmp
            // 
            lblEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Cairo Medium", 12F);
            lblEmp.ForeColor = Color.White;
            lblEmp.Location = new Point(1102, 22);
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
            separatorControl1.Location = new Point(1263, 0);
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
            pictureBox1.Location = new Point(1273, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 615);
            Controls.Add(panel1);
            Controls.Add(btnPrintPurch);
            Controls.Add(btnAddPurch);
            Controls.Add(btnEditPurch);
            Controls.Add(btnDeletePurch);
            Controls.Add(DGListeMedication);
            Name = "XtraForm1";
            Text = "XtraForm1";
            Load += XtraForm1_Load;
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl DGListeMedication;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPurch;
        private DevExpress.XtraEditors.SimpleButton btnAddPurch;
        private DevExpress.XtraEditors.SimpleButton btnEditPurch;
        private DevExpress.XtraEditors.SimpleButton btnDeletePurch;
        private Panel panel1;
        private Label lblEmp;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox1;
    }
}