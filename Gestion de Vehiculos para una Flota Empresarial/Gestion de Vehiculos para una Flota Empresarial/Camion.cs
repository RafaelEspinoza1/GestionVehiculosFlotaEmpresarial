using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    public class Camion : Vehiculo
    {
        public override string Tipo => "Camion";
        public override int? Capacidad { get; set; }  // La capacidad de carga es relevante para los camiones

        public Camion(string marca, string modelo, int capacidadCarga) : base(marca, modelo)
        {
            Capacidad = capacidadCarga;
        }

        public override void Moverse()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} con una capacidad de {Capacidad}kg está en movimiento.");
        }
    }

}
