namespace Vision_Pharmacy.Gui.SettingGui
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            buttonSaveServerSettings = new DevExpress.XtraEditors.SimpleButton();
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
            textBoxPort = new TextBox();
            textBoxDataBase = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            textBoxServer = new TextBox();
            radioButtonLocalConnect = new DevExpress.XtraEditors.ToggleSwitch();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            buttonSaveGeneralSettings = new DevExpress.XtraEditors.SimpleButton();
            numericUpDownDamageDuration = new NumericUpDown();
            label11 = new Label();
            comboBoxCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            label10 = new Label();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            pictureBoxCompanyLogo = new PictureBox();
            label4 = new Label();
            textBoxCompanyEmail = new TextBox();
            label3 = new Label();
            textBoxCompanyTel = new TextBox();
            label2 = new Label();
            textBoxCompanyAdress = new TextBox();
            label1 = new Label();
            textBoxCompanyName = new TextBox();
            buttonBackUp = new DevExpress.XtraEditors.SimpleButton();
            buttonRestore = new DevExpress.XtraEditors.SimpleButton();
            groupBoxServer = new Label();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radioButtonLocalConnect.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDamageDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            groupControl1.Appearance.Options.UseBackColor = true;
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(74, 89, 180);
            groupControl1.AppearanceCaption.Font = new Font("Cairo Medium", 10F);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(buttonSaveServerSettings);
            groupControl1.Controls.Add(textBoxPassword);
            groupControl1.Controls.Add(textBoxUser);
            groupControl1.Controls.Add(textBoxPort);
            groupControl1.Controls.Add(textBoxDataBase);
            groupControl1.Controls.Add(label9);
            groupControl1.Controls.Add(label7);
            groupControl1.Controls.Add(label6);
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(label8);
            groupControl1.Controls.Add(textBoxServer);
            groupControl1.Controls.Add(radioButtonLocalConnect);
            groupControl1.Location = new Point(12, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(457, 492);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "اعدادات السيرفر";
            // 
            // buttonSaveServerSettings
            // 
            buttonSaveServerSettings.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            buttonSaveServerSettings.Appearance.Font = new Font("Cairo Medium", 10F);
            buttonSaveServerSettings.Appearance.ForeColor = Color.White;
            buttonSaveServerSettings.Appearance.Options.UseBackColor = true;
            buttonSaveServerSettings.Appearance.Options.UseFont = true;
            buttonSaveServerSettings.Appearance.Options.UseForeColor = true;
            buttonSaveServerSettings.Cursor = Cursors.Hand;
            buttonSaveServerSettings.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveServerSettings.ImageOptions.SvgImage");
            buttonSaveServerSettings.ImageOptions.SvgImageSize = new Size(25, 25);
            buttonSaveServerSettings.Location = new Point(22, 434);
            buttonSaveServerSettings.Name = "buttonSaveServerSettings";
            buttonSaveServerSettings.Size = new Size(194, 46);
            buttonSaveServerSettings.TabIndex = 9;
            buttonSaveServerSettings.Text = "حفظ";
            buttonSaveServerSettings.Click += buttonSaveServerSettings_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Cairo Medium", 12F);
            textBoxPassword.Location = new Point(22, 353);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.RightToLeft = RightToLeft.No;
            textBoxPassword.Size = new Size(300, 45);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.Text = "12345";
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Cairo Medium", 12F);
            textBoxUser.Location = new Point(22, 297);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.RightToLeft = RightToLeft.No;
            textBoxUser.Size = new Size(300, 45);
            textBoxUser.TabIndex = 11;
            textBoxUser.Text = "sa";
            textBoxUser.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPort
            // 
            textBoxPort.Font = new Font("Cairo Medium", 12F);
            textBoxPort.Location = new Point(22, 238);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.RightToLeft = RightToLeft.No;
            textBoxPort.Size = new Size(300, 45);
            textBoxPort.TabIndex = 10;
            textBoxPort.Text = "1433";
            textBoxPort.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Font = new Font("Cairo Medium", 12F);
            textBoxDataBase.Location = new Point(22, 178);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.RightToLeft = RightToLeft.No;
            textBoxDataBase.Size = new Size(300, 45);
            textBoxDataBase.TabIndex = 9;
            textBoxDataBase.Text = "DB_VisionPharmacy";
            textBoxDataBase.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(229, 230, 234);
            label9.Font = new Font("Cairo Medium", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(331, 366);
            label9.Name = "label9";
            label9.Size = new Size(86, 32);
            label9.TabIndex = 4;
            label9.Text = "كلمة السر";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(229, 230, 234);
            label7.Font = new Font("Cairo Medium", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(331, 310);
            label7.Name = "label7";
            label7.Size = new Size(120, 32);
            label7.TabIndex = 5;
            label7.Text = "اسم المستخدم";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(229, 230, 234);
            label6.Font = new Font("Cairo Medium", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(331, 251);
            label6.Name = "label6";
            label6.Size = new Size(61, 32);
            label6.TabIndex = 6;
            label6.Text = "المنفذ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(229, 230, 234);
            label5.Font = new Font("Cairo Medium", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(328, 191);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 7;
            label5.Text = "قاعدة البيانات";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(229, 230, 234);
            label8.Font = new Font("Cairo Medium", 10F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(328, 131);
            label8.Name = "label8";
            label8.Size = new Size(64, 32);
            label8.TabIndex = 8;
            label8.Text = "السيرفر";
            // 
            // textBoxServer
            // 
            textBoxServer.Font = new Font("Cairo Medium", 12F);
            textBoxServer.Location = new Point(22, 118);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.RightToLeft = RightToLeft.No;
            textBoxServer.Size = new Size(300, 45);
            textBoxServer.TabIndex = 3;
            textBoxServer.Text = ".\\SQLEXPRESS";
            textBoxServer.TextAlign = HorizontalAlignment.Center;
            // 
            // radioButtonLocalConnect
            // 
            radioButtonLocalConnect.Location = new Point(157, 59);
            radioButtonLocalConnect.Name = "radioButtonLocalConnect";
            radioButtonLocalConnect.Properties.Appearance.Font = new Font("Cairo Medium", 10F);
            radioButtonLocalConnect.Properties.Appearance.Options.UseFont = true;
            radioButtonLocalConnect.Properties.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            radioButtonLocalConnect.Properties.AppearanceDisabled.Options.UseFont = true;
            radioButtonLocalConnect.Properties.AppearanceFocused.Font = new Font("Cairo Medium", 10F);
            radioButtonLocalConnect.Properties.AppearanceFocused.Options.UseFont = true;
            radioButtonLocalConnect.Properties.AppearanceReadOnly.Font = new Font("Cairo Medium", 10F);
            radioButtonLocalConnect.Properties.AppearanceReadOnly.Options.UseFont = true;
            radioButtonLocalConnect.Properties.OffText = "محلي";
            radioButtonLocalConnect.Properties.OnText = "شبكة";
            radioButtonLocalConnect.Size = new Size(165, 36);
            radioButtonLocalConnect.TabIndex = 0;
            radioButtonLocalConnect.Toggled += radioButtonLocalConnect_Toggled;
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = Color.FromArgb(74, 89, 180);
            groupControl2.AppearanceCaption.Font = new Font("Cairo Medium", 10F);
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.AppearanceCaption.Options.UseFont = true;
            groupControl2.Controls.Add(buttonSaveGeneralSettings);
            groupControl2.Controls.Add(numericUpDownDamageDuration);
            groupControl2.Controls.Add(label11);
            groupControl2.Controls.Add(comboBoxCurrency);
            groupControl2.Controls.Add(label10);
            groupControl2.Controls.Add(simpleButton1);
            groupControl2.Controls.Add(pictureBoxCompanyLogo);
            groupControl2.Controls.Add(label4);
            groupControl2.Controls.Add(textBoxCompanyEmail);
            groupControl2.Controls.Add(label3);
            groupControl2.Controls.Add(textBoxCompanyTel);
            groupControl2.Controls.Add(label2);
            groupControl2.Controls.Add(textBoxCompanyAdress);
            groupControl2.Controls.Add(label1);
            groupControl2.Controls.Add(textBoxCompanyName);
            groupControl2.Location = new Point(475, 12);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(579, 492);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "اعدادات عامة";
            // 
            // buttonSaveGeneralSettings
            // 
            buttonSaveGeneralSettings.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            buttonSaveGeneralSettings.Appearance.Font = new Font("Cairo Medium", 10F);
            buttonSaveGeneralSettings.Appearance.ForeColor = Color.White;
            buttonSaveGeneralSettings.Appearance.Options.UseBackColor = true;
            buttonSaveGeneralSettings.Appearance.Options.UseFont = true;
            buttonSaveGeneralSettings.Appearance.Options.UseForeColor = true;
            buttonSaveGeneralSettings.Cursor = Cursors.Hand;
            buttonSaveGeneralSettings.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveGeneralSettings.ImageOptions.SvgImage");
            buttonSaveGeneralSettings.ImageOptions.SvgImageSize = new Size(25, 25);
            buttonSaveGeneralSettings.Location = new Point(189, 437);
            buttonSaveGeneralSettings.Name = "buttonSaveGeneralSettings";
            buttonSaveGeneralSettings.Size = new Size(265, 46);
            buttonSaveGeneralSettings.TabIndex = 23;
            buttonSaveGeneralSettings.Text = "حفظ الاعدادات";
            buttonSaveGeneralSettings.Click += buttonSaveGeneralSettings_Click;
            // 
            // numericUpDownDamageDuration
            // 
            numericUpDownDamageDuration.Font = new Font("Tahoma", 12F);
            numericUpDownDamageDuration.Location = new Point(189, 396);
            numericUpDownDamageDuration.Name = "numericUpDownDamageDuration";
            numericUpDownDamageDuration.Size = new Size(265, 32);
            numericUpDownDamageDuration.TabIndex = 22;
            numericUpDownDamageDuration.TextAlign = HorizontalAlignment.Center;
            numericUpDownDamageDuration.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(229, 230, 234);
            label11.Font = new Font("Cairo Medium", 10F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(190, 353);
            label11.Name = "label11";
            label11.Size = new Size(264, 32);
            label11.TabIndex = 21;
            label11.Text = "التذكير للمواد التي سوف تتلف (يوم)";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.EditValue = "";
            comboBoxCurrency.Location = new Point(189, 307);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Properties.Appearance.Font = new Font("Cairo Medium", 11F);
            comboBoxCurrency.Properties.Appearance.Options.UseFont = true;
            comboBoxCurrency.Properties.AppearanceDisabled.Font = new Font("Cairo Medium", 11F);
            comboBoxCurrency.Properties.AppearanceDisabled.Options.UseFont = true;
            comboBoxCurrency.Properties.AppearanceDropDown.Font = new Font("Cairo Medium", 11F);
            comboBoxCurrency.Properties.AppearanceDropDown.Options.UseFont = true;
            comboBoxCurrency.Properties.AppearanceFocused.Font = new Font("Cairo Medium", 11F);
            comboBoxCurrency.Properties.AppearanceFocused.Options.UseFont = true;
            comboBoxCurrency.Properties.AppearanceItemDisabled.Font = new Font("Cairo Medium", 11F);
            comboBoxCurrency.Properties.AppearanceItemDisabled.Options.UseFont = true;
            comboBoxCurrency.Properties.AppearanceItemHighlight.Font = new Font("Cairo Medium", 11F);
            comboBoxCurrency.Properties.AppearanceItemHighlight.Options.UseFont = true;
            comboBoxCurrency.Properties.AppearanceItemSelected.Font = new Font("Cairo Medium", 11F);
            comboBoxCurrency.Properties.AppearanceItemSelected.Options.UseFont = true;
            comboBoxCurrency.Properties.AppearanceReadOnly.Font = new Font("Cairo Medium", 11F);
            comboBoxCurrency.Properties.AppearanceReadOnly.Options.UseFont = true;
            comboBoxCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxCurrency.Properties.Items.AddRange(new object[] { "(د.ع)", "($)" });
            comboBoxCurrency.Size = new Size(265, 40);
            comboBoxCurrency.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(229, 230, 234);
            label10.Font = new Font("Cairo Medium", 10F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(460, 315);
            label10.Name = "label10";
            label10.Size = new Size(62, 32);
            label10.TabIndex = 19;
            label10.Text = "العملة";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            simpleButton1.Appearance.Font = new Font("Cairo Medium", 8F);
            simpleButton1.Appearance.ForeColor = Color.White;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Cursor = Cursors.Hand;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.ImageOptions.SvgImageSize = new Size(20, 20);
            simpleButton1.Location = new Point(31, 445);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(140, 35);
            simpleButton1.TabIndex = 18;
            simpleButton1.Text = "شعار";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // pictureBoxCompanyLogo
            // 
            pictureBoxCompanyLogo.Image = Properties.Resources.logo_2025;
            pictureBoxCompanyLogo.Location = new Point(31, 310);
            pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
            pictureBoxCompanyLogo.Size = new Size(140, 129);
            pictureBoxCompanyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCompanyLogo.TabIndex = 17;
            pictureBoxCompanyLogo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(229, 230, 234);
            label4.Font = new Font("Cairo Medium", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(460, 255);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 16;
            label4.Text = "الايميل";
            // 
            // textBoxCompanyEmail
            // 
            textBoxCompanyEmail.Font = new Font("Cairo Medium", 12F);
            textBoxCompanyEmail.Location = new Point(31, 248);
            textBoxCompanyEmail.Name = "textBoxCompanyEmail";
            textBoxCompanyEmail.RightToLeft = RightToLeft.No;
            textBoxCompanyEmail.Size = new Size(423, 45);
            textBoxCompanyEmail.TabIndex = 15;
            textBoxCompanyEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(229, 230, 234);
            label3.Font = new Font("Cairo Medium", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(460, 193);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 14;
            label3.Text = "الهاتف";
            // 
            // textBoxCompanyTel
            // 
            textBoxCompanyTel.Font = new Font("Cairo Medium", 12F);
            textBoxCompanyTel.Location = new Point(31, 186);
            textBoxCompanyTel.Name = "textBoxCompanyTel";
            textBoxCompanyTel.RightToLeft = RightToLeft.No;
            textBoxCompanyTel.Size = new Size(423, 45);
            textBoxCompanyTel.TabIndex = 13;
            textBoxCompanyTel.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(229, 230, 234);
            label2.Font = new Font("Cairo Medium", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(460, 127);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 12;
            label2.Text = "العنوان";
            // 
            // textBoxCompanyAdress
            // 
            textBoxCompanyAdress.Font = new Font("Cairo Medium", 12F);
            textBoxCompanyAdress.Location = new Point(31, 120);
            textBoxCompanyAdress.Name = "textBoxCompanyAdress";
            textBoxCompanyAdress.RightToLeft = RightToLeft.No;
            textBoxCompanyAdress.Size = new Size(423, 45);
            textBoxCompanyAdress.TabIndex = 11;
            textBoxCompanyAdress.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(229, 230, 234);
            label1.Font = new Font("Cairo Medium", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(460, 61);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 10;
            label1.Text = "اسم الصيدلية";
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Font = new Font("Cairo Medium", 12F);
            textBoxCompanyName.Location = new Point(31, 54);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.RightToLeft = RightToLeft.No;
            textBoxCompanyName.Size = new Size(423, 45);
            textBoxCompanyName.TabIndex = 9;
            textBoxCompanyName.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonBackUp
            // 
            buttonBackUp.Appearance.BackColor = Color.Teal;
            buttonBackUp.Appearance.Font = new Font("Cairo Medium", 13F);
            buttonBackUp.Appearance.ForeColor = Color.White;
            buttonBackUp.Appearance.Options.UseBackColor = true;
            buttonBackUp.Appearance.Options.UseFont = true;
            buttonBackUp.Appearance.Options.UseForeColor = true;
            buttonBackUp.Cursor = Cursors.Hand;
            buttonBackUp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonBackUp.ImageOptions.SvgImage");
            buttonBackUp.ImageOptions.SvgImageSize = new Size(60, 60);
            buttonBackUp.Location = new Point(475, 510);
            buttonBackUp.Name = "buttonBackUp";
            buttonBackUp.Size = new Size(274, 114);
            buttonBackUp.TabIndex = 10;
            buttonBackUp.Text = "    اخذ نسخة احتياطية";
            buttonBackUp.Click += buttonBackUp_Click;
            // 
            // buttonRestore
            // 
            buttonRestore.Appearance.BackColor = Color.FromArgb(192, 0, 0);
            buttonRestore.Appearance.Font = new Font("Cairo Medium", 12F);
            buttonRestore.Appearance.ForeColor = Color.White;
            buttonRestore.Appearance.Options.UseBackColor = true;
            buttonRestore.Appearance.Options.UseFont = true;
            buttonRestore.Appearance.Options.UseForeColor = true;
            buttonRestore.Cursor = Cursors.Hand;
            buttonRestore.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonRestore.ImageOptions.SvgImage");
            buttonRestore.ImageOptions.SvgImageSize = new Size(60, 60);
            buttonRestore.Location = new Point(755, 510);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(299, 114);
            buttonRestore.TabIndex = 11;
            buttonRestore.Text = "          استعادة النسخة";
            buttonRestore.Click += buttonRestore_Click;
            // 
            // groupBoxServer
            // 
            groupBoxServer.AutoSize = true;
            groupBoxServer.BackColor = Color.FromArgb(229, 230, 234);
            groupBoxServer.Font = new Font("Cairo Medium", 10F);
            groupBoxServer.ForeColor = Color.Black;
            groupBoxServer.Location = new Point(194, 510);
            groupBoxServer.Name = "groupBoxServer";
            groupBoxServer.Size = new Size(86, 32);
            groupBoxServer.TabIndex = 12;
            groupBoxServer.Text = "كلمة السر";
            // 
            // SettingsForm
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 656);
            Controls.Add(groupBoxServer);
            Controls.Add(buttonRestore);
            Controls.Add(buttonBackUp);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "SettingsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الاعدادات";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radioButtonLocalConnect.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDamageDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ToggleSwitch radioButtonLocalConnect;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
        private TextBox textBoxPort;
        private TextBox textBoxDataBase;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox textBoxServer;
        private DevExpress.XtraEditors.SimpleButton buttonSaveServerSettings;
        private Label label2;
        private TextBox textBoxCompanyAdress;
        private Label label1;
        private TextBox textBoxCompanyName;
        private Label label4;
        private TextBox textBoxCompanyEmail;
        private Label label3;
        private TextBox textBoxCompanyTel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private PictureBox pictureBoxCompanyLogo;
        private Label label10;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxCurrency;
        private NumericUpDown numericUpDownDamageDuration;
        private Label label11;
        private DevExpress.XtraEditors.SimpleButton buttonBackUp;
        private DevExpress.XtraEditors.SimpleButton buttonRestore;
        private DevExpress.XtraEditors.SimpleButton buttonSaveGeneralSettings;
        private Label groupBoxServer;
    }
}