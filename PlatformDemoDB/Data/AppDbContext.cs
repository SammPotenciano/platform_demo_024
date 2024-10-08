using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PlatformDemoDB.Models;

namespace PlatformDemoDB.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<ServicePlan> ServicePlans { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.HasOne(d => d.ServicePlan).WithMany(p => p.Timesheets)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timesheet_ServicePlan");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}