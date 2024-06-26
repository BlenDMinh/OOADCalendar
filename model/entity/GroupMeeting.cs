using SmartVaccine.model.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OOADAppointment.model.entity {
    public class GroupMeeting {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Location {get; set;}
        public DateTime? Start {get; set;}
        public DateTime? End {get; set;}
        public List<User>? Users {get; set;}

        public GroupMeeting(string name, string? location, DateTime? start, DateTime? end, List<User>? users) {
            Id = AutoIncrement<GroupMeeting>.GetCount();
            Name = name;
            Location = location;
            Start = start;
            End = end;
            Users = users;
        }

        public GroupMeeting() { }
    }
}