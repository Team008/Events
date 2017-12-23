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

namespace Events_Scheduler
{
    public partial class AddingEvent : Form
    {
        List<Event> EventsData=new List<Event>(); // Vector contains the coming events

        List<Event> DoneEvents = new List<Event>(); // Vector contains the done events

        string Dones = "Done Events.txt"; // Done Events file name
        string FileName = "Coming Events.txt"; // coming Events file name

        private bool mouseDown;
        private Point lastLocation;
        public AddingEvent()
        {  
            InitializeComponent();
            // this timer show the current live time and date 
            timer1.Start();
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            // read coming events from the file and store it in the vector
            try
            {
                // First store the data 
                FileStream FS;
                FS = new FileStream(FileName, FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                while (SR.Peek() != -1)
                {
                    string Line = SR.ReadLine();
                    string[] data = Line.Split('@');
                    Event RE = new Event();
                    RE.EName = data[0];
                    RE.EPlace = data[1];
                    RE.EStartDate = data[2];
                    RE.EStartTime = data[3];
                    RE.E_EndDate = data[4];
                    RE.E_ReminderTime = data[5];
                    EventsData.Add(RE);
                }
                SR.Close();


                // clear the file data 
                FS = new FileStream(FileName, FileMode.Truncate);
                FS.Close();

            }
            catch { };

            // read done events from the file and store it in the vector
            try
            {
               
                FileStream FS;
                FS = new FileStream(Dones, FileMode.Open);
                StreamReader SR = new StreamReader(FS);
                while (SR.Peek() != -1)
                {
                    string Line = SR.ReadLine();
                    string[] data = Line.Split('@');
                    Event RE = new Event();
                    RE.EName = data[0];
                    RE.EPlace = data[1];
                    RE.EStartDate = data[2];
                    RE.EStartTime = data[3];
                    RE.E_EndDate = data[4];
                    RE.E_ReminderTime = data[5];
                    DoneEvents.Add(RE);
                }
                SR.Close();


                // clear the file data 
                FS = new FileStream(Dones, FileMode.Truncate);
                FS.Close();

            }
            catch { };

            // check if an event was yesterday delete it from the coming events and adding it to the done events vector
            for (int i = 0; i < EventsData.Count; i++)
            {
                DateTime myDate = DateTime.Parse(EventsData[i].E_EndDate);
                if (myDate == DateTime.Today.AddDays(-1))
                {
                    DoneEvents.Add(EventsData[i]);
                    EventsData.Remove(EventsData[i]);
                }
            }



           

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
            Start_Date.Value = DateTime.Today;
            End_Date.Value = DateTime.Today;
            ReminderTimePicker.Value = DateTime.Today;
            // check if there is an event reminder and display a message
            for (int i = 0; i < EventsData.Count; i++)
            {
                DateTime Reminder = DateTime.Parse(EventsData[i].E_ReminderTime);
                TimeSpan IsToday = DateTime.Now.Date.Subtract(Reminder);
                if (IsToday.ToString() == "00:00:00")
                {
                    MessageBox.Show("There is:\n" + EventsData[i].EName + "\n At " + EventsData[i].EStartTime + " " + EventsData[i].EStartDate, "Remember!");
                }
            }
        }
     
        // textbox will contain event name 
        private void textBox1_Click(object sender, EventArgs e)
        {
            // clear it when you click on it
            if (EventName.Text== "Event's Name")
            EventName.Text = "";
        }

        // textbox will contain event place
        private void textBox2_Click(object sender, EventArgs e)
        {
            // clear it when you click on it
            if (EventPlace.Text == "Event's Location")
            {
                EventPlace.Text = "";
            } 
        }


        // make the textbox of hours accept numbers only
        // else show an error message
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error!");
            }

           
        }

       

        // make the textbox of minutes accept numbers only
        // else show an error message
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error!");

            }

        }

        // clear the text box of hours when click on it
        private void textBox3_Click(object sender, EventArgs e)
        {
            if(S_T_Hours.Text=="HR")
            S_T_Hours.Text = "";
        }

        // clear the text box of minutes when click on it
        private void textBox4_Click(object sender, EventArgs e)
        {
            if(S_T_Minutes.Text=="MN")
            S_T_Minutes.Text = "";
        }

        
        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        // show the current live time
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Time_Now.Text = dateTime.ToString();
        }
        
        // make the user enter only minutes from 0 to 59 in hours cell
       
        // if you check yes done radio button make the no done radio button unchecked
        private void yesDone_CheckedChanged(object sender, EventArgs e)
        {
            if (yesDone.Checked == true)
            {
                noDone.Checked = false;
            }
        }

        // if you check no done radio button make the yes done radio button unchecked
        private void noDonoe_CheckedChanged(object sender, EventArgs e)
        {
            if (noDone.Checked == true)
            {
             yesDone.Checked=false   ;
            }
        }

    

        private void txtremdate_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void pictureBox8_Click(object sender, EventArgs e)
        {

            EventName.Text = "Event's Name";
            EventName.Focus();
            EventName.SelectAll();
            EventPlace.Text = "Event's Location";
            Start_Date.Value = DateTime.Today;
            S_T_Hours.Text = "HR";
            S_T_Minutes.Text = "MN";
            A_P_M.SelectedIndex = -1;
            A_P_M.Text = "AM/PM";
           
            End_Date.Value = DateTime.Today;
            ReminderTimePicker.Value = DateTime.Today;
            yesDone.Checked = false;
            noDone.Checked = false;
        }

        // submit button if there is a missing data or an error show an error provider next to the cell
        // else accept and submit the data to the file
        

           

        // storing data in files while form closing
        private void AddingEvent_FormClosing(object sender, FormClosingEventArgs e)
        {

            // storing coming events in file
            if (EventsData.Count != 0)
            {
                FileStream FS = new FileStream(FileName, FileMode.Append);
                StreamWriter SW = new StreamWriter(FS);

                for (int i = 0; i < EventsData.Count; i++)
                {
                    string writing = EventsData[i].EName + "@" + EventsData[i].EPlace + "@"
                        + EventsData[i].EStartDate + "@" + EventsData[i].EStartTime
                        + "@" + EventsData[i].E_EndDate + "@" + EventsData[i].E_ReminderTime;

                    SW.WriteLine(writing);

                }

                SW.Close();
                FS.Close();
            }

            // Storing done events in file
            if(DoneEvents.Count !=0)
            {
                FileStream FS = new FileStream(Dones, FileMode.Append);
                StreamWriter SW = new StreamWriter(FS);

                for(int i=0;i<DoneEvents.Count;i++)
                {
                    string writing = DoneEvents[i].EName + "@" + DoneEvents[i].EPlace + "@"
                        + DoneEvents[i].EStartDate + "@" + DoneEvents[i].EStartTime
                        + "@" + DoneEvents[i].E_EndDate + "@" + DoneEvents[i].E_ReminderTime;

                    SW.WriteLine(writing);
                }

                SW.Close();
                FS.Close();
            }
        }

        // check if the reminder after start date show error message
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            // clear the errors every sumbitting and check for errors again
          
            errorProvider1.Clear();

            // check if it is no name and give error

            if ((EventName.Text == "") || (EventName.Text == "Event's Name"))
            {
                errorProvider1.SetError(EventName, "Please Enter Event's Name");
                EventName.Focus();
            }

            // check if it is no place and give error
            else if ((EventPlace.Text == "") || (EventPlace.Text == "Event's Location"))
            {
                errorProvider1.SetError(this.EventPlace, "Please Enter Event's Place");
                EventPlace.Focus();
            }

            // check if it is no start date and give error
            else if (this.Start_Date.Value.ToString()=="")
            {
                errorProvider1.SetError(this.Start_Date, "Please Enter Start Day Date");
                Start_Date.Focus();
            }

            else if (Start_Date.Value < DateTime.Today.AddDays(1))
            {
                errorProvider1.SetError(this.Start_Date, "The Evnet Must Be At Least Tomorrow");
                Start_Date.Value = DateTime.Today.AddDays(1);
            }

            // check if it is no start time hours  and give error
            else if ((S_T_Hours.Text == "") || (S_T_Hours.Text == "HR"))
            {
                errorProvider1.SetError(this.S_T_Hours, "Please Start Day Time");
                S_T_Hours.Focus();
            }


            else if ((int.Parse(S_T_Hours.Text) > 12) || (int.Parse(S_T_Hours.Text) < 0))
            {
                errorProvider1.SetError(this.S_T_Hours, "Please Enter Valid Hour (0->12) ");
                S_T_Hours.Text = "";
                S_T_Hours.Focus();
            }

            else if (S_T_Hours.Text.Length == 1)
            {
                int a = int.Parse(S_T_Hours.Text);
                S_T_Hours.Text = "0" + S_T_Hours.Text;
            }
           
            // check if it is no sart time minutes and give error
            else if ((S_T_Minutes.Text == "") || (S_T_Minutes.Text == "MN"))
            {
                errorProvider1.SetError(S_T_Minutes, "Please Enter Start Day Time");
                S_T_Minutes.Focus();
            }

            else if ((int.Parse(S_T_Minutes.Text) > 59) || (int.Parse(S_T_Minutes.Text) < 0))
            {
                errorProvider1.SetError(this.S_T_Minutes, "Please Enter Valid Minute (0 -> 59)");
                S_T_Minutes.Text = "";
                S_T_Minutes.Focus();
            }

            // check if it is no choice of (am) or (pm) and give error
            else if (A_P_M.SelectedIndex == -1)
            {
                errorProvider1.SetError(this.A_P_M, "Please Choose am or pm");
                A_P_M.Focus();
            }

            else if ((int.Parse(S_T_Hours.Text) == 12) && (A_P_M.SelectedIndex == 0))
            {
                S_T_Hours.Text = "00";
            }

            // check if it is no end date and give error
            else if (End_Date.Value.ToString() == "")
            {
                errorProvider1.SetError(this.End_Date, "Please Enter End Day Date");
                End_Date.Focus();
            }
            else if (End_Date.Value < Start_Date.Value)
            {
                errorProvider1.SetError(this.End_Date, "The End Date must not be before Start Date");
                errorProvider1.SetError(this.Start_Date, "The Start Date must not be After End Date");
                Start_Date.Focus();
                End_Date.Focus();
            }

            // check if is no reminder time and give error
            else if (ReminderTimePicker.Value.ToString() == "")
            {
                errorProvider1.SetError(this.ReminderTimePicker, "Please Enter The Reminder Time ");
                ReminderTimePicker.Focus();
            }
            
            else if(ReminderTimePicker.Value<DateTime.Today)
            {
                errorProvider1.SetError(this.ReminderTimePicker, "Please Enter A Valid Reminder Time");
                ReminderTimePicker.Focus();
            }

            else if (ReminderTimePicker.Value >= Start_Date.Value)
            {
                errorProvider1.SetError(this.ReminderTimePicker,"The Reminder must not Be After Or Equal Start Date");
                ReminderTimePicker.Focus();
            }

            // check if it is no choice of yes done and give error
            else if (yesDone.Checked == false)
            {
                errorProvider1.SetError(this.yesDone, "Please Check Yes Done To Sumbit The Event");
                noDone.Checked = false;
            }



            // if thers is no error submitting the data to file
            else
            {
                // check if there is intersection with another event
                bool Intersects = false;

                for (int i = 0; i < EventsData.Count; i++)
                {
                    DateTime DataStartD = Convert.ToDateTime(EventsData[i].EStartDate);
                    DateTime DataEndD = Convert.ToDateTime(EventsData[i].E_EndDate);

                    if ((Start_Date.Value == DataStartD) || (End_Date.Value == DataEndD))
                    {
                        Intersects = true;
                        break;
                    }
                    else if ((End_Date.Value == DataStartD) || (Start_Date.Value == DataEndD))
                    {
                        Intersects = true;
                        break;
                    }
                    else if ((Start_Date.Value > DataStartD) && (End_Date.Value < DataEndD))
                    {
                        Intersects = true;
                        break;
                    }
                    else if ((Start_Date.Value < DataStartD) && (End_Date.Value > DataEndD))
                    {
                        Intersects = true;
                        break;
                    }
                    else if ((Start_Date.Value < DataStartD) && (End_Date.Value > DataStartD))
                    {
                        Intersects = true;
                        break;
                    }
                    else if ((Start_Date.Value < DataEndD) && (End_Date.Value > DataEndD))
                    {
                        Intersects = true;
                        break;
                    }



                }



                // if no intersection sumbit
                if (Intersects == false)
                {
                    Event AddingEvent = new Event(); // object of adding event class
                                                     // copy the data of event to the class members

                    AddingEvent.EName = EventName.Text;
                    AddingEvent.EPlace = EventPlace.Text;
                    AddingEvent.EStartDate = Start_Date.Value.ToShortDateString();
                    AddingEvent.EStartTime = S_T_Hours.Text + ":" + S_T_Minutes.Text + " " + A_P_M.SelectedItem.ToString();
                    AddingEvent.E_EndDate = End_Date.Value.ToShortDateString();
                    AddingEvent.E_ReminderTime = ReminderTimePicker.Value.ToShortDateString();

                    // Adding the class event in the vector
                    EventsData.Add(AddingEvent);
                    MessageBox.Show("Successful Submitting", "Great Job");
                   
                }

                // if there is intersection sow messagebox
                else if (Intersects == true)
                {
                    MessageBox.Show("The Event Intersects with another Event\nYou must change The Dates", "Error!");
                }

            }
    }

      
       

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
