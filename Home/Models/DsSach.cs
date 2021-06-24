using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Home.Models
{
    public partial class DsSach : DbContext
    {
        public DsSach()
            : base("name=DsSach")
        {
        }

        public virtual DbSet<Sach> Sach { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sach>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.Image)
                .IsUnicode(false);
        }
    }
}
