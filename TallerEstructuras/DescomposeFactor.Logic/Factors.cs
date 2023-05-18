namespace DescomposeFactor.Logic
{
    public class Factors
    {
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

    }
}