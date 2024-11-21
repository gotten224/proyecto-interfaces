using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Devolucion : Transaccion
    {
        int libro;

        public Devolucion(int libro, DateTime fechaTransaccion) : base(fechaTransaccion)
        {
            this.libro = libro;
        }

        public Devolucion(DateTime fechaTransaccion) : base(fechaTransaccion) {
            this.libro = 0;
        }

        internal int Libro { get => libro; set => libro = value; }
    }
}
