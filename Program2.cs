internal class Program
{
    private static void Main(string[] args)
    {
        ProgramConfig.Info();
    }

}
internal class ProgramConfig
{
    public const string Version = "1.0.0";
    public const string Name = "Пофистал Бабаев";

    public static void Info()
    {
        Console.WriteLine($"Версия программы: {Version}");
        Console.WriteLine($"Имя разработчика: {Name}");
    }
}