using Consulting.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consulting.Infrastructure.Database
{
    public static class DataLoading
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Consultant>().HasData(new Consultant()
            {
                Id = 1,
                Firstname = "Jawad",
                Lastname = "Chemlal",
                Experience = "Junior"
            },
            new
            {
                Id = 2,
                Firstname = "Xavier",
                Lastname = "Piekara",
                Experience = "Medior"
            },
            new
            {
                Id = 3,
                Firstname = "Loic",
                Lastname = "Ramelot",
                Experience = "Senior"
            });

            modelBuilder.Entity<Mission>().HasData(new Mission()
            {
                Id = 1,
                Name = "Google",
                MaximumRate = 500,
                ExperienceRequired = "Medior"
            },
            new
            {
                Id = 2,
                Name = "Amazon",
                MaximumRate = 700,
                ExperienceRequired = "Senior"
            },
            new
            {
                Id = 3,
                Name = "NRB",
                MaximumRate = 400,
                ExperienceRequired = "Junior"
            });

            modelBuilder.Entity<ConsultantMission>().HasData(new ConsultantMission()
            {
                ConsultantId = 1,
                MissionId = 3,
                isActive = true
            },
            new
            {
               ConsultantId = 2,
               MissionId = 1,
               isActive = true
            },
            new
            {
               ConsultantId = 2,
               MissionId = 3,
               isActive = false
            },
            new
            {
               ConsultantId = 3,
               MissionId = 2,
               isActive = true
            },
            new
            {
               ConsultantId = 3,
               MissionId = 3,
               isActive = false
            },
            new
            {
                ConsultantId = 3,
                MissionId = 1,
                isActive = false
            }
            );
            
        }
    }
}
