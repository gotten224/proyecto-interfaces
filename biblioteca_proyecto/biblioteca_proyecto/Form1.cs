namespace biblioteca_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> personas = new List<Persona>();
        List<Libro> libros = new List<Libro>();
        List<Transaccion> transacciones = new List<Transaccion>();

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
            try
            {
                StreamReader pr = new StreamReader(Application.ExecutablePath + "\\..\\..\\..\\..\\Properties\\usuarios.txt", System.Text.Encoding.UTF7);
                linea = pr.ReadLine();
                while (linea != null) {
                    String[] spliteado2 = linea.Split(",");
                    if (linea.StartsWith("profesor")) {
                        if (spliteado2[1] != null) {
                        }
                        Profesor p = new Profesor()
                        {
                            Nombre = spliteado2[0],
                            Departamento = spliteado2[1]
                        };
                    }
                    linea = pr.ReadLine();
                }
                pr.Close();
            }
            catch(Exception ex) {
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
    }
}
