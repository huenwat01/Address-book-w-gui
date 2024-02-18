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
    public partial class Form52 : Form
    {
        [DllImport("Record_dll.dll")]
        public static extern int checkname(string dname);
        [DllImport("Record_dll.dll")]
        public static extern int checkemail(string demail);
        [DllImport("Record_dll.dll")]
        public static extern void writedata(string record);

        int page = 1;
        string[] na = { "", "", "", "", "", "", "", "", "", "", "" };
        string[] em = { "", "", "", "", "", "", "", "", "", "", "" };
        string[] pno = { "", "", "", "", "", "", "", "", "", "", "" };
        int[] pass = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double pno2 = 0;
        int pno22 = 0;
        double c2 = 0;


        public Form52()
        {
 
            InitializeComponent();
            label2.Text = "( Record " + page + " of " + Form51.no3 + " )";
            for(int i = 0; i < 11; i++) 
            {
                //pass[i] = 0;
            }
            inname.Text = "";
            inemail.Text = "";
            inpno.Text = "";
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (page > Form51.no3)            
            {
                label2.Text = "( Record " + Form51.no3 + " of " + Form51.no3 + " )";
                MessageBox.Show("There is no more record", "Error", MessageBoxButtons.OK);              
            }
            if (inname.Text==null || inemail.Text==null || inpno.Text==null  ) 
            {
                check = 1;
            }
            if (checkname(inname.Text) == 1) 
            {
                check = 1;
            }
            if (checkemail(inemail.Text) == 1)
            {
                check = 1;
            }
            if (double.TryParse(inpno.Text, out pno2))
            {
                c2 = pno2 % 1;
                if (c2 != 0) 
                {
                    check = 1;
                }
                
            }
            int.TryParse(inpno.Text, out pno22);
            //pno22 = Int32.Parse(inpno.Text);
            if (pno22<=9999999 || pno22 > 99999999) 
            {
                check = 1;
            }
            
            if (check == 0 && pass[page]==0 && page<=Form51.no3 ) 
            {
                na[page] = inname.Text;
                em[page] = inemail.Text;
                pno[page] = inpno.Text;
                writedata(inname.Text);
                writedata(inemail.Text);
                writedata(inpno.Text);
                pass[page] = 1;
                page++;
                inname.Text = "";
                inemail.Text = "";
                inpno.Text = "";
                /*if (pass[page] == 1) 
                {                
                    inname.Text = na[page];
                    inemail.Text = em[page];
                    inpno.Text = pno[page];
                }
                else 
                {
                    inname.Text = "";
                    inemail.Text = "";
                    inpno.Text = "";
                }*/
                label2.Text = "( Record " + page + " of " + Form51.no3 + " )";

            }
            if(check==1 && pass[page]==0 && page<= Form51.no3)
            {
                MessageBox.Show("Please Follow the format: name:[a-Z]or[0-9], email:x@x, phone number: 10000000-99999999", "Error", MessageBoxButtons.OK);
            }
            if (pass[page] == 1) 
            {
                page++;
                inname.Text = na[page];
                inemail.Text = em[page];
                inpno.Text = pno[page];
                label2.Text = "( Record " + page + " of " + Form51.no3 + " )";
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (page > 1) 
            {
                page--;
                inname.Text = na[page];
                inemail.Text = em[page];
                inpno.Text = pno[page];
                label2.Text = "( Record " + page + " of " + Form51.no3 + " )";
            }
            else 
            {
                MessageBox.Show("This is the last record", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
