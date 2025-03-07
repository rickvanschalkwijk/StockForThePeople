namespace JustForTestingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var z = DateTime.UnixEpoch.AddSeconds(1741132800);
            
            //DateTime.UnixEpoch.AddSeconds(epochSeconds)
            //DateTime x = Convert.ToDateTime(1741132800);
            DateOnly y = DateOnly.FromDateTime(z);
            Console.WriteLine("pause");
            Console.ReadLine();
        }
    }
}
