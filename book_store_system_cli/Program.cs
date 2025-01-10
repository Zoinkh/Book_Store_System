namespace book_store_system_cli
{
    internal class Program : Menu
    {
        static void Main(string[] args)
        {
            Menu onStart = new Menu();
            onStart.Start();
        }
    }
}
