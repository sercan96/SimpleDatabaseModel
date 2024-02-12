using EfCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Models.ContextClasses
{
    public class LibraryDbContext :DbContext
    {
        public LibraryDbContext():base("MyConnection")
        { }
        public DbSet<Shelf> Shelfs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Book> Books { get; set; }  
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
