using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace my_first_coreMVC.Models
{
    public partial class EvryindiaContext : DbContext
    {
        public EvryindiaContext()
        {
        }

        public EvryindiaContext(DbContextOptions<EvryindiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Trainee> Trainees { get; set; } = null!;

       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
            //if (!optionsBuilder.IsConfigured)
            //{
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=ELW5205;Database=Evryindia;Trusted_Connection=True;");
            //}
       // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainee>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PK__Trainees__C456D7294C23E709");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.Tage).HasColumnName("TAge");

                entity.Property(e => e.Tname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
