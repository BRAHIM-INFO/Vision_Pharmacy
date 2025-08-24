namespace Vision_Pharmacy.Gui.MedicationGui
{
    partial class ExpiredUserControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredUserControl));
            panel1 = new Panel();
            lblEmp = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox1 = new PictureBox();
            DGListeMedication = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnPrintMedic = new DevExpress.XtraEditors.SimpleButton();
            labelExpired = new Label();
            _timer = new System.Windows.Forms.Timer(components);
            comboBoxExpiry = new ComboBox();
            dateTimeExpired = new DateTimePicker();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).BeginInit();
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
            panel1.Size = new Size(1393, 70);
            panel1.TabIndex = 28;
            // 
            // lblEmp
            // 
            lblEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Cairo Medium", 12F);
            lblEmp.ForeColor = Color.White;
            lblEmp.Location = new Point(1018, 19);
            lblEmp.Margin = new Padding(4, 0, 4, 0);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(277, 37);
            lblEmp.TabIndex = 1;
            lblEmp.Text = "قائمة الأدوية المنتهية الصلاحية";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1303, 0);
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
            pictureBox1.Image = Properties.Resources.pill_bottle_15968729;
            pictureBox1.Location = new Point(1313, 0);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // DGListeMedication
            // 
            DGListeMedication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeMedication.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListeMedication.Location = new Point(1, 124);
            DGListeMedication.MainView = gridView1;
            DGListeMedication.Margin = new Padding(4, 2, 4, 2);
            DGListeMedication.Name = "DGListeMedication";
            DGListeMedication.RightToLeft = RightToLeft.Yes;
            DGListeMedication.Size = new Size(1392, 579);
            DGListeMedication.TabIndex = 33;
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
            btnPrintMedic.Location = new Point(4, 74);
            btnPrintMedic.Margin = new Padding(4, 2, 4, 2);
            btnPrintMedic.Name = "btnPrintMedic";
            btnPrintMedic.RightToLeft = RightToLeft.Yes;
            btnPrintMedic.Size = new Size(136, 46);
            btnPrintMedic.TabIndex = 34;
            btnPrintMedic.Text = "طباعة";
            btnPrintMedic.ToolTipTitle = "اضافة";
            btnPrintMedic.Click += btnPrintMedic_Click;
            // 
            // labelExpired
            // 
            labelExpired.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelExpired.AutoSize = true;
            labelExpired.Font = new Font("Cairo Medium", 10F);
            labelExpired.ForeColor = Color.Teal;
            labelExpired.Location = new Point(1348, 705);
            labelExpired.Margin = new Padding(4, 0, 4, 0);
            labelExpired.Name = "labelExpired";
            labelExpired.RightToLeft = RightToLeft.No;
            labelExpired.Size = new Size(21, 32);
            labelExpired.TabIndex = 121;
            labelExpired.Text = "-";
            //  
            // 
            // comboBoxExpiry
            // 
            comboBoxExpiry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxExpiry.BackColor = Color.White;
            comboBoxExpiry.DisplayMember = "اخر 30 يوم";
            comboBoxExpiry.FlatStyle = FlatStyle.System;
            comboBoxExpiry.Font = new Font("Cairo Medium", 9F);
            comboBoxExpiry.FormattingEnabled = true;
            comboBoxExpiry.Items.AddRange(new object[] { "اخر 30 يوم", "الشهر الماضي", "الشهر الحالي", "العام الماضي", "العام الحالي", "فترة محددة" });
            comboBoxExpiry.Location = new Point(1107, 83);
            comboBoxExpiry.Margin = new Padding(4, 2, 4, 2);
            comboBoxExpiry.Name = "comboBoxExpiry";
            comboBoxExpiry.RightToLeft = RightToLeft.Yes;
            comboBoxExpiry.Size = new Size(265, 37);
            comboBoxExpiry.TabIndex = 122;
            comboBoxExpiry.Text = "اخر 30 يوم";
            comboBoxExpiry.ValueMember = "اخر 30 يوم";
            comboBoxExpiry.SelectedIndexChanged += comboBoxExpiry_SelectedIndexChanged;
            // 
            // dateTimeExpired
            // 
            dateTimeExpired.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimeExpired.Font = new Font("Tahoma", 11F);
            dateTimeExpired.Format = DateTimePickerFormat.Short;
            dateTimeExpired.Location = new Point(846, 82);
            dateTimeExpired.Name = "dateTimeExpired";
            dateTimeExpired.Size = new Size(153, 30);
            dateTimeExpired.TabIndex = 123;
            dateTimeExpired.ValueChanged += dateTimeExpired_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Cairo Medium", 10F);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(1005, 88);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(95, 34);
            label7.TabIndex = 124;
            label7.Text = "تاريخ محدد";
            // 
            // ExpiredUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(dateTimeExpired);
            Controls.Add(comboBoxExpiry);
            Controls.Add(labelExpired);
            Controls.Add(btnPrintMedic);
            Controls.Add(DGListeMedication);
            Controls.Add(panel1);
            Name = "ExpiredUserControl";
            Size = new Size(1393, 750);
            Load += ExpiredUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListeMedication).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblEmp;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl DGListeMedication;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPrintMedic;
        private Label labelExpired;
        private System.Windows.Forms.Timer _timer;
        private ComboBox comboBoxExpiry;
        private DateTimePicker dateTimeExpired;
        private Label label7;
    }
}
