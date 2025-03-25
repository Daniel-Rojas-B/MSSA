using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment11_1.Data
{
    public class BookContext: DbContext // db 
    {
        public BookContext(DbContextOptions<BookContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; } // table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(b => b.ISBN);
            modelBuilder.Entity<Book>().HasData(GetBooks());
            base.OnModelCreating(modelBuilder); 
        }
        private Book[] GetBooks()
        {
            return new Book[]
            {
                new Book{ISBN=1010, Name="Crime and Punishment", AuthorName="Fyodor Dostoevsky", Description="Drama and Suspense"},
                new Book{ISBN=1111, Name="Moby-Dick", AuthorName="Herman Melville", Description="Obsession and revenge"},
                new Book{ISBN=2222, Name="Pride and Prejudice", AuthorName="Jane Austen", Description="Classic romance"},
                new Book{ISBN=3333, Name="The Great Gatsby", AuthorName="F. Scott Fitzgerald", Description="A critique of the American Dream"} 
            };
        }
        
    }
}
