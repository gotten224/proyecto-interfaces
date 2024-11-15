using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Pas : Persona
    {
        public Pas(string nombre, string departamento) : base(nombre, departamento)
        {
        }

        public Pas(string nombre, string departamento, DateTime fechaSancion) : base(nombre, departamento, fechaSancion)
        {
        }

        public DateTime CalcularFechaDevolucion(Libro libro, DateTime fechaPrestamo)
        {
            DateTime fechaDev = fechaPrestamo.AddDays(15);
            return fechaDev;
        }

        public DateTime CalcularSancion()
        {
            throw new NotImplementedException();
        }

    }
}
