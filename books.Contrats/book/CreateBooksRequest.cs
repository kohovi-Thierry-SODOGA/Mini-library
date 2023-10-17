namespace books.Contrats.books;

public record CreateBooksRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Topics
);