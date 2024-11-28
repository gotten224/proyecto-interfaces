using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace biblioteca_proyecto
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            EpUsuario.SetError(TxtNombre, "El campo debe estar relleno");
            EpUsuario.SetError(TxtDepartamaento, "El campo debe estar relleno");
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
                bool rep = false;
                foreach(Persona p in Form1.personas)
                {
                    if(p.Nombre == TxtNombre.Text)
                    {
                        rep = true;
                    }
                }
                if (!rep)
                {
                    try
                    {
                        if (RbPas.Checked || RbProfesor.Checked || RbEstudinte.Checked)
                        {
                            if (RbProfesor.Checked)
                            {
                                System.String nombre = TxtNombre.Text;
                                System.String dept = TxtDepartamaento.Text;
                                if (MtbFechSan.MaskCompleted)
                                {
                                    DateTime fechsan = Convert.ToDateTime(MtbFechSan.Text);
                                    Profesor profesor = new Profesor(nombre, dept, fechsan);
                                    Form1.personas.Add(profesor);
                                }
                                else
                                {
                                    Profesor profesor = new Profesor(nombre, dept);
                                    Form1.personas.Add(profesor);
                                }
                                MessageBox.Show("Profesor creado");
                            }
                            else if (RbEstudinte.Checked)
                            {
                                System.String nombre = TxtNombre.Text;
                                System.String dept = TxtDepartamaento.Text;
                                if (MtbFechSan.MaskCompleted)
                                {
                                    DateTime fechsan = Convert.ToDateTime(MtbFechSan.Text);
                                    Alumno alumno = new Alumno(nombre, dept, fechsan);
                                    Form1.personas.Add(alumno);
                                }
                                else
                                {
                                    Alumno alumno = new Alumno(nombre, dept);
                                    Form1.personas.Add(alumno);
                                }
                                MessageBox.Show("Alumno creado");
                            }
                            else if (RbPas.Checked)
                            {
                                System.String nombre = TxtNombre.Text;
                                System.String dept = TxtDepartamaento.Text;
                                if (MtbFechSan.MaskCompleted)
                                {
                                    DateTime fechsan = Convert.ToDateTime(MtbFechSan.Text);
                                    Pas pas = new Pas(nombre, dept, fechsan);
                                    Form1.personas.Add(pas);
                                }
                                else
                                {
                                    Pas pas = new Pas(nombre, dept);
                                    Form1.personas.Add(pas);
                                }
                                MessageBox.Show("Pas creado");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No has seleccionado tipo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No se ha podido guardar el cliente");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido guardar el usuario porque el nombre de usuario ya existe");
                }
            }
            else
            {
                MessageBox.Show("No se ha podido guardar el usuario porque hay algun error");
            }
        }

        private void TxtNombre_Validated(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
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
            if (TxtDepartamaento.Text == "")
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
            if (!DateTime.TryParse(MtbFechSan.Text, out dateValue))
            {
                EpUsuario.SetError(MtbFechSan, "El campo debe ser una fecha");
            }

            else
            {
                EpUsuario.SetError(MtbFechSan, "");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Listado")
            {
                BorrarCampos();
                Recargar_Lista();
            }
            if (tabControl1.SelectedTab.Text == "Alta")
            {
                BorrarCampos();
                foreach (Control i in tabControl1.SelectedTab.Controls)
                {
                    EpUsuario.SetError(i, "");
                    
                }
                EpUsuario.SetError(TxtNombre, "El campo debe estar relleno");
                EpUsuario.SetError(TxtDepartamaento, "El campo debe estar relleno");
            }
            if (tabControl1.SelectedTab.Text == "Buscar")
            {
                foreach (Control i in tabControl1.SelectedTab.Controls)
                {
                    EpUsuario.SetError(i, "");
                }
                BorrarCampos();
            }
        }

        private void BorrarCampos()
        {
            TxtBusc.Text = "";
            TxtBuscDept.Text = "";
            TxtBuscNom.Text = "";
            MtbBuscFech.Text = "";
            TxtNombre.Text = "";
            TxtDepartamaento.Text = "";
            MtbFechSan.Text = "";
            RbBuscEstu.Checked = false;
            RbBuscPas.Checked = false;
            RbBuscProf.Checked = false;
            RbEstudinte.Checked = false;
            RbPas.Checked = false;
            RbProfesor.Checked = false;
            PbTipo.ImageLocation = "";
            PbBusc.ImageLocation = "";
        }

        private void Recargar_Lista()
        {
            LvListar.Items.Clear();
            foreach (Persona i in Form1.personas)
            {
                if (i.GetType() == Type.GetType("biblioteca_proyecto.Profesor"))
                {

                    ListViewItem linea1;
                    linea1 = LvListar.Items.Add("Profesor");
                    linea1.SubItems.Add(i.Nombre);
                    linea1.SubItems.Add(i.Departamento);
                    if (i.FechaSancion != null)
                    {
                        linea1.SubItems.Add(i.FechaSancion.ToString());
                    }
                    else
                    {
                        linea1.SubItems.Add("");
                    }
                }
                else if (i.GetType() == Type.GetType("biblioteca_proyecto.Alumno"))
                {
                    ListViewItem linea1;
                    linea1 = LvListar.Items.Add("Alumno");
                    linea1.SubItems.Add(i.Nombre);
                    linea1.SubItems.Add(i.Departamento);
                    if (i.FechaSancion != null)
                    {
                        linea1.SubItems.Add(i.FechaSancion.ToString());
                    }
                    else
                    {
                        linea1.SubItems.Add("");
                    }
                }
                else if (i.GetType() == Type.GetType("biblioteca_proyecto.Pas"))
                {
                    ListViewItem linea1;
                    linea1 = LvListar.Items.Add("pas");
                    linea1.SubItems.Add(i.Nombre);
                    linea1.SubItems.Add(i.Departamento);
                    if (i.FechaSancion != null)
                    {
                        linea1.SubItems.Add(i.FechaSancion.ToString());
                    }
                    else
                    {
                        linea1.SubItems.Add("");
                    }
                }
            }
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            LvListar.Items.Clear();
            foreach (Persona i in Form1.personas)
            {
                if (i.GetType() == Type.GetType("biblioteca_proyecto." + CbTipo.SelectedItem.ToString()))
                {
                    ListViewItem linea1;
                    linea1 = LvListar.Items.Add(CbTipo.SelectedItem.ToString());
                    linea1.SubItems.Add(i.Nombre);
                    linea1.SubItems.Add(i.Departamento);
                    if (i.FechaSancion != null)
                    {
                        linea1.SubItems.Add(i.FechaSancion.ToString());
                    }
                    else
                    {
                        linea1.SubItems.Add("");
                    }
                }
            }

        }

        private void PbBorr_Click(object sender, EventArgs e)
        {
            if (LvListar.SelectedItems[0] == null)
            {
                MessageBox.Show("Seleccione primero el usuario a eliminar en la lista");
            }
            else
            {
                foreach (Persona p in Form1.personas)
                {
                    if (p.Nombre == LvListar.SelectedItems[0].SubItems[1].Text)
                    {
                        Form1.personas.Remove(p);
                        Recargar_Lista();
                        break;
                    }
                }
            }
        }

        private void BtnBusc_Click(object sender, EventArgs e)
        {
            foreach (Persona p in Form1.personas)
            {
                if (p.Nombre == TxtBusc.Text)
                {
                    TxtBuscNom.Text = p.Nombre;
                    TxtBuscDept.Text = p.Departamento;
                    if (p.FechaSancion != null)
                    {
                        System.String[] fecha = p.FechaSancion.ToString().Split(' ');
                        MtbBuscFech.Text = fecha[0];
                    }
                    if (p.GetType() == Type.GetType("biblioteca_proyecto.Profesor"))
                    {
                        RbBuscProf.Checked = true;
                    }
                    if (p.GetType() == Type.GetType("biblioteca_proyecto.Pas"))
                    {
                        RbBuscPas.Checked = true;
                    }
                    if (p.GetType() == Type.GetType("biblioteca_proyecto.Alumno"))
                    {
                        RbBuscEstu.Checked = true;
                    }
                }
            }
        }

        private void PbModif_Click(object sender, EventArgs e)
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
                    foreach (Persona p in Form1.personas)
                    {
                        if (p.Nombre == TxtBuscNom.Text)
                        {
                            p.Departamento = TxtBuscDept.Text;
                            if (MtbBuscFech.MaskCompleted)
                            {
                                p.FechaSancion = Convert.ToDateTime(MtbBuscFech.Text);
                            }
                            MessageBox.Show("Se han guardar los cambios");
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se han podido guardar los cambios");
                }
            }
            else
            {
                MessageBox.Show("Hay algun error");
            }
        }

        private void TxtBuscDept_Validated(object sender, EventArgs e)
        {
            if (TxtBuscDept.Text == "")
            {
                EpUsuario.SetError(TxtBuscDept, "El campo debe estar relleno");
            }
            else
            {
                EpUsuario.SetError(TxtBuscDept, "");
            }
        }

        private void MtbBuscFech_Validated(object sender, EventArgs e)
        {
            DateTime dateValue;
            if (!DateTime.TryParse(MtbBuscFech.Text, out dateValue))
            {
                EpUsuario.SetError(MtbBuscFech, "El campo debe ser una fecha");
            }
            else
            {
                EpUsuario.SetError(MtbBuscFech, "");
            }
            
        }
    }
}
