﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    public class VehiculoException : Exception
    {
        public VehiculoException(string mensaje) : base(mensaje) { }
    }
}
