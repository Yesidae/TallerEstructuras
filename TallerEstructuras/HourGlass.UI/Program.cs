
using HourGlass.Logic;

Console.Write("Entry the matrix order: ");

int n = int.Parse(Console.ReadLine()!);

var mat = new ExerciceGlass(n);

Console.WriteLine("****Complete Matrix*****");
Console.WriteLine(mat);

Console.WriteLine("RELOJ DE ARENA");
Console.WriteLine(mat.Imp);