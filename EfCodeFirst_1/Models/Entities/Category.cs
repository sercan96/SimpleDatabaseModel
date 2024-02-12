using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Models.Entities
{
    public class Category : BaseEntity
    {
        public string Description { get; set; }

        // Relational Properties
        public List<Book> Books { get; set; }
    }
}
