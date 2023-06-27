using Entities.Configurations;
using GoQR.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator.Forms
{
    public partial class FrmQRCodeURL : Form
    {
        private Image _imgQrCode;
        private string _formato;
        public FrmQRCodeURL()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (txtURL.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe um valor para o campo 'dados'!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtURL.Text.Trim().Contains("http://") && !txtURL.Text.Trim().Contains("https://"))
            {
                MessageBox.Show("Informe um valor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QRConfig config = oUcQRConfig1.GetConfig();

            string strData = WebUtility.UrlEncode(txtURL.Text.Trim());

            _formato = config.Formato;

            _imgQrCode = new GoQRCode().GetQRCode(strData, config);

            if(_imgQrCode != null)
            {
                picImg.BackgroundImage = _imgQrCode;
                picImg.BackgroundImageLayout = ImageLayout.Stretch;
                btnSalvar.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _formato = string.Empty;
            _imgQrCode = null;
            txtURL.Text = string.Empty;
            picImg.BackgroundImage = null;
            oUcQRConfig1.setDefaultOptions();
            btnSalvar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrCode, _formato);
            //SaveImage.Save(picImg.BackgroundImage, _formato);
        }

        private void FrmQRCodeURL_Load(object sender, EventArgs e)
        {
            btnLimpar_Click(btnLimpar, new EventArgs());
        }
    }
}
