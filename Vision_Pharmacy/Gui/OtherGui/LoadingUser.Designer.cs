namespace Vision_Pharmacy.Gui.OtherGui
{
    partial class LoadingUser
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
            label1 = new Label();
            label2 = new Label();
            progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo Medium", 13F);
            label1.Location = new Point(185, 12);
            label1.Name = "label1";
            label1.Size = new Size(128, 42);
            label1.TabIndex = 1;
            label1.Text = "Please Wait";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo Medium", 10F);
            label2.Location = new Point(185, 51);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 2;
            label2.Text = "Loading.....";
            // 
            // progressPanel1
            // 
            progressPanel1.Appearance.BackColor = Color.FromArgb(227, 237, 249);
            progressPanel1.Appearance.Font = new Font("Cairo Medium", 9F);
            progressPanel1.Appearance.Options.UseBackColor = true;
            progressPanel1.Appearance.Options.UseFont = true;
            progressPanel1.AppearanceCaption.Font = new Font("Cairo Medium", 12F);
            progressPanel1.AppearanceCaption.Options.UseFont = true;
            progressPanel1.AppearanceDescription.Font = new Font("Cairo Medium", 9F);
            progressPanel1.AppearanceDescription.Options.UseFont = true;
            progressPanel1.Dock = DockStyle.Fill;
            progressPanel1.Location = new Point(0, 0);
            progressPanel1.Name = "progressPanel1";
            progressPanel1.Size = new Size(319, 100);
            progressPanel1.TabIndex = 3;
            progressPanel1.Text = "progressPanel1";
            // 
            // LoadingUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(319, 100);
            Controls.Add(progressPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingUser";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}