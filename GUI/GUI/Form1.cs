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
    public partial class Form1 : Form
    {
        //Wat Wing Huen 21085591d
        [DllImport("Record_dll.dll")]
        public static extern int dosomething();
        [DllImport("Record_dll.dll")]
        public static extern void initalize();
        public Form1()
        {          
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (initialize.Checked) 
            {
                string a = "" + dosomething();
                initalize();
                MessageBox.Show("Initialization is completed", "Initalize", MessageBoxButtons.OK);
            }
            if (checkall.Checked)
            {
                StreamReader record = new StreamReader("Record.dat");
                string line = record.ReadLine();
                if(line == null) 
                {
                    MessageBox.Show("There is no Record found", "Error", MessageBoxButtons.OK);
                    record.Close();
                }
                else 
                {
                    record.Close();
                    Form2 Form2 = new Form2();
                    Form2.ShowDialog();
                }
            }
            if (LookoneRecord.Checked) 
            {
                Form3 Form3 = new Form3();
                Form3.ShowDialog();
            }
            if (delete.Checked) 
            {
                Form4 Form4 = new Form4();
                Form4.ShowDialog();
            }
            if (creat.Checked) 
            {
                Form51 Form51 = new Form51();
                Form51.ShowDialog();
            }
            if (Quit.Checked) 
            {
                this.Close();
            }
        }
    }
}
