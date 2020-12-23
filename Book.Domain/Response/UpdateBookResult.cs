using System;
using System.Collections.Generic;
using System.Text;

namespace Book.Domain.Response
{
   public class UpdateBookResult
    {
        public int BookId { get; set; }

        public string Message { get; set; }
        public string Result { set; get; }
    }
}
