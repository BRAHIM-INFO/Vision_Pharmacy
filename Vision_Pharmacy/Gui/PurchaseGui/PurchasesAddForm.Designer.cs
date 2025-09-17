using Vision_Pharmacy.Properties;

namespace Vision_Pharmacy.Gui.PurchaseGui
{
    partial class PurchasesAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesAddForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblSupForm = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            panel2 = new Panel();
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
            label18 = new Label();
            Manufacturertxt = new TextBox();
            GenericNametxt = new TextBox();
            Nametxt = new TextBox();
            Barcodetxt = new TextBox();
            label5 = new Label();
            btnForm = new DevExpress.XtraEditors.SimpleButton();
            txtTypePaimt = new ComboBox();
            label4 = new Label();
            txtSupplier = new ComboBox();
            label3 = new Label();
            txtPurchaseDate = new DevExpress.XtraEditors.DateEdit();
            label1 = new Label();
            lblEmpEmail = new Label();
            label2 = new Label();
            txtFactureNum = new TextBox();
            panel5 = new Panel();
            DGListeCustomer = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel6 = new Panel();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            separatorControl22 = new DevExpress.XtraEditors.SeparatorControl();
            txtTotalAmount = new TextBox();
            label6 = new Label();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties.CalendarTimeProperties).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGListeCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl22).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblSupForm);
            panel1.Controls.Add(separatorControl1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1427, 55);
            panel1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = Resources.drugstore_17347470;
            pictureBox2.Location = new Point(1345, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblSupForm
            // 
            lblSupForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupForm.AutoSize = true;
            lblSupForm.Font = new Font("Cairo Medium", 12F);
            lblSupForm.ForeColor = Color.Black;
            lblSupForm.Location = new Point(1010, 12);
            lblSupForm.Name = "lblSupForm";
            lblSupForm.Size = new Size(332, 37);
            lblSupForm.TabIndex = 1;
            lblSupForm.Text = "ادارة المشتريات >  اضافة فاتورة جديدة";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1417, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 55);
            separatorControl1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label14);
            panel2.Controls.Add(ExpiryDatetxt);
            panel2.Controls.Add(LocationInStoretxt);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(BatchNumbertxt);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(MinimumStockLeveltxt);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(QuantityInStocktxt);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(SalePricetxt);
            panel2.Controls.Add(PurchasePricetxt);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblSupplierNotes);
            panel2.Controls.Add(Unitetxt);
            panel2.Controls.Add(Categorytxt);
            panel2.Controls.Add(Strengthtxt);
            panel2.Controls.Add(MedicineTypetxt);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblSupplierEmail);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(lblSupplierName);
            panel2.Controls.Add(lblSupplierAddress);
            panel2.Controls.Add(lblSupplierPhone);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(Manufacturertxt);
            panel2.Controls.Add(GenericNametxt);
            panel2.Controls.Add(Nametxt);
            panel2.Controls.Add(Barcodetxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnForm);
            panel2.Controls.Add(txtTypePaimt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtSupplier);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPurchaseDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblEmpEmail);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtFactureNum);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(1427, 195);
            panel2.TabIndex = 61;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Cairo Medium", 9F);
            label14.Location = new Point(205, 106);
            label14.Name = "label14";
            label14.Size = new Size(105, 29);
            label14.TabIndex = 115;
            label14.Text = "انتهاء الصلاحية";
            // 
            // ExpiryDatetxt
            // 
            ExpiryDatetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExpiryDatetxt.EditValue = null;
            ExpiryDatetxt.Location = new Point(23, 95);
            ExpiryDatetxt.Name = "ExpiryDatetxt";
            ExpiryDatetxt.Properties.Appearance.Font = new Font("Tahoma", 13F);
            ExpiryDatetxt.Properties.Appearance.Options.UseFont = true;
            ExpiryDatetxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ExpiryDatetxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ExpiryDatetxt.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            ExpiryDatetxt.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            ExpiryDatetxt.Size = new Size(176, 34);
            ExpiryDatetxt.TabIndex = 114;
            // 
            // LocationInStoretxt
            // 
            LocationInStoretxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LocationInStoretxt.BackColor = Color.FromArgb(232, 246, 255);
            LocationInStoretxt.Font = new Font("Cairo Medium", 9F);
            LocationInStoretxt.Location = new Point(23, 53);
            LocationInStoretxt.Name = "LocationInStoretxt";
            LocationInStoretxt.PlaceholderText = "مكان التخزين";
            LocationInStoretxt.Size = new Size(176, 36);
            LocationInStoretxt.TabIndex = 111;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnAdd.Location = new Point(23, 134);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(176, 45);
            btnAdd.TabIndex = 82;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            // 
            // BatchNumbertxt
            // 
            BatchNumbertxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BatchNumbertxt.BackColor = Color.FromArgb(232, 246, 255);
            BatchNumbertxt.Font = new Font("Cairo Medium", 9F);
            BatchNumbertxt.Location = new Point(23, 10);
            BatchNumbertxt.Name = "BatchNumbertxt";
            BatchNumbertxt.PlaceholderText = "رقم الدفعة";
            BatchNumbertxt.Size = new Size(176, 36);
            BatchNumbertxt.TabIndex = 110;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Cairo Medium", 9F);
            label15.Location = new Point(219, 60);
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
            label13.Location = new Point(230, 15);
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
            MinimumStockLeveltxt.Location = new Point(316, 141);
            MinimumStockLeveltxt.Name = "MinimumStockLeveltxt";
            MinimumStockLeveltxt.PlaceholderText = "الحد الأدنى";
            MinimumStockLeveltxt.Size = new Size(139, 36);
            MinimumStockLeveltxt.TabIndex = 108;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Cairo Medium", 9F);
            label12.Location = new Point(452, 146);
            label12.Name = "label12";
            label12.Size = new Size(79, 29);
            label12.TabIndex = 109;
            label12.Text = "الحد الأدنى";
            // 
            // QuantityInStocktxt
            // 
            QuantityInStocktxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QuantityInStocktxt.BackColor = Color.FromArgb(232, 246, 255);
            QuantityInStocktxt.Font = new Font("Cairo Medium", 9F);
            QuantityInStocktxt.Location = new Point(316, 99);
            QuantityInStocktxt.Name = "QuantityInStocktxt";
            QuantityInStocktxt.PlaceholderText = "الكمية";
            QuantityInStocktxt.Size = new Size(139, 36);
            QuantityInStocktxt.TabIndex = 106;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Cairo Medium", 9F);
            label11.Location = new Point(473, 102);
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
            SalePricetxt.Location = new Point(316, 53);
            SalePricetxt.Name = "SalePricetxt";
            SalePricetxt.RightToLeft = RightToLeft.No;
            SalePricetxt.Size = new Size(139, 36);
            SalePricetxt.TabIndex = 103;
            SalePricetxt.Text = "0";
            SalePricetxt.TextAlign = HorizontalAlignment.Center;
            // 
            // PurchasePricetxt
            // 
            PurchasePricetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PurchasePricetxt.BackColor = Color.FromArgb(232, 246, 255);
            PurchasePricetxt.Font = new Font("Cairo Medium", 9F);
            PurchasePricetxt.Location = new Point(316, 9);
            PurchasePricetxt.Name = "PurchasePricetxt";
            PurchasePricetxt.RightToLeft = RightToLeft.No;
            PurchasePricetxt.Size = new Size(139, 36);
            PurchasePricetxt.TabIndex = 102;
            PurchasePricetxt.Text = "0";
            PurchasePricetxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Cairo Medium", 9F);
            label10.Location = new Point(452, 16);
            label10.Name = "label10";
            label10.Size = new Size(81, 29);
            label10.TabIndex = 105;
            label10.Text = "سعر الشراء";
            // 
            // lblSupplierNotes
            // 
            lblSupplierNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierNotes.AutoSize = true;
            lblSupplierNotes.BackColor = Color.White;
            lblSupplierNotes.Font = new Font("Cairo Medium", 9F);
            lblSupplierNotes.Location = new Point(461, 60);
            lblSupplierNotes.Name = "lblSupplierNotes";
            lblSupplierNotes.Size = new Size(72, 29);
            lblSupplierNotes.TabIndex = 104;
            lblSupplierNotes.Text = "سعر البيع";
            // 
            // Unitetxt
            // 
            Unitetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Unitetxt.BackColor = Color.FromArgb(232, 246, 255);
            Unitetxt.FlatStyle = FlatStyle.System;
            Unitetxt.Font = new Font("Cairo Medium", 9F);
            Unitetxt.FormattingEnabled = true;
            Unitetxt.Location = new Point(534, 140);
            Unitetxt.Name = "Unitetxt";
            Unitetxt.Size = new Size(169, 37);
            Unitetxt.TabIndex = 97;
            // 
            // Categorytxt
            // 
            Categorytxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Categorytxt.BackColor = Color.FromArgb(232, 246, 255);
            Categorytxt.FlatStyle = FlatStyle.System;
            Categorytxt.Font = new Font("Cairo Medium", 9F);
            Categorytxt.FormattingEnabled = true;
            Categorytxt.Location = new Point(534, 52);
            Categorytxt.Name = "Categorytxt";
            Categorytxt.Size = new Size(169, 37);
            Categorytxt.TabIndex = 96;
            // 
            // Strengthtxt
            // 
            Strengthtxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Strengthtxt.BackColor = Color.FromArgb(232, 246, 255);
            Strengthtxt.FlatStyle = FlatStyle.System;
            Strengthtxt.Font = new Font("Cairo Medium", 9F);
            Strengthtxt.FormattingEnabled = true;
            Strengthtxt.Location = new Point(534, 96);
            Strengthtxt.Name = "Strengthtxt";
            Strengthtxt.Size = new Size(169, 37);
            Strengthtxt.TabIndex = 95;
            // 
            // MedicineTypetxt
            // 
            MedicineTypetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MedicineTypetxt.BackColor = Color.FromArgb(232, 246, 255);
            MedicineTypetxt.FlatStyle = FlatStyle.System;
            MedicineTypetxt.Font = new Font("Cairo Medium", 9F);
            MedicineTypetxt.FormattingEnabled = true;
            MedicineTypetxt.Location = new Point(534, 8);
            MedicineTypetxt.Name = "MedicineTypetxt";
            MedicineTypetxt.Size = new Size(141, 37);
            MedicineTypetxt.TabIndex = 94;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Cairo Medium", 9F);
            label7.Location = new Point(717, 141);
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
            label8.Location = new Point(709, 61);
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
            label9.Location = new Point(671, 11);
            label9.Name = "label9";
            label9.Size = new Size(107, 29);
            label9.TabIndex = 99;
            label9.Text = "الشكل الصيدلي";
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.BackColor = Color.White;
            lblSupplierEmail.Font = new Font("Cairo Medium", 9F);
            lblSupplierEmail.Location = new Point(724, 96);
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
            label16.Location = new Point(999, 16);
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
            lblSupplierName.Location = new Point(1010, 56);
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
            lblSupplierAddress.Location = new Point(990, 100);
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
            lblSupplierPhone.Location = new Point(975, 145);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(114, 29);
            lblSupplierPhone.TabIndex = 90;
            lblSupplierPhone.Text = "الشركة المصنعة";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Cairo Medium", 10F);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(983, 14);
            label18.Name = "label18";
            label18.Size = new Size(21, 32);
            label18.TabIndex = 93;
            label18.Text = "*";
            // 
            // Manufacturertxt
            // 
            Manufacturertxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Manufacturertxt.BackColor = Color.FromArgb(232, 246, 255);
            Manufacturertxt.Font = new Font("Cairo Medium", 9F);
            Manufacturertxt.Location = new Point(778, 140);
            Manufacturertxt.Name = "Manufacturertxt";
            Manufacturertxt.PlaceholderText = "الشركة المصنعة";
            Manufacturertxt.Size = new Size(197, 36);
            Manufacturertxt.TabIndex = 87;
            // 
            // GenericNametxt
            // 
            GenericNametxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GenericNametxt.BackColor = Color.FromArgb(232, 246, 255);
            GenericNametxt.Font = new Font("Cairo Medium", 9F);
            GenericNametxt.Location = new Point(778, 95);
            GenericNametxt.Name = "GenericNametxt";
            GenericNametxt.PlaceholderText = "الاسم العلمي";
            GenericNametxt.Size = new Size(197, 36);
            GenericNametxt.TabIndex = 86;
            // 
            // Nametxt
            // 
            Nametxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Nametxt.BackColor = Color.FromArgb(232, 246, 255);
            Nametxt.Font = new Font("Cairo Medium", 9F);
            Nametxt.Location = new Point(778, 50);
            Nametxt.Name = "Nametxt";
            Nametxt.PlaceholderText = "اسم الدواء";
            Nametxt.Size = new Size(197, 36);
            Nametxt.TabIndex = 85;
            // 
            // Barcodetxt
            // 
            Barcodetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Barcodetxt.BackColor = Color.FromArgb(232, 246, 255);
            Barcodetxt.Font = new Font("Cairo Medium", 9F);
            Barcodetxt.Location = new Point(778, 6);
            Barcodetxt.Name = "Barcodetxt";
            Barcodetxt.PlaceholderText = "باركود الدواء";
            Barcodetxt.Size = new Size(197, 36);
            Barcodetxt.TabIndex = 84;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cairo Medium", 10F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(983, 51);
            label5.Name = "label5";
            label5.Size = new Size(21, 32);
            label5.TabIndex = 91;
            label5.Text = "*";
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
            btnForm.Location = new Point(1093, 51);
            btnForm.Name = "btnForm";
            btnForm.RightToLeft = RightToLeft.Yes;
            btnForm.Size = new Size(35, 40);
            btnForm.TabIndex = 83;
            btnForm.ToolTipTitle = "اضافة";
            btnForm.Click += btnForm_Click;
            // 
            // txtTypePaimt
            // 
            txtTypePaimt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTypePaimt.BackColor = Color.FromArgb(227, 237, 249);
            txtTypePaimt.FlatStyle = FlatStyle.System;
            txtTypePaimt.Font = new Font("Cairo Medium", 10F);
            txtTypePaimt.FormattingEnabled = true;
            txtTypePaimt.Items.AddRange(new object[] { "نقدي", "بطاقة ائتمان", "شيك" });
            txtTypePaimt.Location = new Point(1093, 139);
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
            label4.Location = new Point(1326, 145);
            label4.Name = "label4";
            label4.Size = new Size(91, 29);
            label4.TabIndex = 81;
            label4.Text = "طريقة الدفع";
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplier.BackColor = Color.FromArgb(227, 237, 249);
            txtSupplier.FlatStyle = FlatStyle.System;
            txtSupplier.Font = new Font("Cairo Medium", 10F);
            txtSupplier.FormattingEnabled = true;
            txtSupplier.Location = new Point(1131, 51);
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
            label3.Location = new Point(1366, 55);
            label3.Name = "label3";
            label3.Size = new Size(51, 29);
            label3.TabIndex = 79;
            label3.Text = "المورد";
            // 
            // txtPurchaseDate
            // 
            txtPurchaseDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPurchaseDate.EditValue = null;
            txtPurchaseDate.Location = new Point(1093, 99);
            txtPurchaseDate.Name = "txtPurchaseDate";
            txtPurchaseDate.Properties.Appearance.BackColor = Color.FromArgb(227, 237, 249);
            txtPurchaseDate.Properties.Appearance.Font = new Font("Tahoma", 14F);
            txtPurchaseDate.Properties.Appearance.Options.UseBackColor = true;
            txtPurchaseDate.Properties.Appearance.Options.UseFont = true;
            txtPurchaseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtPurchaseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtPurchaseDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            txtPurchaseDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            txtPurchaseDate.Size = new Size(234, 34);
            txtPurchaseDate.TabIndex = 3;
            txtPurchaseDate.KeyDown += txtPurchaseDate_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cairo Medium", 9F);
            label1.Location = new Point(1329, 10);
            label1.Name = "label1";
            label1.Size = new Size(88, 29);
            label1.TabIndex = 53;
            label1.Text = "رقم الفاتورة";
            // 
            // lblEmpEmail
            // 
            lblEmpEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpEmail.AutoSize = true;
            lblEmpEmail.BackColor = Color.White;
            lblEmpEmail.Font = new Font("Cairo Medium", 9F);
            lblEmpEmail.Location = new Point(1337, 100);
            lblEmpEmail.Name = "lblEmpEmail";
            lblEmpEmail.Size = new Size(80, 29);
            lblEmpEmail.TabIndex = 63;
            lblEmpEmail.Text = "تاريخ الشراء";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cairo Medium", 10F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1306, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 32);
            label2.TabIndex = 54;
            label2.Text = "*";
            // 
            // txtFactureNum
            // 
            txtFactureNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFactureNum.BackColor = Color.FromArgb(227, 237, 249);
            txtFactureNum.Font = new Font("Cairo Medium", 10F);
            txtFactureNum.Location = new Point(1093, 6);
            txtFactureNum.Name = "txtFactureNum";
            txtFactureNum.Size = new Size(207, 39);
            txtFactureNum.TabIndex = 1;
            txtFactureNum.TextAlign = HorizontalAlignment.Center;
            txtFactureNum.KeyDown += txtFactureNum_KeyDown;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(DGListeCustomer);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 250);
            panel5.Name = "panel5";
            panel5.Size = new Size(1427, 451);
            panel5.TabIndex = 64;
            // 
            // DGListeCustomer
            // 
            DGListeCustomer.Dock = DockStyle.Fill;
            DGListeCustomer.Location = new Point(0, 0);
            DGListeCustomer.MainView = gridView1;
            DGListeCustomer.Name = "DGListeCustomer";
            DGListeCustomer.RightToLeft = RightToLeft.Yes;
            DGListeCustomer.Size = new Size(1427, 334);
            DGListeCustomer.TabIndex = 5;
            DGListeCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.CustomizationFormHint.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            gridView1.Appearance.DetailTip.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.DetailTip.Options.UseFont = true;
            gridView1.Appearance.EvenRow.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.EvenRow.Options.UseFont = true;
            gridView1.Appearance.FilterPanel.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.FilterPanel.Options.UseFont = true;
            gridView1.Appearance.FocusedCell.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.FocusedCell.Options.UseFont = true;
            gridView1.Appearance.FocusedRow.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.FocusedRow.Options.UseFont = true;
            gridView1.Appearance.FooterPanel.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.FooterPanel.Options.UseFont = true;
            gridView1.Appearance.GroupFooter.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.GroupFooter.Options.UseFont = true;
            gridView1.Appearance.GroupPanel.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.GroupRow.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.GroupRow.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HideSelectionRow.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            gridView1.Appearance.HotTrackedRow.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            gridView1.Appearance.NoSearchResults.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.NoSearchResults.Options.UseFont = true;
            gridView1.Appearance.OddRow.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.OddRow.Options.UseFont = true;
            gridView1.Appearance.Preview.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.Preview.Options.UseFont = true;
            gridView1.Appearance.Row.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Appearance.SelectedRow.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.SelectedRow.Options.UseFont = true;
            gridView1.Appearance.TopNewRow.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.TopNewRow.Options.UseFont = true;
            gridView1.Appearance.ViewCaption.Font = new Font("Cairo Medium", 7F);
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.GridControl = DGListeCustomer;
            gridView1.Name = "gridView1";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(textBox12);
            panel6.Controls.Add(textBox11);
            panel6.Controls.Add(separatorControl22);
            panel6.Controls.Add(txtTotalAmount);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 334);
            panel6.Name = "panel6";
            panel6.Size = new Size(1427, 117);
            panel6.TabIndex = 64;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox12.BackColor = Color.Black;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Technology", 16F, FontStyle.Bold);
            textBox12.ForeColor = SystemColors.Highlight;
            textBox12.Location = new Point(1283, 71);
            textBox12.Name = "textBox12";
            textBox12.RightToLeft = RightToLeft.No;
            textBox12.Size = new Size(133, 27);
            textBox12.TabIndex = 111;
            textBox12.Text = "14:00:12";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox11.BackColor = Color.Black;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Technology", 18F, FontStyle.Bold);
            textBox11.ForeColor = SystemColors.Highlight;
            textBox11.Location = new Point(1284, 37);
            textBox11.Name = "textBox11";
            textBox11.RightToLeft = RightToLeft.No;
            textBox11.Size = new Size(133, 30);
            textBox11.TabIndex = 110;
            textBox11.Text = "10/08/2025";
            textBox11.TextAlign = HorizontalAlignment.Center;
            // 
            // separatorControl22
            // 
            separatorControl22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            separatorControl22.BackColor = Color.Black;
            separatorControl22.LineColor = Color.DarkGray;
            separatorControl22.LineOrientation = Orientation.Vertical;
            separatorControl22.LineThickness = 2;
            separatorControl22.Location = new Point(1228, 3);
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
            txtTotalAmount.Font = new Font("Technology", 35F);
            txtTotalAmount.ForeColor = Color.Lime;
            txtTotalAmount.Location = new Point(7, 42);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.RightToLeft = RightToLeft.No;
            txtTotalAmount.Size = new Size(545, 59);
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
            label6.Location = new Point(183, 3);
            label6.Name = "label6";
            label6.Size = new Size(205, 32);
            label6.TabIndex = 93;
            label6.Text = "السعر الفاتورة  الاجمالي";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnSave.Location = new Point(1256, 707);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(159, 45);
            btnSave.TabIndex = 83;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "حفظ";
            // 
            // PurchasesAddForm
            // 
            Appearance.BackColor = Color.FromArgb(227, 237, 249);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 764);
            Controls.Add(btnSave);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PurchasesAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة فاتورة جديدة";
            Load += XtraForm1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExpiryDatetxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPurchaseDate.Properties).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGListeCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl22).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblSupForm;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Panel panel2;
        private Label label1;
        private Label label2;
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
        private TextBox textBox12;
        private TextBox textBox11;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl DGListeCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnForm;
        private Label label16;
        private Label lblSupplierName;
        private Label lblSupplierAddress;
        private Label lblSupplierPhone;
        private Label label18;
        private TextBox Manufacturertxt;
        private TextBox GenericNametxt;
        private TextBox Nametxt;
        private TextBox Barcodetxt;
        private Label label5;
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
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}