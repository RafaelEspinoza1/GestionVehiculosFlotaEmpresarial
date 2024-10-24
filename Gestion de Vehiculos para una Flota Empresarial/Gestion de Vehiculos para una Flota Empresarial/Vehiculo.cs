using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vehiculos_para_una_Flota_Empresarial
{
    public abstract class Vehiculo : ITransporte
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public abstract string Tipo { get; }
        public virtual int? Capacidad { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void Moverse();
        public virtual void Iniciar()
        {
            Console.WriteLine($"El vehiculo {Marca} {Modelo} se ha iniciado.");
        }
        public virtual void Detener()
        {
            Console.WriteLine($"El vehiculo {Marca} {Modelo} se ha detenido.");
        }
        public override string ToString()
        {
            return $"{Marca} {Modelo}";
        }
    }
}
