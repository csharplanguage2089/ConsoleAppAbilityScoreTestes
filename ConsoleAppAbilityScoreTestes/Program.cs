using ConsoleAppAbilityScoreTestes;

internal class Program
{
    private static void Main(string[] args)
    {
        Checks checks = new Checks();
        ClassAbilityScoreCalculator classAbilityScoreCalculator = new ClassAbilityScoreCalculator();
        Dashboard dashboard = new Dashboard();

        dashboard.Show("Welcome to the Stats Calculator!");
        dashboard.Show("Set Strength, Agility, and Intelligence");
        dashboard.Show("Compare how much you are superior or inferior in characteristics to your opponent");
        dashboard.Show("Enter a number - the player's strength. The rest of the characteristics are determined automatically based on the selected value");

        while (true)
        {
            double aStrength = checks.ChecksMethod();

            Summary(aStrength);

            Console.ForegroundColor = ConsoleColor.Cyan;
            dashboard.Show("Press Q to exit or any other key to repeat");
            Console.ResetColor();

            char key = dashboard.keyInput();
            if (key == 'Q' || key == 'q')
                return;
            else
                dashboard.Show("Enter a number - the player's strength");
        }

        /// <summary>
        /// Сравнение характеристик игрока и соперника
        /// </summary>
        void Summary(double a)
        {
            // Сформированные характеристики игрока на основе силы
            double[] playerCharacteristics = classAbilityScoreCalculator.CharacterCharacteristicsPlayes(a);

            // Характеристики соперника, которые известны заранее
            double[] enemyCharacteristics = classAbilityScoreCalculator.CharacterCharacteristicsEnemy();

            double playerStrength = playerCharacteristics[0];
            double playerDexterity = playerCharacteristics[1];
            double playerIntelligence = playerCharacteristics[2];

            double enemyStrength = enemyCharacteristics[0];
            double enemyDexterity = enemyCharacteristics[1];
            double enemyIntelligence = enemyCharacteristics[2];

            double resultStrength;
            double resultDexterity;
            double resultIntelligence;

            if (playerStrength == enemyStrength)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                dashboard.Show("Characteristics are equal!");
                Console.ResetColor();
            }
            else if (playerCharacteristics[0] > enemyStrength)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                dashboard.Show("\n" +
                    "The character's stats are higher than the opponent's stats");

                resultStrength = playerCharacteristics[0] - enemyCharacteristics[0];
                resultDexterity = playerCharacteristics[1] - enemyCharacteristics[1];
                resultIntelligence = playerCharacteristics[2] - enemyCharacteristics[2];

                Console.ResetColor();
                dashboard.Show("The difference in strength is: " + Math.Round(resultStrength, 2));
                dashboard.Show("Difference in Dexterity: " + Math.Round(resultDexterity, 2));
                dashboard.Show("Difference in Intelligence: " + Math.Round(resultIntelligence, 2));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                dashboard.Show("\n" +
                    "The character's stats are lower than the opponent's stats");

                resultStrength = enemyCharacteristics[0] - playerCharacteristics[0];
                resultDexterity = enemyCharacteristics[1] - playerCharacteristics[1];
                resultIntelligence = enemyCharacteristics[2] - playerCharacteristics[2];

                Console.ResetColor();
                dashboard.Show("The difference in strength is: " + Math.Round(resultStrength, 2));
                dashboard.Show("The difference in agility is: " + Math.Round(resultDexterity, 2));
                dashboard.Show("The difference in intelligence is: " + Math.Round(resultIntelligence, 2));
            }
        }
    }
}
