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
    public partial class displaydrinfo : Form
    {
        public displaydrinfo()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displaydrinfo_Load(object sender, EventArgs e)
        {
                    try
   {
       FileStream fs = new FileStream("doctor.txt", FileMode.Open , FileAccess.Read);
       StreamReader sr = new StreamReader(fs);
       drclass h = new drclass();
       DataTable tb = new DataTable();
       tb.Columns.Add("ID", typeof(int));
       tb.Columns.Add("Name", typeof(string));
       tb.Columns.Add("Speciality", typeof(string));

       string[] record, field;
       while (sr.Peek() != -1)
       {
           record = sr.ReadLine().Split('#');
           for (int i = 0; i < record.Length -1 ; i++)
           {
               field = record[i].Split('*');
               h.Id = int.Parse(field[0]);
               h.nam = field[1];
                h.spec = field[2];

                
               
           }
           tb.Rows.Add(h.Id, h.nam, h.spec);
               
           dataGridView1.DataSource = tb;
           
          
          
       }
       sr.Close();
   }
   catch
   { Console.WriteLine("error couldnt find file !"); }
        }
        

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        { /*
            drclass h = new drclass();
            DataTable tb = new DataTable();
            FileStream fs = new FileStream("doctor.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            tb.Columns.Add("ID", typeof(string));
            tb.Columns.Add("Name", typeof(string));
            tb.Columns.Add("Speciality", typeof(string));

            while (sr.Peek() != -1)
            {
                tb.Rows.Add(h.id, h.name, h.speciality);
                

            }
            dataGridView1.DataSource = tb;
            sr.Close();*/


        }
    }
}