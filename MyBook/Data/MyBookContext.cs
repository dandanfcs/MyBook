using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBook.Models;

namespace MyBook.Data
{
    public class MyBookContext : DbContext
    {
        public MyBookContext (DbContextOptions<MyBookContext> options)
            : base(options)
        {
        }

        public DbSet<MyBook.Models.Livro> Livro { get; set; }
    }
}
