using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Models.Entities
{
    public class Room : BaseEntity
    {
        public int Floor { get; set; }
        public double Area { get; set; }

        // Relational Properties
        public List<Shelf> Shelves { get; set; }    
    }
}
