namespace Vision_Pharmacy.Gui.Doctors
{
    partial class DoctorAddForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorAddForm));
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDoctorName = new Label();
            PicChange = new PictureBox();
            lblDoctorAddress = new Label();
            buttonSaveSup = new DevExpress.XtraEditors.SimpleButton();
            txtDoctorSpecialit = new TextBox();
            txtDoctorName = new TextBox();
            txtDoctorAddress = new TextBox();
            lblDoctorNotes = new Label();
            txtDoctorEmail = new TextBox();
            lblDoctorPhone = new Label();
            txtDoctorPhone = new TextBox();
            lblDoctorEmail = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lbltitle = new Label();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 68);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1047, 572);
            flowLayoutPanel2.TabIndex = 45;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7165356F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.28346F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.Controls.Add(lblDoctorName, 0, 0);
            tableLayoutPanel1.Controls.Add(PicChange, 2, 4);
            tableLayoutPanel1.Controls.Add(lblDoctorAddress, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSaveSup, 1, 5);
            tableLayoutPanel1.Controls.Add(txtDoctorSpecialit, 1, 4);
            tableLayoutPanel1.Controls.Add(txtDoctorName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDoctorAddress, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDoctorNotes, 0, 4);
            tableLayoutPanel1.Controls.Add(txtDoctorEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(lblDoctorPhone, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDoctorPhone, 1, 2);
            tableLayoutPanel1.Controls.Add(lblDoctorEmail, 0, 3);
            tableLayoutPanel1.Location = new Point(226, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 207F));
            tableLayoutPanel1.Size = new Size(818, 561);
            tableLayoutPanel1.TabIndex = 42;
            tableLayoutPanel1.MouseDown += tableLayoutPanel1_MouseDown;
            // 
            // lblDoctorName
            // 
            lblDoctorName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDoctorName.AutoSize = true;
            lblDoctorName.BackColor = Color.Transparent;
            lblDoctorName.Font = new Font("Cairo Medium", 10F);
            lblDoctorName.Location = new Point(645, 0);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(95, 32);
            lblDoctorName.TabIndex = 19;
            lblDoctorName.Text = "اسم الطبيب";
            // 
            // PicChange
            // 
            PicChange.BackColor = Color.White;
            PicChange.Cursor = Cursors.Hand;
            PicChange.Image = Properties.Resources.person_13508516;
            PicChange.Location = new Point(9, 200);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(171, 137);
            PicChange.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChange.TabIndex = 32;
            PicChange.TabStop = false;
            // 
            // lblDoctorAddress
            // 
            lblDoctorAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDoctorAddress.AutoSize = true;
            lblDoctorAddress.BackColor = Color.Transparent;
            lblDoctorAddress.Font = new Font("Cairo Medium", 10F);
            lblDoctorAddress.Location = new Point(645, 50);
            lblDoctorAddress.Name = "lblDoctorAddress";
            lblDoctorAddress.Size = new Size(66, 32);
            lblDoctorAddress.TabIndex = 21;
            lblDoctorAddress.Text = "العنوان";
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
            buttonSaveSup.Dock = DockStyle.Bottom;
            buttonSaveSup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveSup.ImageOptions.SvgImage");
            buttonSaveSup.ImageOptions.SvgImageSize = new Size(25, 25);
            buttonSaveSup.Location = new Point(186, 513);
            buttonSaveSup.Name = "buttonSaveSup";
            buttonSaveSup.RightToLeft = RightToLeft.Yes;
            buttonSaveSup.Size = new Size(453, 45);
            buttonSaveSup.TabIndex = 26;
            buttonSaveSup.Text = "حفظ البيانات";
            buttonSaveSup.ToolTipTitle = "اضافة";
            buttonSaveSup.Click += buttonSaveSup_Click;
            // 
            // txtDoctorSpecialit
            // 
            txtDoctorSpecialit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDoctorSpecialit.BackColor = Color.FromArgb(232, 246, 255);
            txtDoctorSpecialit.Font = new Font("Cairo Medium", 10F);
            txtDoctorSpecialit.Location = new Point(186, 200);
            txtDoctorSpecialit.Name = "txtDoctorSpecialit";
            txtDoctorSpecialit.Size = new Size(452, 39);
            txtDoctorSpecialit.TabIndex = 37;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDoctorName.BackColor = Color.FromArgb(232, 246, 255);
            txtDoctorName.Font = new Font("Cairo Medium", 10F);
            txtDoctorName.Location = new Point(186, 3);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(452, 39);
            txtDoctorName.TabIndex = 18;
            // 
            // txtDoctorAddress
            // 
            txtDoctorAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDoctorAddress.BackColor = Color.FromArgb(232, 246, 255);
            txtDoctorAddress.Font = new Font("Cairo Medium", 10F);
            txtDoctorAddress.Location = new Point(186, 53);
            txtDoctorAddress.Name = "txtDoctorAddress";
            txtDoctorAddress.Size = new Size(452, 39);
            txtDoctorAddress.TabIndex = 20;
            // 
            // lblDoctorNotes
            // 
            lblDoctorNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDoctorNotes.AutoSize = true;
            lblDoctorNotes.BackColor = Color.Transparent;
            lblDoctorNotes.Font = new Font("Cairo Medium", 10F);
            lblDoctorNotes.Location = new Point(645, 197);
            lblDoctorNotes.Name = "lblDoctorNotes";
            lblDoctorNotes.Size = new Size(75, 32);
            lblDoctorNotes.TabIndex = 35;
            lblDoctorNotes.Text = "التخصص";
            // 
            // txtDoctorEmail
            // 
            txtDoctorEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDoctorEmail.BackColor = Color.FromArgb(232, 246, 255);
            txtDoctorEmail.Font = new Font("Cairo Medium", 10F);
            txtDoctorEmail.Location = new Point(186, 155);
            txtDoctorEmail.Name = "txtDoctorEmail";
            txtDoctorEmail.Size = new Size(452, 39);
            txtDoctorEmail.TabIndex = 36;
            // 
            // lblDoctorPhone
            // 
            lblDoctorPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDoctorPhone.AutoSize = true;
            lblDoctorPhone.BackColor = Color.Transparent;
            lblDoctorPhone.Font = new Font("Cairo Medium", 10F);
            lblDoctorPhone.Location = new Point(645, 100);
            lblDoctorPhone.Name = "lblDoctorPhone";
            lblDoctorPhone.Size = new Size(63, 32);
            lblDoctorPhone.TabIndex = 23;
            lblDoctorPhone.Text = "الهاتف";
            // 
            // txtDoctorPhone
            // 
            txtDoctorPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDoctorPhone.BackColor = Color.FromArgb(232, 246, 255);
            txtDoctorPhone.Font = new Font("Cairo Medium", 10F);
            txtDoctorPhone.Location = new Point(186, 103);
            txtDoctorPhone.Name = "txtDoctorPhone";
            txtDoctorPhone.Size = new Size(452, 39);
            txtDoctorPhone.TabIndex = 22;
            // 
            // lblDoctorEmail
            // 
            lblDoctorEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDoctorEmail.AutoSize = true;
            lblDoctorEmail.BackColor = Color.Transparent;
            lblDoctorEmail.Font = new Font("Cairo Medium", 10F);
            lblDoctorEmail.Location = new Point(645, 152);
            lblDoctorEmail.Name = "lblDoctorEmail";
            lblDoctorEmail.Size = new Size(124, 32);
            lblDoctorEmail.TabIndex = 24;
            lblDoctorEmail.Text = "البريد الإلكتروني";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._269;
            pictureBox1.Location = new Point(6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(separatorControl1);
            flowLayoutPanel1.Controls.Add(lbltitle);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1047, 68);
            flowLayoutPanel1.TabIndex = 44;
            flowLayoutPanel1.MouseDown += flowLayoutPanel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.doctor_16182897;
            pictureBox3.Location = new Point(964, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(948, 3);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // lbltitle
            // 
            lbltitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Cairo Medium", 12F);
            lbltitle.ForeColor = Color.Black;
            lbltitle.Location = new Point(778, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(164, 37);
            lbltitle.TabIndex = 18;
            lbltitle.Text = "اضافة طبيب  جديد";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(1004, 646);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 43;
            btnClose.Text = "simpleButton1";
            btnClose.Click += btnClose_Click;
            // 
            // DoctorAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 689);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorAddForm";
            RightToLeft = RightToLeft.Yes;
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDoctorName;
        private PictureBox PicChange;
        private Label lblDoctorAddress;
        public DevExpress.XtraEditors.SimpleButton buttonSaveSup;
        private TextBox txtDoctorSpecialit;
        private TextBox txtDoctorName;
        private TextBox txtDoctorAddress;
        private Label lblDoctorNotes;
        private TextBox txtDoctorEmail;
        private Label lblDoctorPhone;
        private TextBox txtDoctorPhone;
        private Label lblDoctorEmail;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Label lbltitle;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}
