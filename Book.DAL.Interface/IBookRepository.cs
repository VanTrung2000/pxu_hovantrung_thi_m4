using Book.Domain.Request;
using Book.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL.Interface
{
    public interface IBookRepository
    {
        Task<IEnumerable<Books>> Gets();
        Task<CreateBookResult> CreateBook(CreateBookRequest request);

        Task<UpdateBookResult> UpdateBook(UpdateBookRequest request);
        Task<DeleteBookResult> DeleteBook(DeleteBookRequest request);

    }
}
