using GestaoLivraria.Communication.Requests;
using GestaoLivraria.Communication.Responses;
using GestaoLivraria.Exceptions;
using GestaoLivraria.UseCases.Books;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    [Route("[action]")]
    [ProducesResponseType(typeof(BookResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CreateBook(BookRequest book)
    {
        try
        {
            var response = new CreateBookUseCase().Execute(book);

            return Created(string.Empty, response);
        }
        catch (BadRequestException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType(typeof(List<BookResponse>), StatusCodes.Status201Created)]
    public IActionResult GetBooks()
    {
        try
        {
            var response = new GetBooksUseCase().Execute();
            return Ok(response);
        }
        catch (Exception)
        {

            throw;
        }
    }

    [HttpPut]
    [Route("[action]/{id}")]
    [ProducesResponseType(typeof(BookResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult EditBook(int id, BookRequest book)
    {
        try
        {
            var response = new EditBookUseCase().Execute(id, book);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (BadRequestException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    [Route("[action]/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteBook(int id)
    {
        try
        {
            new DeleteBookUseCase().Execute(id);

            return NoContent();
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
