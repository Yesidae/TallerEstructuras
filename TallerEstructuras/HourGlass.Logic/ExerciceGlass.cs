namespace HourGlass.Logic
{
    public class ExerciceGlass
    {
        public int N { get; set; }
        public int[,] MatGlass { get; set; }

        public string Imp { get; set; }

        public ExerciceGlass(int n)
        {
            N = n;
            MatGlass = new int[n, n];
            GetMatGlass();
            Imp = PrintMatrixHourglass();

        }

        public int[,] GetMatGlass()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MatGlass[i, j] = i * 2 + j;
                }
            }
            return MatGlass;
        }

        public override string ToString()
        {
            var output = string.Empty;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{MatGlass[i, j]}  \t";
                }
                output += $"\n";
            }
            return output;
        }

        public string PrintMatrixHourglass()
        {
            var output = String.Empty;

            for (int i = 0; i < N; i++)
            {
                int x = i <= N / 2 ? i : N - 1 - i;
                int y = N - x;

                for (int j = 0; j < x; j++)
                {
                    output += "\t";
                }

                for (int j = x; j < y; j++)
                {
                    output += $"{MatGlass[i, j]}\t";
                }

                for (int j = y; j < N; j++) 
                {
                    output += "\t";
                }

                output += "\n";
            }
            return output;
        }


        
    }
}