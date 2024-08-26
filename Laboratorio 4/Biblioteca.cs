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
    }
}
