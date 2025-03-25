using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_1.Data
{
    public class Book
    {
        public int ISBN { get; set; } // primary key
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
    }
}
