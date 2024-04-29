using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_2.Ejercicio_1
{
    internal class Auto : Vehiculo
    {
        public override void ImprimirDatosVehiculo(Vehiculo miAuto)
        {
            Console.WriteLine($"AUTO: Marca: {Marca}, Modelo: {Modelo}");
        }
    }
}
