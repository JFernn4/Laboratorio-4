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
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("¿Está disponible? (si/no): ");
            string disponibleInput = Console.ReadLine();
            bool disponible = disponibleInput.ToLower() == "si";

            int numeroCopias;
            while (true)
            {
                Console.Write("Número de copias: ");
                try
                {
                    numeroCopias = Convert.ToInt32(Console.ReadLine());
                    if (numeroCopias < 0)
                    {
                        Console.WriteLine("El número de copias no puede ser negativo.");
                        continue;
                    }
                    break; 
                }
                catch (Exception ex) { Console.WriteLine("Ingresa un número válido."); Console.ReadKey(); }
            }
            Console.Write("Estante: ");
            string estante = Console.ReadLine();

            LibroFisico libroFisico = new LibroFisico(titulo, autor, disponible, numeroCopias, estante);
            AgregarLibro(libroFisico);
        }

        public void AgregarLibroDigital()
        {
            Console.Clear();
            Console.WriteLine("Agregar un nuevo libro digital:");
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("¿Está disponible? (si/no): ");
            string disponibleInput = Console.ReadLine();
            bool disponible = disponibleInput.ToLower() == "si";
            Console.Write("Enlace: ");
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
        public void Prestar()
        {
            Console.Clear();
            Console.WriteLine("Título del libro:");
            string libroBuscar = Console.ReadLine();
            Libro buscar = listaLibros.Find(p => p.Titulo == libroBuscar);
            if (buscar == null)
            {
                Console.WriteLine("No existe el libro.");
                Console.ReadKey();
            }
            else
            {
                buscar.Disponible = false;
                Console.WriteLine($"Se ha prestado el libro {buscar.Titulo} de {buscar.Autor}.");
                Console.ReadKey();
            }
        }
        public void Devolver()
        {
            Console.Clear();
            Console.WriteLine("Título del libro:");
            string libroBuscar = Console.ReadLine();
            Libro buscar = listaLibros.Find(p => p.Titulo == libroBuscar);
            if (buscar == null)
            {
                Console.WriteLine("No existe el libro.");
                Console.ReadKey();
            }
            else
            {
                buscar.Disponible = true;
                Console.WriteLine($"Se ha devuelto el libro {buscar.Titulo} de {buscar.Autor}.");
                Console.ReadKey();
            }
        }
    }
}
