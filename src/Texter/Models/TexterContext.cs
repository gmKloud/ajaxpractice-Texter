using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Texter.Models
{
    public class TexterContext : DbContext
    {
        public TexterContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Texter;integrated security=True");
        }

        public TexterContext(DbContextOptions<TexterContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}
