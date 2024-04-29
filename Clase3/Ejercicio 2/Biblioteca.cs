using Clase3.Ejercicio_2.Ejercicio_2;

namespace Clase3.Ejercicio_2
{
    public class Biblioteca : IBiblioteca
    {
        public List<string> Libros { get; set; }

        public Biblioteca()
        {
            Libros = new List<string>()
            {
                "Cien años de soledad",
                "1984",
                "Don Quijote de la Mancha",
                "Matar a un ruiseñor",
                "El Gran Gatsby",
                "Orgullo y prejuicio",
                "Crónica de una muerte anunciada",
                "El señor de los anillos",
                "Los miserables",
                "La sombra del viento"
            };
        }
        public void ObtenerLibros(Biblioteca miBiblioteca)
        {
            foreach (string bookTitle in Libros)
            {
                Console.WriteLine(bookTitle);
            }
        }
    }
}
