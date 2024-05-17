using GestaoLivraria.Communication.Enums;
using GestaoLivraria.Communication.Requests;
using GestaoLivraria.Communication.Responses;
using GestaoLivraria.Exceptions;

namespace GestaoLivraria.UseCases.Books
{
    public class EditBookUseCase
    {
        public BookResponse Execute(int id, BookRequest book)
        {
            RequestValidation(id, book);

            return new BookResponse
            {
                Id = id,
                Title = book.Title,
                Author = book.Author,
                Gender = book.Gender,
                Price = book.Price,
                Stock = book.Stock
            };
        }

        private void RequestValidation(int id, BookRequest book)
        {
            if (id <= 0)
            {
                throw new BadRequestException("Id inválido");
            }

            if (string.IsNullOrWhiteSpace(book.Title))
            {
                throw new BadRequestException("Título deve ser informado");
            }

            if (string.IsNullOrWhiteSpace(book.Author))
            {
                throw new BadRequestException("Autor deve ser informado");
            }

            if (!Enum.IsDefined(typeof(Gender), book.Gender))
            {
                throw new BadRequestException("Gênero inválido");
            }

            if (book.Price <= 0)
            {
                throw new BadRequestException("Valor de preço inválido");
            }

            if (book.Stock < 0)
            {
                throw new BadRequestException("Valor de estoque inválido");
            }
        }
    }
}
