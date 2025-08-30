namespace Vision_Pharmacy.Gui.EmployeeGui
{
    partial class EmployeeAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAddForm));
            chkEmpActive = new DevExpress.XtraEditors.ToggleSwitch();
            txtEmpSalaire = new TextBox();
            lblEmpNotes = new Label();
            lblEmpIsActive = new Label();
            PicChange = new PictureBox();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            lblEmpEmail = new Label();
            lblEmpPhone = new Label();
            buttonSaveEmp = new DevExpress.XtraEditors.SimpleButton();
            txtEmpPhone = new TextBox();
            lblEmpAddress = new Label();
            txtEmpName = new TextBox();
            txtEmpRole = new TextBox();
            lblEmpName = new Label();
            pictureBox2 = new PictureBox();
            lblSupForm = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox4 = new PictureBox();
            txtEmpDate = new DevExpress.XtraEditors.DateEdit();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)chkEmpActive.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpDate.Properties.CalendarTimeProperties).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // chkEmpActive
            // 
            chkEmpActive.Dock = DockStyle.Left;
            chkEmpActive.EditValue = true;
            chkEmpActive.Location = new Point(420, 260);
            chkEmpActive.Name = "chkEmpActive";
            chkEmpActive.Properties.OffText = "لا";
            chkEmpActive.Properties.OnText = "نعم";
            chkEmpActive.Size = new Size(119, 47);
            chkEmpActive.TabIndex = 58;
            // 
            // txtEmpSalaire
            // 
            txtEmpSalaire.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmpSalaire.BackColor = Color.FromArgb(227, 237, 249);
            txtEmpSalaire.Font = new Font("Cairo Medium", 10F);
            txtEmpSalaire.Location = new Point(225, 313);
            txtEmpSalaire.Name = "txtEmpSalaire";
            txtEmpSalaire.Size = new Size(314, 39);
            txtEmpSalaire.TabIndex = 57;
            txtEmpSalaire.KeyPress += txtEmpSalaire_KeyPress;
            // 
            // lblEmpNotes
            // 
            lblEmpNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpNotes.AutoSize = true;
            lblEmpNotes.BackColor = Color.Transparent;
            lblEmpNotes.Font = new Font("Cairo Medium", 10F);
            lblEmpNotes.Location = new Point(545, 310);
            lblEmpNotes.Name = "lblEmpNotes";
            lblEmpNotes.Size = new Size(53, 32);
            lblEmpNotes.TabIndex = 55;
            lblEmpNotes.Text = "الراتب";
            // 
            // lblEmpIsActive
            // 
            lblEmpIsActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpIsActive.AutoSize = true;
            lblEmpIsActive.BackColor = Color.Transparent;
            lblEmpIsActive.Font = new Font("Cairo Medium", 10F);
            lblEmpIsActive.Location = new Point(545, 257);
            lblEmpIsActive.Name = "lblEmpIsActive";
            lblEmpIsActive.Size = new Size(153, 32);
            lblEmpIsActive.TabIndex = 54;
            lblEmpIsActive.Text = "هل الموظف نشط؟";
            // 
            // PicChange
            // 
            PicChange.BackColor = Color.Silver;
            PicChange.Cursor = Cursors.Hand;
            PicChange.Image = Properties.Resources.pictur;
            PicChange.Location = new Point(3, 3);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(216, 110);
            PicChange.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChange.TabIndex = 53;
            PicChange.TabStop = false;
            PicChange.Click += PicChange_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(3, 675);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 52;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // lblEmpEmail
            // 
            lblEmpEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpEmail.AutoSize = true;
            lblEmpEmail.BackColor = Color.Transparent;
            lblEmpEmail.Font = new Font("Cairo Medium", 10F);
            lblEmpEmail.Location = new Point(545, 207);
            lblEmpEmail.Name = "lblEmpEmail";
            lblEmpEmail.Size = new Size(111, 32);
            lblEmpEmail.TabIndex = 49;
            lblEmpEmail.Text = "تاريخ التوظيف";
            // 
            // lblEmpPhone
            // 
            lblEmpPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpPhone.AutoSize = true;
            lblEmpPhone.BackColor = Color.Transparent;
            lblEmpPhone.Font = new Font("Cairo Medium", 10F);
            lblEmpPhone.Location = new Point(545, 163);
            lblEmpPhone.Name = "lblEmpPhone";
            lblEmpPhone.Size = new Size(63, 32);
            lblEmpPhone.TabIndex = 48;
            lblEmpPhone.Text = "الهاتف";
            // 
            // buttonSaveEmp
            // 
            buttonSaveEmp.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            buttonSaveEmp.Appearance.Font = new Font("Cairo Medium", 10F);
            buttonSaveEmp.Appearance.Options.UseBackColor = true;
            buttonSaveEmp.Appearance.Options.UseFont = true;
            buttonSaveEmp.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            buttonSaveEmp.AppearanceDisabled.Options.UseFont = true;
            buttonSaveEmp.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            buttonSaveEmp.AppearanceHovered.Options.UseFont = true;
            buttonSaveEmp.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            buttonSaveEmp.AppearancePressed.Options.UseFont = true;
            buttonSaveEmp.Cursor = Cursors.Hand;
            buttonSaveEmp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveEmp.ImageOptions.SvgImage");
            buttonSaveEmp.ImageOptions.SvgImageSize = new Size(25, 25);
            buttonSaveEmp.Location = new Point(225, 371);
            buttonSaveEmp.Name = "buttonSaveEmp";
            buttonSaveEmp.RightToLeft = RightToLeft.Yes;
            buttonSaveEmp.Size = new Size(314, 45);
            buttonSaveEmp.TabIndex = 50;
            buttonSaveEmp.Text = "حفظ";
            buttonSaveEmp.ToolTipTitle = "اضافة";
            buttonSaveEmp.Click += buttonSaveEmp_Click;
            // 
            // txtEmpPhone
            // 
            txtEmpPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmpPhone.BackColor = Color.FromArgb(227, 237, 249);
            txtEmpPhone.Font = new Font("Cairo Medium", 10F);
            txtEmpPhone.Location = new Point(225, 166);
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(314, 39);
            txtEmpPhone.TabIndex = 47;
            // 
            // lblEmpAddress
            // 
            lblEmpAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpAddress.AutoSize = true;
            lblEmpAddress.BackColor = Color.Transparent;
            lblEmpAddress.Font = new Font("Cairo Medium", 10F);
            lblEmpAddress.Location = new Point(545, 116);
            lblEmpAddress.Name = "lblEmpAddress";
            lblEmpAddress.Size = new Size(73, 32);
            lblEmpAddress.TabIndex = 46;
            lblEmpAddress.Text = "الوظيفة";
            // 
            // txtEmpName
            // 
            txtEmpName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmpName.BackColor = Color.FromArgb(227, 237, 249);
            txtEmpName.Font = new Font("Cairo Medium", 10F);
            txtEmpName.Location = new Point(225, 3);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(314, 39);
            txtEmpName.TabIndex = 43;
            // 
            // txtEmpRole
            // 
            txtEmpRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmpRole.BackColor = Color.FromArgb(227, 237, 249);
            txtEmpRole.Font = new Font("Cairo Medium", 10F);
            txtEmpRole.Location = new Point(225, 119);
            txtEmpRole.Name = "txtEmpRole";
            txtEmpRole.Size = new Size(314, 39);
            txtEmpRole.TabIndex = 45;
            // 
            // lblEmpName
            // 
            lblEmpName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpName.AutoSize = true;
            lblEmpName.BackColor = Color.Transparent;
            lblEmpName.Font = new Font("Cairo Medium", 10F);
            lblEmpName.Location = new Point(545, 0);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(108, 32);
            lblEmpName.TabIndex = 44;
            lblEmpName.Text = "الاسم الكامل";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.hr_19008748;
            pictureBox2.Location = new Point(935, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 70);
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
            lblSupForm.Location = new Point(584, 0);
            lblSupForm.Name = "lblSupForm";
            lblSupForm.Size = new Size(329, 37);
            lblSupForm.TabIndex = 1;
            lblSupForm.Text = "ادارة الموظفين >  اضافة موظف جديد";
            // 
            // separatorControl1
            // 
            separatorControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(919, 3);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 67);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._21404;
            pictureBox4.Location = new Point(5, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(251, 591);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 59;
            pictureBox4.TabStop = false;
            // 
            // txtEmpDate
            // 
            txtEmpDate.EditValue = null;
            txtEmpDate.Location = new Point(225, 210);
            txtEmpDate.Name = "txtEmpDate";
            txtEmpDate.Properties.Appearance.Font = new Font("Tahoma", 12F);
            txtEmpDate.Properties.Appearance.Options.UseFont = true;
            txtEmpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEmpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEmpDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            txtEmpDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            txtEmpDate.Size = new Size(314, 30);
            txtEmpDate.TabIndex = 60;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(separatorControl1);
            flowLayoutPanel1.Controls.Add(lblSupForm);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1010, 73);
            flowLayoutPanel1.TabIndex = 61;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5555573F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.4444427F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanel1.Controls.Add(txtEmpDate, 1, 3);
            tableLayoutPanel1.Controls.Add(PicChange, 2, 0);
            tableLayoutPanel1.Controls.Add(lblEmpName, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSaveEmp, 1, 6);
            tableLayoutPanel1.Controls.Add(txtEmpSalaire, 1, 5);
            tableLayoutPanel1.Controls.Add(lblEmpAddress, 0, 1);
            tableLayoutPanel1.Controls.Add(lblEmpPhone, 0, 2);
            tableLayoutPanel1.Controls.Add(lblEmpNotes, 0, 5);
            tableLayoutPanel1.Controls.Add(txtEmpName, 1, 0);
            tableLayoutPanel1.Controls.Add(chkEmpActive, 1, 4);
            tableLayoutPanel1.Controls.Add(txtEmpRole, 1, 1);
            tableLayoutPanel1.Controls.Add(txtEmpPhone, 1, 2);
            tableLayoutPanel1.Controls.Add(lblEmpEmail, 0, 3);
            tableLayoutPanel1.Controls.Add(lblEmpIsActive, 0, 4);
            tableLayoutPanel1.Location = new Point(262, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.16564F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.8343563F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.Size = new Size(734, 431);
            tableLayoutPanel1.TabIndex = 62;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel2.Controls.Add(pictureBox4);
            flowLayoutPanel2.Location = new Point(5, 79);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(999, 590);
            flowLayoutPanel2.TabIndex = 62;
            // 
            // EmployeeAddForm
            // 
            Appearance.BackColor = Color.FromArgb(227, 237, 249);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 714);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeAddForm";
            MouseDown += EmployeeAddForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)chkEmpActive.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpDate.Properties).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch chkEmpActive;
        private TextBox txtEmpSalaire; 
        private Label lblEmpNotes;
        private Label lblEmpIsActive;
        private PictureBox PicChange;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private Label lblEmpEmail;
        private Label lblEmpPhone;
        private DevExpress.XtraEditors.SimpleButton buttonSaveEmp;
        private TextBox txtEmpPhone;
        private Label lblEmpAddress;
        private TextBox txtEmpName;
        private TextBox txtEmpRole;
        private Label lblEmpName;
        private PictureBox pictureBox2;
        private Label lblSupForm;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox4;
        private DevExpress.XtraEditors.DateEdit txtEmpDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}