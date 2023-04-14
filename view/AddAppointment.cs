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
    public partial class AddAppointment : Form {
        private DateTime date;

        public AddAppointment() {
            InitializeComponent();
        }

        public void setDate(DateTime date) {
            this.date = date;
        }

        private void bCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public Appointment Appointment { get; set; }

        private void bAdd_Click(object sender, EventArgs e) {
            try {
                DateTime start = new DateTime(date.Year, date.Month, date.Day, int.Parse(startTime_h.Text), int.Parse(startTime_m.Text), 0);
                DateTime end = new DateTime(date.Year, date.Month, date.Day, int.Parse(endTime_h.Text), int.Parse(endTime_m.Text), 0);
                List<Reminder> reminders = new List<Reminder>();
                if (b15minutes.Checked)
                    reminders.Add(Reminder.BEFORE_15_MINUTES);
                if (b1hour.Checked)
                    reminders.Add(Reminder.BEFORE_AN_HOUR);
                if (b1day.Checked) 
                    reminders.Add(Reminder.BEFORE_A_DAY);
                Appointment = new Appointment(name.Text, location.Text, start, end, "", reminders);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch(Exception ex) {
                MessageBox.Show("Input format is not correct");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
