using Taller.Logic;

Console.WriteLine("****Matrix Multiplicatión****");

Console.Write("Ingrese el valor de m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el valor de n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el valor de p: ");
int p = Convert.ToInt32(Console.ReadLine());

var mat = new Exercicemultmat(m, n, p);

Console.WriteLine("***MATRIZ A ***");

var matA = mat.MatAB(mat.A, m, n);

Console.WriteLine(matA);

Console.WriteLine("***MATRIZ B ***");

var matB = mat.MatAB(mat.B, n, p);

Console.WriteLine(matB);

Console.WriteLine("***MATRIZ C ***");

Console.WriteLine(mat);