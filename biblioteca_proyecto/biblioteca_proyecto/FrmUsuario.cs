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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void Rbtipo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbProfesor.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\profe.jpg"; ;
            }
            if (RbPas.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\pas.jpg";
            }
            if (RbEstudinte.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\estu.jpg";
            }
        }
        private void Rbtipobusc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbBuscProf.Checked)
            {
                PbBusc.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\profe.jpg"; ;
            }
            if (RbBuscPas.Checked)
            {
                PbBusc.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\pas.jpg";
            }
            if (RbBuscEstu.Checked)
            {
                PbBusc.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\estu.jpg";
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
