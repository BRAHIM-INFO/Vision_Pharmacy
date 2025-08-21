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
            label6 = new Label();
            lblEmpEmail = new Label();
            lblEmpPhone = new Label();
            buttonSaveEmp = new DevExpress.XtraEditors.SimpleButton();
            txtEmpPhone = new TextBox();
            lblEmpAddress = new Label();
            txtEmpName = new TextBox();
            txtEmpRole = new TextBox();
            lblEmpName = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblSupForm = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            txtEmpDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)chkEmpActive.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmpDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpDate.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // chkEmpActive
            // 
            chkEmpActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkEmpActive.EditValue = true;
            chkEmpActive.Location = new Point(416, 388);
            chkEmpActive.Name = "chkEmpActive";
            chkEmpActive.Properties.OffText = "لا";
            chkEmpActive.Properties.OnText = "نعم";
            chkEmpActive.Size = new Size(119, 24);
            chkEmpActive.TabIndex = 58;
            // 
            // txtEmpSalaire
            // 
            txtEmpSalaire.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmpSalaire.BackColor = Color.FromArgb(227, 237, 249);
            txtEmpSalaire.Font = new Font("Cairo Medium", 10F);
            txtEmpSalaire.Location = new Point(284, 438);
            txtEmpSalaire.Name = "txtEmpSalaire";
            txtEmpSalaire.Size = new Size(419, 39);
            txtEmpSalaire.TabIndex = 57;
            txtEmpSalaire.KeyPress += txtEmpSalaire_KeyPress;
            // 
            // lblEmpNotes
            // 
            lblEmpNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpNotes.AutoSize = true;
            lblEmpNotes.BackColor = Color.White;
            lblEmpNotes.Font = new Font("Cairo Medium", 10F);
            lblEmpNotes.Location = new Point(725, 438);
            lblEmpNotes.Name = "lblEmpNotes";
            lblEmpNotes.Size = new Size(53, 32);
            lblEmpNotes.TabIndex = 55;
            lblEmpNotes.Text = "الراتب";
            // 
            // lblEmpIsActive
            // 
            lblEmpIsActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpIsActive.AutoSize = true;
            lblEmpIsActive.BackColor = Color.White;
            lblEmpIsActive.Font = new Font("Cairo Medium", 10F);
            lblEmpIsActive.Location = new Point(550, 383);
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
            PicChange.Location = new Point(257, 62);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(104, 129);
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
            btnClose.Location = new Point(37, 715);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 52;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Cairo Medium", 10F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(709, 69);
            label6.Name = "label6";
            label6.Size = new Size(21, 32);
            label6.TabIndex = 51;
            label6.Text = "*";
            // 
            // lblEmpEmail
            // 
            lblEmpEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpEmail.AutoSize = true;
            lblEmpEmail.BackColor = Color.White;
            lblEmpEmail.Font = new Font("Cairo Medium", 10F);
            lblEmpEmail.Location = new Point(725, 330);
            lblEmpEmail.Name = "lblEmpEmail";
            lblEmpEmail.Size = new Size(111, 32);
            lblEmpEmail.TabIndex = 49;
            lblEmpEmail.Text = "تاريخ التوظيف";
            // 
            // lblEmpPhone
            // 
            lblEmpPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpPhone.AutoSize = true;
            lblEmpPhone.BackColor = Color.White;
            lblEmpPhone.Font = new Font("Cairo Medium", 10F);
            lblEmpPhone.Location = new Point(725, 248);
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
            buttonSaveEmp.Location = new Point(284, 530);
            buttonSaveEmp.Name = "buttonSaveEmp";
            buttonSaveEmp.RightToLeft = RightToLeft.Yes;
            buttonSaveEmp.Size = new Size(159, 45);
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
            txtEmpPhone.Location = new Point(378, 241);
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.Size = new Size(325, 39);
            txtEmpPhone.TabIndex = 47;
            // 
            // lblEmpAddress
            // 
            lblEmpAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpAddress.AutoSize = true;
            lblEmpAddress.BackColor = Color.White;
            lblEmpAddress.Font = new Font("Cairo Medium", 10F);
            lblEmpAddress.Location = new Point(725, 159);
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
            txtEmpName.Location = new Point(378, 62);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(325, 39);
            txtEmpName.TabIndex = 43;
            // 
            // txtEmpRole
            // 
            txtEmpRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmpRole.BackColor = Color.FromArgb(227, 237, 249);
            txtEmpRole.Font = new Font("Cairo Medium", 10F);
            txtEmpRole.Location = new Point(378, 152);
            txtEmpRole.Name = "txtEmpRole";
            txtEmpRole.Size = new Size(325, 39);
            txtEmpRole.TabIndex = 45;
            // 
            // lblEmpName
            // 
            lblEmpName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmpName.AutoSize = true;
            lblEmpName.BackColor = Color.White;
            lblEmpName.Font = new Font("Cairo Medium", 10F);
            lblEmpName.Location = new Point(725, 69);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(108, 32);
            lblEmpName.TabIndex = 44;
            lblEmpName.Text = "الاسم الكامل";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblSupForm);
            panel1.Controls.Add(separatorControl1);
            panel1.Location = new Point(37, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 70);
            panel1.TabIndex = 41;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.hr_19008748;
            pictureBox2.Location = new Point(785, 0);
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
            lblSupForm.Location = new Point(441, 25);
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
            separatorControl1.Location = new Point(776, 1);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 67);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = Properties.Resources._21404;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(251, 591);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 59;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtEmpDate);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(PicChange);
            panel2.Controls.Add(txtEmpSalaire);
            panel2.Controls.Add(chkEmpActive);
            panel2.Controls.Add(buttonSaveEmp);
            panel2.Controls.Add(lblEmpNotes);
            panel2.Controls.Add(lblEmpName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblEmpIsActive);
            panel2.Controls.Add(txtEmpName);
            panel2.Controls.Add(lblEmpAddress);
            panel2.Controls.Add(txtEmpRole);
            panel2.Controls.Add(lblEmpPhone);
            panel2.Controls.Add(txtEmpPhone);
            panel2.Controls.Add(lblEmpEmail);
            panel2.Location = new Point(37, 118);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(855, 591);
            panel2.TabIndex = 60;
            // 
            // txtEmpDate
            // 
            txtEmpDate.EditValue = null;
            txtEmpDate.Location = new Point(284, 332);
            txtEmpDate.Name = "txtEmpDate";
            txtEmpDate.Properties.Appearance.Font = new Font("Tahoma", 12F);
            txtEmpDate.Properties.Appearance.Options.UseFont = true;
            txtEmpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEmpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEmpDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            txtEmpDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            txtEmpDate.Size = new Size(419, 30);
            txtEmpDate.TabIndex = 60;
            // 
            // EmployeeAddForm
            // 
            Appearance.BackColor = Color.FromArgb(227, 237, 249);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 754);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeAddForm";
            MouseDown += EmployeeAddForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)chkEmpActive.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmpDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmpDate.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch chkEmpActive;
        private TextBox txtEmpSalaire; 
        private Label lblEmpNotes;
        private Label lblEmpIsActive;
        private PictureBox PicChange;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private Label label6;
        private Label lblEmpEmail;
        private Label lblEmpPhone;
        private DevExpress.XtraEditors.SimpleButton buttonSaveEmp;
        private TextBox txtEmpPhone;
        private Label lblEmpAddress;
        private TextBox txtEmpName;
        private TextBox txtEmpRole;
        private Label lblEmpName;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblSupForm;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private DevExpress.XtraEditors.DateEdit txtEmpDate;
    }
}