internal class Program
{
    private static void Main(string[] args)
    {
        Book book = new Book("678-673-636-366", "Роковые яйца", "Михаил Булгаков");
        book.ShowInfoBook();
    }

}
internal class Book
{
    private readonly string _isbn;
    public string ISBN { get { return _isbn; } }
    private string _title;
    public string Title { get { return _title; } set { _title = value; } }

    private string _author;
    public string Author { get { return _author; } set { _author = value; } }

    public Book(string isbn, string title, string author)
    {
        _isbn = isbn;
        _title = title;
        _author = author;
    }

    public void ShowInfoBook()
    {
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
    }


}