using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADCalendar.view
{
    public partial class Date : UserControl
    {
        public int day { get; set; }
        public Date(int day)
        {
            this.day = day;
            InitializeComponent();
            day_l.Text = day.ToString("00");
        }
        
        public void setSelected() {
            this.BackColor = Color.White;
            day_l.BackColor = Color.White;
        }

        public void setUnselected() {
            this.BackColor = Color.FromArgb(255, 171, 171);
            day_l.BackColor = Color.FromArgb(255, 171, 171);
        }
    }
}
