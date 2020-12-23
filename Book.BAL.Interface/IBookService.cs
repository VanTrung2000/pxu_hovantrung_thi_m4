using Book.Domain.Request;
using Book.Domain.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book.BAL.Interface
{
    public interface IBookService
    {
        Task<IEnumerable<Books>> Gets();
        Task<CreateBookResult> CreateBook(CreateBookRequest request);

        Task<UpdateBookResult> UpdateBook(UpdateBookRequest request);
        Task<DeleteBookResult> DeleteBook(DeleteBookRequest request);
    }
}
