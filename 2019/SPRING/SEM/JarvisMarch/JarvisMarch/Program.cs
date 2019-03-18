namespace JarvisMarch
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.FillFile(100, 5);
            new Graph().Run();
        }
    }
}
