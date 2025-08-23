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
            panel1 = new Panel();
            lblSup = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox1 = new PictureBox();
            btnPrintSup = new DevExpress.XtraEditors.SimpleButton();
            DGListeSupplier = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            label14 = new Label();
            DateDu = new DevExpress.XtraEditors.DateEdit();
            label1 = new Label();
            DateAu = new DevExpress.XtraEditors.DateEdit();
            txtSupplier = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListeSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateDu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateDu.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateAu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateAu.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 71, 151);
            panel1.Controls.Add(lblSup);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 70);
            panel1.TabIndex = 11;
            // 
            // lblSup
            // 
            lblSup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSup.AutoSize = true;
            lblSup.Font = new Font("Cairo Medium", 12F);
            lblSup.ForeColor = Color.White;
            lblSup.Location = new Point(928, 16);
            lblSup.Name = "lblSup";
            lblSup.Size = new Size(263, 37);
            lblSup.TabIndex = 1;
            lblSup.Text = "قائمة المشتريات من الموردين";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1208, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.shopping_basket_15712813;
            pictureBox1.Location = new Point(1218, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnPrintSup
            // 
            btnPrintSup.Appearance.BackColor = Color.Gray;
            btnPrintSup.Appearance.Font = new Font("Cairo Medium", 10F);
            btnPrintSup.Appearance.Options.UseBackColor = true;
            btnPrintSup.Appearance.Options.UseFont = true;
            btnPrintSup.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnPrintSup.AppearanceDisabled.Options.UseFont = true;
            btnPrintSup.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnPrintSup.AppearanceHovered.Options.UseFont = true;
            btnPrintSup.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnPrintSup.AppearancePressed.Options.UseFont = true;
            btnPrintSup.Cursor = Cursors.Hand;
            btnPrintSup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrintSup.ImageOptions.SvgImage");
            btnPrintSup.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrintSup.Location = new Point(3, 76);
            btnPrintSup.Name = "btnPrintSup";
            btnPrintSup.RightToLeft = RightToLeft.Yes;
            btnPrintSup.Size = new Size(137, 45);
            btnPrintSup.TabIndex = 15;
            btnPrintSup.Text = "طباعة";
            btnPrintSup.ToolTipTitle = "اضافة";
            btnPrintSup.Click += btnPrintSup_Click;
            // 
            // DGListeSupplier
            // 
            DGListeSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeSupplier.Location = new Point(3, 127);
            DGListeSupplier.MainView = gridView1;
            DGListeSupplier.Name = "DGListeSupplier";
            DGListeSupplier.RightToLeft = RightToLeft.Yes;
            DGListeSupplier.Size = new Size(1298, 638);
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
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Cairo Medium", 9F);
            label14.Location = new Point(845, 84);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.Yes;
            label14.Size = new Size(80, 29);
            label14.TabIndex = 117;
            label14.Text = "الفترة بين : ";
            // 
            // DateDu
            // 
            DateDu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateDu.EditValue = null;
            DateDu.Location = new Point(593, 85);
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cairo Medium", 9F);
            label1.Location = new Point(554, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(35, 29);
            label1.TabIndex = 119;
            label1.Text = "الى ";
            // 
            // DateAu
            // 
            DateAu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateAu.EditValue = null;
            DateAu.Location = new Point(302, 85);
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
            txtSupplier.Location = new Point(934, 79);
            txtSupplier.Margin = new Padding(4, 2, 4, 2);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(263, 40);
            txtSupplier.TabIndex = 120;
            txtSupplier.SelectedValueChanged += txtSupplier_SelectedValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cairo Medium", 9F);
            label3.Location = new Point(1205, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 29);
            label3.TabIndex = 121;
            label3.Text = "اسم المورد";
            // 
            // Purchases_SupplierUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSupplier);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(DateAu);
            Controls.Add(label14);
            Controls.Add(DateDu);
            Controls.Add(DGListeSupplier);
            Controls.Add(btnPrintSup);
            Controls.Add(panel1);
            Name = "Purchases_SupplierUserControl";
            Size = new Size(1298, 768);
            Load += Purchases_SupplierUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListeSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateDu.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateDu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateAu.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateAu.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSup;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnPrintSup;
        private DevExpress.XtraGrid.GridControl DGListeSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label label14;
        private DevExpress.XtraEditors.DateEdit DateDu;
        private Label label1;
        private DevExpress.XtraEditors.DateEdit DateAu;
        private ComboBox txtSupplier;
        private Label label3;
    }
}
