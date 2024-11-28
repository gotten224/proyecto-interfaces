using System.IO;

namespace biblioteca_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        internal static List<Persona> personas = new List<Persona>();
        internal static List<Libro> libros = new List<Libro>();
        internal static List<Transaccion> transacciones = new List<Transaccion>();
        internal static List<Transaccion> transaccionesNuevas = new List<Transaccion>();


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form i in this.MdiChildren)
            {
                i.Close();
            }

            Form f = new FrmUsuario();
            f.MdiParent = this;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            String linea = "";

            //Bloque Usuarios
            try
            {
                StreamReader pr = new StreamReader(Application.ExecutablePath + "\\..\\..\\..\\..\\Properties\\usuarios.txt", System.Text.Encoding.UTF8);
                linea = pr.ReadLine();
                while (linea != null)
                {
                    String[] spliteado2 = linea.Split(',');
                    String tipoYNombre = spliteado2[0].Trim();
                    String nombre = tipoYNombre.Substring(tipoYNombre.IndexOf(' ') + 1);
                    if (linea.StartsWith("profesor"))
                    {
                        if (spliteado2.Length > 2)
                        {
                            Profesor p = new Profesor()
                            {
                                Nombre = nombre,
                                Departamento = spliteado2[1],
                                FechaSancion = Convert.ToDateTime(spliteado2[2])
                            };
                            personas.Add(p);
                        }
                        else
                        {
                            Profesor p = new Profesor()
                            {
                                Nombre = nombre,
                                Departamento = spliteado2[1]
                            };
                            personas.Add(p);
                        }
                    }
                    else if (linea.StartsWith("pas"))
                    {
                        if (spliteado2.Length > 2)
                        {
                            MessageBox.Show("Tengo Fecha");
                            Pas pa = new Pas()
                            {
                                Nombre = nombre,
                                Departamento = spliteado2[1],
                                FechaSancion = Convert.ToDateTime(spliteado2[2])
                            };
                            personas.Add(pa);
                        }
                        else
                        {
                            Pas pa = new Pas()
                            {
                                Nombre = nombre,
                                Departamento = spliteado2[1]
                            };
                            personas.Add(pa);
                        }

                    }
                    else if (linea.StartsWith("alumno"))
                    {
                        if (spliteado2.Length > 2)
                        {
                            Alumno a = new Alumno()
                            {
                                Nombre = nombre,
                                Departamento = spliteado2[1],
                                FechaSancion = Convert.ToDateTime(spliteado2[2])
                            };
                            personas.Add(a);
                        }
                        else
                        {
                            Alumno a = new Alumno()
                            {
                                Nombre = nombre,
                                Departamento = spliteado2[1]
                            };
                            personas.Add(a);
                        }
                    }
                    linea = pr.ReadLine();
                }
                pr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Bloque Libros
            try
            {
                StreamReader pr = new StreamReader(Application.ExecutablePath + "\\..\\..\\..\\..\\Properties\\libros.txt", System.Text.Encoding.UTF8);
                linea = pr.ReadLine();
                while (linea != null)
                {
                    String[] spliteado = linea.Split(',');
                    String titulo = spliteado[0].Trim();
                    String nombre = titulo.Substring(titulo.IndexOf(' ') + 1);
                    String[] tipo = linea.Split(" ");
                    Libro l = new Libro()
                    {
                        Tipo = tipo[0],
                        Titulo = nombre,
                        Id = Convert.ToInt32(spliteado[1])
                    };
                    libros.Add(l);
                    linea = pr.ReadLine();
                }
                pr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Bloque Transacciones

            try
            {
                StreamReader pr = new StreamReader(Application.ExecutablePath + "\\..\\..\\..\\..\\Properties\\transacciones.txt", System.Text.Encoding.UTF8);
                linea = pr.ReadLine();
                while (linea != null)
                {
                    String[] spliteado = linea.Split(",");
                    String tipoYNombre = spliteado[0].Trim();
                    String[] prestamos = linea.Split(" ");
                    String nombre = tipoYNombre.Substring(tipoYNombre.IndexOf(' ') + 1);
                    DateTime fecha = DateTime.MinValue;
                    if (linea.StartsWith("fecha"))
                    {
                        fecha = Convert.ToDateTime(nombre + spliteado[1] + spliteado[2]);

                    }
                    else if (linea.StartsWith("prestamo"))
                    {
                        Prestamo p = new Prestamo(fecha)
                        {
                            Persona = nombre,
                            Libro = Convert.ToInt32(spliteado[1]),
                            FechaDevolucion = Convert.ToDateTime(spliteado[2])
                        };
                    }
                    else if (linea.StartsWith("devolucion"))
                    {
                        Devolucion d = new Devolucion(fecha)
                        {
                            Libro = Convert.ToInt32(nombre)
                        };

                    }


                    linea = pr.ReadLine();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Form i in this.MdiChildren)
            {
                i.Close();
            }

            Form f = new FrmLibro();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form i in this.MdiChildren)
            {
                i.Close();
            }

            Form f = new FrmPrestamo();
            f.MdiParent = this;
            f.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SobreescribirLibros();
            SobrescribirPersonas();
        }

        private void SobreescribirLibros()
        {
            String path = Application.ExecutablePath + "\\..\\..\\..\\..\\Properties\\libros.txt";
            StreamWriter streamOut = new StreamWriter(path);
            foreach (Libro l in libros)
            {
                streamOut.WriteLine(l.Tipo + " " + l.Titulo + ", " + l.Id.ToString());
            }
            streamOut.Close();
            MessageBox.Show("Los libros se han guardado correctamente");


        }

        private void SobrescribirPersonas()
        {

        }
    }
}
