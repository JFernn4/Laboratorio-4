using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    internal class LibroDigital : Libro
    {
        public string Enlace { get; set; }
        public LibroDigital(string titulo, string autor, bool disponible, string enlace) : base(titulo, autor, disponible)
        {
            Enlace = enlace;
        }
        public override string ObtenerDetalles()
        {
            return base.ObtenerDetalles() + $", Enlace: {Enlace}.";
        }
    }
}
