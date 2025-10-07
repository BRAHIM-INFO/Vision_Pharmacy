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
            tabPageServer = new DevExpress.XtraEditors.GroupControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            radioButtonLocalConnect = new DevExpress.XtraEditors.ToggleSwitch();
            textBoxPassword = new TextBox();
            labelServer = new Label();
            labelPassword = new Label();
            textBoxUser = new TextBox();
            textBoxServer = new TextBox();
            textBoxPort = new TextBox();
            labelUser = new Label();
            labelDataBase = new Label();
            textBoxDataBase = new TextBox();
            labelPort = new Label();
            buttonSaveServerSettings = new DevExpress.XtraEditors.SimpleButton();
            tabPageGeneral = new DevExpress.XtraEditors.GroupControl();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            labelCompanyName = new Label();
            numericUpDownDamageDuration = new NumericUpDown();
            textBoxCompanyName = new TextBox();
            labelDamageDuration = new Label();
            labelCompanyAdress = new Label();
            comboBoxCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            textBoxCompanyAdress = new TextBox();
            labelCurrency = new Label();
            labelCompanyTel = new Label();
            textBoxCompanyTel = new TextBox();
            labelCompanyEmail = new Label();
            textBoxCompanyEmail = new TextBox();
            pictureBoxCompanyLogo = new PictureBox();
            buttonSaveGeneralSettings = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            PicLang = new PictureBox();
            SwitchLang = new DevExpress.XtraEditors.ToggleSwitch();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            buttonBackUp = new DevExpress.XtraEditors.SimpleButton();
            buttonRestore = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)tabPageServer).BeginInit();
            tabPageServer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radioButtonLocalConnect.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabPageGeneral).BeginInit();
            tabPageGeneral.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDamageDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SwitchLang.Properties).BeginInit();
            SuspendLayout();
            // 
            // tabPageServer
            // 
            tabPageServer.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            tabPageServer.Appearance.Options.UseBackColor = true;
            tabPageServer.AppearanceCaption.BorderColor = Color.FromArgb(74, 89, 180);
            tabPageServer.AppearanceCaption.Font = new Font("Cairo Medium", 10F);
            tabPageServer.AppearanceCaption.Options.UseBorderColor = true;
            tabPageServer.AppearanceCaption.Options.UseFont = true;
            tabPageServer.Controls.Add(tableLayoutPanel1);
            tabPageServer.Location = new Point(12, 12);
            tabPageServer.Name = "tabPageServer";
            tabPageServer.Size = new Size(457, 531);
            tabPageServer.TabIndex = 0;
            tabPageServer.Text = "اعدادات السيرفر";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.09934F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.9006653F));
            tableLayoutPanel1.Controls.Add(radioButtonLocalConnect, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxPassword, 1, 5);
            tableLayoutPanel1.Controls.Add(labelServer, 0, 1);
            tableLayoutPanel1.Controls.Add(labelPassword, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxUser, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxServer, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxPort, 1, 3);
            tableLayoutPanel1.Controls.Add(labelUser, 0, 4);
            tableLayoutPanel1.Controls.Add(labelDataBase, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxDataBase, 1, 2);
            tableLayoutPanel1.Controls.Add(labelPort, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonSaveServerSettings, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.5555573F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.4444427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 177F));
            tableLayoutPanel1.Size = new Size(453, 496);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // radioButtonLocalConnect
            // 
            radioButtonLocalConnect.Location = new Point(126, 3);
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
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Font = new Font("Cairo Medium", 12F);
            textBoxPassword.Location = new Point(3, 262);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.RightToLeft = RightToLeft.No;
            textBoxPassword.Size = new Size(288, 45);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.Text = "12345";
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.BackColor = Color.White;
            labelServer.Font = new Font("Cairo Medium", 10F);
            labelServer.ForeColor = Color.Black;
            labelServer.Location = new Point(386, 45);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(64, 32);
            labelServer.TabIndex = 8;
            labelServer.Text = "السيرفر";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.White;
            labelPassword.Font = new Font("Cairo Medium", 10F);
            labelPassword.ForeColor = Color.Black;
            labelPassword.Location = new Point(364, 259);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(86, 32);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "كلمة السر";
            // 
            // textBoxUser
            // 
            textBoxUser.Enabled = false;
            textBoxUser.Font = new Font("Cairo Medium", 12F);
            textBoxUser.Location = new Point(3, 210);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.RightToLeft = RightToLeft.No;
            textBoxUser.Size = new Size(288, 45);
            textBoxUser.TabIndex = 11;
            textBoxUser.Text = "sa";
            textBoxUser.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxServer
            // 
            textBoxServer.Font = new Font("Cairo Medium", 12F);
            textBoxServer.Location = new Point(3, 48);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.RightToLeft = RightToLeft.No;
            textBoxServer.Size = new Size(288, 45);
            textBoxServer.TabIndex = 3;
            textBoxServer.Text = ".\\SQLEXPRESS";
            textBoxServer.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPort
            // 
            textBoxPort.Enabled = false;
            textBoxPort.Font = new Font("Cairo Medium", 12F);
            textBoxPort.Location = new Point(3, 157);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.RightToLeft = RightToLeft.No;
            textBoxPort.Size = new Size(288, 45);
            textBoxPort.TabIndex = 10;
            textBoxPort.Text = "1433";
            textBoxPort.TextAlign = HorizontalAlignment.Center;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.White;
            labelUser.Font = new Font("Cairo Medium", 10F);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(330, 207);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(120, 32);
            labelUser.TabIndex = 5;
            labelUser.Text = "اسم المستخدم";
            // 
            // labelDataBase
            // 
            labelDataBase.AutoSize = true;
            labelDataBase.BackColor = Color.White;
            labelDataBase.Font = new Font("Cairo Medium", 10F);
            labelDataBase.ForeColor = Color.Black;
            labelDataBase.Location = new Point(339, 98);
            labelDataBase.Name = "labelDataBase";
            labelDataBase.Size = new Size(111, 32);
            labelDataBase.TabIndex = 7;
            labelDataBase.Text = "قاعدة البيانات";
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Font = new Font("Cairo Medium", 12F);
            textBoxDataBase.Location = new Point(3, 101);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.RightToLeft = RightToLeft.No;
            textBoxDataBase.Size = new Size(288, 45);
            textBoxDataBase.TabIndex = 9;
            textBoxDataBase.Text = "DB_VisionPharmacy";
            textBoxDataBase.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.BackColor = Color.White;
            labelPort.Font = new Font("Cairo Medium", 10F);
            labelPort.ForeColor = Color.Black;
            labelPort.Location = new Point(389, 154);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(61, 32);
            labelPort.TabIndex = 6;
            labelPort.Text = "المنفذ";
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
            buttonSaveServerSettings.Dock = DockStyle.Bottom;
            buttonSaveServerSettings.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveServerSettings.ImageOptions.SvgImage");
            buttonSaveServerSettings.ImageOptions.SvgImageSize = new Size(25, 25);
            buttonSaveServerSettings.Location = new Point(3, 447);
            buttonSaveServerSettings.Name = "buttonSaveServerSettings";
            buttonSaveServerSettings.Size = new Size(288, 46);
            buttonSaveServerSettings.TabIndex = 9;
            buttonSaveServerSettings.Text = "حفظ اعدادات الاتصال";
            buttonSaveServerSettings.Click += buttonSaveServerSettings_Click;
            // 
            // tabPageGeneral
            // 
            tabPageGeneral.AppearanceCaption.BorderColor = Color.FromArgb(74, 89, 180);
            tabPageGeneral.AppearanceCaption.Font = new Font("Cairo Medium", 10F);
            tabPageGeneral.AppearanceCaption.Options.UseBorderColor = true;
            tabPageGeneral.AppearanceCaption.Options.UseFont = true;
            tabPageGeneral.Controls.Add(tableLayoutPanel2);
            tabPageGeneral.Location = new Point(475, 12);
            tabPageGeneral.Name = "tabPageGeneral";
            tabPageGeneral.Size = new Size(579, 566);
            tabPageGeneral.TabIndex = 1;
            tabPageGeneral.Text = "اعدادات عامة";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.9373856F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0626144F));
            tableLayoutPanel2.Controls.Add(label1, 0, 6);
            tableLayoutPanel2.Controls.Add(labelCompanyName, 0, 0);
            tableLayoutPanel2.Controls.Add(numericUpDownDamageDuration, 1, 5);
            tableLayoutPanel2.Controls.Add(textBoxCompanyName, 1, 0);
            tableLayoutPanel2.Controls.Add(labelDamageDuration, 0, 5);
            tableLayoutPanel2.Controls.Add(labelCompanyAdress, 0, 1);
            tableLayoutPanel2.Controls.Add(comboBoxCurrency, 1, 4);
            tableLayoutPanel2.Controls.Add(textBoxCompanyAdress, 1, 1);
            tableLayoutPanel2.Controls.Add(labelCurrency, 0, 4);
            tableLayoutPanel2.Controls.Add(labelCompanyTel, 0, 2);
            tableLayoutPanel2.Controls.Add(textBoxCompanyTel, 1, 2);
            tableLayoutPanel2.Controls.Add(labelCompanyEmail, 0, 3);
            tableLayoutPanel2.Controls.Add(textBoxCompanyEmail, 1, 3);
            tableLayoutPanel2.Controls.Add(pictureBoxCompanyLogo, 0, 7);
            tableLayoutPanel2.Controls.Add(buttonSaveGeneralSettings, 1, 7);
            tableLayoutPanel2.Controls.Add(panel1, 1, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.0980377F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.9019623F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel2.Size = new Size(575, 531);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cairo Medium", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(476, 332);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 24;
            label1.Text = "لغة البرنامج";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.BackColor = Color.White;
            labelCompanyName.Font = new Font("Cairo Medium", 10F);
            labelCompanyName.ForeColor = Color.Black;
            labelCompanyName.Location = new Point(465, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(107, 32);
            labelCompanyName.TabIndex = 10;
            labelCompanyName.Text = "اسم الصيدلية";
            // 
            // numericUpDownDamageDuration
            // 
            numericUpDownDamageDuration.Font = new Font("Tahoma", 12F);
            numericUpDownDamageDuration.Location = new Point(86, 272);
            numericUpDownDamageDuration.Name = "numericUpDownDamageDuration";
            numericUpDownDamageDuration.Size = new Size(268, 32);
            numericUpDownDamageDuration.TabIndex = 22;
            numericUpDownDamageDuration.TextAlign = HorizontalAlignment.Center;
            numericUpDownDamageDuration.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Font = new Font("Cairo Medium", 12F);
            textBoxCompanyName.Location = new Point(3, 3);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.RightToLeft = RightToLeft.No;
            textBoxCompanyName.Size = new Size(351, 45);
            textBoxCompanyName.TabIndex = 9;
            textBoxCompanyName.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDamageDuration
            // 
            labelDamageDuration.AutoSize = true;
            labelDamageDuration.BackColor = Color.White;
            labelDamageDuration.Font = new Font("Cairo Medium", 10F);
            labelDamageDuration.ForeColor = Color.Black;
            labelDamageDuration.Location = new Point(431, 269);
            labelDamageDuration.Name = "labelDamageDuration";
            labelDamageDuration.Size = new Size(141, 63);
            labelDamageDuration.TabIndex = 21;
            labelDamageDuration.Text = "التذكير للمواد التي\r\n سوف تتلف (يوم)";
            // 
            // labelCompanyAdress
            // 
            labelCompanyAdress.AutoSize = true;
            labelCompanyAdress.BackColor = Color.White;
            labelCompanyAdress.Font = new Font("Cairo Medium", 10F);
            labelCompanyAdress.ForeColor = Color.Black;
            labelCompanyAdress.Location = new Point(506, 44);
            labelCompanyAdress.Name = "labelCompanyAdress";
            labelCompanyAdress.Size = new Size(66, 32);
            labelCompanyAdress.TabIndex = 12;
            labelCompanyAdress.Text = "العنوان";
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.EditValue = "";
            comboBoxCurrency.Location = new Point(89, 217);
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
            // textBoxCompanyAdress
            // 
            textBoxCompanyAdress.Font = new Font("Cairo Medium", 12F);
            textBoxCompanyAdress.Location = new Point(3, 47);
            textBoxCompanyAdress.Name = "textBoxCompanyAdress";
            textBoxCompanyAdress.RightToLeft = RightToLeft.No;
            textBoxCompanyAdress.Size = new Size(351, 45);
            textBoxCompanyAdress.TabIndex = 11;
            textBoxCompanyAdress.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCurrency
            // 
            labelCurrency.AutoSize = true;
            labelCurrency.BackColor = Color.White;
            labelCurrency.Font = new Font("Cairo Medium", 10F);
            labelCurrency.ForeColor = Color.Black;
            labelCurrency.Location = new Point(510, 214);
            labelCurrency.Name = "labelCurrency";
            labelCurrency.Size = new Size(62, 32);
            labelCurrency.TabIndex = 19;
            labelCurrency.Text = "العملة";
            // 
            // labelCompanyTel
            // 
            labelCompanyTel.AutoSize = true;
            labelCompanyTel.BackColor = Color.White;
            labelCompanyTel.Font = new Font("Cairo Medium", 10F);
            labelCompanyTel.ForeColor = Color.Black;
            labelCompanyTel.Location = new Point(509, 97);
            labelCompanyTel.Name = "labelCompanyTel";
            labelCompanyTel.Size = new Size(63, 32);
            labelCompanyTel.TabIndex = 14;
            labelCompanyTel.Text = "الهاتف";
            // 
            // textBoxCompanyTel
            // 
            textBoxCompanyTel.Font = new Font("Cairo Medium", 12F);
            textBoxCompanyTel.Location = new Point(3, 100);
            textBoxCompanyTel.Name = "textBoxCompanyTel";
            textBoxCompanyTel.RightToLeft = RightToLeft.No;
            textBoxCompanyTel.Size = new Size(351, 45);
            textBoxCompanyTel.TabIndex = 13;
            textBoxCompanyTel.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCompanyEmail
            // 
            labelCompanyEmail.AutoSize = true;
            labelCompanyEmail.BackColor = Color.White;
            labelCompanyEmail.Font = new Font("Cairo Medium", 10F);
            labelCompanyEmail.ForeColor = Color.Black;
            labelCompanyEmail.Location = new Point(508, 156);
            labelCompanyEmail.Name = "labelCompanyEmail";
            labelCompanyEmail.Size = new Size(64, 32);
            labelCompanyEmail.TabIndex = 16;
            labelCompanyEmail.Text = "الايميل";
            // 
            // textBoxCompanyEmail
            // 
            textBoxCompanyEmail.Font = new Font("Cairo Medium", 12F);
            textBoxCompanyEmail.Location = new Point(3, 159);
            textBoxCompanyEmail.Name = "textBoxCompanyEmail";
            textBoxCompanyEmail.RightToLeft = RightToLeft.No;
            textBoxCompanyEmail.Size = new Size(351, 45);
            textBoxCompanyEmail.TabIndex = 15;
            textBoxCompanyEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxCompanyLogo
            // 
            pictureBoxCompanyLogo.Image = Properties.Resources.logo_2025;
            pictureBoxCompanyLogo.Location = new Point(360, 407);
            pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
            pictureBoxCompanyLogo.Size = new Size(212, 121);
            pictureBoxCompanyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCompanyLogo.TabIndex = 17;
            pictureBoxCompanyLogo.TabStop = false;
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
            buttonSaveGeneralSettings.Location = new Point(3, 407);
            buttonSaveGeneralSettings.Name = "buttonSaveGeneralSettings";
            buttonSaveGeneralSettings.Size = new Size(351, 68);
            buttonSaveGeneralSettings.TabIndex = 23;
            buttonSaveGeneralSettings.Text = "حفظ الاعدادات";
            buttonSaveGeneralSettings.Click += buttonSaveGeneralSettings_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PicLang);
            panel1.Controls.Add(SwitchLang);
            panel1.Location = new Point(64, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 51);
            panel1.TabIndex = 25;
            // 
            // PicLang
            // 
            PicLang.Dock = DockStyle.Right;
            PicLang.Image = Properties.Resources.Arab;
            PicLang.Location = new Point(231, 0);
            PicLang.Name = "PicLang";
            PicLang.Size = new Size(59, 51);
            PicLang.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLang.TabIndex = 18;
            PicLang.TabStop = false;
            // 
            // SwitchLang
            // 
            SwitchLang.Cursor = Cursors.Hand;
            SwitchLang.Location = new Point(41, 10);
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
            SwitchLang.Size = new Size(184, 33);
            SwitchLang.TabIndex = 17;
            SwitchLang.Toggled += SwitchLang_Toggled;
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
            simpleButton1.Location = new Point(259, 580);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(140, 35);
            simpleButton1.TabIndex = 18;
            simpleButton1.Text = "شعار";
            simpleButton1.Click += simpleButton1_Click;
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
            buttonBackUp.Location = new Point(475, 584);
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
            buttonRestore.Location = new Point(755, 584);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(299, 114);
            buttonRestore.TabIndex = 11;
            buttonRestore.Text = "          استعادة النسخة";
            buttonRestore.Click += buttonRestore_Click;
            // 
            // SettingsForm
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 709);
            Controls.Add(simpleButton1);
            Controls.Add(buttonRestore);
            Controls.Add(buttonBackUp);
            Controls.Add(tabPageGeneral);
            Controls.Add(tabPageServer);
            Name = "SettingsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الاعدادات";
            ((System.ComponentModel.ISupportInitialize)tabPageServer).EndInit();
            tabPageServer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radioButtonLocalConnect.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabPageGeneral).EndInit();
            tabPageGeneral.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDamageDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompanyLogo).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicLang).EndInit();
            ((System.ComponentModel.ISupportInitialize)SwitchLang.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl tabPageServer;
        private DevExpress.XtraEditors.GroupControl tabPageGeneral;
        private DevExpress.XtraEditors.ToggleSwitch radioButtonLocalConnect;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
        private TextBox textBoxPort;
        private TextBox textBoxDataBase;
        private Label labelPassword;
        private Label labelUser;
        private Label labelPort;
        private Label labelDataBase;
        private Label labelServer;
        private TextBox textBoxServer;
        private DevExpress.XtraEditors.SimpleButton buttonSaveServerSettings;
        private Label labelCompanyAdress;
        private TextBox textBoxCompanyAdress;
        private Label labelCompanyName;
        private TextBox textBoxCompanyName;
        private Label labelCompanyEmail;
        private TextBox textBoxCompanyEmail;
        private Label labelCompanyTel;
        private TextBox textBoxCompanyTel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private PictureBox pictureBoxCompanyLogo;
        private Label labelCurrency;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxCurrency;
        private NumericUpDown numericUpDownDamageDuration;
        private Label labelDamageDuration;
        private DevExpress.XtraEditors.SimpleButton buttonBackUp;
        private DevExpress.XtraEditors.SimpleButton buttonRestore;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private DevExpress.XtraEditors.SimpleButton buttonSaveGeneralSettings;
        private Panel panel1;
        private PictureBox PicLang;
        private DevExpress.XtraEditors.ToggleSwitch SwitchLang;
    }
}