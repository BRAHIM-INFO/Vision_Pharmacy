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
            panel1 = new Panel();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            lblSupplierEmail = new Label();
            lblSupplierPhone = new Label();
            buttonSaveSup = new DevExpress.XtraEditors.SimpleButton();
            txtSupplierPhone = new TextBox();
            lblSupplierAddress = new Label();
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            lblSupplierName = new Label();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            PicChange = new PictureBox();
            lblSupplierNotes = new Label();
            lblSupplierIsActive = new Label();
            txtSupplierEmail = new TextBox();
            txtSupplierNotes = new TextBox();
            chkSupplierIsActive = new DevExpress.XtraEditors.ToggleSwitch();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkSupplierIsActive.Properties).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.fondSup;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(26, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 70);
            panel1.TabIndex = 16;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(873, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = Properties.Resources.trolley_9284599;
            pictureBox3.Location = new Point(883, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cairo Medium", 10F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(819, 22);
            label6.Name = "label6";
            label6.Size = new Size(21, 32);
            label6.TabIndex = 27;
            label6.Text = "*";
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.BackColor = Color.White;
            lblSupplierEmail.Font = new Font("Cairo Medium", 10F);
            lblSupplierEmail.Location = new Point(819, 229);
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
            lblSupplierPhone.Location = new Point(819, 160);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(63, 32);
            lblSupplierPhone.TabIndex = 23;
            lblSupplierPhone.Text = "الهاتف";
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
            buttonSaveSup.Location = new Point(343, 481);
            buttonSaveSup.Name = "buttonSaveSup";
            buttonSaveSup.RightToLeft = RightToLeft.Yes;
            buttonSaveSup.Size = new Size(159, 45);
            buttonSaveSup.TabIndex = 26;
            buttonSaveSup.Text = "حفظ";
            buttonSaveSup.ToolTipTitle = "اضافة";
            buttonSaveSup.Click += buttonSaveSup_Click;
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplierPhone.BackColor = Color.FromArgb(232, 246, 255);
            txtSupplierPhone.Font = new Font("Cairo Medium", 10F);
            txtSupplierPhone.Location = new Point(343, 160);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(452, 39);
            txtSupplierPhone.TabIndex = 22;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.BackColor = Color.White;
            lblSupplierAddress.Font = new Font("Cairo Medium", 10F);
            lblSupplierAddress.Location = new Point(819, 89);
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
            txtSupplierName.Location = new Point(343, 15);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(452, 39);
            txtSupplierName.TabIndex = 18;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplierAddress.BackColor = Color.FromArgb(232, 246, 255);
            txtSupplierAddress.Font = new Font("Cairo Medium", 10F);
            txtSupplierAddress.Location = new Point(343, 86);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(452, 39);
            txtSupplierAddress.TabIndex = 20;
            // 
            // lblSupplierName
            // 
            lblSupplierName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierName.AutoSize = true;
            lblSupplierName.BackColor = Color.White;
            lblSupplierName.Font = new Font("Cairo Medium", 10F);
            lblSupplierName.Location = new Point(846, 22);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(93, 32);
            lblSupplierName.TabIndex = 19;
            lblSupplierName.Text = "اسم المورد";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(26, 646);
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
            PicChange.Location = new Point(222, 15);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(107, 103);
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
            lblSupplierNotes.Location = new Point(819, 336);
            lblSupplierNotes.Name = "lblSupplierNotes";
            lblSupplierNotes.Size = new Size(131, 32);
            lblSupplierNotes.TabIndex = 35;
            lblSupplierNotes.Text = "ملاحظات إضافية";
            // 
            // lblSupplierIsActive
            // 
            lblSupplierIsActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupplierIsActive.AutoSize = true;
            lblSupplierIsActive.BackColor = Color.FromArgb(232, 246, 255);
            lblSupplierIsActive.Font = new Font("Cairo Medium", 10F);
            lblSupplierIsActive.Location = new Point(660, 283);
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
            txtSupplierEmail.Location = new Point(343, 226);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(452, 39);
            txtSupplierEmail.TabIndex = 36;
            // 
            // txtSupplierNotes
            // 
            txtSupplierNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSupplierNotes.Font = new Font("Cairo Medium", 10F);
            txtSupplierNotes.Location = new Point(343, 336);
            txtSupplierNotes.Multiline = true;
            txtSupplierNotes.Name = "txtSupplierNotes";
            txtSupplierNotes.Size = new Size(452, 137);
            txtSupplierNotes.TabIndex = 37;
            // 
            // chkSupplierIsActive
            // 
            chkSupplierIsActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSupplierIsActive.EditValue = true;
            chkSupplierIsActive.Location = new Point(493, 291);
            chkSupplierIsActive.Name = "chkSupplierIsActive";
            chkSupplierIsActive.Properties.OffText = "لا";
            chkSupplierIsActive.Properties.OnText = "نعم";
            chkSupplierIsActive.Size = new Size(119, 24);
            chkSupplierIsActive.TabIndex = 39;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo Medium", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(572, 22);
            label1.Name = "label1";
            label1.Size = new Size(295, 37);
            label1.TabIndex = 18;
            label1.Text = "ادارة الموردين >  اضافة مورد جديد";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(chkSupplierIsActive);
            panel2.Controls.Add(PicChange);
            panel2.Controls.Add(txtSupplierNotes);
            panel2.Controls.Add(buttonSaveSup);
            panel2.Controls.Add(txtSupplierEmail);
            panel2.Controls.Add(txtSupplierName);
            panel2.Controls.Add(lblSupplierNotes);
            panel2.Controls.Add(lblSupplierName);
            panel2.Controls.Add(lblSupplierIsActive);
            panel2.Controls.Add(txtSupplierAddress);
            panel2.Controls.Add(lblSupplierAddress);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSupplierPhone);
            panel2.Controls.Add(lblSupplierEmail);
            panel2.Controls.Add(lblSupplierPhone);
            panel2.Location = new Point(26, 109);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(963, 531);
            panel2.TabIndex = 40;
            // 
            // SupplierAddForm
            // 
            Appearance.BackColor = Color.FromArgb(232, 246, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 698);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierAddForm";
            MouseDown += SupplierAddForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkSupplierIsActive.Properties).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox3;
        private Label label6;
        private Label lblSupplierEmail;
        private Label lblSupplierPhone;
        private DevExpress.XtraEditors.SimpleButton buttonSaveSup;
        private TextBox txtSupplierPhone;
        private Label lblSupplierAddress;
        private TextBox txtSupplierName;
        private TextBox txtSupplierAddress;
        private Label lblSupplierName;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private PictureBox PicChange;
        private Label lblSupplierNotes;
        private Label lblSupplierIsActive;
        private TextBox txtSupplierEmail;
        private TextBox txtSupplierNotes;
        private DevExpress.XtraEditors.ToggleSwitch chkSupplierIsActive;
        private Label label1;
        private Panel panel2;
    }
}