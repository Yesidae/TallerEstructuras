using DescomposeFactor.Logic;

Console.WriteLine("****Descomposition Into Factors****\n");

Console.Write("Enter the number to descompose: ");
int number = int.Parse(Console.ReadLine()!);

Queue<int> factors = Factors.DecompositionInFactors(number);

Console.WriteLine($"\nFactors descompose is {number} : ");
while (factors.Count > 0)
{
    Console.WriteLine($"{factors.Dequeue()} ");
}