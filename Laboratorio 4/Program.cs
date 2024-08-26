using Laboratorio_4;
Biblioteca biblioteca= new Biblioteca();
Cliente gestionClientes = new Cliente(0, string.Empty, string.Empty);
bool menu = true;
int opcion;
while (menu)
{
    MostrarMenu();
    opcion= Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                biblioteca.AgregarLibroDigital();
                break;
            }
        case 2:
            {
                biblioteca.AgregarLibroFisico();
                break;
            }
        case 3:
            {
                gestionClientes.AgregarClienteRegular();
                break;
            }
        case 4:
            {
                gestionClientes.AgregarClienteVIP();
                break;
            }
        case 5:
            {
                biblioteca.MostrarLibros();
                break;
            }
        case 6:
            {
                gestionClientes.MostrarClientes();
                break;
            }
        case 7:
            {
                biblioteca.BuscarLibro();
                break;
            }
        case 8:
            {
                biblioteca.Prestar();

                break;
            }
        case 9:
            {
                biblioteca.Devolver();
                break;
            }
        case 0:
            {
                menu = false;
                break;
            }
    }
}
static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("1. Agregar libro físico.");
    Console.WriteLine("2. Agregar libro digital.");
    Console.WriteLine("3. Registrar cliente regular..");
    Console.WriteLine("4. Registrar cliente VIP.");
    Console.WriteLine("5. Catálogo.");
    Console.WriteLine("6. Mostrar clientes.");
    Console.WriteLine("7. Buscar libro.");
    Console.WriteLine("8. Prestar libro.");
    Console.WriteLine("9. Devolver libro.");
    Console.WriteLine("0. Salir.");
}