namespace HarvestInHorse.Logic
{
    public class Harvest
    {

        public string Recolects { get; set; }

        public string Fruits { get; set; }

        public string Moves { get; set; }

        public string PosHorse { get; set; }

        public Dictionary<string, int> Frts { get; set; }

        public Harvest(string fruits, string posHorse, string moveHorse)
        {
            Fruits = fruits;
            PosHorse = posHorse;
            Moves = moveHorse;
            Frts = new Dictionary<string, int>();
            SplitText();
            Recolects = CollectedFruits();
        }

        public static string MoveHorse(string pos, string moves)
        {
            int x = pos[0] - 'A';
            int y = pos[1] - '1';

            switch (moves)
            {
                case "UL":
                    x -= 1;
                    y += 2;
                    break;

                case "UR":
                    x += 1;
                    y += 2;
                    break;

                case "LU":
                    x -= 2;
                    y += 1;
                    break;

                case "LD":
                    x -= 2;
                    y -= 1;
                    break;

                case "RU":
                    x += 2;
                    y += 1;
                    break;

                case "RD":
                    x += 2;
                    y -= 1;
                    break;

                case "DL":
                    x -= 1;
                    y -= 2;
                    break;

                case "DR":
                    x += 1;
                    y -= 2;
                    break;
            }
            return "" + (char)('A' + x) + (char)('1' + y);
        }


        

        public void SplitText()
        {
            var fruits = Fruits.Split(',');
            foreach (string aux in fruits)
            {
                string position = aux[..2];
                char fruit = aux[2];
                this.Frts[position] = fruit;
            }
        }

        public string CollectedFruits()
        {
            var collec = "";
            var moves = Moves.Split(",");

            foreach (var move in moves)
            {
                PosHorse = MoveHorse(PosHorse, move);

                if (Frts.ContainsKey(PosHorse))
                {
                    int number = int.Parse(Frts[PosHorse].ToString());
                    char words = Convert.ToChar(number);
                    collec += words + " ";
                    Frts.Remove(PosHorse);
                }
            }

            return $"The collect is: {collec}";
        }

        
    }
}