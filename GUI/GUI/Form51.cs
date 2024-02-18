using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form51 : Form
    {
        public static int no3;
        public Form51()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            double no = 0;
            int no2 = 0;
            double store = 0;
            double check = 0;
            if(double.TryParse(textBox1.Text,out no)) 
            {
                store = no * 10;
                check = store % 10;
                if(no > 0 && no < 11 && check==0) 
                {
                    int.TryParse(textBox1.Text, out no3);
                    Form52 Form52 = new Form52();
                    Form52.ShowDialog();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Please input a integer between 1 and 10", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please input a integer between 1 and 10", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
