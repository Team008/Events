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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString(); //getting the selected name
            for (int i = 0; i < EventsData.Count; i++)
            {
                if (name = EventsData[i].EName) //matching Data
                {
                    EventsData.Remove(EventsData[i]); //Removing Data
                    comboBox1.Items.Remove(@comboBox1.SelectedValue.ToString()); //Removing the item form Combobox
                    break;
                } 
            }
        }
    }
}
