using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book.BAL.Interface;
using Book.Domain.Request;
using Microsoft.AspNetCore.Mvc;

namespace Book.API.Controllers
{
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [HttpGet]
        [Route("/api/book/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await bookService.Gets());
        }
        [HttpPost]
        [Route("/api/book/create")]
        public async Task<OkObjectResult> Create(CreateBookRequest request)
        {
            return Ok(await bookService.CreateBook(request));
        }
        [HttpPut]
        [Route("/api/book/update")]
        public async Task<OkObjectResult> Update(UpdateBookRequest request)
        {
            return Ok(await bookService.UpdateBook(request));
        }
        [HttpDelete]
        [Route("/api/book/delete")]
        public async Task<OkObjectResult> Delete(DeleteBookRequest request)
        {
            return Ok(await bookService.DeleteBook(request));
        }
    }
}
