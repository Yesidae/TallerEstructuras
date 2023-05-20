using HarvestInHorse.Logic;

Console.WriteLine("****Harvest In Horse*****");

Console.WriteLine();


Console.Write("Ingrese la ubicación de los frutos: ");
var cultive = Console.ReadLine();

Console.Write("Ingrese la ubicación inicial del caballo: ");
var posHorse = Console.ReadLine()!;

Console.Write("Ingrese los movimientos del caballo: ");
var moves = Console.ReadLine();


var harvest = new Harvest(cultive, posHorse, moves);

Console.Write(harvest.Recolects);