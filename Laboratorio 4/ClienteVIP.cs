using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    internal class ClienteVIP : Cliente
    {
        public ClienteVIP(int iD, string nombre, string metodoPago) : base(iD, nombre, metodoPago)
        {
        }
        public override string ObtenerDetalles()
        {
            return base.ObtenerDetalles() + "(Descuento del 15% al prestar un libro.)";
        }
    }
}
