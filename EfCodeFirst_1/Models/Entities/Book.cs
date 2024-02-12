using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Models.Entities
{
    public class Book : BaseEntity
    {
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }

        // Relational Properties
        public Shelf Shelf { get; set; }
        public Category Category { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
