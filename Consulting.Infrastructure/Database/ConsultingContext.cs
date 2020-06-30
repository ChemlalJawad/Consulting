using Consulting.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Consulting.Infrastructure.Database
{
    public class ConsultingContext : DbContext
    {
        public ConsultingContext(DbContextOptions<ConsultingContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultant>()
              .HasKey(c => c.Id);
            
            modelBuilder.Entity<Mission>()
              .HasKey(m => m.Id);

            modelBuilder.Entity<ConsultantMission>()
                .HasKey(cm => new { cm.ConsultantId, cm.MissionId });

            modelBuilder.Entity<ConsultantMission>()
                .HasOne(cm => cm.Consultant)
                .WithMany(cm => cm.ConsultantMissions)
                .HasForeignKey(cm => cm.ConsultantId);

            modelBuilder.Entity<ConsultantMission>()
                .HasOne(cm => cm.Mission)
                .WithMany(cm => cm.ConsultantMissions)
                .HasForeignKey(cm => cm.MissionId);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
        }

        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<ConsultantMission> ConsultantMissions { get; set; }
    }
}
