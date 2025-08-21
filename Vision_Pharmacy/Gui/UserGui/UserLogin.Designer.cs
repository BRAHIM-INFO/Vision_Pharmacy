using Vision_Pharmacy.Properties;

namespace Vision_Pharmacy.Gui.UserGui
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            pictureBox1 = new PictureBox();
            textBoxPassword = new TextBox();
            textBoxUserName = new DevExpress.XtraEditors.ComboBoxEdit();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblTitle = new DevExpress.XtraEditors.LabelControl();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            panel1 = new Panel();
            panel2 = new Panel();
            SwitchLang = new DevExpress.XtraEditors.ToggleSwitch();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SwitchLang.Properties).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 646);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Cairo Medium", 12F);
            textBoxPassword.Location = new Point(102, 377);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(265, 45);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // textBoxUserName
            // 
            textBoxUserName.EditValue = "";
            textBoxUserName.Location = new Point(102, 297);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Properties.Appearance.Font = new Font("Cairo Medium", 11F);
            textBoxUserName.Properties.Appearance.Options.UseFont = true;
            textBoxUserName.Properties.AppearanceDisabled.Font = new Font("Cairo Medium", 11F);
            textBoxUserName.Properties.AppearanceDisabled.Options.UseFont = true;
            textBoxUserName.Properties.AppearanceDropDown.Font = new Font("Cairo Medium", 11F);
            textBoxUserName.Properties.AppearanceDropDown.Options.UseFont = true;
            textBoxUserName.Properties.AppearanceFocused.Font = new Font("Cairo Medium", 11F);
            textBoxUserName.Properties.AppearanceFocused.Options.UseFont = true;
            textBoxUserName.Properties.AppearanceItemDisabled.Font = new Font("Cairo Medium", 11F);
            textBoxUserName.Properties.AppearanceItemDisabled.Options.UseFont = true;
            textBoxUserName.Properties.AppearanceItemHighlight.Font = new Font("Cairo Medium", 11F);
            textBoxUserName.Properties.AppearanceItemHighlight.Options.UseFont = true;
            textBoxUserName.Properties.AppearanceItemSelected.Font = new Font("Cairo Medium", 11F);
            textBoxUserName.Properties.AppearanceItemSelected.Options.UseFont = true;
            textBoxUserName.Properties.AppearanceReadOnly.Font = new Font("Cairo Medium", 11F);
            textBoxUserName.Properties.AppearanceReadOnly.Options.UseFont = true;
            textBoxUserName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            textBoxUserName.Size = new Size(265, 40);
            textBoxUserName.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.image_proce;
            pictureBox2.Location = new Point(235, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo Black", 7F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(155, 529);
            label2.Name = "label2";
            label2.Size = new Size(207, 46);
            label2.TabIndex = 6;
            label2.Text = " برنامج رؤيا العراق لإدارة الصيدليات\r\n  © 2025  - جميع الحقوق محفوظة\r\n";
            // 
            // lblTitle
            // 
            lblTitle.Appearance.Font = new Font("Cairo Black", 16F, FontStyle.Bold);
            lblTitle.Appearance.Options.UseFont = true;
            lblTitle.Appearance.Options.UseTextOptions = true;
            lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblTitle.Location = new Point(15, 208);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(429, 50);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "برنامج رؤيا العراق لإدارة الصيدليات";
            // 
            // btnLogin
            // 
            btnLogin.Appearance.BackColor = Color.RoyalBlue;
            btnLogin.Appearance.Font = new Font("Cairo Medium", 10F);
            btnLogin.Appearance.ForeColor = Color.White;
            btnLogin.Appearance.Options.UseBackColor = true;
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Appearance.Options.UseForeColor = true;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(102, 468);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(308, 56);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.Click += btnLogin_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.Location = new Point(273, 341);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(94, 32);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "كلمة المرور";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Cairo Medium", 10F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl2.Location = new Point(249, 262);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(118, 32);
            labelControl2.TabIndex = 10;
            labelControl2.Text = "اسم المستخدم";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(3, 3);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 11;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.Profile;
            pictureBox3.Location = new Point(377, 299);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.Lock;
            pictureBox4.Location = new Point(377, 384);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Cairo Black", 16F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl3.Location = new Point(237, 156);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(110, 50);
            labelControl3.TabIndex = 14;
            labelControl3.Text = "مرحبا بك";
            // 
            // separatorControl1
            // 
            separatorControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            separatorControl1.BackColor = Color.WhiteSmoke;
            separatorControl1.LineColor = Color.RoyalBlue;
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 4;
            separatorControl1.Location = new Point(-10, -7);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new Size(23, 665);
            separatorControl1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(564, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 646);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(SwitchLang);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(labelControl3);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(textBoxUserName);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(labelControl2);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(labelControl1);
            panel2.Location = new Point(-1, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 578);
            panel2.TabIndex = 17;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // SwitchLang
            // 
            SwitchLang.Cursor = Cursors.Hand;
            SwitchLang.Location = new Point(102, 433);
            SwitchLang.Name = "SwitchLang";
            SwitchLang.Properties.Appearance.BackColor = Color.Transparent;
            SwitchLang.Properties.Appearance.Font = new Font("Cairo Medium", 9F);
            SwitchLang.Properties.Appearance.Options.UseBackColor = true;
            SwitchLang.Properties.Appearance.Options.UseFont = true;
            SwitchLang.Properties.AppearanceDisabled.Font = new Font("Cairo Medium", 9F);
            SwitchLang.Properties.AppearanceDisabled.Options.UseFont = true;
            SwitchLang.Properties.AppearanceFocused.Font = new Font("Cairo Medium", 9F);
            SwitchLang.Properties.AppearanceFocused.Options.UseFont = true;
            SwitchLang.Properties.AppearanceReadOnly.Font = new Font("Cairo Medium", 9F);
            SwitchLang.Properties.AppearanceReadOnly.Options.UseFont = true;
            SwitchLang.Properties.OffText = "عربي";
            SwitchLang.Properties.OnText = "انجليزي";
            SwitchLang.RightToLeft = RightToLeft.Yes;
            SwitchLang.Size = new Size(265, 33);
            SwitchLang.TabIndex = 15;
            SwitchLang.Toggled += SwitchLang_Toggled;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(978, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(63, 578);
            panel3.TabIndex = 18;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Location = new Point(19, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(26, 367);
            panel4.TabIndex = 15;
            // 
            // UserLogin
            // 
            Appearance.BackColor = Color.Black;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 646);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XtraForm1";
            TransparencyKey = Color.Black;
            MouseDown += UserLogin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SwitchLang.Properties).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxPassword;
        private DevExpress.XtraEditors.ComboBoxEdit textBoxUserName;
        private PictureBox pictureBox2;
        private Label label2;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DevExpress.XtraEditors.ToggleSwitch SwitchLang;
    }
}