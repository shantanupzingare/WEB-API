using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityCRUD.Models;
namespace EntityCRUD.Repository
{
    internal class SampleContext:DbContext//Intelligent class because derived form dbcontext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Demo;Integrated Security=True;");
        }
        public DbSet<Book>Books { get; set; }
        public DbSet<Author> Author {  get; set; }

    }
}
