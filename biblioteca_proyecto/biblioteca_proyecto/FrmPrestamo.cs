using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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


        //Alta de Prestamos y Devoluciones
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            if (RbPrestamo.Checked)
            {
                DateTime FechaDevolucion = DateTime.MinValue;
                Prestamo p = new Prestamo(fechaActual);
                Libro ls = new Libro();
                Persona pe = new Persona();
                
                //Se busca el libro en la Coleccion de Libros
                foreach (Libro l in Form1.libros)
                {
                    if (Convert.ToInt32(TxtIsbn.Text) == l.Id)
                    {
                        ls = l;
                    }
                }

                if (ls == null)
                {
                    MessageBox.Show("No se puede crear un Préstamo porque el libro asignado no existe.");
                    return;
                }

                p.Libro = ls.Id;
                //Se busca la Persona en la Coleccion de Personas
                foreach (Persona a in Form1.personas)
                {
                    if (TbNombre.Text == a.Nombre)
                    {
                        pe = a;
                        //Buscamos el tipo de la Persona seleccionada para calcular su Fecha de Devolucion
                        if (a.GetType() == Type.GetType("biblioteca_proyecto.Profesor"))
                        {
                            Profesor pr = new Profesor();
                            pr.Nombre = a.Nombre;
                            pr.Departamento = a.Departamento;
                            pr.FechaSancion = a.FechaSancion;
                            p.Persona = pr.Nombre;
                            FechaDevolucion = pr.CalcularFechaDevolucion(ls, fechaActual);
                        }
                        else if (a.GetType() == Type.GetType("biblioteca_proyecto.Pas"))
                        {
                            Pas pas = new Pas()
                            {
                                Nombre = a.Nombre,
                                Departamento = a.Departamento,
                                FechaSancion = a.FechaSancion
                            };
                            p.Persona = pas.Nombre;
                            FechaDevolucion = pas.CalcularFechaDevolucion(ls, fechaActual);
                        }
                        else if (a.GetType() == Type.GetType("biblioteca_proyecto.Alumno"))
                        {
                            Alumno alum = new Alumno()
                            {
                                Nombre = a.Nombre,
                                Departamento = a.Departamento,
                                FechaSancion = a.FechaSancion
                            };
                            p.Persona = alum.Nombre;
                            FechaDevolucion = alum.CalcularFechaDevolucion(ls, fechaActual);
                        }
                    }
                }
                if(pe == null)
                {
                    MessageBox.Show("No se puede crear un Préstamo porque la persona asignada no existe.");
                    return;
                }
                p.FechaDevolucion = FechaDevolucion;
                Form1.transacciones.Add(p);
                Form1.transaccionesNuevas.Add(p);
                MessageBox.Show("Prestamo Creado");

            }
            else if (RbDevolucion.Checked)
            {
                Libro ls = new Libro();
                Devolucion d = new Devolucion(fechaActual);
                foreach (Libro l in Form1.libros)
                {
                    if (Convert.ToInt32(TxtIsbn.Text) == l.Id)
                    {
                        ls = l;
                    }
                }

                if (ls == null) {
                    MessageBox.Show("No se puede crear una Devolucion porque el libro asignado no existe.");
                    return;
                }

                d.Libro = ls.Id;
                Form1.transacciones.Add(d);
                Form1.transaccionesNuevas.Add(d);
                MessageBox.Show("Devolucion Creada");
            }
        }
        private void Rbtipo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDevolucion.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\devult.png";
                LbNombre.Visible = false;
                TbNombre.Visible = false;
            }
            if (RbPrestamo.Checked)
            {
                PbTipo.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\prest.jpg";
                LbNombre.Visible = true;
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


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Listado")
            {
                foreach (Transaccion i in Form1.transacciones)
                {
                    if (i.GetType() == Type.GetType("biblioteca_proyecto.Prestamo"))
                    {
                        Prestamo p = (Prestamo)i;
                        ListViewItem linea = LvListar.Items.Add("Prestamo");
                        linea.SubItems.Add(Convert.ToString(p.Libro));
                        linea.SubItems.Add(p.Persona);
                        linea.SubItems.Add(Convert.ToString(p.FechaDevolucion));
                    }
                    else if (i.GetType() == Type.GetType("biblioteca_proyecto.Devolucion"))
                    {
                        Devolucion d = (Devolucion)i;
                        ListViewItem linea2 = LvListar.Items.Add("Devolucion");
                        linea2.SubItems.Add(Convert.ToString(d.Libro));
                    }
                }
            }

        }

        private void BtnBusc_Click(object sender, EventArgs e)
        {
            
            if (CbBuscar.Text == "Tipo de movimiento")
            {
                busacarMovimiento();
            }
            else if(CbBuscar.Text == "Titulo")
            {
                busacarTitulo();
            }
            else if (CbBuscar.Text == "Usuario")
            {

            }
            else if (CbBuscar.Text == "Fecha")
            {
                busacarFecha();
            }
            else if (CbBuscar.Text == "Departamento")
            {
                buscarDepartamento();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un tipo de busqueda");
            }
        }

        public void busacarMovimiento()
        {
            String buscar = TxtBusc.Text;
            buscar = buscar.Substring(0, 1).ToUpper() + buscar.Substring(1).ToLower();
            if (!string.IsNullOrEmpty(buscar) && (buscar == "Prestamo" || buscar == "Devolucion"))
            {
                LvListar.Items.Clear();
                foreach (Transaccion i in Form1.transacciones)
                {

                    if (i.GetType() == Type.GetType("biblioteca_proyecto." + buscar))
                    {
                        switch (buscar)
                        {
                            case "Prestamo":
                                Prestamo p = (Prestamo)i;
                                ListViewItem linea = LvListar.Items.Add("Prestamo");
                                linea.SubItems.Add(Convert.ToString(p.Libro));
                                linea.SubItems.Add(p.Persona);
                                linea.SubItems.Add(Convert.ToString(p.FechaDevolucion));
                                break;

                            case "Devolucion":
                                Devolucion d = (Devolucion)i;
                                ListViewItem linea2 = LvListar.Items.Add("Devolucion");
                                linea2.SubItems.Add(Convert.ToString(d.Libro));
                                break;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Texto no valido para buscar");
            }
        }

        public void busacarTitulo()
        {
            String buscar = TxtBusc.Text;
            if (!string.IsNullOrEmpty(buscar))
            {
                int isbn = 0;
                foreach (Libro l in Form1.libros)
                {
                    if (l.Titulo == buscar)
                    {
                        isbn = l.Id;
                        break;
                    }
                }
                if (isbn != 0)
                {
                    LvListar.Items.Clear();
                    foreach (Transaccion i in Form1.transacciones)
                    {
                        if (i.GetType() == Type.GetType("biblioteca_proyecto.Prestamo"))
                        {

                            Prestamo p = (Prestamo)i;
                            if (p.Libro == isbn)
                            {
                                ListViewItem linea = LvListar.Items.Add("Prestamo");
                                linea.SubItems.Add(Convert.ToString(p.Libro));
                                linea.SubItems.Add(p.Persona);
                                linea.SubItems.Add(Convert.ToString(p.FechaDevolucion));
                            }
                        }
                        if (i.GetType() == Type.GetType("biblioteca_proyecto.Devolucion"))
                        {
                            Devolucion d = (Devolucion)i;
                            if (d.Libro == isbn)
                            {
                                ListViewItem linea2 = LvListar.Items.Add("Devolucion");
                                linea2.SubItems.Add(Convert.ToString(d.Libro));
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("El libro no existe");
                }
            }
            else
            {
                MessageBox.Show("Texto no valido para buscar");
            }
        }

        public void busacarFecha()
        {
            String buscar = TxtBusc.Text;
            if (!string.IsNullOrEmpty(buscar))
            {
                LvListar.Items.Clear();
                foreach (Transaccion i in Form1.transacciones)
                {
                    if (i.FechaTransaccion.ToShortDateString() == buscar)
                    {
                        if (i.GetType() == Type.GetType("biblioteca_proyecto.Prestamo"))
                        {
                            Prestamo p = (Prestamo)i;
                            ListViewItem linea = LvListar.Items.Add("Prestamo");
                            linea.SubItems.Add(Convert.ToString(p.Libro));
                            linea.SubItems.Add(p.Persona);
                            linea.SubItems.Add(Convert.ToString(p.FechaDevolucion));

                        }
                        if (i.GetType() == Type.GetType("biblioteca_proyecto.Devolucion"))
                        {
                            Devolucion d = (Devolucion)i;
                            ListViewItem linea2 = LvListar.Items.Add("Devolucion");
                            linea2.SubItems.Add(Convert.ToString(d.Libro));

                        }
                    }

                }


            }
            else
            {
                MessageBox.Show("Texto no valido para buscar");
            }
        }

        public void buscarDepartamento()
        {
            String buscar = TxtBusc.Text;
            if (!string.IsNullOrEmpty(buscar))
            {
                LvListar.Items.Clear();

                // Buscar personas por departamento
                foreach (Persona p in Form1.personas)
                {
                    if (buscar == p.Departamento.Trim())
                    {
                        
                        foreach (Transaccion i in Form1.transacciones)
                        { 
                            if (i.GetType() == Type.GetType("biblioteca_proyecto.Prestamo"))
                            {
                                Prestamo pr = (Prestamo)i;
                                if (pr.Persona == p.Nombre)
                                {
                                    ListViewItem linea = LvListar.Items.Add("Prestamo");
                                    linea.SubItems.Add(Convert.ToString(pr.Libro));
                                    linea.SubItems.Add(pr.Persona);
                                    linea.SubItems.Add(Convert.ToString(pr.FechaDevolucion));
                                }

                            }

                        }
                        
                    }
                }

                
                   
            }
            else
            {
                MessageBox.Show("Texto no válido para buscar");
            }
        }

    }
}
