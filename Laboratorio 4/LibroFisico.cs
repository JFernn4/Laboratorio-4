using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    internal class LibroFisico : Libro
    {
        public int NumeroCopias { get; set; }
        public string Estante { get; set; }
        public LibroFisico(string titulo, string autor, bool disponible, int numeroCopias, string estante) : base(titulo, autor, disponible)
        {
           NumeroCopias = numeroCopias;
           Estante = estante;
        }
        public override string ObtenerDetalles()
        {
            return base.ObtenerDetalles() + $", Copias:{NumeroCopias}, Estante: {Estante}";
        }
    }
}
