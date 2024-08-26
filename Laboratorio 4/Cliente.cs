using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    internal class Cliente
    {
        public int ID {  get; set; }
        public string Nombre { get; set; }
        private string MetodoPago { get; set; }

        public Cliente(int iD, string nombre, string metodoPago)
        {
            ID = iD;
            Nombre = nombre;
            MetodoPago = metodoPago;
        }
    }
}
