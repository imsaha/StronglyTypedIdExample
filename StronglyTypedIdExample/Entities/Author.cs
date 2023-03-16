namespace StronglyTypedIdExample.Entities;

public record AuthorId(long Value) : StronglyTypedId(Value);
public class Author
{
    public AuthorId Id { get; set; }
    public string Name { get; set; }
}
