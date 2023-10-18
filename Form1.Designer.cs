namespace IMG2PDF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnChooseImage = new Button();
            btnSavePDF = new Button();
            pictureBox1 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            tsmAbout = new ToolStripMenuItem();
            tsmAboutLicenses = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnChooseImage
            // 
            btnChooseImage.ForeColor = SystemColors.ControlText;
            btnChooseImage.Location = new Point(108, 291);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(115, 23);
            btnChooseImage.TabIndex = 0;
            btnChooseImage.Text = "Choose an Image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnSavePDF
            // 
            btnSavePDF.Location = new Point(241, 291);
            btnSavePDF.Name = "btnSavePDF";
            btnSavePDF.Size = new Size(75, 23);
            btnSavePDF.TabIndex = 1;
            btnSavePDF.Text = "Save PDF";
            btnSavePDF.UseVisualStyleBackColor = true;
            btnSavePDF.Click += btnSavePDF_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(46, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(328, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmAbout
            // 
            tsmAbout.DropDownItems.AddRange(new ToolStripItem[] { tsmAboutLicenses });
            tsmAbout.Name = "tsmAbout";
            tsmAbout.Size = new Size(52, 20);
            tsmAbout.Text = "About";
            // 
            // tsmAboutLicenses
            // 
            tsmAboutLicenses.Name = "tsmAboutLicenses";
            tsmAboutLicenses.Size = new Size(180, 22);
            tsmAboutLicenses.Text = "Licenses";
            tsmAboutLicenses.Click += tsmAboutLicenses_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 326);
            Controls.Add(pictureBox1);
            Controls.Add(btnSavePDF);
            Controls.Add(btnChooseImage);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Image to PDF Converter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseImage;
        private Button btnSavePDF;
        private PictureBox pictureBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmAbout;
        private ToolStripMenuItem tsmAboutLicenses;
    }
}