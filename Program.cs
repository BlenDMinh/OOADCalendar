using OOADAppointment.model;
using OOADCalendar.view;

namespace OOADCalendar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Calendar calendar = new Calendar();
            //calendar.ShowDialog();
            AddAppointment a = new AddAppointment();
            a.ShowDialog();
        }
    }
}