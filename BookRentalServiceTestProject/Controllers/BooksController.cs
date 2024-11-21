using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookRentalServiceTestProject.Models;
using System.Numerics;
namespace BookRentalServiceTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksDbContext _context;
        public BooksController(BooksDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Books>> Get()
        {
            return await _context.Books.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 1)
                return BadRequest();
            var books = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);
            if (books == null)
                return NotFound();
            return Ok(books);

        }

        [HttpPost]
        public async Task<IActionResult> Post(Books books)
        {
            _context.Add(books);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
