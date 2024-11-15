using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal class Transaccion
    {
        DateTime fechaTransaccion;

        public Transaccion(DateTime fechaTransaccion)
        {
            this.fechaTransaccion = fechaTransaccion;
        }

        public DateTime FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
    }
}
