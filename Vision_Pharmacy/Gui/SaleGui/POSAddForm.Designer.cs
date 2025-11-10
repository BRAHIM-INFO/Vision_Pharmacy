namespace Vision_Pharmacy.Gui.SaleGui
{
    partial class POSAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSAddForm));
            pnlTop = new FlowLayoutPanel();
            PicLaterale = new PictureBox();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            lblTitlePurchase = new Label();
            pnlSet = new FlowLayoutPanel();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            lblCounter = new Label();
            pnlListMedic = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtDoctors = new ComboBox();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            pnlSet.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(lblTitlePurchase);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1306, 60);
            pnlTop.TabIndex = 39;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Transparent;
            PicLaterale.Image = Properties.Resources.fax_machine_16457032;
            PicLaterale.Location = new Point(1234, 2);
            PicLaterale.Margin = new Padding(3, 2, 3, 2);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(69, 57);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 26;
            PicLaterale.TabStop = false;
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 8;
            SeparatLat.Location = new Point(1219, 2);
            SeparatLat.Margin = new Padding(3, 2, 3, 2);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(9, 57);
            SeparatLat.TabIndex = 1;
            // 
            // lblTitlePurchase
            // 
            lblTitlePurchase.AutoSize = true;
            lblTitlePurchase.Font = new Font("Cairo Medium", 12F);
            lblTitlePurchase.ForeColor = Color.White;
            lblTitlePurchase.Location = new Point(1094, 0);
            lblTitlePurchase.Name = "lblTitlePurchase";
            lblTitlePurchase.Size = new Size(119, 30);
            lblTitlePurchase.TabIndex = 1;
            lblTitlePurchase.Text = "نقطة بيع الأدوية";
            // 
            // pnlSet
            // 
            pnlSet.Controls.Add(btnPrint);
            pnlSet.Controls.Add(btnAdd);
            pnlSet.Controls.Add(lblCounter);
            pnlSet.Dock = DockStyle.Top;
            pnlSet.Location = new Point(0, 60);
            pnlSet.Margin = new Padding(3, 2, 3, 2);
            pnlSet.Name = "pnlSet";
            pnlSet.RightToLeft = RightToLeft.No;
            pnlSet.Size = new Size(1306, 43);
            pnlSet.TabIndex = 41;
            // 
            // btnPrint
            // 
            btnPrint.Appearance.BackColor = Color.Gray;
            btnPrint.Appearance.Font = new Font("Cairo Medium", 10F);
            btnPrint.Appearance.Options.UseBackColor = true;
            btnPrint.Appearance.Options.UseFont = true;
            btnPrint.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnPrint.AppearanceDisabled.Options.UseFont = true;
            btnPrint.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnPrint.AppearanceHovered.Options.UseFont = true;
            btnPrint.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnPrint.AppearancePressed.Options.UseFont = true;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrint.Location = new Point(3, 2);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(117, 37);
            btnPrint.TabIndex = 35;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.FromArgb(74, 89, 180);
            btnAdd.Appearance.Font = new Font("Cairo Medium", 10F);
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnAdd.AppearanceDisabled.Options.UseFont = true;
            btnAdd.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnAdd.AppearanceHovered.Options.UseFont = true;
            btnAdd.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnAdd.AppearancePressed.Options.UseFont = true;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAdd.ImageOptions.SvgImage");
            btnAdd.ImageOptions.SvgImageSize = new Size(25, 25);
            btnAdd.Location = new Point(126, 2);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(117, 37);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Font = new Font("Cairo Medium", 12F);
            lblCounter.ForeColor = Color.Black;
            lblCounter.Location = new Point(249, 0);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(22, 30);
            lblCounter.TabIndex = 37;
            lblCounter.Text = "0";
            // 
            // pnlListMedic
            // 
            pnlListMedic.AutoScroll = true;
            pnlListMedic.BackColor = Color.White;
            pnlListMedic.FlowDirection = FlowDirection.RightToLeft;
            pnlListMedic.Location = new Point(2, 84);
            pnlListMedic.Name = "pnlListMedic";
            pnlListMedic.Size = new Size(430, 533);
            pnlListMedic.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(490, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo Medium", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(90, 3);
            label1.Name = "label1";
            label1.Size = new Size(20, 26);
            label1.TabIndex = 38;
            label1.Text = "0";
            // 
            // groupControl1
            // 
            groupControl1.Appearance.BackColor = Color.WhiteSmoke;
            groupControl1.Appearance.Options.UseBackColor = true;
            groupControl1.AppearanceCaption.Font = new Font("Cairo Medium", 10F);
            groupControl1.AppearanceCaption.ForeColor = Color.Black;
            groupControl1.AppearanceCaption.Options.UseBackColor = true;
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(txtDoctors);
            groupControl1.Controls.Add(separatorControl1);
            groupControl1.Controls.Add(pnlListMedic);
            groupControl1.Dock = DockStyle.Left;
            groupControl1.Location = new Point(0, 103);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(432, 617);
            groupControl1.TabIndex = 45;
            groupControl1.Text = "قائمة الأدوية";
            // 
            // txtDoctors
            // 
            txtDoctors.BackColor = Color.White;
            txtDoctors.FlatStyle = FlatStyle.System;
            txtDoctors.Font = new Font("Cairo Medium", 10F);
            txtDoctors.FormattingEnabled = true;
            txtDoctors.Location = new Point(5, 27);
            txtDoctors.Margin = new Padding(3, 2, 3, 2);
            txtDoctors.Name = "txtDoctors";
            txtDoctors.Size = new Size(347, 32);
            txtDoctors.TabIndex = 3;
            // 
            // separatorControl1
            // 
            separatorControl1.Location = new Point(0, 55);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new Size(462, 23);
            separatorControl1.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Cairo Medium", 10F);
            label5.Location = new Point(358, 33);
            label5.Name = "label5";
            label5.Size = new Size(59, 26);
            label5.TabIndex = 95;
            label5.Text = "التصنيف";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.A__1_;
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // POSAddForm
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupControl1);
            Controls.Add(pnlSet);
            Controls.Add(pnlTop);
            Name = "POSAddForm";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1306, 720);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            pnlSet.ResumeLayout(false);
            pnlSet.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlTop;
        private PictureBox PicLaterale;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private Label lblTitlePurchase;
        private FlowLayoutPanel pnlSet;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private Label lblCounter;
        private FlowLayoutPanel pnlListMedic;
        private Panel panel1;
        private Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private ComboBox txtDoctors;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
