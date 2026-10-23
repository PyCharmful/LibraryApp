using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryWinFormsApp.Data
{
    public class LibraryContext : DbContext
    {
        // Определение таблиц для каждой сущности.
        public DbSet<Book> Books { get; set; }
        public DbSet<Stuff> Stuff { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookExchange> BookExchange { get; set; }
        // Создание контекста базы данных
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=library.db");
    }

}
