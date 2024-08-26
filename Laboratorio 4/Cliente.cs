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
        List<Cliente>listaClientes= new List<Cliente>();
        public void AgregarCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
            Console.WriteLine("Se ha añadido al cliente.");
            Console.ReadKey();
        }
        public void AgregarClienteRegular()
        {
            Console.Clear();
            Console.WriteLine("Agregar un nuevo cliente:");
            Console.WriteLine("ID:");
            int iD=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Método de pago.");
            string metodoPago= Console.ReadLine();
            Cliente cliente= new Cliente(iD, nombre, metodoPago);
            AgregarCliente(cliente);
        }
        public void AgregarClienteVIP()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Agregar un nuevo cliente:");
                Console.WriteLine("ID:");
                int iD = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Método de pago.");
                string metodoPago = Console.ReadLine();
                Cliente cliente = new Cliente(iD, nombre, metodoPago);
                AgregarCliente(cliente);
            }
            catch (Exception ex) { Console.WriteLine("Ingresa un ID válido. " + ex.Message); Console.ReadKey(); }
        }
        public virtual string ObtenerDetalles()
        {
            return $"ID: {ID}, Nombre: {Nombre}, Método de pago: {MetodoPago}";
        }
        public void MostrarClientes()
        {
            Console.Clear();
            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.ObtenerDetalles());
            }
            Console.ReadKey();
        }
    }
}
