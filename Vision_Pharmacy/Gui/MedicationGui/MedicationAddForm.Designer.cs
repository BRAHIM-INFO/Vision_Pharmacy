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
            panel1 = new Panel();
            label1 = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
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
            label19 = new Label();
            label18 = new Label();
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
            label6 = new Label();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DateAddedtxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateAddedtxt.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RequiresPrescriptiontxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IsActivetxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(31, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1342, 70);
            panel1.TabIndex = 17;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo Medium", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(831, 18);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(413, 37);
            label1.TabIndex = 18;
            label1.Text = "ادارة المخزون > قائمة الأدوية > اظافة دواء جديد";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1252, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = Properties.Resources.pill_bottle_15968729;
            pictureBox3.Location = new Point(1262, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LocationInStoretxt);
            panel2.Controls.Add(DateAddedtxt);
            panel2.Controls.Add(Unitetxt);
            panel2.Controls.Add(Categorytxt);
            panel2.Controls.Add(Strengthtxt);
            panel2.Controls.Add(MedicineTypetxt);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblSupplierName);
            panel2.Controls.Add(lblSupplierAddress);
            panel2.Controls.Add(lblSupplierEmail);
            panel2.Controls.Add(lblSupplierPhone);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnUnite);
            panel2.Controls.Add(btnCategory);
            panel2.Controls.Add(btnStrength);
            panel2.Controls.Add(buttonSaveSup);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(RequiresPrescriptiontxt);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(ExpiryDatetxt);
            panel2.Controls.Add(btnForm);
            panel2.Controls.Add(MinimumStockLeveltxt);
            panel2.Controls.Add(QuantityInStocktxt);
            panel2.Controls.Add(Suppliertxt);
            panel2.Controls.Add(Discounttxt);
            panel2.Controls.Add(SalePricetxt);
            panel2.Controls.Add(PurchasePricetxt);
            panel2.Controls.Add(BatchNumbertxt);
            panel2.Controls.Add(Manufacturertxt);
            panel2.Controls.Add(GenericNametxt);
            panel2.Controls.Add(Nametxt);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(IsActivetxt);
            panel2.Controls.Add(PicChange);
            panel2.Controls.Add(Notestxt);
            panel2.Controls.Add(Barcodetxt);
            panel2.Controls.Add(lblSupplierNotes);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(31, 126);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(1342, 626);
            panel2.TabIndex = 41;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // LocationInStoretxt
            // 
            LocationInStoretxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LocationInStoretxt.BackColor = Color.FromArgb(232, 246, 255);
            LocationInStoretxt.Font = new Font("Cairo Medium", 10F);
            LocationInStoretxt.Location = new Point(373, 195);
            LocationInStoretxt.Name = "LocationInStoretxt";
            LocationInStoretxt.PlaceholderText = "مكان التخزين";
            LocationInStoretxt.Size = new Size(292, 39);
            LocationInStoretxt.TabIndex = 13;
            LocationInStoretxt.KeyDown += LocationInStoretxt_KeyDown;
            // 
            // DateAddedtxt
            // 
            DateAddedtxt.EditValue = null;
            DateAddedtxt.Location = new Point(882, 417);
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
            Unitetxt.FlatStyle = FlatStyle.System;
            Unitetxt.Font = new Font("Cairo Medium", 10F);
            Unitetxt.FormattingEnabled = true;
            Unitetxt.Location = new Point(927, 333);
            Unitetxt.Name = "Unitetxt";
            Unitetxt.Size = new Size(248, 40);
            Unitetxt.TabIndex = 12;
            Unitetxt.KeyDown += Unitetxt_KeyDown;
            // 
            // Categorytxt
            // 
            Categorytxt.FlatStyle = FlatStyle.System;
            Categorytxt.Font = new Font("Cairo Medium", 10F);
            Categorytxt.FormattingEnabled = true;
            Categorytxt.Location = new Point(927, 287);
            Categorytxt.Name = "Categorytxt";
            Categorytxt.Size = new Size(248, 40);
            Categorytxt.TabIndex = 11;
            Categorytxt.KeyDown += Categorytxt_KeyDown;
            // 
            // Strengthtxt
            // 
            Strengthtxt.FlatStyle = FlatStyle.System;
            Strengthtxt.Font = new Font("Cairo Medium", 10F);
            Strengthtxt.FormattingEnabled = true;
            Strengthtxt.Location = new Point(927, 241);
            Strengthtxt.Name = "Strengthtxt";
            Strengthtxt.Size = new Size(248, 40);
            Strengthtxt.TabIndex = 10;
            Strengthtxt.KeyDown += Strengthtxt_KeyDown;
            // 
            // MedicineTypetxt
            // 
            MedicineTypetxt.FlatStyle = FlatStyle.System;
            MedicineTypetxt.Font = new Font("Cairo Medium", 10F);
            MedicineTypetxt.FormattingEnabled = true;
            MedicineTypetxt.Location = new Point(927, 195);
            MedicineTypetxt.Name = "MedicineTypetxt";
            MedicineTypetxt.Size = new Size(248, 40);
            MedicineTypetxt.TabIndex = 9;
            MedicineTypetxt.KeyDown += MedicineTypetxt_KeyDown;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Cairo Medium", 10F);
            label16.Location = new Point(1189, 15);
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
            label14.Location = new Point(1189, 461);
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
            label13.Location = new Point(1184, 420);
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
            label5.Location = new Point(1189, 331);
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
            label3.Location = new Point(1189, 283);
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
            label2.Location = new Point(1189, 195);
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
            lblSupplierName.Location = new Point(1189, 64);
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
            lblSupplierAddress.Location = new Point(1189, 109);
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
            lblSupplierEmail.Location = new Point(1189, 238);
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
            lblSupplierPhone.Location = new Point(1189, 154);
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
            label9.Location = new Point(1184, 379);
            label9.Name = "label9";
            label9.Size = new Size(155, 32);
            label9.TabIndex = 46;
            label9.Text = "تاريخ انتهاء الصلاحية";
            // 
            // btnUnite
            // 
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
            btnUnite.Location = new Point(882, 333);
            btnUnite.Name = "btnUnite";
            btnUnite.RightToLeft = RightToLeft.Yes;
            btnUnite.Size = new Size(38, 40);
            btnUnite.TabIndex = 91;
            btnUnite.ToolTipTitle = "اضافة";
            btnUnite.Click += btnUnite_Click;
            // 
            // btnCategory
            // 
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
            btnCategory.Location = new Point(882, 287);
            btnCategory.Name = "btnCategory";
            btnCategory.RightToLeft = RightToLeft.Yes;
            btnCategory.Size = new Size(38, 40);
            btnCategory.TabIndex = 90;
            btnCategory.ToolTipTitle = "اضافة";
            btnCategory.Click += btnCategory_Click;
            // 
            // btnStrength
            // 
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
            btnStrength.Location = new Point(882, 241);
            btnStrength.Name = "btnStrength";
            btnStrength.RightToLeft = RightToLeft.Yes;
            btnStrength.Size = new Size(38, 40);
            btnStrength.TabIndex = 89;
            btnStrength.ToolTipTitle = "اضافة";
            btnStrength.Click += btnStrength_Click;
            // 
            // buttonSaveSup
            // 
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
            buttonSaveSup.Location = new Point(373, 575);
            buttonSaveSup.Name = "buttonSaveSup";
            buttonSaveSup.RightToLeft = RightToLeft.Yes;
            buttonSaveSup.Size = new Size(159, 45);
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
            label20.Location = new Point(669, 412);
            label20.Name = "label20";
            label20.Size = new Size(132, 32);
            label20.TabIndex = 84;
            label20.Text = "هل الدواء نشط؟";
            // 
            // RequiresPrescriptiontxt
            // 
            RequiresPrescriptiontxt.EditValue = true;
            RequiresPrescriptiontxt.Location = new Point(543, 380);
            RequiresPrescriptiontxt.Name = "RequiresPrescriptiontxt";
            RequiresPrescriptiontxt.Properties.OffText = "لا";
            RequiresPrescriptiontxt.Properties.OnText = "نعم";
            RequiresPrescriptiontxt.Size = new Size(119, 24);
            RequiresPrescriptiontxt.TabIndex = 83;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.BackColor = Color.White;
            label19.Font = new Font("Cairo Medium", 10F);
            label19.Location = new Point(373, 334);
            label19.Name = "label19";
            label19.Size = new Size(24, 32);
            label19.TabIndex = 82;
            label19.Text = "%";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Cairo Medium", 10F);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(1175, 18);
            label18.Name = "label18";
            label18.Size = new Size(21, 32);
            label18.TabIndex = 80;
            label18.Text = "*";
            // 
            // ExpiryDatetxt
            // 
            ExpiryDatetxt.EditValue = null;
            ExpiryDatetxt.Location = new Point(882, 378);
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
            btnForm.Location = new Point(882, 195);
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
            MinimumStockLeveltxt.Location = new Point(373, 60);
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
            QuantityInStocktxt.Location = new Point(373, 15);
            QuantityInStocktxt.Name = "QuantityInStocktxt";
            QuantityInStocktxt.PlaceholderText = "كمية المتوفرة";
            QuantityInStocktxt.Size = new Size(292, 39);
            QuantityInStocktxt.TabIndex = 5;
            QuantityInStocktxt.KeyDown += QuantityInStocktxt_KeyDown;
            // 
            // Suppliertxt
            // 
            Suppliertxt.FlatStyle = FlatStyle.System;
            Suppliertxt.Font = new Font("Cairo Medium", 10F);
            Suppliertxt.FormattingEnabled = true;
            Suppliertxt.Location = new Point(373, 149);
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
            Discounttxt.Location = new Point(401, 330);
            Discounttxt.Name = "Discounttxt";
            Discounttxt.RightToLeft = RightToLeft.No;
            Discounttxt.Size = new Size(264, 39);
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
            SalePricetxt.Location = new Point(373, 285);
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
            PurchasePricetxt.Location = new Point(373, 240);
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
            BatchNumbertxt.Location = new Point(373, 105);
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
            Manufacturertxt.Location = new Point(882, 150);
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
            GenericNametxt.Location = new Point(882, 105);
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
            Nametxt.Location = new Point(882, 60);
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
            label17.Location = new Point(672, 337);
            label17.Name = "label17";
            label17.Size = new Size(99, 32);
            label17.TabIndex = 54;
            label17.Text = "نسبة الخصم";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Cairo Medium", 10F);
            label15.Location = new Point(672, 202);
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
            label12.Location = new Point(669, 375);
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
            label11.Location = new Point(672, 157);
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
            label10.Location = new Point(672, 113);
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
            label8.Location = new Point(672, 66);
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
            label7.Location = new Point(672, 22);
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
            label4.Location = new Point(672, 247);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 42;
            label4.Text = "سعر الشراء";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.ealthcare;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 626);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // IsActivetxt
            // 
            IsActivetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IsActivetxt.EditValue = true;
            IsActivetxt.Location = new Point(543, 420);
            IsActivetxt.Name = "IsActivetxt";
            IsActivetxt.Properties.OffText = "غير نشط";
            IsActivetxt.Properties.OnText = "نشط";
            IsActivetxt.Size = new Size(119, 24);
            IsActivetxt.TabIndex = 39;
            // 
            // PicChange
            // 
            PicChange.BackColor = Color.Silver;
            PicChange.Cursor = Cursors.Hand;
            PicChange.Image = Properties.Resources.product;
            PicChange.Location = new Point(209, 18);
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
            Notestxt.Location = new Point(373, 462);
            Notestxt.Multiline = true;
            Notestxt.Name = "Notestxt";
            Notestxt.PlaceholderText = "ملاحظات إضافية";
            Notestxt.Size = new Size(801, 107);
            Notestxt.TabIndex = 19;
            // 
            // Barcodetxt
            // 
            Barcodetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Barcodetxt.BackColor = Color.FromArgb(232, 246, 255);
            Barcodetxt.Font = new Font("Cairo Medium", 10F);
            Barcodetxt.Location = new Point(882, 15);
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
            lblSupplierNotes.Location = new Point(672, 292);
            lblSupplierNotes.Name = "lblSupplierNotes";
            lblSupplierNotes.Size = new Size(79, 32);
            lblSupplierNotes.TabIndex = 35;
            lblSupplierNotes.Text = "سعر البيع";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cairo Medium", 10F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(1175, 64);
            label6.Name = "label6";
            label6.Size = new Size(21, 32);
            label6.TabIndex = 27;
            label6.Text = "*";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(31, 753);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 53;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // MedicationAddForm
            // 
            Appearance.BackColor = Color.FromArgb(212, 220, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 798);
            Controls.Add(btnClose);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MedicationAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicAddForm";
            MouseDown += MedicAddForm_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DateAddedtxt.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateAddedtxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)RequiresPrescriptiontxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)IsActivetxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.ToggleSwitch IsActivetxt;
        private PictureBox PicChange;
        private TextBox Notestxt;
        public DevExpress.XtraEditors.SimpleButton buttonSaveSup;
        private TextBox Barcodetxt;
        private Label lblSupplierNotes;
        private Label lblSupplierName;
        private Label lblSupplierAddress;
        private Label label6;
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
        private Label label18;
        private Label label20;
        private DevExpress.XtraEditors.ToggleSwitch RequiresPrescriptiontxt;
        private Label label19;
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
    }
}