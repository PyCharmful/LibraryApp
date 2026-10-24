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
            textBoxAbout = new TextBox();
            buttonCloseAbout = new Button();
            pictureBoxURFUlogo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxURFUlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxAbout
            // 
            textBoxAbout.Font = new Font("Sitka Heading", 12F);
            textBoxAbout.Location = new Point(171, 12);
            textBoxAbout.Multiline = true;
            textBoxAbout.Name = "textBoxAbout";
            textBoxAbout.ReadOnly = true;
            textBoxAbout.Size = new Size(587, 275);
            textBoxAbout.TabIndex = 0;
            textBoxAbout.TabStop = false;
            textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // buttonCloseAbout
            // 
            buttonCloseAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCloseAbout.Font = new Font("Segoe UI", 10F);
            buttonCloseAbout.Location = new Point(651, 293);
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
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 335);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxURFUlogo);
            Controls.Add(buttonCloseAbout);
            Controls.Add(textBoxAbout);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxURFUlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout;
        private Button buttonCloseAbout;
        private PictureBox pictureBoxURFUlogo;
        private PictureBox pictureBox1;
    }
}