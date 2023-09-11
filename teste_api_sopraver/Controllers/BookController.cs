using Microsoft.AspNetCore.Mvc;
using teste_api_sopraver.Model;
using teste_api_sopraver.Repo;

namespace teste_api_sopraver
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBooks(int id)
        {
            return await _bookRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> PostBook([FromBody] Book book)
        {
            var newBook = await _bookRepository.Create(book);
            return CreatedAtAction(nameof(GetBooks), new { id = newBook.Id}, newBook);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var bookDelete = await _bookRepository.Get(id);

            if(bookDelete != null)
            {
                return NotFound();

            }
            
            await _bookRepository.Delete(bookDelete.Id);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> PutBoks(int id, [FromBody] Book book)
        {
            if(id != book.Id)
            {
                return BadRequest();                
            }

            await _bookRepository.Update(book);

            return NoContent();
        }
    }
}
