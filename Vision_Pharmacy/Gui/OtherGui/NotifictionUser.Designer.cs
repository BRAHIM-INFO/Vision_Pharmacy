namespace Vision_Pharmacy.Gui.OtherGui
{
    partial class NotifictionUser
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
            components = new System.ComponentModel.Container();
            timerhide = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            labelNotifictionCatption = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timerhide
            // 
            timerhide.Enabled = true;
            timerhide.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.Notification_128px;
            pictureBox1.Location = new Point(354, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelNotifictionCatption
            // 
            labelNotifictionCatption.BackColor = Color.FromArgb(70, 161, 87);
            labelNotifictionCatption.Dock = DockStyle.Fill;
            labelNotifictionCatption.Font = new Font("Cairo Medium", 12F);
            labelNotifictionCatption.ForeColor = Color.FromArgb(224, 224, 224);
            labelNotifictionCatption.Location = new Point(0, 0);
            labelNotifictionCatption.Name = "labelNotifictionCatption";
            labelNotifictionCatption.Size = new Size(354, 60);
            labelNotifictionCatption.TabIndex = 1;
            labelNotifictionCatption.Text = "تمت عملية الاضافة بنجاح";
            labelNotifictionCatption.TextAlign = ContentAlignment.MiddleCenter;
            labelNotifictionCatption.Click += labelNotifictionCatption_Click;
            // 
            // NotifictionUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(441, 60);
            Controls.Add(labelNotifictionCatption);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotifictionUser";
            Opacity = 0.9D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerhide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNotifictionCatption;
    }
}