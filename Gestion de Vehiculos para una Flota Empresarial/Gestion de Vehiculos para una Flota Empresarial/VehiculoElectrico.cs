using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    public class VehiculoElectrico : Vehiculo, IElectrico
    {
        public override string Tipo => "Vehiculo Electrico";
        public override int? Capacidad { get; set; }  // Capacidad de la batería

        public VehiculoElectrico(string marca, string modelo, int capacidadBateria) : base(marca, modelo)
        {
            Capacidad = capacidadBateria;
        }

        public override void Moverse()
        {
            Console.WriteLine($"El vehículo eléctrico {Marca} {Modelo} está en movimiento.");
        }

        public void CargarBateria()
        {
            Console.WriteLine($"El vehículo eléctrico {Marca} {Modelo} está cargando la batería.");
        }
    }
}
