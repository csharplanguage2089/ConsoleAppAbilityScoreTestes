namespace ConsoleAppAbilityScoreTestes
{
    internal class Dashboard
    {
        public void Show(string a)
        {
            Console.WriteLine(a);
        }

        public void Show(int a)
        {
            Console.WriteLine(a);
        }

        public void Show(double a)
        {
            Console.WriteLine(a);
        }

        public string messageInput()
        {
            return Console.ReadLine();
        }

        public char keyInput()
        {
            return Console.ReadKey(true).KeyChar;
        }
    }
}
