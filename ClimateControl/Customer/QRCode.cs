using QRCoder;

namespace ClimateControl.Customer
{
    public partial class QRCode : Form
    {
        public QRCode()
        {
            InitializeComponent();

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(@"https://google.com", QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(12);

            Bitmap bmp;
            using (var ms = new MemoryStream(qrCodeAsPngByteArr))
            {
                bmp = new Bitmap(ms);
            }

            pictureBox1.Image = bmp;
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();
    }
}
