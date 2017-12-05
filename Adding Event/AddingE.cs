using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Scheduler
{
    class AddingE
    {
        // Adding Event Class data members
        public string EName; // contain  Event name
        public string EPlace; // contain the place where the event will be
        public string EStartDate; // contain the start date of Event
        public string EStartTime; // contain the start time of Event
        public string E_EndDate; // contain the end date of event

        // this function writing the event data in file
        public void Writing_in_file()
        {
            string filename = "Events";
            FileStream FS = new FileStream(filename, FileMode.Append);
            StreamWriter SR = new StreamWriter(FS);

            string writing = EName + "@" + EPlace + "@" + EStartDate + "@" + EStartTime + "@" + E_EndDate;
            SR.WriteLine(writing);
            SR.Close();
            MessageBox.Show("Successful Submitting", "Great Job");
        }

        // this function show message of name and time of event only if it is today
        public void TodayTimeReminder()
        {
            DateTime StartD =DateTime.Parse(EStartDate);
            TimeSpan IsToday = DateTime.Now.Date.Subtract(StartD);
            if (IsToday.ToString()=="00:00:00")
            {
                MessageBox.Show(EName + " at " + EStartTime, "Today Is :");
            }
        }

    }
}
