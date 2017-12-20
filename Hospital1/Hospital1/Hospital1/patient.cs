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
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            
            patientclass dr = new patientclass();
          
            dr.id = txtid.Text;
            dr.name = txtname.Text;
            dr.disease = txtdiesase.Text;
            dr.doctor_id = txtdrid.Text;
            dr.appointment_date = txtdate.Text;
            dr.time = txthr.Text + ":" + txtmn.Text;
            dr.write();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void clid(object sender, EventArgs e)
        {
            txtid.Text = "";
        }

        private void clname(object sender, EventArgs e)
        {
            txtname.Text = "";
        }

        private void cldisease(object sender, EventArgs e)
        {
            txtdiesase.Text = "";
        }

        private void cldrid(object sender, EventArgs e)
        {
            txtdrid.Text = "";
        }

        private void clhr(object sender, EventArgs e)
        {
            txthr.Text = "";
        }

        private void clmn(object sender, EventArgs e)
        {
            txtmn.Text = "";
        }

        private void press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error!!! Please Enter Numbers Only");

            }

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientdisplay ds = new patientdisplay();
            ds.ShowDialog();

            Application.Exit();
        }

    }
}
