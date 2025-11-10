internal class Program
{
    private static void Main(string[] args)
    {
        ObjectCounter obj = new ObjectCounter();
        ObjectCounter obj1 = new ObjectCounter();
        ObjectCounter.ShowCount();
        ObjectCounter obj2 = new ObjectCounter();
        ObjectCounter.ShowCount();
    }

}
internal class ObjectCounter
{
    private static int count = 0;

    public ObjectCounter()
    {
        count++;
    }
    public static void ShowCount()
    {
        Console.WriteLine("Количество экземпляров(обьектов): " + count);
    }

}