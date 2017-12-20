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
    public partial class patientdisplay : Form
    {
        public patientdisplay()
        {
            InitializeComponent();
        }

        private void patientdisplay_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("patient.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
               patientclass h = new patientclass();
                DataTable tb = new DataTable();
                tb.Columns.Add("ID", typeof(int));
                tb.Columns.Add("Name", typeof(string));
                tb.Columns.Add("Disease", typeof(string));
                tb.Columns.Add("Doctor ID", typeof(int));
                tb.Columns.Add("Date", typeof(string));
                tb.Columns.Add("Time", typeof(string));
                string[] record, field;
                while (sr.Peek() != -1)
                {
                    record = sr.ReadLine().Split('#');
                    for (int i = 0; i < record.Length-1 ; i++)
                    {
                        field = record[i].Split('@' , ':');
                        h.iid = int.Parse(field[0]);
                        h.nam = field[1];
                        h.dis = field[2];
                        h.doctorid = int.Parse(field[3]);
                        h.appointmentdate = field[4];
                        h.hr = field[5];
                        h.mn = field[6];
                        h.tim = h.hr + ':' + h.mn;




                    }
                    tb.Rows.Add(h.iid, h.nam, h.dis,h.doctorid,h.appointmentdate,h.tim);

                    dataGridView1.DataSource = tb;



                }
                fs.Close();
                sr.Close();
            }
            catch
            { Console.WriteLine("error couldnt find file !"); }
        }
    }
}
