using Vision_Pharmacy.Properties;

namespace Vision_Pharmacy.Gui.PurchaseGui
{
    partial class PurchaseAddForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseAddForm));
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lblSupForm = new Label();
            label20 = new Label();
            IsActivetxt = new DevExpress.XtraEditors.ToggleSwitch();
            RequiresPrescriptiontxt = new DevExpress.XtraEditors.ToggleSwitch();
            label17 = new Label();
            PicChange = new PictureBox();
            label14 = new Label();
            ExpiryDatetxt = new DevExpress.XtraEditors.DateEdit();
            LocationInStoretxt = new TextBox();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            BatchNumbertxt = new TextBox();
            label15 = new Label();
            label13 = new Label();
            MinimumStockLeveltxt = new TextBox();
            label12 = new Label();
            QuantityInStocktxt = new TextBox();
            label11 = new Label();
            SalePricetxt = new TextBox();
            PurchasePricetxt = new TextBox();
            label10 = new Label();
            lblSupplierNotes = new Label();
            Unitetxt = new ComboBox();
            Categorytxt = new ComboBox();
            Strengthtxt = new ComboBox();
            MedicineTypetxt = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblSupplierEmail = new Label();
            label16 = new Label();
            lblSupplierName = new Label();
            lblSupplierAddress = new Label();
            lblSupplierPhone = new Label();
            Manufacturertxt = new TextBox();
            GenericNametxt = new TextBox();
            Nametxt = new TextBox();
            Barcodetxt = new TextBox();
            btnForm = new DevExpress.XtraEditors.SimpleButton();
            txtTypePaimt = new ComboBox();
            label4 = new Label();
            txtSupplier = new ComboBox();
            label3 = new Label();
            txtPurchaseDate = new DevExpress.XtraEditors.DateEdit();
            label1 = new Label();
            lblEmpEmail = new Label();
            txtFactureNum = new TextBox();
            panel5 = new Panel();
            DGListePurchase = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel6 = new Panel();
            txtTimerClock = new TextBox();
            txtdate = new TextBox();
            separatorControl22 = new DevExpress.XtraEditors.SeparatorControl();
            txtTotalAmount = new TextBox();
            label6 = new Label();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            timer1 = new System.Windows.Forms.Timer(components);
            label19 = new Label();
            txtNotes = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IsActivetxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RequiresPrescriptiontxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties.CalendarTimeProperties).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGListePurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl22).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1567, 55);
            panel1.TabIndex = 42;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Controls.Add(separatorControl1);
            flowLayoutPanel2.Controls.Add(lblSupForm);
            flowLayoutPanel2.Controls.Add(label20);
            flowLayoutPanel2.Controls.Add(IsActivetxt);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1567, 55);
            flowLayoutPanel2.TabIndex = 65;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.drugstore_17347470;
            pictureBox2.Location = new Point(1491, 2);
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
            separatorControl1.Location = new Point(1473, 2);
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
            lblSupForm.Location = new Point(1133, 0);
            lblSupForm.Margin = new Padding(4, 0, 4, 0);
            lblSupForm.Name = "lblSupForm";
            lblSupForm.Size = new Size(332, 37);
            lblSupForm.TabIndex = 1;
            lblSupForm.Text = "ادارة المشتريات >  اضافة فاتورة جديدة";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.BackColor = Color.White;
            label20.Font = new Font("Cairo Medium", 9F);
            label20.Location = new Point(1011, 0);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(114, 29);
            label20.TabIndex = 120;
            label20.Text = "هل الدواء نشط؟";
            // 
            // IsActivetxt
            // 
            IsActivetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IsActivetxt.EditValue = true;
            IsActivetxt.Enabled = false;
            IsActivetxt.Location = new Point(909, 2);
            IsActivetxt.Margin = new Padding(4, 2, 4, 2);
            IsActivetxt.Name = "IsActivetxt";
            IsActivetxt.Properties.OffText = "غير نشط";
            IsActivetxt.Properties.OnText = "نشط";
            IsActivetxt.Size = new Size(94, 24);
            IsActivetxt.TabIndex = 117;
            // 
            // RequiresPrescriptiontxt
            // 
            RequiresPrescriptiontxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RequiresPrescriptiontxt.EditValue = true;
            RequiresPrescriptiontxt.Enabled = false;
            RequiresPrescriptiontxt.Location = new Point(133, 142);
            RequiresPrescriptiontxt.Margin = new Padding(4, 2, 4, 2);
            RequiresPrescriptiontxt.Name = "RequiresPrescriptiontxt";
            RequiresPrescriptiontxt.Properties.OffText = "لا";
            RequiresPrescriptiontxt.Properties.OnText = "نعم";
            RequiresPrescriptiontxt.Size = new Size(91, 24);
            RequiresPrescriptiontxt.TabIndex = 119;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Cairo Medium", 9F);
            label17.Location = new Point(288, 140);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(118, 45);
            label17.TabIndex = 118;
            label17.Text = "هل يتطلب وصفة طبية؟";
            // 
            // PicChange
            // 
            PicChange.BackColor = Color.Transparent;
            PicChange.Cursor = Cursors.Hand;
            PicChange.Image = Resources.product;
            PicChange.Location = new Point(4, 2);
            PicChange.Margin = new Padding(4, 2, 4, 2);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(121, 43);
            PicChange.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChange.TabIndex = 116;
            PicChange.TabStop = false;
            PicChange.Click += PicChange_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Cairo Medium", 9F);
            label14.Location = new Point(288, 96);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(105, 29);
            label14.TabIndex = 115;
            label14.Text = "انتهاء الصلاحية";
            // 
            // ExpiryDatetxt
            // 
            ExpiryDatetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExpiryDatetxt.EditValue = null;
            ExpiryDatetxt.Enabled = false;
            ExpiryDatetxt.Location = new Point(133, 98);
            ExpiryDatetxt.Margin = new Padding(4, 2, 4, 2);
            ExpiryDatetxt.Name = "ExpiryDatetxt";
            ExpiryDatetxt.Properties.Appearance.BackColor = Color.FromArgb(227, 237, 249);
            ExpiryDatetxt.Properties.Appearance.Font = new Font("Tahoma", 10F);
            ExpiryDatetxt.Properties.Appearance.Options.UseBackColor = true;
            ExpiryDatetxt.Properties.Appearance.Options.UseFont = true;
            ExpiryDatetxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ExpiryDatetxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ExpiryDatetxt.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            ExpiryDatetxt.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            ExpiryDatetxt.Size = new Size(147, 28);
            ExpiryDatetxt.TabIndex = 19;
            ExpiryDatetxt.KeyDown += ExpiryDatetxt_KeyDown;
            // 
            // LocationInStoretxt
            // 
            LocationInStoretxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LocationInStoretxt.BackColor = Color.FromArgb(232, 246, 255);
            LocationInStoretxt.Enabled = false;
            LocationInStoretxt.Font = new Font("Cairo Medium", 9F);
            LocationInStoretxt.Location = new Point(133, 51);
            LocationInStoretxt.Margin = new Padding(4, 2, 4, 2);
            LocationInStoretxt.Name = "LocationInStoretxt";
            LocationInStoretxt.PlaceholderText = "مكان التخزين";
            LocationInStoretxt.Size = new Size(147, 36);
            LocationInStoretxt.TabIndex = 18;
            LocationInStoretxt.KeyDown += LocationInStoretxt_KeyDown;
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.FromArgb(33, 136, 56);
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
            btnAdd.Location = new Point(4, 142);
            btnAdd.Margin = new Padding(4, 2, 4, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(121, 41);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            btnAdd.Click += btnAdd_Click;
            // 
            // BatchNumbertxt
            // 
            BatchNumbertxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BatchNumbertxt.BackColor = Color.FromArgb(232, 246, 255);
            BatchNumbertxt.Enabled = false;
            BatchNumbertxt.Font = new Font("Cairo Medium", 9F);
            BatchNumbertxt.Location = new Point(133, 2);
            BatchNumbertxt.Margin = new Padding(4, 2, 4, 2);
            BatchNumbertxt.Name = "BatchNumbertxt";
            BatchNumbertxt.PlaceholderText = "رقم الدفعة";
            BatchNumbertxt.Size = new Size(147, 36);
            BatchNumbertxt.TabIndex = 17;
            BatchNumbertxt.KeyDown += BatchNumbertxt_KeyDown;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Cairo Medium", 9F);
            label15.Location = new Point(288, 49);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(94, 29);
            label15.TabIndex = 113;
            label15.Text = "مكان التخزين";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Cairo Medium", 9F);
            label13.Location = new Point(288, 0);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(83, 29);
            label13.TabIndex = 112;
            label13.Text = "رقم الدفعة";
            // 
            // MinimumStockLeveltxt
            // 
            MinimumStockLeveltxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimumStockLeveltxt.BackColor = Color.FromArgb(232, 246, 255);
            MinimumStockLeveltxt.Font = new Font("Cairo Medium", 9F);
            MinimumStockLeveltxt.Location = new Point(444, 142);
            MinimumStockLeveltxt.Margin = new Padding(4, 2, 4, 2);
            MinimumStockLeveltxt.Name = "MinimumStockLeveltxt";
            MinimumStockLeveltxt.PlaceholderText = "الحد الأدنى";
            MinimumStockLeveltxt.Size = new Size(112, 36);
            MinimumStockLeveltxt.TabIndex = 9;
            MinimumStockLeveltxt.KeyDown += MinimumStockLeveltxt_KeyDown;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Cairo Medium", 9F);
            label12.Location = new Point(564, 140);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(51, 45);
            label12.TabIndex = 109;
            label12.Text = "الحد الأدنى";
            // 
            // QuantityInStocktxt
            // 
            QuantityInStocktxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QuantityInStocktxt.BackColor = Color.FromArgb(232, 246, 255);
            QuantityInStocktxt.Font = new Font("Cairo Medium", 9F);
            QuantityInStocktxt.Location = new Point(444, 98);
            QuantityInStocktxt.Margin = new Padding(4, 2, 4, 2);
            QuantityInStocktxt.Name = "QuantityInStocktxt";
            QuantityInStocktxt.PlaceholderText = "الكمية";
            QuantityInStocktxt.Size = new Size(112, 36);
            QuantityInStocktxt.TabIndex = 8;
            QuantityInStocktxt.KeyDown += QuantityInStocktxt_KeyDown;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Cairo Medium", 9F);
            label11.Location = new Point(564, 96);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 29);
            label11.TabIndex = 107;
            label11.Text = "الكمية";
            // 
            // SalePricetxt
            // 
            SalePricetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SalePricetxt.BackColor = Color.FromArgb(232, 246, 255);
            SalePricetxt.Font = new Font("Cairo Medium", 9F);
            SalePricetxt.Location = new Point(444, 51);
            SalePricetxt.Margin = new Padding(4, 2, 4, 2);
            SalePricetxt.Name = "SalePricetxt";
            SalePricetxt.RightToLeft = RightToLeft.No;
            SalePricetxt.Size = new Size(112, 36);
            SalePricetxt.TabIndex = 7;
            SalePricetxt.Text = "0";
            SalePricetxt.TextAlign = HorizontalAlignment.Center;
            SalePricetxt.KeyDown += SalePricetxt_KeyDown;
            // 
            // PurchasePricetxt
            // 
            PurchasePricetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PurchasePricetxt.BackColor = Color.FromArgb(232, 246, 255);
            PurchasePricetxt.Font = new Font("Cairo Medium", 9F);
            PurchasePricetxt.Location = new Point(444, 2);
            PurchasePricetxt.Margin = new Padding(4, 2, 4, 2);
            PurchasePricetxt.Name = "PurchasePricetxt";
            PurchasePricetxt.RightToLeft = RightToLeft.No;
            PurchasePricetxt.Size = new Size(112, 36);
            PurchasePricetxt.TabIndex = 6;
            PurchasePricetxt.Text = "0";
            PurchasePricetxt.TextAlign = HorizontalAlignment.Center;
            PurchasePricetxt.KeyDown += PurchasePricetxt_KeyDown;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Cairo Medium", 9F);
            label10.Location = new Point(564, 0);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 49);
            label10.TabIndex = 105;
            label10.Text = "سعر الشراء";
            // 
            // lblSupplierNotes
            // 
            lblSupplierNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierNotes.AutoSize = true;
            lblSupplierNotes.BackColor = Color.White;
            lblSupplierNotes.Font = new Font("Cairo Medium", 9F);
            lblSupplierNotes.Location = new Point(564, 49);
            lblSupplierNotes.Margin = new Padding(4, 0, 4, 0);
            lblSupplierNotes.Name = "lblSupplierNotes";
            lblSupplierNotes.Size = new Size(72, 29);
            lblSupplierNotes.TabIndex = 104;
            lblSupplierNotes.Text = "سعر البيع";
            // 
            // Unitetxt
            // 
            Unitetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Unitetxt.BackColor = Color.FromArgb(232, 246, 255);
            Unitetxt.DropDownStyle = ComboBoxStyle.Simple;
            Unitetxt.Enabled = false;
            Unitetxt.FlatStyle = FlatStyle.System;
            Unitetxt.Font = new Font("Cairo Medium", 9F);
            Unitetxt.FormattingEnabled = true;
            Unitetxt.Location = new Point(648, 142);
            Unitetxt.Margin = new Padding(4, 2, 4, 2);
            Unitetxt.Name = "Unitetxt";
            Unitetxt.Size = new Size(176, 37);
            Unitetxt.TabIndex = 26;
            Unitetxt.KeyDown += Unitetxt_KeyDown;
            // 
            // Categorytxt
            // 
            Categorytxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Categorytxt.BackColor = Color.FromArgb(232, 246, 255);
            Categorytxt.DropDownStyle = ComboBoxStyle.Simple;
            Categorytxt.Enabled = false;
            Categorytxt.FlatStyle = FlatStyle.System;
            Categorytxt.Font = new Font("Cairo Medium", 9F);
            Categorytxt.FormattingEnabled = true;
            Categorytxt.Location = new Point(648, 51);
            Categorytxt.Margin = new Padding(4, 2, 4, 2);
            Categorytxt.Name = "Categorytxt";
            Categorytxt.Size = new Size(176, 37);
            Categorytxt.TabIndex = 24;
            Categorytxt.KeyDown += Categorytxt_KeyDown;
            // 
            // Strengthtxt
            // 
            Strengthtxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Strengthtxt.BackColor = Color.FromArgb(232, 246, 255);
            Strengthtxt.DropDownStyle = ComboBoxStyle.Simple;
            Strengthtxt.Enabled = false;
            Strengthtxt.FlatStyle = FlatStyle.System;
            Strengthtxt.Font = new Font("Cairo Medium", 9F);
            Strengthtxt.FormattingEnabled = true;
            Strengthtxt.Location = new Point(648, 98);
            Strengthtxt.Margin = new Padding(4, 2, 4, 2);
            Strengthtxt.Name = "Strengthtxt";
            Strengthtxt.Size = new Size(176, 37);
            Strengthtxt.TabIndex = 25;
            Strengthtxt.KeyDown += Strengthtxt_KeyDown;
            // 
            // MedicineTypetxt
            // 
            MedicineTypetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MedicineTypetxt.BackColor = Color.FromArgb(232, 246, 255);
            MedicineTypetxt.DropDownStyle = ComboBoxStyle.Simple;
            MedicineTypetxt.Enabled = false;
            MedicineTypetxt.FlatStyle = FlatStyle.System;
            MedicineTypetxt.Font = new Font("Cairo Medium", 9F);
            MedicineTypetxt.FormattingEnabled = true;
            MedicineTypetxt.Location = new Point(648, 2);
            MedicineTypetxt.Margin = new Padding(4, 2, 4, 2);
            MedicineTypetxt.Name = "MedicineTypetxt";
            MedicineTypetxt.Size = new Size(176, 37);
            MedicineTypetxt.TabIndex = 23;
            MedicineTypetxt.KeyDown += MedicineTypetxt_KeyDown;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Cairo Medium", 9F);
            label7.Location = new Point(834, 140);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 29);
            label7.TabIndex = 101;
            label7.Text = "الوحدة";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Cairo Medium", 9F);
            label8.Location = new Point(834, 49);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 29);
            label8.TabIndex = 100;
            label8.Text = "التصنيف";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Cairo Medium", 9F);
            label9.Location = new Point(834, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 49);
            label9.TabIndex = 99;
            label9.Text = "الشكل الصيدلي";
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.BackColor = Color.White;
            lblSupplierEmail.Font = new Font("Cairo Medium", 9F);
            lblSupplierEmail.Location = new Point(834, 96);
            lblSupplierEmail.Margin = new Padding(4, 0, 4, 0);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(48, 29);
            lblSupplierEmail.TabIndex = 98;
            lblSupplierEmail.Text = "التركيز";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Cairo Medium", 9F);
            label16.Location = new Point(1122, 0);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(90, 29);
            label16.TabIndex = 92;
            label16.Text = "باركود الدواء";
            // 
            // lblSupplierName
            // 
            lblSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierName.AutoSize = true;
            lblSupplierName.BackColor = Color.White;
            lblSupplierName.Font = new Font("Cairo Medium", 9F);
            lblSupplierName.Location = new Point(1122, 49);
            lblSupplierName.Margin = new Padding(4, 0, 4, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(79, 29);
            lblSupplierName.TabIndex = 88;
            lblSupplierName.Text = "اسم الدواء";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.BackColor = Color.White;
            lblSupplierAddress.Font = new Font("Cairo Medium", 9F);
            lblSupplierAddress.Location = new Point(1122, 96);
            lblSupplierAddress.Margin = new Padding(4, 0, 4, 0);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(99, 29);
            lblSupplierAddress.TabIndex = 89;
            lblSupplierAddress.Text = "الاسم العلمي";
            // 
            // lblSupplierPhone
            // 
            lblSupplierPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierPhone.AutoSize = true;
            lblSupplierPhone.BackColor = Color.White;
            lblSupplierPhone.Font = new Font("Cairo Medium", 9F);
            lblSupplierPhone.Location = new Point(1122, 140);
            lblSupplierPhone.Margin = new Padding(4, 0, 4, 0);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(68, 45);
            lblSupplierPhone.TabIndex = 90;
            lblSupplierPhone.Text = "الشركة المصنعة";
            // 
            // Manufacturertxt
            // 
            Manufacturertxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Manufacturertxt.BackColor = Color.FromArgb(232, 246, 255);
            Manufacturertxt.Enabled = false;
            Manufacturertxt.Font = new Font("Cairo Medium", 9F);
            Manufacturertxt.Location = new Point(938, 142);
            Manufacturertxt.Margin = new Padding(4, 2, 4, 2);
            Manufacturertxt.Name = "Manufacturertxt";
            Manufacturertxt.PlaceholderText = "الشركة المصنعة";
            Manufacturertxt.Size = new Size(176, 36);
            Manufacturertxt.TabIndex = 22;
            Manufacturertxt.KeyDown += Manufacturertxt_KeyDown;
            // 
            // GenericNametxt
            // 
            GenericNametxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GenericNametxt.BackColor = Color.FromArgb(232, 246, 255);
            GenericNametxt.Enabled = false;
            GenericNametxt.Font = new Font("Cairo Medium", 9F);
            GenericNametxt.Location = new Point(938, 98);
            GenericNametxt.Margin = new Padding(4, 2, 4, 2);
            GenericNametxt.Name = "GenericNametxt";
            GenericNametxt.PlaceholderText = "الاسم العلمي";
            GenericNametxt.Size = new Size(176, 36);
            GenericNametxt.TabIndex = 21;
            GenericNametxt.KeyDown += GenericNametxt_KeyDown;
            // 
            // Nametxt
            // 
            Nametxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Nametxt.BackColor = Color.FromArgb(232, 246, 255);
            Nametxt.Enabled = false;
            Nametxt.Font = new Font("Cairo Medium", 9F);
            Nametxt.Location = new Point(938, 51);
            Nametxt.Margin = new Padding(4, 2, 4, 2);
            Nametxt.Name = "Nametxt";
            Nametxt.PlaceholderText = "اسم الدواء";
            Nametxt.Size = new Size(176, 36);
            Nametxt.TabIndex = 30;
            Nametxt.KeyDown += Nametxt_KeyDown;
            // 
            // Barcodetxt
            // 
            Barcodetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Barcodetxt.BackColor = Color.FromArgb(232, 246, 255);
            Barcodetxt.Font = new Font("Cairo Medium", 9F);
            Barcodetxt.Location = new Point(938, 2);
            Barcodetxt.Margin = new Padding(4, 2, 4, 2);
            Barcodetxt.Name = "Barcodetxt";
            Barcodetxt.PlaceholderText = "باركود الدواء";
            Barcodetxt.Size = new Size(176, 36);
            Barcodetxt.TabIndex = 5;
            Barcodetxt.KeyDown += Barcodetxt_KeyDown;
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
            btnForm.Margin = new Padding(4, 2, 4, 2);
            btnForm.Name = "btnForm";
            btnForm.RightToLeft = RightToLeft.Yes;
            btnForm.Size = new Size(35, 39);
            btnForm.TabIndex = 83;
            btnForm.ToolTipTitle = "اضافة";
            // 
            // txtTypePaimt
            // 
            txtTypePaimt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTypePaimt.BackColor = Color.FromArgb(227, 237, 249);
            txtTypePaimt.FlatStyle = FlatStyle.System;
            txtTypePaimt.Font = new Font("Cairo Medium", 10F);
            txtTypePaimt.FormattingEnabled = true;
            txtTypePaimt.Items.AddRange(new object[] { "نقدي", "بطاقة ائتمان", "شيك" });
            txtTypePaimt.Location = new Point(1237, 142);
            txtTypePaimt.Margin = new Padding(4, 2, 4, 2);
            txtTypePaimt.Name = "txtTypePaimt";
            txtTypePaimt.Size = new Size(234, 40);
            txtTypePaimt.TabIndex = 4;
            txtTypePaimt.KeyDown += txtTypePaimt_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Cairo Medium", 9F);
            label4.Location = new Point(1479, 140);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 45);
            label4.TabIndex = 81;
            label4.Text = "طريقة الدفع";
            // 
            // txtSupplier
            // 
            txtSupplier.BackColor = Color.FromArgb(227, 237, 249);
            txtSupplier.Dock = DockStyle.Right;
            txtSupplier.FlatStyle = FlatStyle.System;
            txtSupplier.Font = new Font("Cairo Medium", 10F);
            txtSupplier.FormattingEnabled = true;
            txtSupplier.Location = new Point(38, 0);
            txtSupplier.Margin = new Padding(4, 2, 4, 2);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(196, 40);
            txtSupplier.TabIndex = 2;
            txtSupplier.KeyDown += txtSupplier_KeyDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cairo Medium", 9F);
            label3.Location = new Point(1479, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 29);
            label3.TabIndex = 79;
            label3.Text = "المورد";
            // 
            // txtPurchaseDate
            // 
            txtPurchaseDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPurchaseDate.EditValue = null;
            txtPurchaseDate.Location = new Point(1237, 98);
            txtPurchaseDate.Margin = new Padding(4, 2, 4, 2);
            txtPurchaseDate.Name = "txtPurchaseDate";
            txtPurchaseDate.Properties.Appearance.BackColor = Color.FromArgb(227, 237, 249);
            txtPurchaseDate.Properties.Appearance.Font = new Font("Tahoma", 10F);
            txtPurchaseDate.Properties.Appearance.Options.UseBackColor = true;
            txtPurchaseDate.Properties.Appearance.Options.UseFont = true;
            txtPurchaseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtPurchaseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtPurchaseDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            txtPurchaseDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            txtPurchaseDate.Size = new Size(234, 28);
            txtPurchaseDate.TabIndex = 3;
            txtPurchaseDate.KeyDown += txtPurchaseDate_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cairo Medium", 9F);
            label1.Location = new Point(1479, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 49);
            label1.TabIndex = 53;
            label1.Text = "رقم الفاتورة";
            // 
            // lblEmpEmail
            // 
            lblEmpEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpEmail.AutoSize = true;
            lblEmpEmail.BackColor = Color.White;
            lblEmpEmail.Font = new Font("Cairo Medium", 9F);
            lblEmpEmail.Location = new Point(1479, 96);
            lblEmpEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmpEmail.Name = "lblEmpEmail";
            lblEmpEmail.Size = new Size(80, 29);
            lblEmpEmail.TabIndex = 63;
            lblEmpEmail.Text = "تاريخ الشراء";
            // 
            // txtFactureNum
            // 
            txtFactureNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFactureNum.BackColor = Color.FromArgb(227, 237, 249);
            txtFactureNum.Font = new Font("Cairo Medium", 10F);
            txtFactureNum.Location = new Point(1237, 2);
            txtFactureNum.Margin = new Padding(4, 2, 4, 2);
            txtFactureNum.Name = "txtFactureNum";
            txtFactureNum.ReadOnly = true;
            txtFactureNum.Size = new Size(224, 39);
            txtFactureNum.TabIndex = 1;
            txtFactureNum.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(DGListePurchase);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 240);
            panel5.Margin = new Padding(4, 2, 4, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1567, 537);
            panel5.TabIndex = 64;
            // 
            // DGListePurchase
            // 
            DGListePurchase.Dock = DockStyle.Top;
            DGListePurchase.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListePurchase.Location = new Point(0, 0);
            DGListePurchase.MainView = gridView1;
            DGListePurchase.Margin = new Padding(4, 2, 4, 2);
            DGListePurchase.Name = "DGListePurchase";
            DGListePurchase.Size = new Size(1567, 416);
            DGListePurchase.TabIndex = 5;
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
            gridView1.RowCountChanged += gridView1_RowCountChanged;
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
            panel6.Location = new Point(0, 418);
            panel6.Margin = new Padding(4, 2, 4, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1567, 113);
            panel6.TabIndex = 64;
            // 
            // txtTimerClock
            // 
            txtTimerClock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimerClock.BackColor = Color.Black;
            txtTimerClock.BorderStyle = BorderStyle.None;
            txtTimerClock.Font = new Font("Technology", 16F, FontStyle.Bold);
            txtTimerClock.ForeColor = Color.DeepSkyBlue;
            txtTimerClock.Location = new Point(1423, 71);
            txtTimerClock.Margin = new Padding(4, 2, 4, 2);
            txtTimerClock.Name = "txtTimerClock";
            txtTimerClock.RightToLeft = RightToLeft.No;
            txtTimerClock.Size = new Size(133, 27);
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
            txtdate.Location = new Point(1400, 32);
            txtdate.Margin = new Padding(4, 2, 4, 2);
            txtdate.Name = "txtdate";
            txtdate.RightToLeft = RightToLeft.No;
            txtdate.Size = new Size(156, 30);
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
            separatorControl22.Location = new Point(1368, 2);
            separatorControl22.Margin = new Padding(4, 2, 4, 2);
            separatorControl22.Name = "separatorControl22";
            separatorControl22.Padding = new Padding(0);
            separatorControl22.Size = new Size(10, 118);
            separatorControl22.TabIndex = 105;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTotalAmount.BackColor = Color.Black;
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.Font = new Font("Technology", 45F);
            txtTotalAmount.ForeColor = Color.Lime;
            txtTotalAmount.Location = new Point(7, 38);
            txtTotalAmount.Margin = new Padding(4, 2, 4, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.RightToLeft = RightToLeft.No;
            txtTotalAmount.Size = new Size(545, 75);
            txtTotalAmount.TabIndex = 94;
            txtTotalAmount.Text = "0.00";
            txtTotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(183, -1);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(205, 32);
            label6.TabIndex = 93;
            label6.Text = "السعر الفاتورة  الاجمالي";
            // 
            // btnSave
            // 
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
            btnSave.Dock = DockStyle.Left;
            btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSave.ImageOptions.SvgImage");
            btnSave.ImageOptions.SvgImageSize = new Size(25, 25);
            btnSave.Location = new Point(12, 2);
            btnSave.Margin = new Padding(4, 2, 4, 2);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(159, 36);
            btnSave.TabIndex = 83;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "حفظ";
            btnSave.Click += btnSave_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Cairo Medium", 9F);
            label19.Location = new Point(1494, 11);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(69, 29);
            label19.TabIndex = 84;
            label19.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtNotes.BackColor = Color.FromArgb(232, 246, 255);
            txtNotes.Font = new Font("Cairo Medium", 9F);
            txtNotes.Location = new Point(179, 2);
            txtNotes.Margin = new Padding(4, 2, 4, 2);
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "تسجيل ملاحظات";
            txtNotes.Size = new Size(1307, 36);
            txtNotes.TabIndex = 85;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.758007F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.24199F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(RequiresPrescriptiontxt, 9, 3);
            tableLayoutPanel1.Controls.Add(PicChange, 10, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAdd, 10, 3);
            tableLayoutPanel1.Controls.Add(label17, 8, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(ExpiryDatetxt, 9, 2);
            tableLayoutPanel1.Controls.Add(lblEmpEmail, 0, 2);
            tableLayoutPanel1.Controls.Add(LocationInStoretxt, 9, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label14, 8, 2);
            tableLayoutPanel1.Controls.Add(BatchNumbertxt, 9, 0);
            tableLayoutPanel1.Controls.Add(txtFactureNum, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPurchaseDate, 1, 2);
            tableLayoutPanel1.Controls.Add(txtTypePaimt, 1, 3);
            tableLayoutPanel1.Controls.Add(label16, 2, 0);
            tableLayoutPanel1.Controls.Add(lblSupplierName, 2, 1);
            tableLayoutPanel1.Controls.Add(label15, 8, 1);
            tableLayoutPanel1.Controls.Add(lblSupplierAddress, 2, 2);
            tableLayoutPanel1.Controls.Add(label13, 8, 0);
            tableLayoutPanel1.Controls.Add(lblSupplierPhone, 2, 3);
            tableLayoutPanel1.Controls.Add(MinimumStockLeveltxt, 7, 3);
            tableLayoutPanel1.Controls.Add(Barcodetxt, 3, 0);
            tableLayoutPanel1.Controls.Add(QuantityInStocktxt, 7, 2);
            tableLayoutPanel1.Controls.Add(label12, 6, 3);
            tableLayoutPanel1.Controls.Add(SalePricetxt, 7, 1);
            tableLayoutPanel1.Controls.Add(Nametxt, 3, 1);
            tableLayoutPanel1.Controls.Add(PurchasePricetxt, 7, 0);
            tableLayoutPanel1.Controls.Add(GenericNametxt, 3, 2);
            tableLayoutPanel1.Controls.Add(label11, 6, 2);
            tableLayoutPanel1.Controls.Add(Manufacturertxt, 3, 3);
            tableLayoutPanel1.Controls.Add(label9, 4, 0);
            tableLayoutPanel1.Controls.Add(label8, 4, 1);
            tableLayoutPanel1.Controls.Add(lblSupplierNotes, 6, 1);
            tableLayoutPanel1.Controls.Add(label10, 6, 0);
            tableLayoutPanel1.Controls.Add(lblSupplierEmail, 4, 2);
            tableLayoutPanel1.Controls.Add(label7, 4, 3);
            tableLayoutPanel1.Controls.Add(Unitetxt, 5, 3);
            tableLayoutPanel1.Controls.Add(MedicineTypetxt, 5, 0);
            tableLayoutPanel1.Controls.Add(Strengthtxt, 5, 2);
            tableLayoutPanel1.Controls.Add(Categorytxt, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.7042236F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2957764F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(1567, 185);
            tableLayoutPanel1.TabIndex = 86;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSupplier);
            panel3.Controls.Add(btnForm);
            panel3.Location = new Point(1237, 53);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 39);
            panel3.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label19);
            flowLayoutPanel1.Controls.Add(txtNotes);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 779);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1567, 46);
            flowLayoutPanel1.TabIndex = 86;
            // 
            // PurchaseAddForm
            // 
            Appearance.BackColor = Color.FromArgb(227, 237, 249);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 825);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PurchaseAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة فاتورة جديدة";
            Load += PurchaseAddForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)IsActivetxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)RequiresPrescriptiontxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGListePurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl22).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSupForm;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Label label1;
        private TextBox txtFactureNum;
        private DevExpress.XtraEditors.DateEdit txtPurchaseDate;
        private Label lblEmpEmail;
        private ComboBox txtSupplier;
        private Label label3;
        private ComboBox txtTypePaimt;
        private Label label4;
        private Panel panel5;
        private Panel panel6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl22;
        private TextBox txtTotalAmount;
        private Label label6;
        private TextBox txtTimerClock;
        private TextBox txtdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl DGListePurchase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnForm;
        private Label label16;
        private Label lblSupplierName;
        private Label lblSupplierAddress;
        private Label lblSupplierPhone;
        private TextBox Manufacturertxt;
        private TextBox GenericNametxt;
        private TextBox Nametxt;
        private TextBox Barcodetxt;
        private ComboBox Unitetxt;
        private ComboBox Categorytxt;
        private ComboBox Strengthtxt;
        private ComboBox MedicineTypetxt;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblSupplierEmail;
        private TextBox SalePricetxt;
        private TextBox PurchasePricetxt;
        private Label label10;
        private Label lblSupplierNotes;
        private TextBox QuantityInStocktxt;
        private Label label11;
        private TextBox MinimumStockLeveltxt;
        private Label label12;
        private TextBox LocationInStoretxt;
        private TextBox BatchNumbertxt;
        private Label label15;
        private Label label13;
        private Label label14;
        private DevExpress.XtraEditors.DateEdit ExpiryDatetxt;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private PictureBox PicChange;
        private System.Windows.Forms.Timer timer1;
        private Label label20;
        private DevExpress.XtraEditors.ToggleSwitch RequiresPrescriptiontxt;
        private Label label17;
        private DevExpress.XtraEditors.ToggleSwitch IsActivetxt;
        private Label label19;
        private TextBox txtNotes;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
    }
}