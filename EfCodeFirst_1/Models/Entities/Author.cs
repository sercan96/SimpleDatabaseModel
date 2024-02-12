using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Models.Entities
{
    public class Author : BaseEntity 
    {
        public string Surname { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }

        // Relational Properties
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
