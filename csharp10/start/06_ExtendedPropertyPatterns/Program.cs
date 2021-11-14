var book = new Book("1234", new Author("Steven King"));



public record Book(string ISBN, Author Author);
public record Author(string Name);
