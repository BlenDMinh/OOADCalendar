using SmartVaccine.model.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OOADAppointment.model.entity {
    public class Appointment {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Location {get; set;}
        public DateTime? Start {get; set;}
        public DateTime? End {get; set;}
        public string? Description {get; set;}
        [NotMapped]
        public List<Reminder>? Reminders {get; set;}

        public Appointment(string Name, string Location, DateTime Start, DateTime End, string Description, List<Reminder> Reminders) { 
            Id = AutoIncrement<Appointment>.GetCount();
            this.Name = Name;
            this.Location = Location;
            this.Start = Start;
            this.End = End;
            this.Description = Description;
            this.Reminders = Reminders;
        }

        public Appointment() { }
    }
}