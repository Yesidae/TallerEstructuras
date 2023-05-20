using HorsesInConflict;

Console.Write("Ingrese la ubicación de los caballo: ");
var positions = Console.ReadLine();

var response = new ConflictHorses(positions!);
Console.WriteLine(response);