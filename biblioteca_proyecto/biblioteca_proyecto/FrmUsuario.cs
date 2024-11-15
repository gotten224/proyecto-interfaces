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
                PbTipo.Image = ILtipo.Images[0];
            }
            if (RbPas.Checked)
            {
                PbTipo.Image = ILtipo.Images[1];
            }
            if (RbEstudinte.Checked)
            {
                PbTipo.Image = ILtipo.Images[2];
            }
        }
    }
}
