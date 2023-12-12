namespace ConsoleAppAbilityScoreTestes
{
    internal class Checks
    {
        Dashboard dashboard = new Dashboard();
        Error error = new Error();
        public double ChecksMethod()
        {
            string message = dashboard.messageInput();
            double messageDouble;
            while (true)
            {
                if (double.TryParse(message, out messageDouble))
                    if (messageDouble > 0.0)
                        return messageDouble + .00;
                    else
                        return error.ConsoleError();
                else
                    return error.ConsoleError();
            }
        }
    }
}
