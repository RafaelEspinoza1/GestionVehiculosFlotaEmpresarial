using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    public class ControladorVehiculos
    {
        public Vehiculo CrearVehiculo(string tipoVehiculo, string marca, string modelo, int? capacidad = null)
        {
            switch (tipoVehiculo)
            {
                case "Auto":
                    return new Auto(marca, modelo);
                case "Camion":
                    if (capacidad == null)
                        throw new VehiculoException("Se requiere la capacidad de carga para crear un camión.");
                    return new Camion(marca, modelo, capacidad.Value);
                case "Motocicleta":
                    return new Motocicleta(marca, modelo);
                case "Vehiculo Electrico":
                    if (capacidad == null)
                        throw new VehiculoException("Se requiere la capacidad de batería para crear un vehículo eléctrico.");
                    return new VehiculoElectrico(marca, modelo, capacidad.Value);
                default:
                    throw new VehiculoException("Tipo de vehículo no válido.");
            }
        }
    }
}
