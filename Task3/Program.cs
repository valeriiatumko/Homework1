internal class Program
{
    private static void Main(string[] args)
    {
        Title title = new Title("It");
        Author author = new Author("Stephen King");
        Content content = new Content("test content");
        Book book = new Book(title, author, content);
        book.Show();
    }
}
class Book
{
    Title title;
    Author author;
    Content content;

    public Book(Title title, Author author, Content content)
    {
        this.title = title;
        this.author = author;
        this.content = content;
    }

    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }
}
class Title
{   

    string name;
    public Title(string name)
    {
        this.name = name;
    }
     public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(name);
    }
}
class Author
{
    string name;
    public Author(string name)
    {
        this.name = name;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(name);
    }
}
class Content
{
    string content;
    public Content(string content)
    {
        this.content = content;
    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(content);
    }
}
