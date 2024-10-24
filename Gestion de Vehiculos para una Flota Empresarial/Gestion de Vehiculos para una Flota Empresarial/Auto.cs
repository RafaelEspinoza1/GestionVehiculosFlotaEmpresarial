using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    public class Auto : Vehiculo
    {
        public Auto(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override string Tipo => "Auto";

        public override void Moverse()
        {
            Console.WriteLine($"El auto {Marca} {Modelo} esta en movimiento.");
        }
    }
}
