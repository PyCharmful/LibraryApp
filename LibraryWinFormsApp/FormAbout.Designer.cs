namespace LibraryWinFormsApp
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonCloseAbout = new Button();
            pictureBoxURFUlogo = new PictureBox();
            pictureBox1 = new PictureBox();
            labelAbout = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxURFUlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCloseAbout
            // 
            buttonCloseAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCloseAbout.Font = new Font("Segoe UI", 10F);
            buttonCloseAbout.Location = new Point(645, 249);
            buttonCloseAbout.Name = "buttonCloseAbout";
            buttonCloseAbout.Size = new Size(103, 30);
            buttonCloseAbout.TabIndex = 1;
            buttonCloseAbout.Text = "Закрыть";
            buttonCloseAbout.UseVisualStyleBackColor = true;
            buttonCloseAbout.Click += buttonCloseAbout_Click;
            // 
            // pictureBoxURFUlogo
            // 
            pictureBoxURFUlogo.BackgroundImage = Properties.Resources.urfu_logo;
            pictureBoxURFUlogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxURFUlogo.Location = new Point(12, 12);
            pictureBoxURFUlogo.Name = "pictureBoxURFUlogo";
            pictureBoxURFUlogo.Size = new Size(153, 70);
            pictureBoxURFUlogo.TabIndex = 2;
            pictureBoxURFUlogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.steve_harrington;
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAbout.Location = new Point(171, 12);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(573, 231);
            labelAbout.TabIndex = 4;
            labelAbout.Text = resources.GetString("labelAbout.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(760, 291);
            Controls.Add(labelAbout);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxURFUlogo);
            Controls.Add(buttonCloseAbout);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxURFUlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCloseAbout;
        private PictureBox pictureBoxURFUlogo;
        private PictureBox pictureBox1;
        private Label labelAbout;
    }
}