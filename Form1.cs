using PdfSharp.Drawing;
using PdfSharp.Pdf;


namespace IMG2PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            InitializeComponent();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files(*.PNG;*.JPG;*.JPEG;)|*.PNG;*.JPG;*.JPEG;|All files (*.*)|*.*";
            openFileDialog1.Title = "Select your Image";

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    using (FileStream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(stream);
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF";

                try
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog1.FileName;  // Assume you have the image path from the openFileDialog
                        PdfDocument pdf = new PdfDocument();
                        PdfPage pdfPage = pdf.AddPage();
                        XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
                        XImage xImage = XImage.FromFile(imagePath);

                        // Optionally, you could set the page size to match the image size
                        pdfPage.Width = xImage.PointWidth;
                        pdfPage.Height = xImage.PointHeight;

                        xGraphics.DrawImage(xImage, 0, 0, pdfPage.Width, pdfPage.Height);  // This will draw the image onto the PDF page


                        string pdfFileName = saveFileDialog.FileName;
                        pdf.Save(pdfFileName);
                        MessageBox.Show("PDF saved successfully!");

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmAboutLicenses_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();


        }
    }
}