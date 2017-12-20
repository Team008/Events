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
    public partial class hospital2 : Form
    {
        public hospital2()
        {
            InitializeComponent();
        }
     
        private void drid_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void drname_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void drspeciality_TextChanged(object sender, EventArgs e)
        {

            
        }
        

        private void clickid(object sender, EventArgs e)
        {
            txtid.Text = "";
        }

        private void clickname(object sender, EventArgs e)
        {
            txtname.Text = "";
        }

        private void clickspec(object sender, EventArgs e)
        {
            txtspec.Text = "";
        }

        private void keypress_id(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error!!! Please Enter Numbers Only");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            drclass dr = new drclass();
            //FileStream fs = new FileStream("doctor.txt", FileMode.Append);
            //StreamWriter sw = new StreamWriter(fs);
            dr.id = txtid.Text.ToString();
            dr.name = txtname.Text;
            dr.speciality = txtspec.Text;
            dr.Write();

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            displaydrinfo ds = new displaydrinfo();
            ds.ShowDialog();
           
            Application.Exit();
        }

        


      
    }
}

