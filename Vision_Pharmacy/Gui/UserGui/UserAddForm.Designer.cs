namespace Vision_Pharmacy.Gui.UserGui
{
    partial class UserAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddForm));
            comboBoxRole = new DevExpress.XtraEditors.ComboBoxEdit();
            label4 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxUserName = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            buttonSave = new DevExpress.XtraEditors.SimpleButton();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            label5 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            lblSup = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)comboBoxRole.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxRole.Location = new Point(160, 363);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Properties.Appearance.Font = new Font("Cairo Medium", 10F);
            comboBoxRole.Properties.Appearance.Options.UseFont = true;
            comboBoxRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxRole.Properties.Items.AddRange(new object[] { "مدير", "مستخدم" });
            comboBoxRole.Size = new Size(454, 38);
            comboBoxRole.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Cairo Medium", 10F);
            label4.Location = new Point(56, 366);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 7;
            label4.Text = "الصلاحية";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cairo Medium", 10F);
            label3.Location = new Point(45, 297);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 5;
            label3.Text = "كلمة السر";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPassword.Font = new Font("Cairo Medium", 10F);
            textBoxPassword.Location = new Point(160, 297);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(454, 39);
            textBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cairo Medium", 10F);
            label2.Location = new Point(11, 223);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 3;
            label2.Text = "اسم المستخدم";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxUserName.Font = new Font("Cairo Medium", 10F);
            textBoxUserName.Location = new Point(160, 223);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(454, 39);
            textBoxUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cairo Medium", 10F);
            label1.Location = new Point(72, 155);
            label1.Name = "label1";
            label1.Size = new Size(59, 32);
            label1.TabIndex = 1;
            label1.Text = "الاسم:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxName.Font = new Font("Cairo Medium", 10F);
            textBoxName.Location = new Point(160, 152);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(454, 39);
            textBoxName.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            buttonSave.Appearance.Font = new Font("Cairo Medium", 10F);
            buttonSave.Appearance.Options.UseBackColor = true;
            buttonSave.Appearance.Options.UseFont = true;
            buttonSave.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            buttonSave.AppearanceDisabled.Options.UseFont = true;
            buttonSave.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            buttonSave.AppearanceHovered.Options.UseFont = true;
            buttonSave.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            buttonSave.AppearancePressed.Options.UseFont = true;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSave.ImageOptions.SvgImage");
            buttonSave.ImageOptions.SvgImageSize = new Size(25, 25);
            buttonSave.Location = new Point(483, 564);
            buttonSave.Name = "buttonSave";
            buttonSave.RightToLeft = RightToLeft.Yes;
            buttonSave.Size = new Size(159, 45);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "حفظ";
            buttonSave.ToolTipTitle = "اضافة";
            buttonSave.Click += buttonSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(24, 571);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 12;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cairo Medium", 14F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(432, 14);
            label5.Name = "label5";
            label5.Size = new Size(157, 45);
            label5.TabIndex = 2;
            label5.Text = "مستخدم جديد";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Cairo Medium", 10F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(133, 366);
            label9.Name = "label9";
            label9.Size = new Size(21, 32);
            label9.TabIndex = 17;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Cairo Medium", 10F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(133, 304);
            label8.Name = "label8";
            label8.Size = new Size(21, 32);
            label8.TabIndex = 16;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Cairo Medium", 10F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(133, 226);
            label7.Name = "label7";
            label7.Size = new Size(21, 32);
            label7.TabIndex = 15;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Cairo Medium", 10F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(133, 159);
            label6.Name = "label6";
            label6.Size = new Size(21, 32);
            label6.TabIndex = 14;
            label6.Text = "*";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Users2;
            pictureBox2.Location = new Point(595, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.top_view;
            pictureBox1.Location = new Point(660, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 632);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(232, 246, 255);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblSup);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 70);
            panel1.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.Supplier;
            pictureBox4.Location = new Point(1342, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // lblSup
            // 
            lblSup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSup.AutoSize = true;
            lblSup.Font = new Font("Cairo Medium", 12F);
            lblSup.ForeColor = Color.Black;
            lblSup.Location = new Point(1193, 18);
            lblSup.Name = "lblSup";
            lblSup.Size = new Size(143, 37);
            lblSup.TabIndex = 1;
            lblSup.Text = "قائمة الموردين";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(649, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // UserAddForm
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 632);
            Controls.Add(panel1);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxRole);
            Controls.Add(label9);
            Controls.Add(textBoxPassword);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxName);
            Controls.Add(label8);
            Controls.Add(textBoxUserName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة مستخدم";
            FormClosing += UserAddForm_FormClosing;
            MouseDown += UserAddForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)comboBoxRole.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxName;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label2;
        private TextBox textBoxUserName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxRole;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label lblSup;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}