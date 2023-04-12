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
        DateTime _date = DateTime.Now;
        public Calendar() {
            InitializeComponent();
            DrawCalendar();
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
                    MessageBox.Show("HEHE");
                };
                flowLayoutPanel.Controls.Add(ucDate);
            }
        }

        // Next
        private void button1_Click(object sender, EventArgs e) {
            _date = _date.AddMonths(1);
            DrawCalendar();
        }

        // Previous
        private void button2_Click(object sender, EventArgs e) {
            _date = _date.AddMonths(-1);
            DrawCalendar();
        }
    }
}
