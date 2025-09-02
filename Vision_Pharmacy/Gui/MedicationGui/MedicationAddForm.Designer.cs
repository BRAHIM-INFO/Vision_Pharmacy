namespace Vision_Pharmacy.Gui.MedicationGui
{
    partial class MedicationAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationAddForm));
            label1 = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox3 = new PictureBox();
            LocationInStoretxt = new TextBox();
            DateAddedtxt = new DevExpress.XtraEditors.DateEdit();
            Unitetxt = new ComboBox();
            Categorytxt = new ComboBox();
            Strengthtxt = new ComboBox();
            MedicineTypetxt = new ComboBox();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblSupplierName = new Label();
            lblSupplierAddress = new Label();
            lblSupplierEmail = new Label();
            lblSupplierPhone = new Label();
            label9 = new Label();
            btnUnite = new DevExpress.XtraEditors.SimpleButton();
            btnCategory = new DevExpress.XtraEditors.SimpleButton();
            btnStrength = new DevExpress.XtraEditors.SimpleButton();
            buttonSaveSup = new DevExpress.XtraEditors.SimpleButton();
            label20 = new Label();
            RequiresPrescriptiontxt = new DevExpress.XtraEditors.ToggleSwitch();
            ExpiryDatetxt = new DevExpress.XtraEditors.DateEdit();
            btnForm = new DevExpress.XtraEditors.SimpleButton();
            MinimumStockLeveltxt = new TextBox();
            QuantityInStocktxt = new TextBox();
            Suppliertxt = new ComboBox();
            Discounttxt = new TextBox();
            SalePricetxt = new TextBox();
            PurchasePricetxt = new TextBox();
            BatchNumbertxt = new TextBox();
            Manufacturertxt = new TextBox();
            GenericNametxt = new TextBox();
            Nametxt = new TextBox();
            label17 = new Label();
            label15 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            IsActivetxt = new DevExpress.XtraEditors.ToggleSwitch();
            PicChange = new PictureBox();
            Notestxt = new TextBox();
            Barcodetxt = new TextBox();
            lblSupplierNotes = new Label();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateAddedtxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateAddedtxt.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RequiresPrescriptiontxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IsActivetxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo Medium", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(914, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(413, 37);
            label1.TabIndex = 18;
            label1.Text = "ادارة المخزون > قائمة الأدوية > اظافة دواء جديد";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1333, 3);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Image = Properties.Resources.pill_bottle_15968729;
            pictureBox3.Location = new Point(1349, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // LocationInStoretxt
            // 
            LocationInStoretxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LocationInStoretxt.BackColor = Color.FromArgb(232, 246, 255);
            LocationInStoretxt.Font = new Font("Cairo Medium", 10F);
            LocationInStoretxt.Location = new Point(3, 187);
            LocationInStoretxt.Name = "LocationInStoretxt";
            LocationInStoretxt.PlaceholderText = "مكان التخزين";
            LocationInStoretxt.Size = new Size(292, 39);
            LocationInStoretxt.TabIndex = 13;
            LocationInStoretxt.KeyDown += LocationInStoretxt_KeyDown;
            // 
            // DateAddedtxt
            // 
            DateAddedtxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateAddedtxt.EditValue = null;
            DateAddedtxt.Location = new Point(510, 415);
            DateAddedtxt.Name = "DateAddedtxt";
            DateAddedtxt.Properties.Appearance.Font = new Font("Tahoma", 13F);
            DateAddedtxt.Properties.Appearance.Options.UseFont = true;
            DateAddedtxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateAddedtxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DateAddedtxt.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            DateAddedtxt.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            DateAddedtxt.Size = new Size(292, 34);
            DateAddedtxt.TabIndex = 18;
            DateAddedtxt.KeyDown += DateAddedtxt_KeyDown;
            // 
            // Unitetxt
            // 
            Unitetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Unitetxt.FlatStyle = FlatStyle.System;
            Unitetxt.Font = new Font("Cairo Medium", 10F);
            Unitetxt.FormattingEnabled = true;
            Unitetxt.Location = new Point(43, 0);
            Unitetxt.Margin = new Padding(0);
            Unitetxt.Name = "Unitetxt";
            Unitetxt.Size = new Size(248, 40);
            Unitetxt.TabIndex = 12;
            Unitetxt.KeyDown += Unitetxt_KeyDown;
            // 
            // Categorytxt
            // 
            Categorytxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Categorytxt.FlatStyle = FlatStyle.System;
            Categorytxt.Font = new Font("Cairo Medium", 10F);
            Categorytxt.FormattingEnabled = true;
            Categorytxt.Location = new Point(45, 0);
            Categorytxt.Margin = new Padding(0);
            Categorytxt.Name = "Categorytxt";
            Categorytxt.Size = new Size(248, 40);
            Categorytxt.TabIndex = 11;
            Categorytxt.KeyDown += Categorytxt_KeyDown;
            // 
            // Strengthtxt
            // 
            Strengthtxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Strengthtxt.FlatStyle = FlatStyle.System;
            Strengthtxt.Font = new Font("Cairo Medium", 10F);
            Strengthtxt.FormattingEnabled = true;
            Strengthtxt.Location = new Point(40, 0);
            Strengthtxt.Margin = new Padding(0);
            Strengthtxt.Name = "Strengthtxt";
            Strengthtxt.Size = new Size(248, 40);
            Strengthtxt.TabIndex = 10;
            Strengthtxt.KeyDown += Strengthtxt_KeyDown;
            // 
            // MedicineTypetxt
            // 
            MedicineTypetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MedicineTypetxt.FlatStyle = FlatStyle.System;
            MedicineTypetxt.Font = new Font("Cairo Medium", 10F);
            MedicineTypetxt.FormattingEnabled = true;
            MedicineTypetxt.Location = new Point(38, 0);
            MedicineTypetxt.Margin = new Padding(0);
            MedicineTypetxt.Name = "MedicineTypetxt";
            MedicineTypetxt.Size = new Size(245, 40);
            MedicineTypetxt.TabIndex = 9;
            MedicineTypetxt.KeyDown += MedicineTypetxt_KeyDown;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Cairo Medium", 10F);
            label16.Location = new Point(811, 0);
            label16.Name = "label16";
            label16.Size = new Size(104, 32);
            label16.TabIndex = 53;
            label16.Text = "باركود الدواء";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Cairo Medium", 10F);
            label14.Location = new Point(811, 460);
            label14.Name = "label14";
            label14.Size = new Size(131, 32);
            label14.TabIndex = 51;
            label14.Text = "ملاحظات إضافية";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Cairo Medium", 10F);
            label13.Location = new Point(811, 412);
            label13.Name = "label13";
            label13.Size = new Size(140, 32);
            label13.TabIndex = 50;
            label13.Text = "تاريخ إضافة الدواء";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Cairo Medium", 10F);
            label5.Location = new Point(811, 323);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 43;
            label5.Text = "الوحدة";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cairo Medium", 10F);
            label3.Location = new Point(811, 276);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 41;
            label3.Text = "التصنيف";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cairo Medium", 10F);
            label2.Location = new Point(811, 184);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 40;
            label2.Text = "الشكل الصيدلي";
            // 
            // lblSupplierName
            // 
            lblSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierName.AutoSize = true;
            lblSupplierName.BackColor = Color.White;
            lblSupplierName.Font = new Font("Cairo Medium", 10F);
            lblSupplierName.Location = new Point(811, 44);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(90, 32);
            lblSupplierName.TabIndex = 19;
            lblSupplierName.Text = "اسم الدواء";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.BackColor = Color.White;
            lblSupplierAddress.Font = new Font("Cairo Medium", 10F);
            lblSupplierAddress.Location = new Point(811, 90);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(112, 32);
            lblSupplierAddress.TabIndex = 21;
            lblSupplierAddress.Text = "الاسم العلمي";
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.BackColor = Color.White;
            lblSupplierEmail.Font = new Font("Cairo Medium", 10F);
            lblSupplierEmail.Location = new Point(811, 233);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(55, 32);
            lblSupplierEmail.TabIndex = 24;
            lblSupplierEmail.Text = "التركيز";
            // 
            // lblSupplierPhone
            // 
            lblSupplierPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierPhone.AutoSize = true;
            lblSupplierPhone.BackColor = Color.White;
            lblSupplierPhone.Font = new Font("Cairo Medium", 10F);
            lblSupplierPhone.Location = new Point(811, 137);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(132, 32);
            lblSupplierPhone.TabIndex = 23;
            lblSupplierPhone.Text = "الشركة المصنعة";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Cairo Medium", 10F);
            label9.Location = new Point(811, 369);
            label9.Name = "label9";
            label9.Size = new Size(155, 32);
            label9.TabIndex = 46;
            label9.Text = "تاريخ انتهاء الصلاحية";
            // 
            // btnUnite
            // 
            btnUnite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUnite.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnUnite.Appearance.Font = new Font("Cairo Medium", 10F);
            btnUnite.Appearance.Options.UseBackColor = true;
            btnUnite.Appearance.Options.UseFont = true;
            btnUnite.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnUnite.AppearanceDisabled.Options.UseFont = true;
            btnUnite.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnUnite.AppearanceHovered.Options.UseFont = true;
            btnUnite.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnUnite.AppearancePressed.Options.UseFont = true;
            btnUnite.Cursor = Cursors.Hand;
            btnUnite.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnUnite.ImageOptions.SvgImage");
            btnUnite.ImageOptions.SvgImageSize = new Size(25, 25);
            btnUnite.Location = new Point(5, 0);
            btnUnite.Margin = new Padding(0);
            btnUnite.Name = "btnUnite";
            btnUnite.RightToLeft = RightToLeft.Yes;
            btnUnite.Size = new Size(38, 40);
            btnUnite.TabIndex = 91;
            btnUnite.ToolTipTitle = "اضافة";
            btnUnite.Click += btnUnite_Click;
            // 
            // btnCategory
            // 
            btnCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCategory.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnCategory.Appearance.Font = new Font("Cairo Medium", 10F);
            btnCategory.Appearance.Options.UseBackColor = true;
            btnCategory.Appearance.Options.UseFont = true;
            btnCategory.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnCategory.AppearanceDisabled.Options.UseFont = true;
            btnCategory.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnCategory.AppearanceHovered.Options.UseFont = true;
            btnCategory.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnCategory.AppearancePressed.Options.UseFont = true;
            btnCategory.Cursor = Cursors.Hand;
            btnCategory.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCategory.ImageOptions.SvgImage");
            btnCategory.ImageOptions.SvgImageSize = new Size(25, 25);
            btnCategory.Location = new Point(7, 0);
            btnCategory.Margin = new Padding(0);
            btnCategory.Name = "btnCategory";
            btnCategory.RightToLeft = RightToLeft.Yes;
            btnCategory.Size = new Size(38, 40);
            btnCategory.TabIndex = 90;
            btnCategory.ToolTipTitle = "اضافة";
            btnCategory.Click += btnCategory_Click;
            // 
            // btnStrength
            // 
            btnStrength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStrength.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnStrength.Appearance.Font = new Font("Cairo Medium", 10F);
            btnStrength.Appearance.Options.UseBackColor = true;
            btnStrength.Appearance.Options.UseFont = true;
            btnStrength.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnStrength.AppearanceDisabled.Options.UseFont = true;
            btnStrength.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnStrength.AppearanceHovered.Options.UseFont = true;
            btnStrength.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnStrength.AppearancePressed.Options.UseFont = true;
            btnStrength.Cursor = Cursors.Hand;
            btnStrength.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnStrength.ImageOptions.SvgImage");
            btnStrength.ImageOptions.SvgImageSize = new Size(25, 25);
            btnStrength.Location = new Point(2, 0);
            btnStrength.Margin = new Padding(0);
            btnStrength.Name = "btnStrength";
            btnStrength.RightToLeft = RightToLeft.Yes;
            btnStrength.Size = new Size(38, 40);
            btnStrength.TabIndex = 89;
            btnStrength.ToolTipTitle = "اضافة";
            btnStrength.Click += btnStrength_Click;
            // 
            // buttonSaveSup
            // 
            buttonSaveSup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSaveSup.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            buttonSaveSup.Appearance.Font = new Font("Cairo Medium", 10F);
            buttonSaveSup.Appearance.Options.UseBackColor = true;
            buttonSaveSup.Appearance.Options.UseFont = true;
            buttonSaveSup.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            buttonSaveSup.AppearanceDisabled.Options.UseFont = true;
            buttonSaveSup.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            buttonSaveSup.AppearanceHovered.Options.UseFont = true;
            buttonSaveSup.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            buttonSaveSup.AppearancePressed.Options.UseFont = true;
            buttonSaveSup.Cursor = Cursors.Hand;
            buttonSaveSup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveSup.ImageOptions.SvgImage");
            buttonSaveSup.ImageOptions.SvgImageSize = new Size(25, 25);
            buttonSaveSup.Location = new Point(3, 463);
            buttonSaveSup.Name = "buttonSaveSup";
            buttonSaveSup.RightToLeft = RightToLeft.Yes;
            buttonSaveSup.Size = new Size(264, 43);
            buttonSaveSup.TabIndex = 26;
            buttonSaveSup.Text = "حفظ";
            buttonSaveSup.ToolTipTitle = "اضافة";
            buttonSaveSup.Click += buttonSaveSup_Click;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.BackColor = Color.White;
            label20.Font = new Font("Cairo Medium", 10F);
            label20.Location = new Point(307, 412);
            label20.Name = "label20";
            label20.Size = new Size(135, 32);
            label20.TabIndex = 84;
            label20.Text = "مفعل/غير مفعل";
            // 
            // RequiresPrescriptiontxt
            // 
            RequiresPrescriptiontxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RequiresPrescriptiontxt.EditValue = true;
            RequiresPrescriptiontxt.Location = new Point(3, 372);
            RequiresPrescriptiontxt.Name = "RequiresPrescriptiontxt";
            RequiresPrescriptiontxt.Properties.OffText = "لا";
            RequiresPrescriptiontxt.Properties.OnText = "نعم";
            RequiresPrescriptiontxt.Size = new Size(119, 24);
            RequiresPrescriptiontxt.TabIndex = 83;
            // 
            // ExpiryDatetxt
            // 
            ExpiryDatetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExpiryDatetxt.EditValue = null;
            ExpiryDatetxt.Location = new Point(510, 372);
            ExpiryDatetxt.Name = "ExpiryDatetxt";
            ExpiryDatetxt.Properties.Appearance.Font = new Font("Tahoma", 13F);
            ExpiryDatetxt.Properties.Appearance.Options.UseFont = true;
            ExpiryDatetxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ExpiryDatetxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ExpiryDatetxt.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            ExpiryDatetxt.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            ExpiryDatetxt.Size = new Size(292, 34);
            ExpiryDatetxt.TabIndex = 17;
            ExpiryDatetxt.KeyDown += ExpiryDatetxt_KeyDown;
            // 
            // btnForm
            // 
            btnForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnForm.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnForm.ImageOptions.SvgImage");
            btnForm.ImageOptions.SvgImageSize = new Size(25, 25);
            btnForm.Location = new Point(0, 0);
            btnForm.Margin = new Padding(0);
            btnForm.Name = "btnForm";
            btnForm.RightToLeft = RightToLeft.Yes;
            btnForm.Size = new Size(38, 40);
            btnForm.TabIndex = 77;
            btnForm.ToolTipTitle = "اضافة";
            btnForm.Click += btnForm_Click;
            // 
            // MinimumStockLeveltxt
            // 
            MinimumStockLeveltxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimumStockLeveltxt.BackColor = Color.FromArgb(232, 246, 255);
            MinimumStockLeveltxt.Font = new Font("Cairo Medium", 10F);
            MinimumStockLeveltxt.Location = new Point(3, 47);
            MinimumStockLeveltxt.Name = "MinimumStockLeveltxt";
            MinimumStockLeveltxt.PlaceholderText = "الحد الأدنى للتنبيه";
            MinimumStockLeveltxt.Size = new Size(292, 39);
            MinimumStockLeveltxt.TabIndex = 6;
            MinimumStockLeveltxt.KeyDown += MinimumStockLeveltxt_KeyDown;
            // 
            // QuantityInStocktxt
            // 
            QuantityInStocktxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QuantityInStocktxt.BackColor = Color.FromArgb(232, 246, 255);
            QuantityInStocktxt.Font = new Font("Cairo Medium", 10F);
            QuantityInStocktxt.Location = new Point(3, 3);
            QuantityInStocktxt.Name = "QuantityInStocktxt";
            QuantityInStocktxt.PlaceholderText = "كمية المتوفرة";
            QuantityInStocktxt.Size = new Size(292, 39);
            QuantityInStocktxt.TabIndex = 5;
            QuantityInStocktxt.KeyDown += QuantityInStocktxt_KeyDown;
            // 
            // Suppliertxt
            // 
            Suppliertxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Suppliertxt.FlatStyle = FlatStyle.System;
            Suppliertxt.Font = new Font("Cairo Medium", 10F);
            Suppliertxt.FormattingEnabled = true;
            Suppliertxt.Location = new Point(3, 140);
            Suppliertxt.Name = "Suppliertxt";
            Suppliertxt.Size = new Size(292, 40);
            Suppliertxt.TabIndex = 8;
            Suppliertxt.KeyDown += Suppliertxt_KeyDown;
            // 
            // Discounttxt
            // 
            Discounttxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Discounttxt.BackColor = Color.FromArgb(232, 246, 255);
            Discounttxt.Font = new Font("Cairo Medium", 10F);
            Discounttxt.Location = new Point(3, 326);
            Discounttxt.Name = "Discounttxt";
            Discounttxt.RightToLeft = RightToLeft.No;
            Discounttxt.Size = new Size(292, 39);
            Discounttxt.TabIndex = 16;
            Discounttxt.Text = "0";
            Discounttxt.TextAlign = HorizontalAlignment.Center;
            Discounttxt.KeyDown += Discounttxt_KeyDown;
            // 
            // SalePricetxt
            // 
            SalePricetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SalePricetxt.BackColor = Color.FromArgb(232, 246, 255);
            SalePricetxt.Font = new Font("Cairo Medium", 10F);
            SalePricetxt.Location = new Point(3, 279);
            SalePricetxt.Name = "SalePricetxt";
            SalePricetxt.RightToLeft = RightToLeft.No;
            SalePricetxt.Size = new Size(292, 39);
            SalePricetxt.TabIndex = 15;
            SalePricetxt.Text = "0";
            SalePricetxt.TextAlign = HorizontalAlignment.Center;
            SalePricetxt.KeyDown += SalePricetxt_KeyDown;
            SalePricetxt.KeyPress += SalePricetxt_KeyPress;
            SalePricetxt.Leave += SalePricetxt_Leave;
            // 
            // PurchasePricetxt
            // 
            PurchasePricetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PurchasePricetxt.BackColor = Color.FromArgb(232, 246, 255);
            PurchasePricetxt.Font = new Font("Cairo Medium", 10F);
            PurchasePricetxt.Location = new Point(3, 236);
            PurchasePricetxt.Name = "PurchasePricetxt";
            PurchasePricetxt.RightToLeft = RightToLeft.No;
            PurchasePricetxt.Size = new Size(292, 39);
            PurchasePricetxt.TabIndex = 14;
            PurchasePricetxt.Text = "0";
            PurchasePricetxt.TextAlign = HorizontalAlignment.Center;
            PurchasePricetxt.KeyDown += PurchasePricetxt_KeyDown;
            PurchasePricetxt.KeyPress += PurchasePricetxt_KeyPress;
            PurchasePricetxt.Leave += PurchasePricetxt_Leave;
            // 
            // BatchNumbertxt
            // 
            BatchNumbertxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BatchNumbertxt.BackColor = Color.FromArgb(232, 246, 255);
            BatchNumbertxt.Font = new Font("Cairo Medium", 10F);
            BatchNumbertxt.Location = new Point(3, 93);
            BatchNumbertxt.Name = "BatchNumbertxt";
            BatchNumbertxt.PlaceholderText = "رقم الدفعة";
            BatchNumbertxt.Size = new Size(292, 39);
            BatchNumbertxt.TabIndex = 7;
            BatchNumbertxt.KeyDown += BatchNumbertxt_KeyDown;
            // 
            // Manufacturertxt
            // 
            Manufacturertxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Manufacturertxt.BackColor = Color.FromArgb(232, 246, 255);
            Manufacturertxt.Font = new Font("Cairo Medium", 10F);
            Manufacturertxt.Location = new Point(510, 140);
            Manufacturertxt.Name = "Manufacturertxt";
            Manufacturertxt.PlaceholderText = "الشركة المصنعة";
            Manufacturertxt.Size = new Size(292, 39);
            Manufacturertxt.TabIndex = 4;
            Manufacturertxt.KeyDown += Manufacturertxt_KeyDown;
            // 
            // GenericNametxt
            // 
            GenericNametxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GenericNametxt.BackColor = Color.FromArgb(232, 246, 255);
            GenericNametxt.Font = new Font("Cairo Medium", 10F);
            GenericNametxt.Location = new Point(510, 93);
            GenericNametxt.Name = "GenericNametxt";
            GenericNametxt.PlaceholderText = "الاسم العلمي";
            GenericNametxt.Size = new Size(292, 39);
            GenericNametxt.TabIndex = 3;
            GenericNametxt.KeyDown += GenericNametxt_KeyDown;
            // 
            // Nametxt
            // 
            Nametxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Nametxt.BackColor = Color.FromArgb(232, 246, 255);
            Nametxt.Font = new Font("Cairo Medium", 10F);
            Nametxt.Location = new Point(510, 47);
            Nametxt.Name = "Nametxt";
            Nametxt.PlaceholderText = "اسم الدواء";
            Nametxt.Size = new Size(292, 39);
            Nametxt.TabIndex = 2;
            Nametxt.KeyDown += Nametxt_KeyDown;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Cairo Medium", 10F);
            label17.Location = new Point(307, 323);
            label17.Name = "label17";
            label17.Size = new Size(113, 32);
            label17.TabIndex = 54;
            label17.Text = "نسبة الخصم %";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Cairo Medium", 10F);
            label15.Location = new Point(307, 184);
            label15.Name = "label15";
            label15.Size = new Size(104, 32);
            label15.TabIndex = 52;
            label15.Text = "مكان التخزين";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Cairo Medium", 10F);
            label12.Location = new Point(307, 369);
            label12.Name = "label12";
            label12.Size = new Size(179, 32);
            label12.TabIndex = 49;
            label12.Text = "هل يتطلب وصفة طبية؟";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Cairo Medium", 10F);
            label11.Location = new Point(307, 137);
            label11.Name = "label11";
            label11.Size = new Size(116, 32);
            label11.TabIndex = 48;
            label11.Text = "المورد الرئيسي";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Cairo Medium", 10F);
            label10.Location = new Point(307, 90);
            label10.Name = "label10";
            label10.Size = new Size(94, 32);
            label10.TabIndex = 47;
            label10.Text = "رقم الدفعة";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Cairo Medium", 10F);
            label8.Location = new Point(307, 44);
            label8.Name = "label8";
            label8.Size = new Size(135, 32);
            label8.TabIndex = 45;
            label8.Text = "الحد الأدنى للتنبيه";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Cairo Medium", 10F);
            label7.Location = new Point(307, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 32);
            label7.TabIndex = 44;
            label7.Text = "كمية المتوفرة";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Cairo Medium", 10F);
            label4.Location = new Point(307, 233);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 42;
            label4.Text = "سعر الشراء";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.ealthcare;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 558);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // IsActivetxt
            // 
            IsActivetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IsActivetxt.EditValue = true;
            IsActivetxt.Location = new Point(3, 415);
            IsActivetxt.Name = "IsActivetxt";
            IsActivetxt.Properties.OffText = "غير نشط";
            IsActivetxt.Properties.OnText = "نشط";
            IsActivetxt.Size = new Size(119, 24);
            IsActivetxt.TabIndex = 39;
            // 
            // PicChange
            // 
            PicChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PicChange.BackColor = Color.Silver;
            PicChange.Cursor = Cursors.Hand;
            PicChange.Image = Properties.Resources.product;
            PicChange.Location = new Point(287, 3);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(144, 127);
            PicChange.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChange.TabIndex = 32;
            PicChange.TabStop = false;
            PicChange.Click += PicChange_Click;
            // 
            // Notestxt
            // 
            Notestxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Notestxt.Font = new Font("Cairo Medium", 10F);
            Notestxt.Location = new Point(510, 463);
            Notestxt.Multiline = true;
            Notestxt.Name = "Notestxt";
            Notestxt.PlaceholderText = "ملاحظات إضافية";
            Notestxt.Size = new Size(295, 160);
            Notestxt.TabIndex = 19;
            // 
            // Barcodetxt
            // 
            Barcodetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Barcodetxt.BackColor = Color.FromArgb(232, 246, 255);
            Barcodetxt.Font = new Font("Cairo Medium", 10F);
            Barcodetxt.Location = new Point(510, 3);
            Barcodetxt.Name = "Barcodetxt";
            Barcodetxt.PlaceholderText = "باركود الدواء";
            Barcodetxt.Size = new Size(292, 39);
            Barcodetxt.TabIndex = 1;
            Barcodetxt.KeyDown += Barcodetxt_KeyDown;
            // 
            // lblSupplierNotes
            // 
            lblSupplierNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierNotes.AutoSize = true;
            lblSupplierNotes.BackColor = Color.White;
            lblSupplierNotes.Font = new Font("Cairo Medium", 10F);
            lblSupplierNotes.Location = new Point(307, 276);
            lblSupplierNotes.Name = "lblSupplierNotes";
            lblSupplierNotes.Size = new Size(79, 32);
            lblSupplierNotes.TabIndex = 35;
            lblSupplierNotes.Text = "سعر البيع";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(0, 719);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 53;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.9381447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0618553F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 203F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 303F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 1, 7);
            tableLayoutPanel1.Controls.Add(buttonSaveSup, 3, 10);
            tableLayoutPanel1.Controls.Add(LocationInStoretxt, 3, 4);
            tableLayoutPanel1.Controls.Add(label20, 2, 9);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 6);
            tableLayoutPanel1.Controls.Add(RequiresPrescriptiontxt, 3, 8);
            tableLayoutPanel1.Controls.Add(IsActivetxt, 3, 9);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 5);
            tableLayoutPanel1.Controls.Add(label16, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 4);
            tableLayoutPanel1.Controls.Add(label12, 2, 8);
            tableLayoutPanel1.Controls.Add(Discounttxt, 3, 7);
            tableLayoutPanel1.Controls.Add(Barcodetxt, 1, 0);
            tableLayoutPanel1.Controls.Add(label17, 2, 7);
            tableLayoutPanel1.Controls.Add(SalePricetxt, 3, 6);
            tableLayoutPanel1.Controls.Add(DateAddedtxt, 1, 9);
            tableLayoutPanel1.Controls.Add(PurchasePricetxt, 3, 5);
            tableLayoutPanel1.Controls.Add(Suppliertxt, 3, 3);
            tableLayoutPanel1.Controls.Add(MinimumStockLeveltxt, 3, 1);
            tableLayoutPanel1.Controls.Add(lblSupplierName, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 5);
            tableLayoutPanel1.Controls.Add(lblSupplierNotes, 2, 6);
            tableLayoutPanel1.Controls.Add(QuantityInStocktxt, 3, 0);
            tableLayoutPanel1.Controls.Add(label15, 2, 4);
            tableLayoutPanel1.Controls.Add(lblSupplierAddress, 0, 2);
            tableLayoutPanel1.Controls.Add(BatchNumbertxt, 3, 2);
            tableLayoutPanel1.Controls.Add(lblSupplierPhone, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(label11, 2, 3);
            tableLayoutPanel1.Controls.Add(lblSupplierEmail, 0, 5);
            tableLayoutPanel1.Controls.Add(label14, 0, 10);
            tableLayoutPanel1.Controls.Add(label3, 0, 6);
            tableLayoutPanel1.Controls.Add(label10, 2, 2);
            tableLayoutPanel1.Controls.Add(label13, 0, 9);
            tableLayoutPanel1.Controls.Add(label5, 0, 7);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(Nametxt, 1, 1);
            tableLayoutPanel1.Controls.Add(GenericNametxt, 1, 2);
            tableLayoutPanel1.Controls.Add(Manufacturertxt, 1, 3);
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(ExpiryDatetxt, 1, 8);
            tableLayoutPanel1.Controls.Add(Notestxt, 1, 10);
            tableLayoutPanel1.Location = new Point(437, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.54369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.45631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 174F));
            tableLayoutPanel1.Size = new Size(992, 635);
            tableLayoutPanel1.TabIndex = 92;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(Unitetxt);
            flowLayoutPanel4.Controls.Add(btnUnite);
            flowLayoutPanel4.Location = new Point(517, 323);
            flowLayoutPanel4.Margin = new Padding(0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(291, 43);
            flowLayoutPanel4.TabIndex = 93;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(Categorytxt);
            flowLayoutPanel3.Controls.Add(btnCategory);
            flowLayoutPanel3.Location = new Point(515, 276);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(293, 45);
            flowLayoutPanel3.TabIndex = 93;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(Strengthtxt);
            flowLayoutPanel2.Controls.Add(btnStrength);
            flowLayoutPanel2.Location = new Point(520, 233);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(288, 40);
            flowLayoutPanel2.TabIndex = 94;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(MedicineTypetxt);
            flowLayoutPanel1.Controls.Add(btnForm);
            flowLayoutPanel1.Location = new Point(522, 187);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(283, 40);
            flowLayoutPanel1.TabIndex = 93;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.White;
            flowLayoutPanel5.Controls.Add(pictureBox3);
            flowLayoutPanel5.Controls.Add(separatorControl1);
            flowLayoutPanel5.Controls.Add(label1);
            flowLayoutPanel5.Dock = DockStyle.Top;
            flowLayoutPanel5.Location = new Point(0, 0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(1432, 75);
            flowLayoutPanel5.TabIndex = 54;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel6.Controls.Add(PicChange);
            flowLayoutPanel6.Controls.Add(pictureBox1);
            flowLayoutPanel6.Dock = DockStyle.Top;
            flowLayoutPanel6.Location = new Point(0, 75);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(1432, 638);
            flowLayoutPanel6.TabIndex = 55;
            // 
            // MedicationAddForm
            // 
            Appearance.BackColor = Color.FromArgb(212, 220, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 760);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MedicationAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicAddForm";
            MouseDown += MedicAddForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateAddedtxt.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateAddedtxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)RequiresPrescriptiontxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)IsActivetxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.ToggleSwitch IsActivetxt;
        private PictureBox PicChange;
        private TextBox Notestxt;
        public DevExpress.XtraEditors.SimpleButton buttonSaveSup;
        private TextBox Barcodetxt;
        private Label lblSupplierNotes;
        private Label lblSupplierName;
        private Label lblSupplierAddress;
        private Label lblSupplierEmail;
        private Label lblSupplierPhone;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label13;
        private Label label14;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox Discounttxt;
        private TextBox SalePricetxt;
        private TextBox PurchasePricetxt;
        private TextBox BatchNumbertxt;
        private TextBox Manufacturertxt;
        private TextBox GenericNametxt;
        private TextBox Nametxt;
        private ComboBox Suppliertxt;
        private DevExpress.XtraEditors.DateEdit ExpiryDatetxt;
        private DevExpress.XtraEditors.SimpleButton btnForm;
        private TextBox MinimumStockLeveltxt;
        private TextBox QuantityInStocktxt;
        private Label label20;
        private DevExpress.XtraEditors.ToggleSwitch RequiresPrescriptiontxt;
        private DevExpress.XtraEditors.SimpleButton btnUnite;
        private DevExpress.XtraEditors.SimpleButton btnCategory;
        private DevExpress.XtraEditors.SimpleButton btnStrength;
        private ComboBox Unitetxt;
        private ComboBox Categorytxt;
        private ComboBox Strengthtxt;
        private ComboBox MedicineTypetxt;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private TextBox LocationInStoretxt;
        private DevExpress.XtraEditors.DateEdit DateAddedtxt;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
    }
}