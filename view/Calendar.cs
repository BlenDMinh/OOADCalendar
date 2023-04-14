using OOADAppointment.model;
using OOADAppointment.model.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADCalendar.view {
    public partial class Calendar : Form {

        private User user = Database.Instance.Users.First();
        private List<GroupMeeting> groupMeetings = Database.Instance.GroupMeetings.ToList();

        private DateTime _date = DateTime.Now;
        private Date? selected = null;
        public Calendar() {
            InitializeComponent();
            DrawCalendar();
            bAdd.Hide();
        }

        private void DrawCalendar() {
            flowLayoutPanel.Controls.Clear();
            date.Text = _date.Month.ToString("00") + "-" + _date.Year;
            DateTime firstDayOfMonth = new DateTime(_date.Year, _date.Month, 1);
            int dayOfWeek = ((int)firstDayOfMonth.DayOfWeek);
            for (int i = 0; i < dayOfWeek; i++)
                flowLayoutPanel.Controls.Add(new DateBlank());
            for (int i = 0; i < DateTime.DaysInMonth(_date.Year, _date.Month); i++) {
                Date ucDate = new Date(i + 1);
                ucDate.Click += (o, e) => {
                    selected?.setUnselected();
                    selected = ucDate;
                    selected.setSelected();
                    ucDate.BackColor = Color.White;
                    bAdd.Show();
                };
                flowLayoutPanel.Controls.Add(ucDate);
            }
        }

        // Next
        private void button1_Click(object sender, EventArgs e) {
            _date = _date.AddMonths(1);
            selected = null;
            bAdd.Hide();
            DrawCalendar();
        }

        // Previous
        private void button2_Click(object sender, EventArgs e) {
            _date = _date.AddMonths(-1);
            bAdd.Hide();
            selected = null;
            DrawCalendar();
        }

        private void bAdd_Click(object sender, EventArgs e) {
            if(selected == null) {
                MessageBox.Show("Please select a date");
                return;
            }
            AddAppointment add = new AddAppointment();
            add.setDate(new DateTime(_date.Year, _date.Month, selected.day));
            add.ShowDialog();
            if(add.DialogResult == DialogResult.OK) {
                Appointment newApp = add.Appointment;

                // Do proper conflict check next time
                if(user.Appointments != null && user.Appointments.Exists((e) => e.Name == newApp.Name && e.Location == newApp.Location && e.Start == newApp.Start && e.End == newApp.End)) {
                    DialogResult res = MessageBox.Show("This appointment is already exist! Do you want to override this appointment?", "Appointment conflict", MessageBoxButtons.YesNo);
                    if(res == DialogResult.Yes) {
                        // Override
                    }
                    return;
                }
                if(groupMeetings != null && groupMeetings.Exists((e) => e.Start == newApp.Start && e.End == newApp.End)) {
                    GroupMeeting? g = groupMeetings.Find((e) => e.Start == newApp.Start && e.End == newApp.End);
                    if (g == null)
                        return;
                    DialogResult res = MessageBox.Show("There is a group meeting '" + g.Name + "' at current timespan. Do you want to join instead?", "Group Meeting", MessageBoxButtons.YesNo);
                    if (res != DialogResult.Yes) {
                        if (g.Users == null)
                            g.Users = new List<User>();
                        g.Users?.Add(user);
                        Database.Instance.Update(g);
                        Database.Instance.SaveChanges();
                        return;
                    }
                }
                if(user.Appointments == null)
                    user.Appointments = new List<Appointment>();
                user.Appointments.Add(newApp);
                Database.Instance.Add(newApp);
                Database.Instance.Update(user);
                Database.Instance.SaveChanges();
            }
        }
    }
}
