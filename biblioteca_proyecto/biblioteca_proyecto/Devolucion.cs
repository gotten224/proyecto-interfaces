using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Devolucion : Transaccion
    {
        Persona persona;
        Libro libro;

        public Devolucion(Persona persona, Libro libro, DateTime fechaTransaccion) : base(fechaTransaccion)
        {
            this.persona = persona;
            this.libro = libro;
        }

        internal Persona Persona { get => persona; set => persona = value; }
        internal Libro Libro { get => libro; set => libro = value; }
    }
}
