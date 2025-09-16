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
            pnlTop = new Panel();
            lblTitle = new Label();
            SeparatLat = new DevExpress.XtraEditors.SeparatorControl();
            PicLaterale = new PictureBox();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnEdit = new DevExpress.XtraEditors.SimpleButton();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(60, 71, 151);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(SeparatLat);
            pnlTop.Controls.Add(PicLaterale);
            pnlTop.Controls.Add(btnDelete);
            pnlTop.Controls.Add(btnEdit);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.RightToLeft = RightToLeft.Yes;
            pnlTop.Size = new Size(1119, 57);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Right;
            lblTitle.Font = new Font("Cairo Medium", 12F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(902, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(139, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "قائمة المستخدمين";
            // 
            // SeparatLat
            // 
            SeparatLat.BackColor = Color.FromArgb(255, 128, 0);
            SeparatLat.Dock = DockStyle.Right;
            SeparatLat.LineColor = Color.FromArgb(255, 128, 0);
            SeparatLat.LineOrientation = Orientation.Vertical;
            SeparatLat.LineThickness = 8;
            SeparatLat.Location = new Point(1041, 0);
            SeparatLat.Margin = new Padding(3, 2, 3, 2);
            SeparatLat.Name = "SeparatLat";
            SeparatLat.Padding = new Padding(0);
            SeparatLat.Size = new Size(9, 57);
            SeparatLat.TabIndex = 1;
            // 
            // PicLaterale
            // 
            PicLaterale.BackColor = Color.Silver;
            PicLaterale.Dock = DockStyle.Right;
            PicLaterale.Image = Properties.Resources.tasking_15578464;
            PicLaterale.Location = new Point(1050, 0);
            PicLaterale.Margin = new Padding(3, 2, 3, 2);
            PicLaterale.Name = "PicLaterale";
            PicLaterale.Size = new Size(69, 57);
            PicLaterale.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLaterale.TabIndex = 0;
            PicLaterale.TabStop = false;
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
            btnDelete.Location = new Point(310, 2);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.Yes;
            btnDelete.Size = new Size(55, 37);
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
            btnEdit.Location = new Point(370, 2);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.RightToLeft = RightToLeft.Yes;
            btnEdit.Size = new Size(73, 37);
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
            btnAdd.Location = new Point(125, 62);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(117, 37);
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
            btnPrint.Location = new Point(3, 62);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(117, 37);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "طباعة";
            btnPrint.ToolTipTitle = "اضافة";
            btnPrint.Click += btnPrint_Click;
            // 
            // gridControl1
            // 
            gridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridControl1.Location = new Point(3, 103);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(3, 2, 3, 2);
            gridControl1.Name = "gridControl1";
            gridControl1.RightToLeft = RightToLeft.Yes;
            gridControl1.Size = new Size(1117, 438);
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
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // UserUserControl
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(pnlTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1119, 541);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SeparatLat).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicLaterale).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private PictureBox PicLaterale;
        private DevExpress.XtraEditors.SeparatorControl SeparatLat;
        private Label lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
