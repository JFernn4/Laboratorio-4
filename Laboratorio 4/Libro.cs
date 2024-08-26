using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public bool Disponible { get; set; }

        public Libro(string titulo, string autor, bool disponible)
        {
            Titulo = titulo;
            Autor = autor;
            Disponible = disponible;
        }
        public virtual string ObtenerDetalles()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Disponible: {Disponible}";
        }
    }
}
