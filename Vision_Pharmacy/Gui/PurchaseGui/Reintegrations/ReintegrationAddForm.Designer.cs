namespace Vision_Pharmacy.Gui.PurchaseGui.Reintegrations
{
    partial class ReintegrationAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReintegrationAddForm));
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lblSupForm = new Label();
            DGListeReturns = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label19 = new Label();
            txtNotes = new TextBox();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            panel6 = new Panel();
            txtTimerClock = new TextBox();
            txtdate = new TextBox();
            separatorControl22 = new DevExpress.XtraEditors.SeparatorControl();
            txtTotalAmount = new TextBox();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSaleDate = new TextBox();
            txtCustomer = new TextBox();
            label1 = new Label();
            label3 = new Label();
            lblEmpEmail = new Label();
            txtFactureNum = new ComboBox();
            label2 = new Label();
            txtDoctors = new TextBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGListeReturns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl22).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Controls.Add(separatorControl1);
            flowLayoutPanel2.Controls.Add(lblSupForm);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1456, 64);
            flowLayoutPanel2.TabIndex = 67;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.feedback_loop_14662074;
            pictureBox2.Location = new Point(1380, 2);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1362, 2);
            separatorControl1.Margin = new Padding(4, 2, 4, 2);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 55);
            separatorControl1.TabIndex = 1;
            // 
            // lblSupForm
            // 
            lblSupForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSupForm.AutoSize = true;
            lblSupForm.Font = new Font("Cairo Medium", 12F);
            lblSupForm.ForeColor = Color.Black;
            lblSupForm.Location = new Point(925, 0);
            lblSupForm.Margin = new Padding(4, 0, 4, 0);
            lblSupForm.Name = "lblSupForm";
            lblSupForm.Size = new Size(429, 37);
            lblSupForm.TabIndex = 1;
            lblSupForm.Text = "إدارة المبيعات و المرجعات >  اضافة مرجعات جديدة";
            // 
            // DGListeReturns
            // 
            DGListeReturns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGListeReturns.EmbeddedNavigator.Margin = new Padding(4, 2, 4, 2);
            DGListeReturns.Location = new Point(0, 165);
            DGListeReturns.MainView = gridView1;
            DGListeReturns.Margin = new Padding(4, 2, 4, 2);
            DGListeReturns.Name = "DGListeReturns";
            DGListeReturns.Size = new Size(1456, 407);
            DGListeReturns.TabIndex = 89;
            DGListeReturns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.CustomizationFormHint.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            gridView1.Appearance.DetailTip.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.DetailTip.Options.UseFont = true;
            gridView1.Appearance.EvenRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.EvenRow.Options.UseFont = true;
            gridView1.Appearance.FilterPanel.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.FilterPanel.Options.UseFont = true;
            gridView1.Appearance.FocusedCell.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.FocusedCell.Options.UseFont = true;
            gridView1.Appearance.FocusedRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.FocusedRow.Options.UseFont = true;
            gridView1.Appearance.FooterPanel.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.FooterPanel.Options.UseFont = true;
            gridView1.Appearance.GroupFooter.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.GroupFooter.Options.UseFont = true;
            gridView1.Appearance.GroupPanel.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.GroupRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.GroupRow.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HideSelectionRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            gridView1.Appearance.HotTrackedRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            gridView1.Appearance.NoSearchResults.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.NoSearchResults.Options.UseFont = true;
            gridView1.Appearance.OddRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.OddRow.Options.UseFont = true;
            gridView1.Appearance.Preview.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.Preview.Options.UseFont = true;
            gridView1.Appearance.Row.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.SelectedRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.SelectedRow.Options.UseFont = true;
            gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            gridView1.Appearance.TopNewRow.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.TopNewRow.Options.UseFont = true;
            gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.ViewCaption.Font = new Font("Cairo Medium", 12F);
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.GridControl = DGListeReturns;
            gridView1.Name = "gridView1";
            gridView1.KeyDown += gridView1_KeyDown;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label19);
            flowLayoutPanel1.Controls.Add(txtNotes);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 689);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1456, 46);
            flowLayoutPanel1.TabIndex = 91;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Cairo Medium", 9F);
            label19.Location = new Point(1383, 12);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(69, 29);
            label19.TabIndex = 84;
            label19.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.BackColor = Color.FromArgb(232, 246, 255);
            txtNotes.Font = new Font("Cairo Medium", 9F);
            txtNotes.Location = new Point(215, 3);
            txtNotes.Margin = new Padding(4, 2, 4, 2);
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "تسجيل ملاحظات";
            txtNotes.Size = new Size(1160, 36);
            txtNotes.TabIndex = 85;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Appearance.BackColor = SystemColors.Highlight;
            btnSave.Appearance.Font = new Font("Cairo Medium", 10F);
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearanceDisabled.Options.UseFont = true;
            btnSave.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearanceHovered.Options.UseFont = true;
            btnSave.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnSave.AppearancePressed.Options.UseFont = true;
            btnSave.Cursor = Cursors.Hand;
            btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSave.ImageOptions.SvgImage");
            btnSave.ImageOptions.SvgImageSize = new Size(25, 25);
            btnSave.Location = new Point(27, 2);
            btnSave.Margin = new Padding(4, 2, 4, 2);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(180, 37);
            btnSave.TabIndex = 83;
            btnSave.Text = "حفظ";
            btnSave.ToolTipTitle = "حفظ";
            btnSave.Click += btnSave_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(txtTimerClock);
            panel6.Controls.Add(txtdate);
            panel6.Controls.Add(separatorControl22);
            panel6.Controls.Add(txtTotalAmount);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(0, 575);
            panel6.Margin = new Padding(4, 2, 4, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1456, 113);
            panel6.TabIndex = 92;
            // 
            // txtTimerClock
            // 
            txtTimerClock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimerClock.BackColor = Color.Black;
            txtTimerClock.BorderStyle = BorderStyle.None;
            txtTimerClock.Font = new Font("Technology", 16F, FontStyle.Bold);
            txtTimerClock.ForeColor = Color.DeepSkyBlue;
            txtTimerClock.Location = new Point(1298, 65);
            txtTimerClock.Margin = new Padding(4, 2, 4, 2);
            txtTimerClock.Name = "txtTimerClock";
            txtTimerClock.RightToLeft = RightToLeft.No;
            txtTimerClock.Size = new Size(133, 27);
            txtTimerClock.TabIndex = 111;
            txtTimerClock.Text = "14:00:12";
            txtTimerClock.TextAlign = HorizontalAlignment.Center;
            // 
            // txtdate
            // 
            txtdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtdate.BackColor = Color.Black;
            txtdate.BorderStyle = BorderStyle.None;
            txtdate.Font = new Font("Technology", 18F, FontStyle.Bold);
            txtdate.ForeColor = Color.DeepSkyBlue;
            txtdate.Location = new Point(1275, 16);
            txtdate.Margin = new Padding(4, 2, 4, 2);
            txtdate.Name = "txtdate";
            txtdate.RightToLeft = RightToLeft.No;
            txtdate.Size = new Size(156, 30);
            txtdate.TabIndex = 110;
            txtdate.Text = "10/08/2025";
            txtdate.TextAlign = HorizontalAlignment.Center;
            // 
            // separatorControl22
            // 
            separatorControl22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            separatorControl22.BackColor = Color.Black;
            separatorControl22.LineColor = Color.DarkGray;
            separatorControl22.LineOrientation = Orientation.Vertical;
            separatorControl22.LineThickness = 2;
            separatorControl22.Location = new Point(1256, -5);
            separatorControl22.Margin = new Padding(4, 2, 4, 2);
            separatorControl22.Name = "separatorControl22";
            separatorControl22.Padding = new Padding(0);
            separatorControl22.Size = new Size(10, 118);
            separatorControl22.TabIndex = 105;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTotalAmount.BackColor = Color.Black;
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.Font = new Font("Technology", 45F);
            txtTotalAmount.ForeColor = Color.Lime;
            txtTotalAmount.Location = new Point(4, 33);
            txtTotalAmount.Margin = new Padding(4, 2, 4, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.RightToLeft = RightToLeft.No;
            txtTotalAmount.Size = new Size(545, 75);
            txtTotalAmount.TabIndex = 94;
            txtTotalAmount.Text = "0.00";
            txtTotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Cairo Medium", 16F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(557, 42);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(307, 50);
            label6.TabIndex = 93;
            label6.Text = "السعر الفاتورة  الاجمالي";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.6826916F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.31731F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 424F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 499F));
            tableLayoutPanel1.Controls.Add(txtSaleDate, 3, 1);
            tableLayoutPanel1.Controls.Add(txtCustomer, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(lblEmpEmail, 2, 1);
            tableLayoutPanel1.Controls.Add(txtFactureNum, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(txtDoctors, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.35165F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.64835F));
            tableLayoutPanel1.Size = new Size(1456, 95);
            tableLayoutPanel1.TabIndex = 93;
            // 
            // txtSaleDate
            // 
            txtSaleDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSaleDate.BackColor = Color.FromArgb(227, 237, 249);
            txtSaleDate.Font = new Font("Cairo Medium", 10F);
            txtSaleDate.Location = new Point(504, 47);
            txtSaleDate.Margin = new Padding(4, 2, 4, 2);
            txtSaleDate.Name = "txtSaleDate";
            txtSaleDate.ReadOnly = true;
            txtSaleDate.Size = new Size(416, 39);
            txtSaleDate.TabIndex = 95;
            txtSaleDate.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomer
            // 
            txtCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomer.BackColor = Color.FromArgb(227, 237, 249);
            txtCustomer.Font = new Font("Cairo Medium", 10F);
            txtCustomer.Location = new Point(1044, 47);
            txtCustomer.Margin = new Padding(4, 2, 4, 2);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(297, 39);
            txtCustomer.TabIndex = 94;
            txtCustomer.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cairo Medium", 9F);
            label1.Location = new Point(1364, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 29);
            label1.TabIndex = 53;
            label1.Text = "رقم الفاتورة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cairo Medium", 9F);
            label3.Location = new Point(1395, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 29);
            label3.TabIndex = 79;
            label3.Text = "العميل";
            // 
            // lblEmpEmail
            // 
            lblEmpEmail.AutoSize = true;
            lblEmpEmail.BackColor = Color.White;
            lblEmpEmail.Font = new Font("Cairo Medium", 9F);
            lblEmpEmail.Location = new Point(965, 45);
            lblEmpEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmpEmail.Name = "lblEmpEmail";
            lblEmpEmail.Size = new Size(71, 29);
            lblEmpEmail.TabIndex = 63;
            lblEmpEmail.Text = "تاريخ البيع";
            // 
            // txtFactureNum
            // 
            txtFactureNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFactureNum.BackColor = Color.FromArgb(227, 237, 249);
            txtFactureNum.FlatStyle = FlatStyle.System;
            txtFactureNum.Font = new Font("Cairo Medium", 10F);
            txtFactureNum.FormattingEnabled = true;
            txtFactureNum.Location = new Point(1044, 2);
            txtFactureNum.Margin = new Padding(4, 2, 4, 2);
            txtFactureNum.Name = "txtFactureNum";
            txtFactureNum.Size = new Size(297, 40);
            txtFactureNum.TabIndex = 96;
            txtFactureNum.KeyDown += txtFactureNum_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cairo Medium", 9F);
            label2.Location = new Point(982, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 29);
            label2.TabIndex = 93;
            label2.Text = "الطبيب";
            // 
            // txtDoctors
            // 
            txtDoctors.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDoctors.BackColor = Color.FromArgb(227, 237, 249);
            txtDoctors.Font = new Font("Cairo Medium", 10F);
            txtDoctors.Location = new Point(504, 2);
            txtDoctors.Margin = new Padding(4, 2, 4, 2);
            txtDoctors.Name = "txtDoctors";
            txtDoctors.ReadOnly = true;
            txtDoctors.Size = new Size(416, 39);
            txtDoctors.TabIndex = 94;
            txtDoctors.TextAlign = HorizontalAlignment.Center;
            // 
            // ReintegrationAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 735);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel6);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(DGListeReturns);
            Controls.Add(flowLayoutPanel2);
            Name = "ReintegrationAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اظافة مرجعات";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGListeReturns).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl22).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Label lblSupForm;
        private DevExpress.XtraGrid.GridControl DGListeReturns;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label19;
        private TextBox txtNotes;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        private Panel panel6;
        private TextBox txtTimerClock;
        private TextBox txtdate;
        private DevExpress.XtraEditors.SeparatorControl separatorControl22;
        private TextBox txtTotalAmount;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label lblEmpEmail;
        private Label label2;
        private TextBox txtSaleDate;
        private TextBox txtCustomer;
        private TextBox txtDoctors;
        private ComboBox txtFactureNum;
    }
}