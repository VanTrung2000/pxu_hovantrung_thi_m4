using System;
using System.Collections.Generic;
using System.Text;

namespace Book.Domain.Response
{
   public class Books
    {
        public int BookId { set; get; }
        public string BookName { set; get; }
        public string Author { set; get; }
        public int Year { set; get; }
        public int Count { set; get; }
        public string CategoryId { set; get; }
    }
}
