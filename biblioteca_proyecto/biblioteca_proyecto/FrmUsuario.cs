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

        private void TxtNombre_Validated(object sender, EventArgs e)
        {
            if (TxtNombre.Text != "")
            {
                EpUsuario.SetError(TxtNombre, "El campo debe estar relleno");
            }
            else
            {
                EpUsuario.SetError(TxtNombre, "");
            }
        }

        private void TxtDepartamaento_Validated(object sender, EventArgs e)
        {
            if (TxtNombre.Text != "")
            {
                EpUsuario.SetError(TxtDepartamaento, "El campo debe estar relleno");
            }
            else
            {
                EpUsuario.SetError(TxtDepartamaento, "");
            }
        }

        private void MtbFechSan_Validated(object sender, EventArgs e)
        {
            DateTime dateValue;
            if (!MtbFechSan.MaskCompleted)
            {
                EpUsuario.SetError(MtbFechSan, "El campo debe estar relleno");
                if(DateTime.TryParse(MtbFechSan.Text, out dateValue))
                {
                    EpUsuario.SetError(MtbFechSan, "El campo debe ser una fecha");
                }
            }
            else
            {
                EpUsuario.SetError(MtbFechSan, "");
            }
        }
    }
}
