using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Alumno : Persona
    {
        public Alumno(string nombre, string departamento) : base(nombre, departamento)
        {
        }

        public Alumno(string nombre, string departamento, DateTime fechaSancion) : base(nombre, departamento, fechaSancion)
        {
        }
    }
}
