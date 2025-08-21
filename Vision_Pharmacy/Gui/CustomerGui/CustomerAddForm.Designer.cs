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
            panel1 = new Panel();
            label1 = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox3 = new PictureBox();
            label6 = new Label();
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
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Resources._3850595;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo Medium", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(572, 22);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 18;
            label1.Text = "ادارة العملاء >  اضافة عميل  جديد";
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
            pictureBox3.Image = Resources.trolley_9284599;
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
            // lblCustomerEmail
            // 
            lblCustomerEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.BackColor = Color.White;
            lblCustomerEmail.Font = new Font("Cairo Medium", 10F);
            lblCustomerEmail.Location = new Point(802, 229);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(124, 32);
            lblCustomerEmail.TabIndex = 24;
            lblCustomerEmail.Text = "البريد الإلكتروني";
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.BackColor = Color.White;
            lblCustomerPhone.Font = new Font("Cairo Medium", 10F);
            lblCustomerPhone.Location = new Point(802, 160);
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
            buttonSaveSup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveSup.ImageOptions.SvgImage");
            buttonSaveSup.ImageOptions.SvgImageSize = new Size(25, 25);
            buttonSaveSup.Location = new Point(343, 471);
            buttonSaveSup.Name = "buttonSaveSup";
            buttonSaveSup.RightToLeft = RightToLeft.Yes;
            buttonSaveSup.Size = new Size(159, 45);
            buttonSaveSup.TabIndex = 26;
            buttonSaveSup.Text = "حفظ";
            buttonSaveSup.ToolTipTitle = "اضافة";
            buttonSaveSup.Click += buttonSaveSup_Click;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerPhone.BackColor = Color.FromArgb(232, 246, 255);
            txtCustomerPhone.Font = new Font("Cairo Medium", 10F);
            txtCustomerPhone.Location = new Point(343, 160);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(452, 39);
            txtCustomerPhone.TabIndex = 22;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.BackColor = Color.White;
            lblCustomerAddress.Font = new Font("Cairo Medium", 10F);
            lblCustomerAddress.Location = new Point(802, 89);
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
            txtCustomerName.Location = new Point(343, 15);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(452, 39);
            txtCustomerName.TabIndex = 18;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerAddress.BackColor = Color.FromArgb(232, 246, 255);
            txtCustomerAddress.Font = new Font("Cairo Medium", 10F);
            txtCustomerAddress.Location = new Point(343, 86);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(452, 39);
            txtCustomerAddress.TabIndex = 20;
            // 
            // lblCustomerName
            // 
            lblCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerName.AutoSize = true;
            lblCustomerName.BackColor = Color.White;
            lblCustomerName.Font = new Font("Cairo Medium", 10F);
            lblCustomerName.Location = new Point(793, 22);
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
            PicChange.Image = Resources.pictur;
            PicChange.Location = new Point(222, 15);
            PicChange.Name = "PicChange";
            PicChange.Size = new Size(107, 103);
            PicChange.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChange.TabIndex = 32;
            PicChange.TabStop = false;
            PicChange.Click += PicChange_Click;
            // 
            // lblCustomerNotes
            // 
            lblCustomerNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomerNotes.AutoSize = true;
            lblCustomerNotes.BackColor = Color.White;
            lblCustomerNotes.Font = new Font("Cairo Medium", 10F);
            lblCustomerNotes.Location = new Point(802, 299);
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
            txtCustomerEmail.Location = new Point(343, 226);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(452, 39);
            txtCustomerEmail.TabIndex = 36;
            // 
            // txtCustomerNotes
            // 
            txtCustomerNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerNotes.Font = new Font("Cairo Medium", 10F);
            txtCustomerNotes.Location = new Point(343, 299);
            txtCustomerNotes.Multiline = true;
            txtCustomerNotes.Name = "txtCustomerNotes";
            txtCustomerNotes.Size = new Size(452, 137);
            txtCustomerNotes.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(PicChange);
            panel2.Controls.Add(txtCustomerNotes);
            panel2.Controls.Add(buttonSaveSup);
            panel2.Controls.Add(txtCustomerEmail);
            panel2.Controls.Add(txtCustomerName);
            panel2.Controls.Add(lblCustomerNotes);
            panel2.Controls.Add(lblCustomerName);
            panel2.Controls.Add(txtCustomerAddress);
            panel2.Controls.Add(lblCustomerAddress);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCustomerPhone);
            panel2.Controls.Add(lblCustomerEmail);
            panel2.Controls.Add(lblCustomerPhone);
            panel2.Location = new Point(26, 109);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(963, 531);
            panel2.TabIndex = 40;
            // 
            // CustumerAddForm
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
            Name = "CustumerAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerAddForm";
            MouseDown += CustomerAddForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicChange).EndInit();
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
        private Label lblCustomerEmail;
        private Label lblCustomerPhone;
        private DevExpress.XtraEditors.SimpleButton buttonSaveSup;
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
        private Label label1;
        private Panel panel2;
    }
}