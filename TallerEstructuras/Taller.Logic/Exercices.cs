namespace Taller.Logic
{
    public class Exercices
    {

        public static int[,] GetMatrixMultiplication(int m, int n, int p)
        {
            int[,] A = new int[m, n];
            int[,] B = new int[n, p];
            int[,] C = new int[m, p];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = (i + 1) * (j);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = (j + 1) * (i);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return C;
        }


        public static Queue<int> DecompositionInFactors(int number)
        {
            var factors = new Queue<int>();
            int div = 2;

            while (number > 1)
            {
                if (number % div == 0)
                {
                    factors.Enqueue(div);
                    number /= div;
                }
                else
                {
                    div++;
                }
            }
            return factors;
        }

        public static int[,] Hourglass(int n)
        {


            return null!;

        }

        public static string HarvestInHorse(char posCrops, char posHorse)
        {
            char[,] board = new char[8, 8];
            var field = new Dictionary<char, int>();

            field.Add(posCrops, 1);

            
            return null!;
        }
    }
}