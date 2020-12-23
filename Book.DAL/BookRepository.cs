using Book.DAL.Interface;
using Book.Domain.Request;
using Book.Domain.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public async Task<CreateBookResult> CreateBook(CreateBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookName", request.BookName);
                parameters.Add("@Author", request.Author);
                parameters.Add("@Year", request.Year);
                parameters.Add("@Count", request.Count);
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateBookResult>(cnn: connect,
                                                    sql: "sp_CreateBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteBookResult> DeleteBook(DeleteBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookId", request.BookId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteBookResult>(cnn: connect,
                                                    sql: "sp_DeleteBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Books>> Gets()
        {
            return await SqlMapper.QueryAsync<Books>(cnn: connect,
                                            sql: "sp_GetBooks",
                                            commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateBookResult> UpdateBook(UpdateBookRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BookId", request.BookId);
                parameters.Add("@BookName", request.BookName);
                parameters.Add("@Author", request.Author);
                parameters.Add("@Year", request.Year);
                parameters.Add("@Count", request.Count);
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateBookResult>(cnn: connect,
                                                    sql: "sp_UpdateBook",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
