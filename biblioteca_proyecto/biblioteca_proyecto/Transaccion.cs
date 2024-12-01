using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    public class Transaccion
    {
        DateTime fechaTransaccion;

        public Transaccion(DateTime fechaTransaccion)
        {
            this.fechaTransaccion = fechaTransaccion;
        }

        public Transaccion() {
            this.fechaTransaccion = DateTime.MinValue;
        }

        public DateTime FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
    }
}
