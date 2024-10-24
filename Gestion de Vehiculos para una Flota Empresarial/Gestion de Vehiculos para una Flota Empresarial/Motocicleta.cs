using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    public sealed class Motocicleta : Vehiculo
    {
        public override string Tipo => "Motocicleta";

        public Motocicleta(string marca, string modelo) : base(marca, modelo) { }

        public override void Moverse()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} está en movimiento.");
        }
    }
}
