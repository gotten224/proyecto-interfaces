using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca_proyecto
{
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
        private void Rbtipo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDevolucion.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\devult.png"; ;
            }
            if (RbPrestamo.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\prest.jpg";
            }
            
        }
        private void RbtipoBusc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDevBusc.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\devult.png"; ;
            }
            if (RbPrestBusc.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\prest.jpg";
            }

        }
    }
}
