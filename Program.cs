using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

{
    class Event // Abraam's class
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
List<Event> EventsData = new List<Event>(); //The used list
for (int i = 0; i < EventsData.Count; i++)
            {
                comboBox1.Items.Add(EventsData[i].EName); //Adding Name to combobox
            }
}
