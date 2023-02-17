using EntityFramework_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_3.Contexts
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NiKO\\NIKO;Initial Catalog=LibraryDb1;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Press> Presses { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Lib> Libs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<S_Card> S_Cards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<T_Card> T_Cards { get; set; }
    }
}
