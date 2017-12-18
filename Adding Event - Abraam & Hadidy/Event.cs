using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Scheduler
{
    class Event
    {
        // Adding Event Class data members
        public string EName; // contains  Event name
        public string EPlace; // contains the place where the event will be
        public string EStartDate; // contains the start date of Event
        public string EStartTime; // contains the start time of Event
        public string E_EndDate; // contains the end date of event
        public string E_ReminderTime;  // ontains te remainder date 
    }
    
}