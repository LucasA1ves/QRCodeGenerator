using QRCodeGenerator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void AbrirFormularios (Form oFrm)
        {
            oFrm.MdiParent = this;
            oFrm.Top = 0;
            oFrm.Left = pnlMenu.Size.Width;
            oFrm.Show();
        }

        private void btnUrlType_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmQRCodeURL());
        }
    }
}
