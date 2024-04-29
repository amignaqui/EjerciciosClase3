using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_2.Ejercicio_1
{
    public abstract class Vehiculo
    {
        public required string Marca { get; set; }
        public required string Modelo { get; set; }

        public abstract void ImprimirDatosVehiculo(Vehiculo vehiculo);
    }
} 
