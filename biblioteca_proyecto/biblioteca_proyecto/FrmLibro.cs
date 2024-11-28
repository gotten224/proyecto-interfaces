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
        //Controla imagen cuando se selecciona uun RadioButton

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
        //Controla imagen cuando se selecciona uun RadioButton en el apartado buscar
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

        //Validacion de campos
        private void TbTitulo_Validated(object sender, EventArgs e)
        {
            if (TbTitulo.Text == "")
            {
                EpLibro.SetError(TbTitulo, "El campo debe estar relleno");
            }
            else
            {
                EpLibro.SetError(TbTitulo, "");
            }
        }
        //Validacion de campos

        private void MtbIdLibro_Validated(object sender, EventArgs e)
        {
            int idLibro;
            if (!Int32.TryParse(MtbIdLibro.Text, out idLibro))
            {
                EpLibro.SetError(MtbIdLibro, "El campo debe ser un numero");
            }

            else
            {
                EpLibro.SetError(MtbIdLibro, "");
            }
        }
        //Al hacer click en el boton, agrega el libro si cumple las condiciones necesarias y si no presenta ningun error

        private void BtnAgragar_Click(object sender, EventArgs e)
        {
            try
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
                    if (l.Id == Int32.Parse(MtbIdLibro.Text))
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
                            MessageBox.Show("El libro se ha agregado correctamente");
                            TbTitulo.Clear();
                            MtbIdLibro.Clear();
                            RbAlmacen.Checked = false;
                            RbSala.Checked = false;
                            PbUbicacion.Image = null;
                        }
                        else if (RbAlmacen.Checked)
                        {
                            string titulo = TbTitulo.Text;
                            int id = Int32.Parse(MtbIdLibro.Text);
                            string tipo = "almacen";
                            Libro libro = new Libro(tipo, titulo, id);
                            Form1.libros.Add(libro);
                            MessageBox.Show("El libro se ha agregado correctamente");
                            TbTitulo.Clear();
                            MtbIdLibro.Clear();
                            RbAlmacen.Checked = false;
                            RbSala.Checked = false;
                            PbUbicacion.Image = null;
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
            catch
            {
                MessageBox.Show("Ha ocurrido un error al agregar un usuario");
            }
        }

        //Al volver al tabControl listado actualiza el listview para que muestre todos los libros automaticamente
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Listado")
            {
                CbUbi.Text = "";
                LvListar.Items.Clear();
                foreach (Libro l in Form1.libros)
                {
                    ListViewItem item = new ListViewItem(l.Id.ToString());
                    item.SubItems.Add(l.Titulo);
                    item.SubItems.Add(l.Tipo);
                    LvListar.Items.Add(item);
                }
            }
        }
        //Al seleccionar una de las opciones del cbox filtra la lista por la ubicacion seleccionada
        private void CbUbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LvListar.Items.Clear();
            foreach (Libro libro in Form1.libros)
            {
                if (CbUbi.Text == libro.Tipo)
                {
                    ListViewItem item = new ListViewItem(libro.Id.ToString());
                    item.SubItems.Add(libro.Titulo);
                    item.SubItems.Add(libro.Tipo);
                    LvListar.Items.Add(item);
                }

            }

        }
        //Al pulsar sobre el boton borrar se elimina el item seleccionado en el listView
        private void PbBorr_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = LvListar.SelectedItems[0].Index;
                Libro libroSeleccionado = Form1.libros[indice];
                Form1.libros.RemoveAt(indice);
                LvListar.Items.Clear();
                foreach (Libro libro in Form1.libros)
                {
                    if (CbUbi.Text == libro.Tipo)
                    {
                        ListViewItem item = new ListViewItem(libro.Id.ToString());
                        item.SubItems.Add(libro.Titulo);
                        item.SubItems.Add(libro.Tipo);
                        LvListar.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(libro.Id.ToString());
                        item.SubItems.Add(libro.Titulo);
                        item.SubItems.Add(libro.Tipo);
                        LvListar.Items.Add(item);
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un error al intentar borrar un usuario");
            }

        }

        //Recoge el titulo que ha escrito el usuario y lo busca dentro de la lista que contiene todos los libros
        private void BtnBusc_Click(object sender, EventArgs e)
        {
            String nombreLibroBusc = TxtBusc.Text;
            foreach (Libro l in Form1.libros)
            {
                if (l.Titulo == nombreLibroBusc)
                {
                    TbtituloBusc.Text = l.Titulo;
                    mskTbIdBusc.Text = l.Id.ToString();
                    if (l.Tipo == "sala")
                    {
                        RbSalaBusc.Checked = true;
                    }
                    else if (l.Tipo == "almacen")
                    {
                        RbAlmaBusc.Checked = true;
                    }
                }
            }
        }

        //Modifica el libro 
        private void PbModif_Click(object sender, EventArgs e)
        {
            try
            {
                String tituloCambiar = TbtituloBusc.Text;
                int idCambiar = Int32.Parse(mskTbIdBusc.Text);
                String ubiCambiar = "";
                if (RbSalaBusc.Checked)
                {
                    ubiCambiar = "sala";
                }
                else if (RbAlmaBusc.Checked)
                {
                    ubiCambiar = "almacen";
                }
                foreach (Libro l in Form1.libros)
                {
                    if (l.Id == idCambiar)
                    {
                        l.Titulo = tituloCambiar;
                        l.Id = idCambiar;
                        l.Tipo = ubiCambiar;
                    }
                }
                MessageBox.Show("Se ha actualizado la informacion del libro " + tituloCambiar);

            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar el libro");
            }
            TbtituloBusc.Clear();
            mskTbIdBusc.Clear();
            RbAlmaBusc.Checked = false;
            RbSalaBusc.Checked = false;
            PbBusc.Image = null;


        }
    }
}
