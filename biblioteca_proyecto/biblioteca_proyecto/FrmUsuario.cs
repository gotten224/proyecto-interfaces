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
            bool error = false;
            foreach (Control i in tabControl1.SelectedTab.Controls)
            {
                if (EpUsuario.GetError(i) != "")
                {
                    error = true;
                }
            }
            if (!error)
            {
                try
                {
                    if (RbProfesor.Checked)
                    {
                        String nombre;
                        String dept;
                        if (MtbFechSan.MaskCompleted)
                        {
                            DateTime fechsan;
                        }
                        else
                        {
                            Profesor profesor = new Profesor();
                            Form1.pe
                        }
                    }
                    else if (RbEstudinte.Checked)
                    {

                    }
                    else if (RbPas.Checked)
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("No se ha podido guardar el cliente");
                }
            }
            else
            {
                 MessageBox.Show("Nose ha podido guardar el usuario porque hay algun error");
            }
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
            if(DateTime.TryParse(MtbFechSan.Text, out dateValue))
            {
                EpUsuario.SetError(MtbFechSan, "El campo debe ser una fecha");
            }
            
            else
            {
                EpUsuario.SetError(MtbFechSan, "");
            }
        }
    }
}
