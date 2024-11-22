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
            bool error = false;
            foreach (Control i in tabControl1.SelectedTab.Controls)
            {
                if (EpLibro.GetError(i) != "")
                {
                    error = true;
                }
            }
            foreach (Libro l in Form1.libros)
            {
                if(l.Id == Int32.Parse(MtbIdLibro.Text))
                {
                    error = true;
                }
            }

            if (!error)
            {
                try
                {
                    if (RbSala.Checked)
                    {
                        string titulo = TbTitulo.Text;
                        int id = Int32.Parse(MtbIdLibro.Text);
                        string tipo = "sala";
                        Libro libro = new Libro(tipo, titulo, id);
                        Form1.libros.Add(libro);
                    }else if (RbAlmacen.Checked)
                    {
                        string titulo = TbTitulo.Text;
                        int id = Int32.Parse(MtbIdLibro.Text);
                        string tipo = "almacen";
                        Libro libro = new Libro(tipo, titulo, id);
                        Form1.libros.Add(libro);
                    }

                }
                catch
                {
                    MessageBox.Show("No se ha podido guardar el libro");
                }
            }
            else
            {
                MessageBox.Show("No se ha podido guardar el libro porque contiene algun error");
            }
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


        private void TbTitulo_Validated(object sender, EventArgs e)
        {
            if (TbTitulo.Text != "")
            {
                EpLibro.SetError(TbTitulo, "El campo debe estar relleno");
            }
            else
            {
                EpLibro.SetError(TbTitulo, "");
            }
        }

        private void MtbIdLibro_Validated(object sender, EventArgs e)
        {
            int idLibro;
            if (Int32.TryParse(MtbIdLibro.Text, out idLibro))
            {
                EpLibro.SetError(MtbIdLibro, "El campo debe ser un numero");
            }

            else
            {
                EpLibro.SetError(MtbIdLibro, "");
            }
        }

        private void BtnAgragar_Click(object sender, EventArgs e)
        {

        }
    }
}
