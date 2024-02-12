using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Models.Entities
{
    // CrossTable
    public class BookAuthor : BaseEntity 
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }   

        // Relational Properties

        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }  
    }
}
