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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            int check= 0;

            string n2;
            string e2;
            string p2;
            if (byname.Checked) // search by name
            {
                if(showname.Text==null) 
                {
                    label1.Text = "No Match!";
                    showemail.Text = "";
                    showpno.Text = "";
                }
                else 
                {
                    StreamReader Record = new StreamReader("Record.dat");
                    n2= Record.ReadLine();
                    if (n2 == showname.Text)
                    {
                        showemail.Text = Record.ReadLine();
                        showpno.Text = Record.ReadLine();
                        check = 1;
                    }
                    else 
                    {
                        for (; showname.Text != n2 && n2!=null;)
                        {
                            n2 = Record.ReadLine();
                            n2 = Record.ReadLine();
                            n2 = Record.ReadLine();
                        }
                    }
                    if (check == 0) 
                    {
                        if (showname.Text == n2)
                        {
                            showemail.Text = Record.ReadLine();
                            showpno.Text = Record.ReadLine();
                            check = 1;
                        }
                    }
                    if (check == 1) 
                    {
                        label1.Text = "Match Found!";
                        Record.Close();
                    }
                    else 
                    {
                        label1.Text = "No Match!";
                        showemail.Text = "";
                        showpno.Text = "";
                        Record.Close();
                    }
                    Record.Close();
                }
            }

            if (byemail.Checked) // search by email
            {
                if (showemail.Text==null)
                {
                    label1.Text = "No Match!";
                    showname.Text = "";
                    showpno.Text = "";
                }
                else 
                {
                    StreamReader Record = new StreamReader("Record.dat");
                    n2 = Record.ReadLine();
                    e2 = Record.ReadLine();
                    if (e2 == showemail.Text)
                    {
                        showname.Text = n2;
                        showpno.Text = Record.ReadLine();
                        check = 1;
                    }
                    else
                    {
                        for (; showemail.Text != e2 && e2!=null;)
                        {
                            n2 = e2;
                            e2 = Record.ReadLine();
                            n2 = e2;
                            e2 = Record.ReadLine();
                            n2 = e2;
                            e2 = Record.ReadLine();
                        }
                    }
                    if (check == 0)
                    {
                        if (showemail.Text == e2)
                        {
                            showname.Text = n2;
                            showpno.Text = Record.ReadLine();
                            check = 1;
                        }
                    }
                    if (check == 1)
                    {
                        label1.Text = "Match Found!";
                        Record.Close();
                    }
                    else
                    {
                        label1.Text = "No Match!";
                        showname.Text = "";
                        showpno.Text = "";
                        Record.Close();
                    }
                    Record.Close();
                }
            }

            if (bypno.Checked) //by phone number
            {
                if (showpno.Text==null)
                {
                    label1.Text = "No Match!";
                    showname.Text = "";
                    showpno.Text = "";

                }
                else 
                {
                    StreamReader Record = new StreamReader("Record.dat");
                    n2 = Record.ReadLine();
                    e2 = Record.ReadLine();
                    p2 = Record.ReadLine();
                    if (p2 == showpno.Text)
                    {
                        showname.Text = n2;
                        showemail.Text = e2;
                        showpno.Text = p2;
                        check = 1;
                    }
                    else
                    {
                        for (; showpno.Text != p2 && p2 != null;)
                        {
                            p2 = Record.ReadLine();
                            n2 = p2;
                            p2 = Record.ReadLine();
                            e2 = p2;
                            p2 = Record.ReadLine();
                        }
                    }
                    if (check == 0)
                    {
                        if (showpno.Text == p2)
                        {
                            showname.Text = n2;
                            showemail.Text = e2;
                            showpno.Text = p2;
                            check = 1;
                        }
                    }
                    if (check == 1)
                    {
                        label1.Text = "Match Found!";
                        Record.Close();
                    }
                    else
                    {
                        label1.Text = "No Match!";
                        showname.Text = "";
                        showemail.Text = "";
                        Record.Close();
                    }
                    Record.Close();
                }
            }
        }
    }
}
