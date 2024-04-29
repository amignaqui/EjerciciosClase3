using Clase3.Ejercicio_2;
using Clase3.Ejercicio_2.Ejercicio_1;
using Clase3.Ejercicio_2.Ejercicio_2;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1

            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            //ImprimirDatosVehiculo(moto);
            //ImprimirDatosVehiculo(auto);
            
            Auto miAuto = new Auto() { Marca = "Fiat", Modelo = "600" };
            miAuto.ImprimirDatosVehiculo(miAuto); 

            Moto miMoto = new Moto() { Marca = "Zanella", Modelo = "500" };
            miMoto.ImprimirDatosVehiculo(miMoto);
            #endregion

            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca

            Ejercicio_2.Biblioteca miBiblioteca = new Ejercicio_2.Biblioteca();
            Console.WriteLine("\nLista de libros de mi biblioteca");
            Console.WriteLine("--------------------------------");
            miBiblioteca.ObtenerLibros(miBiblioteca);

            #endregion
        }
    }
}