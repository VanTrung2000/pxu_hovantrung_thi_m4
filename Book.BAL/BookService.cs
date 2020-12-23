using Book.BAL.Interface;
using Book.DAL.Interface;
using Book.Domain.Request;
using Book.Domain.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book.BAL
{
    public class BookService: IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Task<CreateBookResult> CreateCategory(CreateBookRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteBookResult> DeleteBook(DeleteBookRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Books>> Gets()
        {
            return await bookRepository.Gets();
        }

        public Task<UpdateBookResult> UpdateBook(UpdateBookRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
