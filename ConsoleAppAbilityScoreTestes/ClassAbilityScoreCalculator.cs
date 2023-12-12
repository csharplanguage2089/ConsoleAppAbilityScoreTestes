namespace ConsoleAppAbilityScoreTestes
{
    internal class ClassAbilityScoreCalculator
    {
        Dashboard dashboard = new Dashboard();

        /// <summary>
        /// Значение по умолчанию
        /// </summary>
        public double defaultValue = 10.08;

        /// <summary>
        /// Сила
        /// </summary>
        public double strength;

        /// <summary>
        /// Ловкость
        /// </summary>
        public double dexterity;

        /// <summary>
        /// Интеллект
        /// </summary>
        public double intelligence;

        /// <summary>
        /// Начальные характеристики игрока
        /// </summary>
        public double[] CharacterCharacteristicsPlayes(double a)
        {
            strength = Math.Round(a, 2);
            dexterity = Math.Round(strength - (strength / 3), 2); // Ловкость на основе силы минус (-) (сила деленная на треть) // 6.6666666666666661
            intelligence = Math.Round(dexterity - (dexterity / 3), 2); // Интеллект на основе ловкости минус (-) (ловкость деленная на треть) // 4.4444444444444446

            dashboard.Show("\n" +
                "Player default character info: \n" +
                "- Strength: " + "[" + strength + "] \n" +
                "- Dexterity: " + "[" + dexterity + "] \n" +
                "- Intelligence: " + "[" + intelligence + "]");

            double[] doubles = { strength, dexterity, intelligence };
            return doubles;
        }

        /// <summary>
        /// Начальные характеристики соперника
        /// </summary>
        public double[] CharacterCharacteristicsEnemy()
        {
            strength = Math.Round(defaultValue, 2); // Сила // 10.08
            dexterity = Math.Round(strength - (strength / 3), 2); // Ловкость на основе силы минус (-) (сила деленная на треть) // 6.6666666666666661
            intelligence = Math.Round(dexterity - (dexterity / 3), 2); // Интеллект на основе ловкости минус (-) (ловкость деленная на треть) // 4.4444444444444446

            dashboard.Show("\n" +
                "Enemy default character info: \n" +
                "- Strength: " + "[" + strength + "] \n" +
                "- Dexterity: " + "[" + dexterity + "] \n" +
                "- Intelligence: " + "[" + intelligence + "]");

            double[] doubles = { strength, dexterity, intelligence };
            return doubles;
        }
    }
}
