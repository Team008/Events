using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Hospital1
{
    class patientclass
    {
        public string id;
        public string name;
        public string disease;
        public string doctor_id;
        public string appointment_date;
        public string time;
        public string info;
        //------------------------
        public int iid;
        public string nam;
        public string dis;
        public int doctorid;
        public string appointmentdate;
        public string hr;
        public string mn;
        public string tim;
       



        public void write()
        {
            FileStream fs = new FileStream("patient.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            info = id + "@" + name + "@" + disease + "@" + doctor_id + "@" + appointment_date + "@" + time + "@" + info + "#";
            sw.WriteLine(info);

            
            sw.Close();
        MessageBox.Show("Successful !!!");
            Application.Exit();
        }

    }
}
