using OOADAppointment.model;
using OOADAppointment.model.entity;
using OOADCalendar.view;
using System.Diagnostics;

namespace OOADCalendar
{
    internal static class Program
    {
        private static void Init() {
            Database.Instance.Database.EnsureCreated();
            if (File.Exists("./Init"))
                return;
            GroupMeeting a = new GroupMeeting("OOAD",
                "BKDN",
                new DateTime(2023, 4, 13, 10, 0, 0),
                new DateTime(2023, 4, 13, 12, 0, 0),
                new List<User>()
            );
            GroupMeeting b = new GroupMeeting("Toan UD",
                "BKDN",
                new DateTime(2023, 4, 13, 14, 0, 0),
                new DateTime(2023, 4, 13, 17, 0, 0),
                new List<User>()
            );
            Debug.WriteLine(a.Id + " " + b.Id);
            Database.Instance.Add(a);
            Database.Instance.SaveChanges();
            Database.Instance.Add(b);
            Database.Instance.SaveChanges();
            User user = new User(new List<Appointment>());
            Database.Instance.Add(user);
            Database.Instance.SaveChanges();
            File.Create("./Init");
        }

        [STAThread]
        static void Main() {
            Init();
            ApplicationConfiguration.Initialize();
            Form f = new Calendar();
            f.ShowDialog();
        }
    }
}