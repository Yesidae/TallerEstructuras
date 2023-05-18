using Taller.Logic;

Console.WriteLine("****Matrix Multiplicatión****");


Console.WriteLine("****Descomposition Into Factors****");

Console.Write("Enter the number to descompose");
int number = int.Parse(Console.ReadLine()!);

Queue<int> factors = Exercices.DecompositionInFactors(number);

Console.WriteLine($"Factors descompose is {number} : ");
while (factors.Count > 0)
{
    Console.WriteLine($"{factors.Dequeue()} ");
}
Console.WriteLine();


Console.WriteLine("****Descomposition Into Factors****");

Console.Write("Ingrese la ubicación de los frutos: ");
char frutos = char.Parse(Console.ReadLine()!);

Console.Write("Ingrese la ubicación del caballo: ");
char caballo = char.Parse(Console.ReadLine()!);