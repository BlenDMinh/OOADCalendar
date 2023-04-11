using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OOADAppointment.model.entity {
    public class Appointment {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Loaction {get; set;}
        public DateTime? Start {get; set;}
        public DateTime? End {get; set;}
        public string? Description {get; set;}
        [NotMapped]
        public List<Reminder>? Reminders {get; set;}
    }
}