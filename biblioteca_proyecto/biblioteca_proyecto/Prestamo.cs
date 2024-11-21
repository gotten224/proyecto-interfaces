using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Prestamo : Transaccion
    {
        String persona;
        int libro;
        DateTime fechaDevolucion;

        public Prestamo(DateTime fechaTransaccion, String persona, int libro, DateTime fechaDevolucion) : base(fechaTransaccion)
        {
            this.persona = persona;
            this.libro = libro;
            this.fechaDevolucion = fechaDevolucion;
        }

        public Prestamo(DateTime fechaTransaccion) : base(fechaTransaccion) {
            this.persona = "";
            this.libro = 0;
            this.fechaDevolucion = DateTime.MinValue;
        }

        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        internal String Persona { get => persona; set => persona = value; }
        internal int Libro { get => libro; set => libro = value; }
    }

}
