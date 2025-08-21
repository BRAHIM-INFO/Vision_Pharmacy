namespace Vision_Pharmacy.Gui.UserGui
{
    partial class UserUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUserControl));
            panel1 = new Panel();
            label1 = new Label();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureBox1 = new PictureBox();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(60, 71, 151);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(separatorControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo Medium", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(996, 21);
            label1.Name = "label1";
            label1.Size = new Size(175, 37);
            label1.TabIndex = 1;
            label1.Text = "قائمة المستخدمين";
            // 
            // separatorControl1
            // 
            separatorControl1.BackColor = Color.FromArgb(255, 128, 0);
            separatorControl1.Dock = DockStyle.Right;
            separatorControl1.LineColor = Color.FromArgb(255, 128, 0);
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.LineThickness = 10;
            separatorControl1.Location = new Point(1216, 0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new Padding(0);
            separatorControl1.Size = new Size(10, 70);
            separatorControl1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.tasking_15578464;
            pictureBox1.Location = new Point(1226, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Appearance.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Appearance.Font = new Font("Cairo Medium", 10F);
            btnDelete.Appearance.Options.UseBackColor = true;
            btnDelete.Appearance.Options.UseFont = true;
            btnDelete.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnDelete.AppearanceDisabled.Options.UseFont = true;
            btnDelete.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnDelete.AppearanceHovered.Options.UseFont = true;
            btnDelete.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnDelete.AppearancePressed.Options.UseFont = true;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDelete.ImageOptions.SvgImage");
            btnDelete.ImageOptions.SvgImageSize = new Size(25, 25);
            btnDelete.Location = new Point(146, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.Yes;
            btnDelete.Size = new Size(137, 45);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "حذف";
            btnDelete.ToolTipTitle = "اضافة";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Appearance.BackColor = Color.FromArgb(18, 128, 146);
            btnEdit.Appearance.Font = new Font("Cairo Medium", 10F);
            btnEdit.Appearance.Options.UseBackColor = true;
            btnEdit.Appearance.Options.UseFont = true;
            btnEdit.AppearanceDisabled.Font = new Font("Cairo Medium", 10F);
            btnEdit.AppearanceDisabled.Options.UseFont = true;
            btnEdit.AppearanceHovered.Font = new Font("Cairo Medium", 10F);
            btnEdit.AppearanceHovered.Options.UseFont = true;
            btnEdit.AppearancePressed.Font = new Font("Cairo Medium", 10F);
            btnEdit.AppearancePressed.Options.UseFont = true;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnEdit.ImageOptions.SvgImage");
            btnEdit.ImageOptions.SvgImageSize = new Size(25, 25);
            btnEdit.Location = new Point(289, 130);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.Yes;
            btnEdit.Size = new Size(137, 45);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "تعديل";
            btnEdit.ToolTipTitle = "اضافة";
            btnEdit.Click += btnEdit_Click;
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
            btnAdd.Location = new Point(432, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(137, 45);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "اضافة";
            btnAdd.ToolTipTitle = "اضافة";
            btnAdd.Click += btnAdd_Click;
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
            btnPrint.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrint.ImageOptions.SvgImage");
            btnPrint.ImageOptions.SvgImageSize = new Size(25, 25);
            btnPrint.Location = new Point(3, 130);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(137, 45);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrint_Click;
            // 
            // gridControl1
            // 
            gridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControl1.Location = new Point(3, 181);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RightToLeft = RightToLeft.Yes;
            gridControl1.Size = new Size(1289, 468);
            gridControl1.TabIndex = 8;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.CustomizationFormHint.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            gridView1.Appearance.DetailTip.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.DetailTip.Options.UseFont = true;
            gridView1.Appearance.EvenRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.EvenRow.Options.UseFont = true;
            gridView1.Appearance.FilterPanel.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.FilterPanel.Options.UseFont = true;
            gridView1.Appearance.FocusedCell.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.FocusedCell.Options.UseFont = true;
            gridView1.Appearance.FocusedRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.FocusedRow.Options.UseFont = true;
            gridView1.Appearance.FooterPanel.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.FooterPanel.Options.UseFont = true;
            gridView1.Appearance.GroupFooter.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.GroupFooter.Options.UseFont = true;
            gridView1.Appearance.GroupPanel.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.GroupPanel.Options.UseFont = true;
            gridView1.Appearance.GroupRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.GroupRow.Options.UseFont = true;
            gridView1.Appearance.HeaderPanel.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.HideSelectionRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            gridView1.Appearance.HotTrackedRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            gridView1.Appearance.NoSearchResults.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.NoSearchResults.Options.UseFont = true;
            gridView1.Appearance.OddRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.OddRow.Options.UseFont = true;
            gridView1.Appearance.Preview.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.Preview.Options.UseFont = true;
            gridView1.Appearance.Row.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Appearance.SelectedRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.SelectedRow.Options.UseFont = true;
            gridView1.Appearance.TopNewRow.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.TopNewRow.Options.UseFont = true;
            gridView1.Appearance.ViewCaption.Font = new Font("Cairo Medium", 10F);
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // UserUserControl
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(panel1);
            Name = "UserUserControl";
            Size = new Size(1306, 666);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
