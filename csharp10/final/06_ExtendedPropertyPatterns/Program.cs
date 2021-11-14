var book = new Book("1234", new Author("Steven King"));

// pre C#10
var isNull = book is null;
var hasIsbn = book is { ISBN: "1234" } or { ISBN: "5431" };

// new: pattern for nested properties
var isFromStevenKing = book is { Author.Name: "Steven King" };

string bookDescription = book switch
{
    { ISBN: "1234" } or { ISBN: "4321" } => "Book has ISBN 1234 oder 4321",
    { Author.Name: "Steven King" } => "Book is from Steven King",
    null => "Book is null",
    _ => "No idea"
};

public record Book(string ISBN, Author Author);
public record Author(string Name);
