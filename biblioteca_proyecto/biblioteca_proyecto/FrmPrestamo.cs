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
            if (RbPrestamo.Checked) {
                DateTime fechaActual = DateTime.Now;
                Prestamo p = new Prestamo(fechaActual)
                {
                    Persona = TbNombre.Text,
                    Libro = Convert.ToInt32(TxtIsbn.Text)
                };
            } else if (RbDevolucion.Checked) {
                
            }
        }
        private void Rbtipo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDevolucion.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\devult.png";
                TbNombre.Visible = false;
            }
            if (RbPrestamo.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\prest.jpg";
                TbNombre.Visible = true;
            }

        }
        private void RbtipoBusc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDevBusc.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\devult.png";
            }
            if (RbPrestBusc.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\prest.jpg";
            }

        }

        private void TpAlta_Click(object sender, EventArgs e)
        {

        }

        private void TbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (TbNombre.Text == "")
            {
                epTransacciones.SetError(TbNombre, "El campo no puede estar vacio");
            }
            else
            {
                epTransacciones.Clear();
            }
        }

        private void TxtIsbn_Validated(object sender, EventArgs e)
        {
            if (TxtIsbn.Text == "")
            {
                epTransacciones.SetError(TxtIsbn, "El campo no puede estar vacio");
            }
            else
            {
                epTransacciones.Clear();
            }
        }
    }
}
