using System;
using System.Data;
using System.Data.SqlClient;

namespace Book.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connect;
        public BaseRepository()
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-V2NNT7G;Initial Catalog=BookManager;Integrated Security=True");
        }
    }
}
