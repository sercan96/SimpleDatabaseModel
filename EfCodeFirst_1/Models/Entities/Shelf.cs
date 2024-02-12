using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Models.Entities
{
    public class Shelf :BaseEntity
    {
        public string Location { get; set; }
        public string ShelfType { get; set; }
        public int Capacity { get; set; }

        // Relational Properties
        public Room Room { get; set; }
        public List<Book> Books { get; set; }
    }
}
