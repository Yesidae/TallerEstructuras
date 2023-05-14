namespace Taller.Logic
{
    public class MatrixMultiplication
    {
        
        public static Array[,] GetMatrixMultiplication(int m,int n,int p)
        {
            int[,] A = new int[m,n];
            int[,] B = new int[n, p];
            int[,] C = new int[m, p];
            int count;
            int resultado;

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
                    for (int k = 0; k < length; k++)
                    {

                    }
                    resultado[i,j] = A[i,count] * B[count,j];
                }
                    
                count++;
            }

            return null!;
        }



        public static string ToString(List<int> numbers)
        {
            var output = string.Empty;
            foreach (var number in numbers)
            {
                output += $"{number}\t";
            }
            return output + "\n";
        }
    }
}