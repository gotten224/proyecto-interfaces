using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca_proyecto
{
    public partial class FrmModificar : Form
    {
        Transaccion transaccionActual;
        DateTime fechaDev;
        public FrmModificar(Transaccion transaccion)
        {
            InitializeComponent();
            MostrarInformacion(transaccion);
            transaccionActual = transaccion;
        }

        private void MostrarInformacion(Transaccion transaccion)
        {
            if (transaccion is Prestamo prestamo)
            {
                labelCambiar.Text = "Nombre";
                Txt1.Text = prestamo.Persona;
                TxtIsbnBusc.Text = prestamo.Libro.ToString();
                RbPrestBusc.Checked = true;
                fechaDev = prestamo.FechaDevolucion;
            }
            else if (transaccion is Devolucion devolucion)
            {
                labelCambiar.Text = "Fecha transacion";
                //Txt1.Text = DateTime.Now.ToString();
                Txt1.Text = devolucion.FechaTransaccion.ToString();
                TxtIsbnBusc.Text = devolucion.Libro.ToString();
                RbDevBusc.Checked = true;
            }
        }

        private void RbPrestBusc_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDevBusc.Checked)
            {
                PbBusc.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\devult.png";
            }
            if (RbPrestBusc.Checked)
            {
                PbBusc.ImageLocation = Application.ExecutablePath + "\\..\\..\\..\\..\\img\\prest.jpg";
            }
        }

        private void PbModif_Click(object sender, EventArgs e)
        {
            if (RbDevBusc.Checked)
            {
                Form1.transacciones.Remove(transaccionActual);
                Form1.transaccionesNuevas.Remove(transaccionActual);
                Form1.transacciones.Add(new Devolucion(Int32.Parse(TxtIsbnBusc.Text),DateTime.Now));
                Form1.transaccionesNuevas.Add(new Devolucion(Int32.Parse(TxtIsbnBusc.Text), DateTime.Now));
                MessageBox.Show("Se ha modificado la transaccion");
            }else if (RbPrestBusc.Checked)
            {
                Form1.transacciones.Remove(transaccionActual);
                Form1.transaccionesNuevas.Remove(transaccionActual);
                Form1.transacciones.Add(new Prestamo(DateTime.Now, Txt1.Text, Int32.Parse(TxtIsbnBusc.Text), fechaDev));
                Form1.transaccionesNuevas.Add(new Prestamo(DateTime.Now, Txt1.Text, Int32.Parse(TxtIsbnBusc.Text), fechaDev));
                MessageBox.Show("Se ha modificado la transaccion");
            }
        }
    }
}
