namespace Vision_Pharmacy.Gui.SupplierGui
{
    partial class SupplierAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierAddForm));
            pictureBox1 = new PictureBox();
            lblSupplierEmail = new Label();
            lblSupplierPhone = new Label();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtSupplierPhone = new TextBox();
            lblSupplierAddress = new Label();
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            PicChange = new PictureBox();
            lblSupplierNotes = new Label();
            lblSupplierIsActive = new Label();
            txtSupplierEmail = new TextBox();
            txtSupplierNotes = new TextBox();
            chkSupplierIsActive = new DevExpress.XtraEditors.ToggleSwitch();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSupplierName = new Label();
            pnlContaint = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkSupplierIsActive.Properties).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlContaint.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.fondSup;
            pictureBox1.Location = new Point(14, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 542);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.BackColor = Color.White;
            lblSupplierEmail.Font = new Font("Cairo Medium", 10F);
            lblSupplierEmail.Location = new Point(562, 247);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(124, 32);
            lblSupplierEmail.TabIndex = 24;
            lblSupplierEmail.Text = "البريد الإلكتروني";
            // 
            // lblSupplierPhone
            // 
            lblSupplierPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierPhone.AutoSize = true;
            lblSupplierPhone.BackColor = Color.White;
            lblSupplierPhone.Font = new Font("Cairo Medium", 10F);
            lblSupplierPhone.Location = new Point(562, 175);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(63, 32);
            lblSupplierPhone.TabIndex = 23;
            lblSupplierPhone.Text = "الهاتف";
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = Color.FromArgb(74, 89, 180);
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
            btnSave.Location = new Point(397, 478);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(159, 45);
            btnSave.TabIndex = 26;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "اضافة";
            btnSave.Click += buttonSaveSup_Click;
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplierPhone.BackColor = Color.FromArgb(232, 246, 255);
            txtSupplierPhone.Font = new Font("Cairo Medium", 10F);
            txtSupplierPhone.Location = new Point(151, 178);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(405, 39);
            txtSupplierPhone.TabIndex = 22;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.BackColor = Color.White;
            lblSupplierAddress.Font = new Font("Cairo Medium", 10F);
            lblSupplierAddress.Location = new Point(562, 103);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(66, 32);
            lblSupplierAddress.TabIndex = 21;
            lblSupplierAddress.Text = "العنوان";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplierName.BackColor = Color.FromArgb(232, 246, 255);
            txtSupplierName.Font = new Font("Cairo Medium", 10F);
            txtSupplierName.Location = new Point(151, 3);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(405, 39);
            txtSupplierName.TabIndex = 18;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplierAddress.BackColor = Color.FromArgb(232, 246, 255);
            txtSupplierAddress.Font = new Font("Cairo Medium", 10F);
            txtSupplierAddress.Location = new Point(151, 106);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(405, 39);
            txtSupplierAddress.TabIndex = 20;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(14, 654);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 31;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // PicChange
            // 
            PicChange.BackColor = Color.Silver;
            PicChange.Cursor = Cursors.Hand;
            PicChange.Image = Properties.Resources.pictur;
            PicChange.Location = new Point(10, 3);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(135, 97);
            PicChange.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChange.TabIndex = 32;
            PicChange.TabStop = false;
            PicChange.Click += PicChange_Click;
            // 
            // lblSupplierNotes
            // 
            lblSupplierNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierNotes.AutoSize = true;
            lblSupplierNotes.BackColor = Color.White;
            lblSupplierNotes.Font = new Font("Cairo Medium", 10F);
            lblSupplierNotes.Location = new Point(562, 367);
            lblSupplierNotes.Name = "lblSupplierNotes";
            lblSupplierNotes.Size = new Size(131, 32);
            lblSupplierNotes.TabIndex = 35;
            lblSupplierNotes.Text = "ملاحظات إضافية";
            // 
            // lblSupplierIsActive
            // 
            lblSupplierIsActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierIsActive.AutoSize = true;
            lblSupplierIsActive.BackColor = Color.White;
            lblSupplierIsActive.Font = new Font("Cairo Medium", 10F);
            lblSupplierIsActive.Location = new Point(562, 319);
            lblSupplierIsActive.Name = "lblSupplierIsActive";
            lblSupplierIsActive.Size = new Size(135, 32);
            lblSupplierIsActive.TabIndex = 34;
            lblSupplierIsActive.Text = "هل المورد نشط؟";
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplierEmail.BackColor = Color.FromArgb(232, 246, 255);
            txtSupplierEmail.Font = new Font("Cairo Medium", 10F);
            txtSupplierEmail.Location = new Point(151, 250);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(405, 39);
            txtSupplierEmail.TabIndex = 36;
            // 
            // txtSupplierNotes
            // 
            txtSupplierNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplierNotes.Font = new Font("Cairo Medium", 10F);
            txtSupplierNotes.Location = new Point(151, 370);
            txtSupplierNotes.Multiline = true;
            txtSupplierNotes.Name = "txtSupplierNotes";
            txtSupplierNotes.Size = new Size(405, 100);
            txtSupplierNotes.TabIndex = 37;
            // 
            // chkSupplierIsActive
            // 
            chkSupplierIsActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSupplierIsActive.EditValue = true;
            chkSupplierIsActive.Location = new Point(151, 322);
            chkSupplierIsActive.Name = "chkSupplierIsActive";
            chkSupplierIsActive.Properties.OffText = "لا";
            chkSupplierIsActive.Properties.OnText = "نعم";
            chkSupplierIsActive.Size = new Size(119, 24);
            chkSupplierIsActive.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(separatorControl1);
            flowLayoutPanel1.Controls.Add(lblTitle);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1000, 74);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Image = Properties.Resources.trolley_9284599;
            pictureBox3.Location = new Point(917, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(901, 3);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 19;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cairo Medium", 12F);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(600, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 37);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "ادارة الموردين >  اضافة مورد جديد";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.17073F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.82927F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel1.Controls.Add(lblSupplierName, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 6);
            tableLayoutPanel1.Controls.Add(txtSupplierNotes, 1, 5);
            tableLayoutPanel1.Controls.Add(txtSupplierName, 1, 0);
            tableLayoutPanel1.Controls.Add(PicChange, 2, 0);
            tableLayoutPanel1.Controls.Add(lblSupplierNotes, 0, 5);
            tableLayoutPanel1.Controls.Add(lblSupplierAddress, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSupplierEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(txtSupplierAddress, 1, 1);
            tableLayoutPanel1.Controls.Add(lblSupplierPhone, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSupplierPhone, 1, 2);
            tableLayoutPanel1.Controls.Add(lblSupplierEmail, 0, 3);
            tableLayoutPanel1.Controls.Add(chkSupplierIsActive, 1, 4);
            tableLayoutPanel1.Controls.Add(lblSupplierIsActive, 0, 4);
            tableLayoutPanel1.Location = new Point(234, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.23077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4615383F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4615383F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4615383F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.04059F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2952023F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9926195F));
            tableLayoutPanel1.Size = new Size(763, 542);
            tableLayoutPanel1.TabIndex = 42;
            // 
            // lblSupplierName
            // 
            lblSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierName.AutoSize = true;
            lblSupplierName.BackColor = Color.White;
            lblSupplierName.Font = new Font("Cairo Medium", 10F);
            lblSupplierName.Location = new Point(562, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(93, 32);
            lblSupplierName.TabIndex = 19;
            lblSupplierName.Text = "اسم المورد";
            // 
            // pnlContaint
            // 
            pnlContaint.Controls.Add(tableLayoutPanel1);
            pnlContaint.Controls.Add(pictureBox1);
            pnlContaint.Dock = DockStyle.Top;
            pnlContaint.Location = new Point(0, 74);
            pnlContaint.Name = "pnlContaint";
            pnlContaint.Size = new Size(1000, 574);
            pnlContaint.TabIndex = 43;
            // 
            // SupplierAddForm
            // 
            Appearance.BackColor = Color.FromArgb(232, 246, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 698);
            Controls.Add(pnlContaint);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierAddForm";
            MouseDown += SupplierAddForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkSupplierIsActive.Properties).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlContaint.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSupplierEmail;
        private Label lblSupplierPhone;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private TextBox txtSupplierPhone;
        private Label lblSupplierAddress;
        private TextBox txtSupplierName;
        private TextBox txtSupplierAddress;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private PictureBox PicChange;
        private Label lblSupplierNotes;
        private Label lblSupplierIsActive;
        private TextBox txtSupplierEmail;
        private TextBox txtSupplierNotes;
        private DevExpress.XtraEditors.ToggleSwitch chkSupplierIsActive;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSupplierName;
        private FlowLayoutPanel pnlContaint;
    }
}