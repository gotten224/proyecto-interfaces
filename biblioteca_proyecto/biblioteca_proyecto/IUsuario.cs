﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_proyecto
{
    internal interface IUsuario
    {
        DateTime CalcularFechaDevolucion();
        DateTime CalcularSancion();
    }
}
