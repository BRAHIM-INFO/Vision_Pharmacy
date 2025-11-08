namespace Vision_Pharmacy.Gui.FinancialTransaction.Expenses
{
    partial class Expenses_IncomesAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses_IncomesAddForm));
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lbltitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDate = new DevExpress.XtraEditors.DateEdit();
            lblTypePaimt = new Label();
            panel1 = new Panel();
            txtTypeOperatExp = new RadioButton();
            txtTypeOperatInc = new RadioButton();
            lblExpenseIncomeID = new Label();
            lblTypeOperat = new Label();
            txtExpenseIncomeID = new TextBox();
            buttonSaveSup = new DevExpress.XtraEditors.SimpleButton();
            lblDescription = new Label();
            txtTransactionName = new TextBox();
            lblTransactionName = new Label();
            txtTypePaimt = new ComboBox();
            txtMontant = new TextBox();
            lblMontant = new Label();
            lblDate = new Label();
            txtDescription = new TextBox();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties.CalendarTimeProperties).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Controls.Add(separatorControl1);
            flowLayoutPanel2.Controls.Add(lbltitle);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(992, 64);
            flowLayoutPanel2.TabIndex = 67;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.drugstore_17347470;
            pictureBox2.Location = new Point(916, 2);
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
            separatorControl1.Location = new Point(898, 2);
            separatorControl1.Margin = new Padding(4, 2, 4, 2);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 55);
            separatorControl1.TabIndex = 1;
            // 
            // lbltitle
            // 
            lbltitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Cairo Medium", 12F);
            lbltitle.ForeColor = Color.Black;
            lbltitle.Location = new Point(564, 0);
            lbltitle.Margin = new Padding(4, 0, 4, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(326, 37);
            lbltitle.TabIndex = 1;
            lbltitle.Text = "ادارة المالية >  المصروفات و المداخيل";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(238, 240, 255);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2068958F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.7931061F));
            tableLayoutPanel1.Controls.Add(txtDate, 1, 2);
            tableLayoutPanel1.Controls.Add(lblTypePaimt, 0, 4);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(lblExpenseIncomeID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTypeOperat, 0, 1);
            tableLayoutPanel1.Controls.Add(txtExpenseIncomeID, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonSaveSup, 1, 7);
            tableLayoutPanel1.Controls.Add(lblDescription, 0, 6);
            tableLayoutPanel1.Controls.Add(txtTransactionName, 1, 5);
            tableLayoutPanel1.Controls.Add(lblTransactionName, 0, 5);
            tableLayoutPanel1.Controls.Add(txtTypePaimt, 1, 4);
            tableLayoutPanel1.Controls.Add(txtMontant, 1, 3);
            tableLayoutPanel1.Controls.Add(lblMontant, 0, 3);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDescription, 1, 6);
            tableLayoutPanel1.Location = new Point(14, 71);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.391304F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.608696F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 224F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(677, 561);
            tableLayoutPanel1.TabIndex = 88;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // txtDate
            // 
            txtDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDate.EditValue = null;
            txtDate.Location = new Point(4, 89);
            txtDate.Margin = new Padding(4, 2, 4, 2);
            txtDate.Name = "txtDate";
            txtDate.Properties.Appearance.BackColor = Color.White;
            txtDate.Properties.Appearance.Font = new Font("Tahoma", 12F);
            txtDate.Properties.Appearance.Options.UseBackColor = true;
            txtDate.Properties.Appearance.Options.UseFont = true;
            txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            txtDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            txtDate.Size = new Size(520, 30);
            txtDate.TabIndex = 96;
            // 
            // lblTypePaimt
            // 
            lblTypePaimt.AutoSize = true;
            lblTypePaimt.BackColor = Color.FromArgb(238, 240, 255);
            lblTypePaimt.Font = new Font("Cairo Medium", 11F);
            lblTypePaimt.Location = new Point(561, 184);
            lblTypePaimt.Margin = new Padding(4, 0, 4, 0);
            lblTypePaimt.Name = "lblTypePaimt";
            lblTypePaimt.Size = new Size(112, 36);
            lblTypePaimt.TabIndex = 95;
            lblTypePaimt.Text = "طريقة الدفع";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTypeOperatExp);
            panel1.Controls.Add(txtTypeOperatInc);
            panel1.Location = new Point(10, 41);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 42);
            panel1.TabIndex = 92;
            // 
            // txtTypeOperatExp
            // 
            txtTypeOperatExp.AutoSize = true;
            txtTypeOperatExp.Cursor = Cursors.Hand;
            txtTypeOperatExp.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            txtTypeOperatExp.Location = new Point(132, 2);
            txtTypeOperatExp.Name = "txtTypeOperatExp";
            txtTypeOperatExp.Size = new Size(109, 36);
            txtTypeOperatExp.TabIndex = 94;
            txtTypeOperatExp.Text = "مصروفات";
            txtTypeOperatExp.UseVisualStyleBackColor = true;
            // 
            // txtTypeOperatInc
            // 
            txtTypeOperatInc.AutoSize = true;
            txtTypeOperatInc.Checked = true;
            txtTypeOperatInc.Cursor = Cursors.Hand;
            txtTypeOperatInc.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            txtTypeOperatInc.Location = new Point(410, 2);
            txtTypeOperatInc.Name = "txtTypeOperatInc";
            txtTypeOperatInc.Size = new Size(92, 36);
            txtTypeOperatInc.TabIndex = 93;
            txtTypeOperatInc.TabStop = true;
            txtTypeOperatInc.Text = "مداخيل";
            txtTypeOperatInc.UseVisualStyleBackColor = true;
            // 
            // lblExpenseIncomeID
            // 
            lblExpenseIncomeID.AutoSize = true;
            lblExpenseIncomeID.BackColor = Color.FromArgb(238, 240, 255);
            lblExpenseIncomeID.Font = new Font("Cairo Medium", 11F);
            lblExpenseIncomeID.Location = new Point(566, 0);
            lblExpenseIncomeID.Margin = new Padding(4, 0, 4, 0);
            lblExpenseIncomeID.Name = "lblExpenseIncomeID";
            lblExpenseIncomeID.Size = new Size(107, 36);
            lblExpenseIncomeID.TabIndex = 53;
            lblExpenseIncomeID.Text = "رقم العملية";
            // 
            // lblTypeOperat
            // 
            lblTypeOperat.AutoSize = true;
            lblTypeOperat.BackColor = Color.FromArgb(238, 240, 255);
            lblTypeOperat.Font = new Font("Cairo Medium", 11F);
            lblTypeOperat.Location = new Point(569, 37);
            lblTypeOperat.Margin = new Padding(4, 0, 4, 0);
            lblTypeOperat.Name = "lblTypeOperat";
            lblTypeOperat.Size = new Size(104, 36);
            lblTypeOperat.TabIndex = 79;
            lblTypeOperat.Text = "نوع العملية";
            // 
            // txtExpenseIncomeID
            // 
            txtExpenseIncomeID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtExpenseIncomeID.BackColor = Color.White;
            txtExpenseIncomeID.Font = new Font("Cairo Medium", 10F);
            txtExpenseIncomeID.Location = new Point(4, 2);
            txtExpenseIncomeID.Margin = new Padding(4, 2, 4, 2);
            txtExpenseIncomeID.Name = "txtExpenseIncomeID";
            txtExpenseIncomeID.ReadOnly = true;
            txtExpenseIncomeID.Size = new Size(520, 39);
            txtExpenseIncomeID.TabIndex = 1;
            txtExpenseIncomeID.TextAlign = HorizontalAlignment.Center;
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
            buttonSaveSup.Location = new Point(4, 513);
            buttonSaveSup.Margin = new Padding(4, 2, 4, 2);
            buttonSaveSup.Name = "buttonSaveSup";
            buttonSaveSup.RightToLeft = RightToLeft.Yes;
            buttonSaveSup.Size = new Size(526, 46);
            buttonSaveSup.TabIndex = 91;
            buttonSaveSup.Text = "حفظ البيانات";
            buttonSaveSup.ToolTipTitle = "اضافة";
            buttonSaveSup.Click += buttonSaveSup_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(238, 240, 255);
            lblDescription.Font = new Font("Cairo Medium", 11F);
            lblDescription.Location = new Point(550, 287);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(123, 36);
            lblDescription.TabIndex = 81;
            lblDescription.Text = "وصف العملية";
            // 
            // txtTransactionName
            // 
            txtTransactionName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTransactionName.BackColor = Color.White;
            txtTransactionName.Font = new Font("Cairo Medium", 10F);
            txtTransactionName.Location = new Point(4, 235);
            txtTransactionName.Margin = new Padding(4, 2, 4, 2);
            txtTransactionName.Multiline = true;
            txtTransactionName.Name = "txtTransactionName";
            txtTransactionName.RightToLeft = RightToLeft.Yes;
            txtTransactionName.Size = new Size(520, 48);
            txtTransactionName.TabIndex = 93;
            // 
            // lblTransactionName
            // 
            lblTransactionName.AutoSize = true;
            lblTransactionName.BackColor = Color.FromArgb(238, 240, 255);
            lblTransactionName.Font = new Font("Cairo Medium", 11F);
            lblTransactionName.Location = new Point(558, 233);
            lblTransactionName.Margin = new Padding(4, 0, 4, 0);
            lblTransactionName.Name = "lblTransactionName";
            lblTransactionName.Size = new Size(115, 36);
            lblTransactionName.TabIndex = 94;
            lblTransactionName.Text = "اسم  العملية";
            // 
            // txtTypePaimt
            // 
            txtTypePaimt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTypePaimt.BackColor = Color.White;
            txtTypePaimt.FlatStyle = FlatStyle.System;
            txtTypePaimt.Font = new Font("Cairo Medium", 10F);
            txtTypePaimt.FormattingEnabled = true;
            txtTypePaimt.Items.AddRange(new object[] { "نقدي", "بطاقة ائتمان", "شيك" });
            txtTypePaimt.Location = new Point(4, 186);
            txtTypePaimt.Margin = new Padding(4, 2, 4, 2);
            txtTypePaimt.Name = "txtTypePaimt";
            txtTypePaimt.RightToLeft = RightToLeft.No;
            txtTypePaimt.Size = new Size(520, 40);
            txtTypePaimt.TabIndex = 86;
            // 
            // txtMontant
            // 
            txtMontant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMontant.BackColor = Color.White;
            txtMontant.Font = new Font("Dubai", 12F);
            txtMontant.Location = new Point(4, 133);
            txtMontant.Margin = new Padding(4, 2, 4, 2);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(520, 41);
            txtMontant.TabIndex = 83;
            txtMontant.Text = "0.00";
            txtMontant.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.BackColor = Color.FromArgb(238, 240, 255);
            lblMontant.Font = new Font("Cairo Medium", 11F);
            lblMontant.Location = new Point(611, 131);
            lblMontant.Margin = new Padding(4, 0, 4, 0);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new Size(62, 36);
            lblMontant.TabIndex = 63;
            lblMontant.Text = "المبلغ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.FromArgb(238, 240, 255);
            lblDate.Font = new Font("Cairo Medium", 11F);
            lblDate.Location = new Point(613, 87);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(60, 36);
            lblDate.TabIndex = 80;
            lblDate.Text = "التاريخ";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescription.BackColor = Color.White;
            txtDescription.Font = new Font("Cairo Medium", 10F);
            txtDescription.Location = new Point(4, 289);
            txtDescription.Margin = new Padding(4, 2, 4, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.RightToLeft = RightToLeft.Yes;
            txtDescription.Size = new Size(520, 216);
            txtDescription.TabIndex = 85;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(938, 609);
            btnClose.Margin = new Padding(4, 2, 4, 2);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 39);
            btnClose.TabIndex = 89;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._6617;
            pictureBox1.Location = new Point(698, 68);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 537);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 90;
            pictureBox1.TabStop = false;
            // 
            // Expenses_IncomesAddForm
            // 
            Appearance.BackColor = Color.FromArgb(238, 240, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 647);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Expenses_IncomesAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpendesAddForm";
            Load += ExpendesAddForm_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Label lbltitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblExpenseIncomeID;
        private Label lblTypeOperat;
        private TextBox txtExpenseIncomeID;
        private Label lblMontant;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private PictureBox pictureBox1;
        private TextBox txtDescription;
        private TextBox txtMontant;
        private TextBox txtTypeOperat;
        private Label lblDate;
        private Label lblDescription;
        private ComboBox txtTypePaimt;
        public DevExpress.XtraEditors.SimpleButton buttonSaveSup;
        private Panel panel1;
        private Label lblTransactionName;
        private TextBox txtTransactionName;
        private Label lblTypePaimt;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private RadioButton txtTypeOperatExp;
        private RadioButton txtTypeOperatInc;
    }
}