namespace BanNuoc.AllUserControls
{
    partial class UC_Welcome
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblBanner = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_alleksana_7430733;
            pictureBox1.Location = new Point(-3, -92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(693, 554);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(462, 318);
            label1.Name = "label1";
            label1.Size = new Size(74, 51);
            label1.TabIndex = 1;
            label1.Text = "To";
            // 
            // lblBanner
            // 
            lblBanner.AutoSize = true;
            lblBanner.Font = new Font("Tahoma", 30F, FontStyle.Bold);
            lblBanner.ForeColor = Color.FromArgb(64, 64, 64);
            lblBanner.Location = new Point(18, 427);
            lblBanner.Name = "lblBanner";
            lblBanner.Size = new Size(349, 60);
            lblBanner.TabIndex = 2;
            lblBanner.Text = "MOOI Coffee";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 217, 214);
            Controls.Add(lblBanner);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UC_Welcome";
            Size = new Size(690, 554);
            Load += UC_Welcome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblBanner;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
