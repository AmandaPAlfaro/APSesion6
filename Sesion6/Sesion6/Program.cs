using Sesion6.Patrones;

Console.WriteLine("Patrones de Comportamiento");

Console.WriteLine("Seleccione el patron a ejecutar");

Console.WriteLine("1. Observer");

var opcion = Console.ReadLine();

switch (opcion) 
{
    case "1":
        Console.WriteLine("Patron Observador");
        AppObserver.Ejecutar();
        break;

    case "2":
        Console.WriteLine("Opcion no valida");
        break;
}