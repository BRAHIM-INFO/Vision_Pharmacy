using Vision_Pharmacy.Properties;

namespace Vision_Pharmacy.Gui.CustomerGui
{
    partial class CustomerAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAddForm));
            pictureBox1 = new PictureBox();
            lbltitle = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox3 = new PictureBox();
            lblCustomerEmail = new Label();
            lblCustomerPhone = new Label();
            buttonSaveSup = new DevExpress.XtraEditors.SimpleButton();
            txtCustomerPhone = new TextBox();
            lblCustomerAddress = new Label();
            txtCustomerName = new TextBox();
            txtCustomerAddress = new TextBox();
            lblCustomerName = new Label();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            PicChange = new PictureBox();
            lblCustomerNotes = new Label();
            txtCustomerEmail = new TextBox();
            txtCustomerNotes = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Resources._3850595;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // lbltitle
            // 
            lbltitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Cairo Medium", 12F);
            lbltitle.ForeColor = Color.Black;
            lbltitle.Location = new Point(644, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(296, 37);
            lbltitle.TabIndex = 18;
            lbltitle.Text = "ادارة العملاء >  اضافة عميل  جديد";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(946, 3);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.Image = Resources.trolley_9284599;
            pictureBox3.Location = new Point(962, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.BackColor = Color.Transparent;
            lblCustomerEmail.Font = new Font("Cairo Medium", 10F);
            lblCustomerEmail.Location = new Point(645, 152);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(124, 32);
            lblCustomerEmail.TabIndex = 24;
            lblCustomerEmail.Text = "البريد الإلكتروني";
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.BackColor = Color.Transparent;
            lblCustomerPhone.Font = new Font("Cairo Medium", 10F);
            lblCustomerPhone.Location = new Point(645, 100);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(63, 32);
            lblCustomerPhone.TabIndex = 23;
            lblCustomerPhone.Text = "الهاتف";
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
            // txtCustomerPhone
            // 
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerPhone.BackColor = Color.FromArgb(232, 246, 255);
            txtCustomerPhone.Font = new Font("Cairo Medium", 10F);
            txtCustomerPhone.Location = new Point(186, 103);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(452, 39);
            txtCustomerPhone.TabIndex = 22;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.BackColor = Color.Transparent;
            lblCustomerAddress.Font = new Font("Cairo Medium", 10F);
            lblCustomerAddress.Location = new Point(645, 50);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(66, 32);
            lblCustomerAddress.TabIndex = 21;
            lblCustomerAddress.Text = "العنوان";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerName.BackColor = Color.FromArgb(232, 246, 255);
            txtCustomerName.Font = new Font("Cairo Medium", 10F);
            txtCustomerName.Location = new Point(186, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(452, 39);
            txtCustomerName.TabIndex = 18;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerAddress.BackColor = Color.FromArgb(232, 246, 255);
            txtCustomerAddress.Font = new Font("Cairo Medium", 10F);
            txtCustomerAddress.Location = new Point(186, 53);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(452, 39);
            txtCustomerAddress.TabIndex = 20;
            // 
            // lblCustomerName
            // 
            lblCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerName.AutoSize = true;
            lblCustomerName.BackColor = Color.Transparent;
            lblCustomerName.Font = new Font("Cairo Medium", 10F);
            lblCustomerName.Location = new Point(645, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(167, 32);
            lblCustomerName.TabIndex = 19;
            lblCustomerName.Text = "اسم العميل / المريض";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ImageOptions.SvgImageSize = new Size(25, 25);
            btnClose.Location = new Point(12, 646);
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
            PicChange.Image = Resources.pictur;
            PicChange.Location = new Point(9, 200);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(171, 137);
            PicChange.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChange.TabIndex = 32;
            PicChange.TabStop = false;
            PicChange.Click += PicChange_Click;
            // 
            // lblCustomerNotes
            // 
            lblCustomerNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerNotes.AutoSize = true;
            lblCustomerNotes.BackColor = Color.Transparent;
            lblCustomerNotes.Font = new Font("Cairo Medium", 10F);
            lblCustomerNotes.Location = new Point(645, 197);
            lblCustomerNotes.Name = "lblCustomerNotes";
            lblCustomerNotes.Size = new Size(131, 32);
            lblCustomerNotes.TabIndex = 35;
            lblCustomerNotes.Text = "ملاحظات إضافية";
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerEmail.BackColor = Color.FromArgb(232, 246, 255);
            txtCustomerEmail.Font = new Font("Cairo Medium", 10F);
            txtCustomerEmail.Location = new Point(186, 155);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(452, 39);
            txtCustomerEmail.TabIndex = 36;
            // 
            // txtCustomerNotes
            // 
            txtCustomerNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerNotes.Font = new Font("Cairo Medium", 10F);
            txtCustomerNotes.Location = new Point(186, 200);
            txtCustomerNotes.Multiline = true;
            txtCustomerNotes.Name = "txtCustomerNotes";
            txtCustomerNotes.Size = new Size(452, 137);
            txtCustomerNotes.TabIndex = 37;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(separatorControl1);
            flowLayoutPanel1.Controls.Add(lbltitle);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1045, 68);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7165356F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.28346F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.Controls.Add(lblCustomerName, 0, 0);
            tableLayoutPanel1.Controls.Add(PicChange, 2, 4);
            tableLayoutPanel1.Controls.Add(lblCustomerAddress, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSaveSup, 1, 5);
            tableLayoutPanel1.Controls.Add(txtCustomerNotes, 1, 4);
            tableLayoutPanel1.Controls.Add(txtCustomerName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtCustomerAddress, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCustomerNotes, 0, 4);
            tableLayoutPanel1.Controls.Add(txtCustomerEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(lblCustomerPhone, 0, 2);
            tableLayoutPanel1.Controls.Add(txtCustomerPhone, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCustomerEmail, 0, 3);
            tableLayoutPanel1.Location = new Point(224, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 205F));
            tableLayoutPanel1.Size = new Size(818, 561);
            tableLayoutPanel1.TabIndex = 42;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 68);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1045, 572);
            flowLayoutPanel2.TabIndex = 42;
            // 
            // CustomerAddForm
            // 
            Appearance.BackColor = Color.FromArgb(232, 246, 255);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 698);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerAddForm";
            MouseDown += CustomerAddForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private PictureBox pictureBox3;
        private Label lblCustomerEmail;
        private Label lblCustomerPhone;
        public DevExpress.XtraEditors.SimpleButton buttonSaveSup;
        private TextBox txtCustomerPhone;
        private Label lblCustomerAddress;
        private TextBox txtCustomerName;
        private TextBox txtCustomerAddress;
        private Label lblCustomerName;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private PictureBox PicChange;
        private Label lblCustomerNotes;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerNotes;
        private Label lbltitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}