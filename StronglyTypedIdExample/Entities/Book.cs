namespace StronglyTypedIdExample.Entities;

public record BookId(long Value) : StronglyTypedId(Value);
public class Book
{
    public BookId Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public AuthorId AuthorId { get; set; }
    public Author Author { get; set; }
}
