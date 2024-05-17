using GestaoLivraria.Communication.Enums;
using GestaoLivraria.Communication.Responses;

namespace GestaoLivraria.UseCases.Books;

public class GetBooksUseCase
{
    public List<BookResponse> Execute()
    {
        return new List<BookResponse>()
        {
            new BookResponse()
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Gender = Gender.Fiction,
                Price = 10.99m,
                Stock = 12
            },
            new BookResponse()
            {
                Id = 2,
                Title = "Harry Potter and the Philosopher's Stone",
                Author = "J.K. Rowling",
                Gender = Gender.Fantasy,
                Price = 7.99m,
                Stock = 25
            },
            new BookResponse()
            {
                Id = 3,
                Title = "Dune",
                Author = "Frank Herbert",
                Gender = Gender.ScienceFiction,
                Price = 9.99m,
                Stock = 8
            },
            new BookResponse()
            {
                Id = 4,
                Title = "Sherlock Holmes: The Complete Novels and Stories",
                Author = "Arthur Conan Doyle",
                Gender = Gender.Mystery,
                Price = 15.99m,
                Stock = 5
            },
            new BookResponse()
            {
                Id = 5,
                Title = "The Da Vinci Code",
                Author = "Dan Brown",
                Gender = Gender.Thriller,
                Price = 12.99m,
                Stock = 10
            },
            new BookResponse()
            {
                Id = 6,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Gender = Gender.Romance,
                Price = 8.99m,
                Stock = 20
            },
            new BookResponse()
            {
                Id = 7,
                Title = "It",
                Author = "Stephen King",
                Gender = Gender.Horror,
                Price = 14.99m,
                Stock = 7
            },
            new BookResponse()
            {
                Id = 8,
                Title = "The Book Thief",
                Author = "Markus Zusak",
                Gender = Gender.HistoricalFiction,
                Price = 11.99m,
                Stock = 15
            },
            new BookResponse()
            {
                Id = 9,
                Title = "The Diary of a Young Girl",
                Author = "Anne Frank",
                Gender = Gender.Biography,
                Price = 6.99m,
                Stock = 30
            },
            new BookResponse()
            {
                Id = 10,
                Title = "Becoming",
                Author = "Michelle Obama",
                Gender = Gender.Memoir,
                Price = 18.99m,
                Stock = 10
            }
        };
    }
}
