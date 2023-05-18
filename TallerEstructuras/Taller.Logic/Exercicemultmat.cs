namespace Taller.Logic
{
    public class Exercicemultmat
    {

        private int M { get; set; }
        private int N { get; set; }
        private int P { get; set; }

        public int[,] A { get; set; }

        public int[,] B { get; set; }

        private int[,] C { get; set; }

        public Exercicemultmat(int m, int n, int p)
        {
            M = m;
            N = n;
            P = p;
            A = new int[m, n];
            B = new int[n, p];
            C = new int[m, p];
            GetMatrixMultiplication();
        }
        public int[,] GetMatrixMultiplication()
        {

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = (i + 1) * (j);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    B[i, j] = (j + 1) * (i);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return C;
        }

        public override string ToString()
        {
            var output = string.Empty;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    output += $"{C[i, j]}  ";
                }
                output += $"\n";
            }
            return output;
        }

        public string MatAB(int[,] matrix, int aux, int aux2)
        {
            var output = string.Empty;

            for (int i = 0; i < aux; i++)
            {
                for (int j = 0; j < aux2; j++)
                {
                    output += $"{matrix[i, j]}  ";
                }
                output += $"\n";
            }
            return output;
        }
    }
}