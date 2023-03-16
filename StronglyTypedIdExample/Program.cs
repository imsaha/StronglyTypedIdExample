// See https://aka.ms/new-console-template for more information

using StronglyTypedIdExample;
using StronglyTypedIdExample.DTOs;
using StronglyTypedIdExample.Entities;

Console.WriteLine("Hello, World!");



var dbContext = new AppDbContext();

var book = new Book()
{
    Id = new BookId(1),
    Name = "Design Patterns: Elements of Reusable Object-Oriented Software"
};

dbContext.Books.Add(book);
dbContext.SaveChanges();

var books = dbContext.Books.Select(s => new BookDto(s.Id, s.Name)).ToList();
var authors = dbContext.Authors.Select(s => new AuthorDto(s.Id, s.Name)).ToList();
