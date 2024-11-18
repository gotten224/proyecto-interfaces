using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Persona : IUsuario
    {
        String nombre;
        String departamento;
        DateTime fechaSancion;

        public Persona(string nombre, string departamento)
        {
            this.nombre = nombre;
            this.departamento = departamento;
        }

        public Persona(string nombre, string departamento, DateTime fechaSancion) : this(nombre, departamento)
        {
            this.nombre = nombre;
            this.departamento = departamento;
            this.fechaSancion = fechaSancion;
        }

        public Persona() {
            this.Nombre = "";
            this.Departamento = "";
            this.FechaSancion = DateTime.MinValue;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public DateTime FechaSancion { get => fechaSancion; set => fechaSancion = value; }

        public DateTime CalcularFechaDevolucion()
        {
            throw new NotImplementedException();
        }

        public DateTime CalcularSancion()
        {
            throw new NotImplementedException();
        }
    }
}
