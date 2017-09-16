using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenging_mechanics_1_ushapant12345
{
    public partial class Form1 : Form
    {
        public Form1()

       
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            MessageBox.Show(txtFirstName.Text);
            MessageBox.Show(txtLastname.Text);
            MessageBox.Show(txtFirstName.Text + "-");
            MessageBox.Show(txtFirstName.Text + "- " +  "12345");
            MessageBox.Show(txtFirstName.Text + "-" + "12345" + "-");
            MessageBox.Show(txtFirstName.Text + "-" + "*" + "-" + "*" + "-" + "*" + "-");
            MessageBox.Show(txtFirstName.Text + "-" + "*" + "-" + "*" + "-" + "*" + "-" + txtLastname.Text);
            MessageBox.Show(txtFirstName.Text + " " + txtLastname.Text);
            MessageBox.Show(txtFirstName.Text + " " + txtFirstName.Text);
            MessageBox.Show(txtFirstName.Text + " " + txtFirstName.Text + " " + txtLastname.Text + " " + txtLastname.Text);
            MessageBox.Show(txtFirstName.Text + "-" + txtLastname.Text);
            MessageBox.Show(txtFirstName.Text + "-" + txtLastname.Text + "*");
            MessageBox.Show(txtLastname.Text + "," + txtFirstName.Text);
            MessageBox.Show(txtFirstName.Text + "\r\n" + txtLastname.Text);
            MessageBox.Show("First Name:"+ txtFirstName.Text + "\r\n " + "Last Name:" + txtLastname.Text);
            MessageBox.Show("First---Last" + "\r\n" + txtFirstName.Text + "---" + txtLastname.Text);
            MessageBox.Show(String.Format(txtFirstName.Text + "\r\n" + "{0}", txtLastname.Text));
            MessageBox.Show(String.Format("Firstname:" + txtFirstName.Text + "\r\n" + "Lastname:" + "{0}", txtLastname.Text));
            MessageBox.Show(String.Format("First---Last" + "\r\n" + txtFirstName.Text + "{0}", txtLastname.Text));
            MessageBox.Show(String.Format(txtFirstName.Text + "-" + "*" + "-" + "*" + "-" + "*" + "-" + "{0}", txtLastname.Text));
            MessageBox.Show(String.Format(txtFirstName.Text + "-" + "*" + "-" + "*" + "-" + "*" + "-" + "{0}", txtLastname.Text));







            //fill in the blanks
            //MessageBox.Show(string.Format(("{ 0}" + "{-}" + "{2}" + "{-}" + "{2}" + "{-}" + "{2}" + "{-}" + "{1}"), "A", "B", "*"));
            //MessageBox.Show(string.Format(("{ 1}" + "{0}" + "{3}" + "{0}" + "{3}" + "{0}" + "{3}" + "{0}" + "{2}"), "-", "A", "B", "*"));
            //MessageBox.Show(string.Format(("{ 1}" + "{3}" + "{0}" + "{3}" + "{0}" + "{3}" + "{0}" + "{3}" + "{0}" + "2"), "-", "A", "B", "\r\n"));
            //MessageBox.Show(string.Format(("{ 0}" + "{-}" + "{1}" + "{-}" + "{0}" + "{-}" + "{1}" + "{-}" + "{0}"), "A","B"));
            //MessageBox.Show(string.Format(("{ 0}" + "{2}" + "{1}" + "{2}" + "{0}" + "{2}" + "{1}" + "{2}" + "{0}"), "A", "B", "-"));







        }





    }
}
