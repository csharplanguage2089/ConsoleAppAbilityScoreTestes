namespace ConsoleAppAbilityScoreTestes
{
    internal class Error
    {
        Dashboard dashboard = new Dashboard();
        public double ConsoleError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            dashboard.Show("Error! Default value selected: 1.01");
            Console.ResetColor();
            return 1.01;
        }
    }
}
