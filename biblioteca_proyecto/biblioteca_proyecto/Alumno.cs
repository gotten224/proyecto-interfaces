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


        public DateTime CalcularFechaDevolucion(Libro libro, DateTime fechaPrestamo)
        {
            DateTime fechaDev = fechaPrestamo;
            if (libro.Tipo == "sala")
            {
                fechaDev = fechaDev.AddDays(10);
            }
            if (libro.Tipo == "almacen")
            {
                fechaDev = fechaDev.AddDays(15);
            }
            return fechaDev;
        }

        public DateTime CalcularSancion(Prestamo prestamo, Devolucion devolucion)
        {
            int diasRetraso = (devolucion.FechaTransaccion - prestamo.FechaDevolucion).Days;
            int diasSumar = diasRetraso * 7;
            DateTime fechaSanc = devolucion.FechaTransaccion.AddDays(diasSumar);
            return fechaSanc;
        }



    }




}
