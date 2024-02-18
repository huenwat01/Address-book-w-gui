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
    public partial class Form4 : Form
    {
        [DllImport("Record_dll.dll")]
        public static extern void deleterecord(string dname);
        public Form4()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int check2 = 0;

            string n3;
            string e3;
            string p3;
            if (byname2.Checked) // search by name
            {
                if (showname2.Text==null)
                {
                    label1.Text = "No Match!";
                    showemail2.Text = "";
                    showpno2.Text = "";
                }
                else
                {
                    StreamReader Record = new StreamReader("Record.dat");
                    n3 = Record.ReadLine();
                    if (n3 == showname2.Text)
                    {
                        showemail2.Text = Record.ReadLine();
                        showpno2.Text = Record.ReadLine();
                        check2 = 1;
                    }
                    else
                    {
                        for (; showname2.Text != n3 && n3 != null;)
                        {
                            n3 = Record.ReadLine();
                            n3 = Record.ReadLine();
                            n3 = Record.ReadLine();
                        }
                    }
                    if (check2 == 0)
                    {
                        if (showname2.Text == n3)
                        {
                            showemail2.Text = Record.ReadLine();
                            showpno2.Text = Record.ReadLine();
                            check2 = 1;
                        }
                    }
                    Record.Close();
                    if (check2 == 1)
                    {
                        label1.Text = "Match Found!";
                        DialogResult result = MessageBox.Show("Confirm to delete the information?", "Confirm Message", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes) 
                        {
                            deleterecord(n3);
                            MessageBox.Show("Deleted", "delete", MessageBoxButtons.OK);
                        }
                        
                    }
                    else
                    {
                        label1.Text = "No Match!";
                        showemail2.Text = "";
                        showpno2.Text = "";
                    }
                }
            }

            if (byemail2.Checked) // search by email
            {
                if (showemail2.Text==null)
                {
                    label1.Text = "No Match!";
                    showname2.Text = "";
                    showpno2.Text = "";
                }
                else
                {
                    StreamReader Record = new StreamReader("Record.dat");
                    n3 = Record.ReadLine();
                    e3 = Record.ReadLine();
                    if (e3 == showemail2.Text)
                    {
                        showname2.Text = n3;
                        showpno2.Text = Record.ReadLine();
                        check2 = 1;
                    }
                    else
                    {
                        for (; showemail2.Text != e3 && e3 != null;)
                        {
                            n3 = e3;
                            e3 = Record.ReadLine();
                            n3 = e3;
                            e3 = Record.ReadLine();
                            n3 = e3;
                            e3 = Record.ReadLine();
                        }
                    }                    
                    if (check2 == 0)
                    {
                        if (showemail2.Text == e3)
                        {
                            showname2.Text = n3;
                            showpno2.Text = Record.ReadLine();
                            check2 = 1;
                        }
                    }
                    Record.Close();
                    if (check2 == 1)
                    {
                        label1.Text = "Match Found!";
                        DialogResult result = MessageBox.Show("Confirm to delete the information?", "Confirm Message", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            deleterecord(n3);
                            MessageBox.Show("Deleted", "delete", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        label1.Text = "No Match!";
                        showname2.Text = "";
                        showpno2.Text = "";

                    }
                }
            }

            if (bypno2.Checked) //by phone number
            {
                if (showpno2.Text==null)
                {
                    label1.Text = "No Match!";
                    showname2.Text = "";
                    showpno2.Text = "";

                }
                else
                {
                    StreamReader Record = new StreamReader("Record.dat");
                    n3 = Record.ReadLine();
                    e3 = Record.ReadLine();
                    p3 = Record.ReadLine();
                    if (p3 == showpno2.Text)
                    {
                        showname2.Text = n3;
                        showemail2.Text = e3;
                        showpno2.Text = p3;
                        check2 = 1;
                    }
                    else
                    {
                        for (; showpno2.Text != p3 && p3 != null;)
                        {
                            p3 = Record.ReadLine();
                            n3 = p3;
                            p3 = Record.ReadLine();
                            e3 = p3;
                            p3 = Record.ReadLine();
                        }
                    }
                    if (check2 == 0)
                    {
                        if (showpno2.Text == p3)
                        {
                            showname2.Text = n3;
                            showemail2.Text = e3;
                            showpno2.Text = p3;
                            check2 = 1;
                        }
                    }
                    Record.Close();
                    if (check2 == 1)
                    {
                        label1.Text = "Match Found!";
                        DialogResult result = MessageBox.Show("Confirm to delete the information?", "Confirm Message", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            deleterecord(n3);
                            MessageBox.Show("Deleted", "delete", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        label1.Text = "No Match!";
                        showname2.Text = "";
                        showemail2.Text = "";

                    }
                }
            }
        }
    }
}
