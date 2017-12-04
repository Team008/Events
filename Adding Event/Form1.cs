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
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (EventName.Text== "Enter Events' name")
            EventName.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error!");

            }

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if(S_T_Hours.Text=="HR")
            S_T_Hours.Text = "";
        }

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
            MessageBox.Show("Please Enter Place", "Error");
            
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

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if ((EventName.Text == "") || (EventName.Text == "Enter Events' name"))
            {
                errorProvider1.SetError(this.EventName, "Please Enter Event's Name");
                EventName.Focus();
            }

            else if ((EventPlace.Text == "") || (EventPlace.Text == "Enter Place The Event Will Be"))
            {
                errorProvider1.SetError(this.EventPlace, "Please Enter Event's Place");
                EventPlace.Focus();
            }

            else if (Start_Date.Value.ToString() == "")
            {
                errorProvider1.SetError(this.Start_Date, "Please Enter Start Day Date");
                Start_Date.Focus();
            }

            else if ((S_T_Hours.Text == "") || (S_T_Hours.Text == "HR"))
            {
                errorProvider1.SetError(this.S_T_Hours, "Please Start Day Time");
                S_T_Hours.Focus();
            }

            else if ((S_T_Minutes.Text == "") || (S_T_Minutes.Text == "MN"))
            {
                errorProvider1.SetError(this.S_T_Minutes, "Please Start Day Time");
                S_T_Minutes.Focus();
            }

            else if (A_P_M.SelectedIndex==-1)
            {
                errorProvider1.SetError(this.A_P_M, "Please Choose am or pm");
                A_P_M.Focus();
            }

            else if (End_Date.Value.ToString() == "")
            {
                errorProvider1.SetError(this.End_Date, "Please Enter End Day Date");
                End_Date.Focus();
            }

            else if (yesDone.Checked==false)
            {
                errorProvider1.SetError(this.yesDone, "Please Check Yes Done To Sumbit The Event");
                noDone.Checked = false;
            }

            else
            {
                AddingE AE = new AddingE();
                AE.EName = EventName.Text;
                AE.EPlace = EventPlace.Text;
                AE.EStartDate = Start_Date.Value.ToShortDateString();
                AE.EStartTime = S_T_Hours.Text + ":" + S_T_Minutes.Text + " " + A_P_M.SelectedItem.ToString();
                AE.E_EndDate = End_Date.Value.ToShortDateString();
                AE.Writing_in_file();
                AE.TodayTimeReminder();
             
            }

          
            
        }

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

        private void yesDone_CheckedChanged(object sender, EventArgs e)
        {
            if (yesDone.Checked == true)
            {
                noDone.Checked = false;
            }
        }

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

        private void claering_Click(object sender, EventArgs e)
        {
           
           AddingEvent NewForm = new AddingEvent();
            NewForm.Show();
            this.Dispose(false);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingEvent NewForm = new AddingEvent();
            NewForm.Show();
            this.Dispose(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are ...", "About Us:");
        }
    }
}
