using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace E03_MVC_NET_Core_Person.Models
{
    public partial class E03Context : DbContext
    {
        public E03Context()
        {
        }

        public E03Context(DbContextOptions<E03Context> options) // Conection string
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; } = null!;

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // Alternativa: criar aqui as annotations com fluent API
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
