var book = new Book { ISBN = "1234", Author = new() { Name = "Steven King" } };

// pre C#10
var isNull = book is null;
var hasIsbn = book is { ISBN: "1234" } or { ISBN: "5431" };

// new: pattern for nested properties
var isFromStevenKing = book is { Author.Name: "Steven King" };

public class Book
{
    public string ISBN { get; set; } = "";
    public Author Author { get; set; } = new Author();
}

public class Author
{
    public string Name { get; set; } = "";
}