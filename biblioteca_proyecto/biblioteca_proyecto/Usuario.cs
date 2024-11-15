using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Usuario
    {
        String nombre;
        String departamento;
        DateTime fechaSancion;

        public Usuario(string nombre, string departamento)
        {
            this.nombre = nombre;
            this.departamento = departamento;
        }

        public Usuario(string nombre, string departamento, DateTime fechaSancion) : this(nombre, departamento)
        {
            this.fechaSancion = fechaSancion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public DateTime FechaSancion { get => fechaSancion; set => fechaSancion = value; }
    }
}
