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
        int day;
        public Date(int day)
        {
            this.day = day;
            InitializeComponent();
            day_l.Text = day.ToString("00");
        }
    }
}
