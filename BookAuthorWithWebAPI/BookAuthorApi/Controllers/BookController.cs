using BookAuthorApi.Core.DTOs;
using BookAuthorApi.Core.Entities;
using BookAuthorApi.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//API Controllers are similar to controllers of MVC applications, but they are specifically designed to handle HTTP requests and responses for RESTful APIs. They typically return data in formats like JSON or XML rather than rendering views.
namespace BookAuthorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository repo)
        {
            this._bookRepository = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookRepository.GetAllBooksAsync();
            var model = books.Select(b => new BookDto(b.BookId, b.Title,
b.BookPrice, b.AuthorId));
            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(new BookDto(book.BookId, book.Title, book.BookPrice, book.AuthorId));
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] BookDto bookDto)
        {
            if (bookDto == null)
            {
                return BadRequest();
            }
            var book = new Book
            {
                Title = bookDto.Title,
                BookPrice = bookDto.BookPrice,
                AuthorId = bookDto.AuthorId
            };
            var createdBook = await _bookRepository.AddBookAsync(book);
            var result = new BookDto(createdBook.BookId, createdBook.Title, createdBook.BookPrice, createdBook.AuthorId);
            return CreatedAtAction(nameof(GetBookById), new { id = result.BookId }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] BookDto bookDto)
        {
            if (bookDto == null || id != bookDto.BookId)
            {
                return BadRequest();
            }
            var existingBook = await _bookRepository.GetBookByIdAsync(id);
            if (existingBook == null)
            {
                return NotFound();
            }
            existingBook.Title = bookDto.Title;
            existingBook.BookPrice = bookDto.BookPrice;
            existingBook.AuthorId = bookDto.AuthorId;
            await _bookRepository.UpdateBookAsync(existingBook);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var existingBook = await _bookRepository.GetBookByIdAsync(id);
            if (existingBook == null)
            {
                return NotFound();
            }
            await _bookRepository.DeleteBookAsync(id);
            return NoContent();
        }
    }
}