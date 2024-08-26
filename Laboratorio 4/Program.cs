using Laboratorio_4;
Biblioteca biblioteca= new Biblioteca();
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
                break;
            }
        case 4:
            {
                break;
            }
        case 5:
            {
                break;
            }
        case 6:
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
    Console.WriteLine("3. Registrar usuario.");
    Console.WriteLine("4. Catálogo.");
    Console.WriteLine("5. Buscar libro.");
    Console.WriteLine("6. Prestar libro.");
    Console.WriteLine("7. Salir.");
}