using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OOADAppointment.model.entity;

namespace OOADAppointment.model {
    public class Database : DbContext {
        public DbSet<Appointment>? Appointments {get; set;}
        public DbSet<GroupMeeting>? GroupMeetings {get; set;}
        public string DbPath {get;} = "./database.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}