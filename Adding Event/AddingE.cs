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
        public string EName;
        public string EPlace;
        public string EStartDate;
        public string EStartTime;
        public string E_EndDate;


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
