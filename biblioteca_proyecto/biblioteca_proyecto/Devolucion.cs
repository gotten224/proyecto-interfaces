using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Devolucion : Transaccion
    {
        Libro libro;

        public Devolucion(DateTime fechaTransaccion, Libro libro) : base(fechaTransaccion)
        {
            this.libro = libro;
        }

        internal Libro Libro { get => libro; set => libro = value; }
    }
}
