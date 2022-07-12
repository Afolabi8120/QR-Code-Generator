using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using ThoughtWorks;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;
using System.IO;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {
        string a;
        QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
        string encoding = "Byte";

        public Form1()
        {
            InitializeComponent();
        }

        void generateCode()
        {

            if (encoding == "Byte")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            }
            else if (encoding == "AlphaNumeric")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
            }
            else if (encoding == "Numeric")
            {
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                return;
            }

            try
            {
                int scale = 4;
                qrCodeEncoder.QRCodeScale = scale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int version = 7;
                qrCodeEncoder.QRCodeVersion = version;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorCorrect = "M";

            if (errorCorrect == "M")
            {
                qrCodeEncoder.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.M;
            }
            else if (errorCorrect == "L")
            {
                qrCodeEncoder.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.L;
            }
            else if (errorCorrect == "Q")
            {
                qrCodeEncoder.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.Q;
            }
            else if (errorCorrect == "H")
            {
                qrCodeEncoder.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.H;
            }

            Bitmap image;
            string data = txtCode.Text;
            image = qrCodeEncoder.Encode(data);

            pictureBox1.Image = image;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Please enter a text", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                generateCode();
            }
        }

        private void btnJPG_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }

        private void btnPNG_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PNG(*.PNG)|*.png";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }

        private void btnJPEG_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPEG(*.JPEG)|*.jpeg";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }
    }
}
