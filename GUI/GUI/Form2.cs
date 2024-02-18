using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;

namespace GUI
{

    public partial class Form2 : Form
    {
        int p = 1;//page
        [DllImport("Record_dll.dll")]
        public static extern int countrecord();
        public Form2()
        {
            InitializeComponent();
            StreamReader Record = new StreamReader("Record.dat");
            name.Text = Record.ReadLine();
            email.Text = Record.ReadLine();
            pno.Text = Record.ReadLine();
            string count = "" + countrecord();
            label4.Text = "(Record " + p + " of " + countrecord() + ")";
            Record.Close();
        }



        private void Next_Click(object sender, EventArgs e)
        {
            int i = 0;
 
            if (p < countrecord())
            {
                p++;
                StreamReader Record = new StreamReader("Record.dat");
                while(pno.Text != Record.ReadLine() ) 
                {
                    i++;
                }
                name.Text = Record.ReadLine();
                email.Text = Record.ReadLine();
                pno.Text = Record.ReadLine();
                string count = "" + countrecord();
                label4.Text = "(Record " + p + " of " + countrecord() + ")";
                Record.Close();
            }
            else 
            {
                MessageBox.Show("This is the last Record", "Error", MessageBoxButtons.OK);
            }
            
        }        
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            string Lname = "";
            string Lemail = "";
            string Lpno = "";
            string n = "";
            if (p > 1)
            {
                p--;
                StreamReader Record = new StreamReader("Record.dat");
                n = Record.ReadLine();
                while (n != name.Text)
                {
                    Lname = n;
                    Lemail = Record.ReadLine();
                    Lpno = Record.ReadLine();
                    n=Record.ReadLine();
                }
                name.Text = Lname;
                email.Text = Lemail;
                pno.Text = Lpno;
                string count = "" + countrecord();
                label4.Text = "(Record " + p + " of " + countrecord() + ")";
                Record.Close();
            }
            else
            {
                MessageBox.Show("There is no more previous Record", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
