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
    public partial class FrmLibro : Form
    {
        public FrmLibro()
        {
            InitializeComponent();
        }

        private void TpAltaLibro_Click(object sender, EventArgs e)
        {

        }

        private void RbSala_CheckedChanged(object sender, EventArgs e)
        {
            if (RbSala.Checked)
            {
                PbUbicacion.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\sala.jpg";
            }
            if (RbAlmacen.Checked)
            {
                PbUbicacion.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\almacen.jpg";
            }
        }

        private void RbSalaBusc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbSalaBusc.Checked)
            {
                PbBusc.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\sala.jpg";
            }
            if (RbAlmaBusc.Checked)
            {
                PbBusc.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\almacen.jpg";
            }
        }

        private void comprobarNombre()
        {

        }





    }
}
