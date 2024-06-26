using SmartVaccine.model.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOADAppointment.model.entity
{
    public class User
    {
        public int Id {get; set;}
        public List<Appointment>? Appointments {get; set;}

        public User(List<Appointment>? appointments) {
            Id = AutoIncrement<User>.GetCount();
            Appointments = appointments;
        }

        public User() { }
    }
}