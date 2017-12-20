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
    class drclass
    {
        public string id;
        public string name;
        public string speciality;
        public int Id;
        public string nam;
        public string spec;
        

        
        public void Write()
        {

            bool toolong = true;

            FileStream fs = new FileStream("doctor.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string drinfo = id.ToString() + "*" + name + "*" + speciality + "#";
            if (drinfo.Length > 30)
            {
                Console.WriteLine("Input To Long Doctor please use short form , Thank You");
                toolong = false;
            }
            sw.WriteLine(drinfo);
            
            sw.Close();
            MessageBox.Show("Successful !!");

            
            Application.Exit();


        }
        public void display()
        {
          /*  try
            {
                FileStream fs = new FileStream("doctor.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                drclass h = new drclass();
                DataTable tb = new DataTable();
                tb.Columns.Add("ID", typeof(string));
                tb.Columns.Add("Name", typeof(string));
                tb.Columns.Add("Speciality", typeof(string));

                string[] record, field;
                while (sr.Peek() != -1)
                {
                    record = sr.ReadLine().Split('#');
                    for (int i = 0; i < record.Length - 2; i++)
                    {
                        field = record[i].Split('*');
                        string id = field[0];
                        string name = field[1];
                        string spec = field[2];
                        tb.Rows.Add(id, name, spec);
                    }
                   // dataGridView1.DataSource = tb;
                }
                sr.Close();
            }
            catch
            { Console.WriteLine("error couldnt find file !"); }
           */ 
        }
           
    }
}
