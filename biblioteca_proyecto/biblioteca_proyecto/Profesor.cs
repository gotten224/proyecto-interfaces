using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Profesor : Persona
    {
        public Profesor(string nombre, string departamento) : base(nombre, departamento)
        {
        }

        public Profesor(string nombre, string departamento, DateTime fechaSancion) : base(nombre, departamento, fechaSancion)
        {
        }

        public DateTime CalcularFechaDevolucion(Libro libro, DateTime fechaPrestamo)
        {
            DateTime fechaDev = fechaPrestamo;
            if(libro.Tipo == "sala")
            {
                fechaDev = fechaDev.AddDays(30);
            }
            if (libro.Tipo == "almacen")
            {
                fechaDev = fechaDev.AddDays(45);
            }
            return fechaDev;
        }

        public DateTime CalcularSancion()
        {
            throw new NotImplementedException();
        }



    }
}
