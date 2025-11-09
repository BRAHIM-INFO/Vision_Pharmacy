namespace Vision_Pharmacy.Gui.SaleGui
{
    partial class SalesAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesAddForm));
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lblSupForm = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            txtSupplier = new ComboBox();
            btnForm = new DevExpress.XtraEditors.SimpleButton();
            label1 = new Label();
            label3 = new Label();
            txtFactureNum = new TextBox();
            txtPurchaseDate = new DevExpress.XtraEditors.DateEdit();
            label16 = new Label();
            Barcodetxt = new TextBox();
            txtTypePaimt = new ComboBox();
            label4 = new Label();
            lblEmpEmail = new Label();
            DGListePurchase = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label19 = new Label();
            txtNotes = new TextBox();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            panel6 = new Panel();
            txtTimerClock = new TextBox();
            txtdate = new TextBox();
            separatorControl22 = new DevExpress.XtraEditors.SeparatorControl();
            txtTotalAmount = new TextBox();
            label6 = new Label();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListePurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl22).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Controls.Add(separatorControl1);
            flowLayoutPanel2.Controls.Add(lblSupForm);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1341, 52);
            flowLayoutPanel2.TabIndex = 67;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.drugstore_17347470;
            pictureBox2.Location = new Point(1276, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 8;
            separatorControl1.Location = new Point(1261, 2);
            separatorControl1.Margin = new Padding(3, 2, 3, 2);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(9, 45);
            separatorControl1.TabIndex = 1;
            // 
            // lblSupForm
            // 
            lblSupForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupForm.AutoSize = true;
            lblSupForm.Font = new Font("Cairo Medium", 12F);
            lblSupForm.ForeColor = Color.Black;
            lblSupForm.Location = new Point(1032, 0);
            lblSupForm.Name = "lblSupForm";
            lblSupForm.Size = new Size(223, 30);
            lblSupForm.TabIndex = 1;
            lblSupForm.Text = "ادارة المبيعات >  اضافة بيع جديد";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7661285F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.23387F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 425F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(txtFactureNum, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPurchaseDate, 1, 2);
            tableLayoutPanel1.Controls.Add(label16, 2, 0);
            tableLayoutPanel1.Controls.Add(Barcodetxt, 3, 0);
            tableLayoutPanel1.Controls.Add(txtTypePaimt, 3, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(lblEmpEmail, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.35165F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.64835F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(1341, 103);
            tableLayoutPanel1.TabIndex = 88;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(txtSupplier);
            panel3.Controls.Add(btnForm);
            panel3.Location = new Point(930, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 29);
            panel3.TabIndex = 20;
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplier.BackColor = Color.FromArgb(227, 237, 249);
            txtSupplier.FlatStyle = FlatStyle.System;
            txtSupplier.Font = new Font("Cairo Medium", 10F);
            txtSupplier.FormattingEnabled = true;
            txtSupplier.Location = new Point(157, 0);
            txtSupplier.Margin = new Padding(3, 2, 3, 2);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(294, 32);
            txtSupplier.TabIndex = 2;
            // 
            // btnForm
            // 
            btnForm.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnForm.Appearance.Font = new Font("Cairo Medium", 10F);
            btnForm.Appearance.Options.UseBackColor = true;
            btnForm.Appearance.Options.UseFont = true;
            btnForm.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnForm.AppearanceDisabled.Options.UseFont = true;
            btnForm.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnForm.AppearanceHovered.Options.UseFont = true;
            btnForm.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnForm.AppearancePressed.Options.UseFont = true;
            btnForm.Cursor = Cursors.Hand;
            btnForm.Dock = DockStyle.Left;
            btnForm.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnForm.ImageOptions.SvgImage");
            btnForm.ImageOptions.SvgImageSize = new Size(25, 25);
            btnForm.Location = new Point(0, 0);
            btnForm.Margin = new Padding(3, 2, 3, 2);
            btnForm.Name = "btnForm";
            btnForm.RightToLeft = RightToLeft.Yes;
            btnForm.Size = new Size(30, 29);
            btnForm.TabIndex = 83;
            btnForm.ToolTipTitle = "اضافة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cairo Medium", 9F);
            label1.Location = new Point(1269, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 53;
            label1.Text = "رقم الفاتورة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cairo Medium", 9F);
            label3.Location = new Point(1298, 34);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 79;
            label3.Text = "المورد";
            // 
            // txtFactureNum
            // 
            txtFactureNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFactureNum.BackColor = Color.FromArgb(227, 237, 249);
            txtFactureNum.Font = new Font("Cairo Medium", 10F);
            txtFactureNum.Location = new Point(930, 2);
            txtFactureNum.Margin = new Padding(3, 2, 3, 2);
            txtFactureNum.Name = "txtFactureNum";
            txtFactureNum.ReadOnly = true;
            txtFactureNum.Size = new Size(322, 32);
            txtFactureNum.TabIndex = 1;
            txtFactureNum.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPurchaseDate
            // 
            txtPurchaseDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPurchaseDate.EditValue = null;
            txtPurchaseDate.Location = new Point(930, 72);
            txtPurchaseDate.Margin = new Padding(3, 2, 3, 2);
            txtPurchaseDate.Name = "txtPurchaseDate";
            txtPurchaseDate.Properties.Appearance.BackColor = Color.FromArgb(227, 237, 249);
            txtPurchaseDate.Properties.Appearance.Font = new Font("Tahoma", 12F);
            txtPurchaseDate.Properties.Appearance.Options.UseBackColor = true;
            txtPurchaseDate.Properties.Appearance.Options.UseFont = true;
            txtPurchaseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtPurchaseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtPurchaseDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            txtPurchaseDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            txtPurchaseDate.Size = new Size(322, 26);
            txtPurchaseDate.TabIndex = 3;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Cairo Medium", 9F);
            label16.Location = new Point(829, 0);
            label16.Name = "label16";
            label16.Size = new Size(73, 23);
            label16.TabIndex = 92;
            label16.Text = "باركود الدواء";
            // 
            // Barcodetxt
            // 
            Barcodetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Barcodetxt.BackColor = Color.FromArgb(232, 246, 255);
            Barcodetxt.Font = new Font("Cairo Medium", 9F);
            Barcodetxt.Location = new Point(429, 2);
            Barcodetxt.Margin = new Padding(3, 2, 3, 2);
            Barcodetxt.Name = "Barcodetxt";
            Barcodetxt.PlaceholderText = "باركود الدواء";
            Barcodetxt.Size = new Size(394, 30);
            Barcodetxt.TabIndex = 5;
            // 
            // txtTypePaimt
            // 
            txtTypePaimt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTypePaimt.BackColor = Color.FromArgb(227, 237, 249);
            txtTypePaimt.FlatStyle = FlatStyle.System;
            txtTypePaimt.Font = new Font("Cairo Medium", 10F);
            txtTypePaimt.FormattingEnabled = true;
            txtTypePaimt.Items.AddRange(new object[] { "نقدي", "بطاقة ائتمان", "شيك" });
            txtTypePaimt.Location = new Point(429, 36);
            txtTypePaimt.Margin = new Padding(3, 2, 3, 2);
            txtTypePaimt.Name = "txtTypePaimt";
            txtTypePaimt.Size = new Size(394, 32);
            txtTypePaimt.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Cairo Medium", 9F);
            label4.Location = new Point(829, 34);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 81;
            label4.Text = "طريقة الدفع";
            // 
            // lblEmpEmail
            // 
            lblEmpEmail.AutoSize = true;
            lblEmpEmail.BackColor = Color.White;
            lblEmpEmail.Font = new Font("Cairo Medium", 9F);
            lblEmpEmail.Location = new Point(1273, 70);
            lblEmpEmail.Name = "lblEmpEmail";
            lblEmpEmail.Size = new Size(65, 23);
            lblEmpEmail.TabIndex = 63;
            lblEmpEmail.Text = "تاريخ الشراء";
            // 
            // DGListePurchase
            // 
            DGListePurchase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListePurchase.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            DGListePurchase.Location = new Point(0, 157);
            DGListePurchase.MainView = gridView1;
            DGListePurchase.Margin = new Padding(3, 2, 3, 2);
            DGListePurchase.Name = "DGListePurchase";
            DGListePurchase.Size = new Size(1341, 323);
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
            gridView1.DetailHeight = 284;
            gridView1.GridControl = DGListePurchase;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label19);
            flowLayoutPanel1.Controls.Add(txtNotes);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 578);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1341, 37);
            flowLayoutPanel1.TabIndex = 91;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Cairo Medium", 9F);
            label19.Location = new Point(1282, 11);
            label19.Name = "label19";
            label19.Size = new Size(56, 23);
            label19.TabIndex = 84;
            label19.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.BackColor = Color.FromArgb(232, 246, 255);
            txtNotes.Font = new Font("Cairo Medium", 9F);
            txtNotes.Location = new Point(183, 2);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "تسجيل ملاحظات";
            txtNotes.Size = new Size(1093, 30);
            txtNotes.TabIndex = 85;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Appearance.BackColor = SystemColors.Highlight;
            btnSave.Appearance.Font = new Font("Cairo Medium", 10F);
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearanceDisabled.Options.UseFont = true;
            btnSave.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearanceHovered.Options.UseFont = true;
            btnSave.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearancePressed.Options.UseFont = true;
            btnSave.Cursor = Cursors.Hand;
            btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSave.ImageOptions.SvgImage");
            btnSave.ImageOptions.SvgImageSize = new Size(25, 25);
            btnSave.Location = new Point(23, 2);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(154, 30);
            btnSave.TabIndex = 83;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "حفظ";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(txtTimerClock);
            panel6.Controls.Add(txtdate);
            panel6.Controls.Add(separatorControl22);
            panel6.Controls.Add(txtTotalAmount);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(0, 484);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1341, 92);
            panel6.TabIndex = 92;
            // 
            // txtTimerClock
            // 
            txtTimerClock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimerClock.BackColor = Color.Black;
            txtTimerClock.BorderStyle = BorderStyle.None;
            txtTimerClock.Font = new Font("Technology", 16F, FontStyle.Bold);
            txtTimerClock.ForeColor = Color.DeepSkyBlue;
            txtTimerClock.Location = new Point(2391, 58);
            txtTimerClock.Margin = new Padding(3, 2, 3, 2);
            txtTimerClock.Name = "txtTimerClock";
            txtTimerClock.RightToLeft = RightToLeft.No;
            txtTimerClock.Size = new Size(114, 22);
            txtTimerClock.TabIndex = 111;
            txtTimerClock.Text = "14:00:12";
            txtTimerClock.TextAlign = HorizontalAlignment.Center;
            // 
            // txtdate
            // 
            txtdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtdate.BackColor = Color.Black;
            txtdate.BorderStyle = BorderStyle.None;
            txtdate.Font = new Font("Technology", 18F, FontStyle.Bold);
            txtdate.ForeColor = Color.DeepSkyBlue;
            txtdate.Location = new Point(2371, 26);
            txtdate.Margin = new Padding(3, 2, 3, 2);
            txtdate.Name = "txtdate";
            txtdate.RightToLeft = RightToLeft.No;
            txtdate.Size = new Size(134, 24);
            txtdate.TabIndex = 110;
            txtdate.Text = "10/08/2025";
            txtdate.TextAlign = HorizontalAlignment.Center;
            // 
            // separatorControl22
            // 
            separatorControl22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            separatorControl22.BackColor = Color.Black;
            separatorControl22.LineColor = Color.DarkGray;
            separatorControl22.LineOrientation = Orientation.Vertical;
            separatorControl22.LineThickness = 2;
            separatorControl22.Location = new Point(2344, 2);
            separatorControl22.Margin = new Padding(3, 2, 3, 2);
            separatorControl22.Name = "separatorControl22";
            separatorControl22.Padding = new Padding(0);
            separatorControl22.Size = new Size(9, 96);
            separatorControl22.TabIndex = 105;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTotalAmount.BackColor = Color.Black;
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.Font = new Font("Technology", 45F);
            txtTotalAmount.ForeColor = Color.Lime;
            txtTotalAmount.Location = new Point(6, 25);
            txtTotalAmount.Margin = new Padding(3, 2, 3, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.RightToLeft = RightToLeft.No;
            txtTotalAmount.Size = new Size(467, 60);
            txtTotalAmount.TabIndex = 94;
            txtTotalAmount.Text = "0.00";
            txtTotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Cairo Medium", 16F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(531, 18);
            label6.Name = "label6";
            label6.Size = new Size(255, 42);
            label6.TabIndex = 93;
            label6.Text = "السعر الفاتورة  الاجمالي";
            // 
            // SalesAddForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 615);
            Controls.Add(panel6);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(DGListePurchase);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Name = "SalesAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesAddForm";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListePurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl22).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Label lblSupForm;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private ComboBox txtSupplier;
        private DevExpress.XtraEditors.SimpleButton btnForm;
        private Label label1;
        private Label label3;
        private TextBox txtFactureNum;
        private DevExpress.XtraEditors.DateEdit txtPurchaseDate;
        private Label label16;
        private TextBox Barcodetxt;
        private ComboBox txtTypePaimt;
        private Label label4;
        private Label lblEmpEmail;
        private DevExpress.XtraGrid.GridControl DGListePurchase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label19;
        private TextBox txtNotes;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private Panel panel6;
        private TextBox txtTimerClock;
        private TextBox txtdate;
        private DevExpress.XtraEditors.SeparatorControl separatorControl22;
        private TextBox txtTotalAmount;
        private Label label6;
    }
}