using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    internal class Biblioteca
    {
        List<Libro> listaLibros=new List<Libro>();
        public void AgregarLibro(Libro libro)
        {
            listaLibros.Add(libro);
            Console.WriteLine("Se ha añadido el libro.");
            Console.ReadKey();
        }
        public void AgregarLibroFisico()
        {
            Console.Clear();
            Console.WriteLine("Agregar un nuevo libro físico:");
            Console.WriteLine("Título: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("¿Está disponible? (si/no): ");
            string disponibleInput = Console.ReadLine();
            bool disponible = disponibleInput.ToLower() == "si";
            Console.WriteLine("Número de copias:");
            int numeroCopias= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Estante: ");
            string estante = Console.ReadLine();

            LibroFisico libroFisico = new LibroFisico(titulo, autor, disponible, numeroCopias, estante);
            AgregarLibro(libroFisico);
        }
        public void AgregarLibroDigital()
        {
            Console.Clear();
            Console.WriteLine("Agregar un nuevo libro digital:");
            Console.WriteLine("Título: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("¿Está disponible? (si/no): ");
            string disponibleInput = Console.ReadLine();
            bool disponible = disponibleInput.ToLower() == "si";
            Console.WriteLine("Enlace: ");
            string enlace = Console.ReadLine();
            LibroDigital libroDigital = new LibroDigital(titulo, autor, disponible, enlace);
            AgregarLibro(libroDigital);
        }
        public void MostrarLibros()
        {
            Console.Clear();
            Console.WriteLine("Catálogo de libros:");
            foreach (Libro libro in listaLibros)
            {
                Console.WriteLine(libro.ObtenerDetalles());
            }
            Console.ReadKey();
        }
        public void BuscarLibro()
        {
            Console.Clear();
            Console.WriteLine("Título del libro:");
            string libroBuscar= Console.ReadLine();
            Libro buscar= listaLibros.Find(p=>p.Titulo==libroBuscar);
            if (buscar == null)
            {
                Console.WriteLine("No existe el libro.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(buscar.ObtenerDetalles());
                Console.ReadKey();
            }
        }
    }
}
