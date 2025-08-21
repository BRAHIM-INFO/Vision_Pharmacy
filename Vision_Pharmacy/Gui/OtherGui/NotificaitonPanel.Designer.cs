namespace Vision_Pharmacy.Gui.OtherGui
{
    partial class NotificaitonPanel
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            PanelNote = new Panel();
            LabelNote = new Label();
            pictureBox1 = new PictureBox();
            PanelNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelNote
            // 
            PanelNote.BorderStyle = BorderStyle.FixedSingle;
            PanelNote.Controls.Add(LabelNote);
            PanelNote.Controls.Add(pictureBox1);
            PanelNote.Location = new Point(3, 3);
            PanelNote.Name = "PanelNote";
            PanelNote.Size = new Size(539, 77);
            PanelNote.TabIndex = 1;
            // 
            // LabelNote
            // 
            LabelNote.Dock = DockStyle.Fill;
            LabelNote.Font = new Font("Cairo Medium", 12F);
            LabelNote.ForeColor = Color.FromArgb(255, 128, 128);
            LabelNote.Location = new Point(94, 0);
            LabelNote.Name = "LabelNote";
            LabelNote.Size = new Size(443, 75);
            LabelNote.TabIndex = 1;
            LabelNote.Text = "احسبنت لا يلزمك اتخاذ اي اجراء ";
            LabelNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.icons8_Notification_128px;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NotificaitonPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelNote);
            Name = "NotificaitonPanel";
            Size = new Size(548, 84);
            PanelNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PanelNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LabelNote;
    }
}
