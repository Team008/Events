using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Scheduler
{
    public partial class AddingEvent : Form
    {
        public AddingEvent()
        {
            InitializeComponent();
            // this timer show the current live time and date 
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // textbox will contain event name 
        private void textBox1_Click(object sender, EventArgs e)
        {
            // clear it when you click on it
            if (EventName.Text== "Enter Events' name")
            EventName.Text = "";
        }

        // textbox will contain event place
        private void textBox2_Click(object sender, EventArgs e)
        {
            // clear it when you click on it
            if (EventPlace.Text == "Enter Place The Event Will Be")
            {
                EventPlace.Text = "";
            } 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
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

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void EventName_Leave(object sender, EventArgs e)
        {

        }
        

        private void EventPlace_Leave(object sender, EventArgs e)
        { 
            
        }

        private void Start_Date_Leave(object sender, EventArgs e)
        {

        }

        private void EventPlace_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void S_T_Hours_TextChanged(object sender, EventArgs e)
        {


        }
     
    private void EventName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Start_Date_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void End_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Done_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        // submit button if ther is a missing data show an error provider next to the cell
        // else accept and submit the data to the file 
        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            // clear the errors every sumbitting and check for errors again
            errorProvider1.Clear();

            // check if it is no name and give error
            if ((EventName.Text == "") || (EventName.Text == "Enter Events' name"))
            {
                errorProvider1.SetError(this.EventName, "Please Enter Event's Name");
                EventName.Focus();
            }

            // check if it is no place and give error
            else if ((EventPlace.Text == "") || (EventPlace.Text == "Enter Place The Event Will Be"))
            {
                errorProvider1.SetError(this.EventPlace, "Please Enter Event's Place");
                EventPlace.Focus();
            }

            // check if it is no start date and give error
            else if (Start_Date.Value.ToString() == "")
            {
                errorProvider1.SetError(this.Start_Date, "Please Enter Start Day Date");
                Start_Date.Focus();
            }

            // check if it is no start time hours  and give error
            else if ((S_T_Hours.Text == "") || (S_T_Hours.Text == "HR"))
            {
                errorProvider1.SetError(this.S_T_Hours, "Please Start Day Time");
                S_T_Hours.Focus();
            }

            // check if it is no sart time minutes and give error
            else if ((S_T_Minutes.Text == "") || (S_T_Minutes.Text == "MN"))
            {
                errorProvider1.SetError(this.S_T_Minutes, "Please Start Day Time");
                S_T_Minutes.Focus();
            }

            // check if it is no choice of (am) or (pm) and give error
            else if (A_P_M.SelectedIndex==-1)
            {
                errorProvider1.SetError(this.A_P_M, "Please Choose am or pm");
                A_P_M.Focus();
            }

            // check if it is no end date and give error
            else if (End_Date.Value.ToString() == "")
            {
                errorProvider1.SetError(this.End_Date, "Please Enter End Day Date");
                End_Date.Focus();
            }

            // check if it is no choice of yes done and give error
            else if (yesDone.Checked==false)
            {
                errorProvider1.SetError(this.yesDone, "Please Check Yes Done To Sumbit The Event");
                noDone.Checked = false;
            }

            // if thers is no error submitting the data to file
            else
            {
                AddingE AE = new AddingE(); // object of adding event class
                // copy the data of event to the class members
                AE.EName = EventName.Text; 
                AE.EPlace = EventPlace.Text;
                AE.EStartDate = Start_Date.Value.ToShortDateString();
                AE.EStartTime = S_T_Hours.Text + ":" + S_T_Minutes.Text + " " + A_P_M.SelectedItem.ToString();
                AE.E_EndDate = End_Date.Value.ToShortDateString();

                // writing the data of event in file by member function 
                AE.Writing_in_file();
                // check if the event is today by member function
                AE.TodayTimeReminder();
             
            }

          
            
        }


        // make the user enter only hours from 0 to 12 in hours cell
        private void S_T_Hours_Leave(object sender, EventArgs e)
        {
            int a = int.Parse(S_T_Hours.Text);
            if ((a > 12) || (a< 0))
            {
                MessageBox.Show("Please Enter Valid Time!", "Error!");
                S_T_Hours.Text = "";
                S_T_Hours.Focus();
            }
        }

        // make the user enter only minutes from 0 to 59 in hours cell
        private void S_T_Minutes_Leave(object sender, EventArgs e)
        {
            int a = int.Parse(S_T_Minutes.Text);

            if ((a > 59) || (a < 0))
            {

                MessageBox.Show("Please Enter Valid Time!", "Error!");
                S_T_Minutes.Text = "";
                S_T_Minutes.Focus();
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

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

        private void yesDone_Click(object sender, EventArgs e)
        {

            noDone.Checked = false;
        }

        // clear buuton that clear all data to start a new form
        private void claering_Click(object sender, EventArgs e)
        {
           
           AddingEvent NewForm = new AddingEvent();
            NewForm.Show();
            this.Dispose(false);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        // a (new form) from menu strip that start a blank form with no data
        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingEvent NewForm = new AddingEvent();
            NewForm.Show();
            this.Dispose(false);
        }

        // an (Exit) from menu strip that make the application exit 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // an help from menu strip that show who we are
        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are ...", "About Us:");
        }
    }
}
