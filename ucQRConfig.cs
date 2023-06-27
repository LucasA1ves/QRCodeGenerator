using Entities.Configurations;
using System;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class ucQRConfig : UserControl
    {
        public ucQRConfig()
        {
            InitializeComponent();
        }

        private void ucQRConfig_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            cmbTamanho.Items.Clear();
            for(int i = 0; i <= 10; i++)
            {
                cmbTamanho.Items.Add(string.Format("{0}x{0}", i*100));
            }

            cmbFonte.Items.Clear();
            cmbFonte.Items.Add("ISO-8859-1");
            cmbFonte.Items.Add("UTF-8");

            cmbAlvo.Items.Clear();
            cmbAlvo.Items.Add("ISO-8859-1");
            cmbAlvo.Items.Add("UTF-8");

            cmbECC.Items.Clear();
            cmbECC.Items.Add("L");
            cmbECC.Items.Add("M");
            cmbECC.Items.Add("Q");
            cmbECC.Items.Add("H");

            cmbCor.Items.Clear();
            cmbCor.Items.Add("000000");
            cmbCor.Items.Add("FFFFFF");
            cmbCor.Items.Add("FF0000");
            cmbCor.Items.Add("00FF00");
            cmbCor.Items.Add("0000FF");

            cmbCordeFundo.Items.Clear();
            cmbCordeFundo.Items.Add("000000");
            cmbCordeFundo.Items.Add("FFFFFF");
            cmbCordeFundo.Items.Add("FF0000");
            cmbCordeFundo.Items.Add("00FF00");
            cmbCordeFundo.Items.Add("0000FF");

            cmbMargem.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                cmbMargem.Items.Add(i);
            }

            cmbQZone.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                cmbQZone.Items.Add(i);
            }

            cmbFormato.Items.Clear();
            cmbFormato.Items.Add("png"); 
            cmbFormato.Items.Add("gif");
            cmbFormato.Items.Add("jpeg");
            cmbFormato.Items.Add("jpg");

            setDefaultOptions();
        }

        public void setDefaultOptions()
        {
            cmbTamanho.SelectedIndex = 1;
            cmbFonte.SelectedIndex = 1;
            cmbAlvo.SelectedIndex = 1;
            cmbECC.SelectedIndex = 0;
            cmbCor.SelectedIndex = 0;
            cmbCordeFundo.SelectedIndex = 1;
            cmbMargem.SelectedIndex = 1;
            cmbQZone.SelectedIndex = 0;
            cmbFormato.SelectedIndex = 0;
        }

        public QRConfig GetConfig()
        {
            QRConfig config = new QRConfig();
            config.Tamanho = cmbTamanho.SelectedItem.ToString();
            config.Fonte = cmbFonte.SelectedItem.ToString();
            config.Alvo = cmbAlvo.SelectedItem.ToString();
            config.ECC = cmbECC.SelectedItem.ToString()[0];
            config.Cor = cmbCor.SelectedItem.ToString();
            config.CordeFundo = cmbCordeFundo.SelectedItem.ToString();
            config.Margem = Convert.ToInt32(cmbMargem.SelectedItem);
            config.QZone = Convert.ToInt32(cmbQZone.SelectedItem);
            config.Formato = cmbFormato.SelectedItem.ToString();

            return config;
        }
    }
}
