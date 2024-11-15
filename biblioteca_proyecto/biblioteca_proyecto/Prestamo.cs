using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Prestamo : Transaccion
    {
        Persona persona;
        Libro libro;
        DateTime fechaDevolucion;

        public Prestamo(DateTime fechaTransaccion, Persona persona, Libro libro, DateTime fechaDevolucion) : base(fechaTransaccion)
        {
            this.persona = persona;
            this.libro = libro;
            this.fechaDevolucion = fechaDevolucion;
        }

        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        internal Persona Persona { get => persona; set => persona = value; }
        internal Libro Libro { get => libro; set => libro = value; }
    }

}
