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
                break;
            }
        case 2:
            {
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
    Console.WriteLine("1. Agregar libro.");
    Console.WriteLine("2. Registrar usuario.");
    Console.WriteLine("3. Catálogo.");
    Console.WriteLine("4. Buscar libro.");
    Console.WriteLine("5. Prestar libro.");
    Console.WriteLine("6. Salir.");
}