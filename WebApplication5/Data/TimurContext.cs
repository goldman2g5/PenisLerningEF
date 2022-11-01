using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication5.Models;

namespace WebApplication5.Data
{
    public partial class TimurContext : DbContext
    {
        public TimurContext()
        {
        }

        public TimurContext(DbContextOptions<TimurContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emploee> Emploees { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emploee>(entity =>
            {
                entity.Property(e => e.EmployeeEMail).HasDefaultValueSql("('@.')");

                entity.Property(e => e.IdEmployee).ValueGeneratedOnAdd();

                entity.Property(e => e.MiddleName).HasDefaultValueSql("('-')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
