namespace IMG2PDF
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lnklblIcons8 = new LinkLabel();
            SuspendLayout();
            // 
            // lnklblIcons8
            // 
            lnklblIcons8.AutoSize = true;
            lnklblIcons8.LinkArea = new LinkArea(23, 18);
            lnklblIcons8.Location = new Point(13, 9);
            lnklblIcons8.Name = "lnklblIcons8";
            lnklblIcons8.Size = new Size(423, 452);
            lnklblIcons8.TabIndex = 2;
            lnklblIcons8.TabStop = true;
            lnklblIcons8.Text = resources.GetString("lnklblIcons8.Text");
            lnklblIcons8.UseCompatibleTextRendering = true;
            lnklblIcons8.LinkClicked += lnklblIcons8_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 474);
            Controls.Add(lnklblIcons8);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Licenses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel lnklblIcons8;
    }
}