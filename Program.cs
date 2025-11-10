internal class Program
{
    private static void Main(string[] args)
    {
        Settings.ShowConfigFilePath();
    }

}
internal class Settings
{
    private static readonly string ConfigFilePath;

    static Settings()
    {
        ConfigFilePath = @"C:\config\settings.json";
    }
    public static void ShowConfigFilePath()
    {
        Console.WriteLine(ConfigFilePath);
    }
}