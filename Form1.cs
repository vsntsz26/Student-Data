using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oi
{
    public partial class EYLN : Form
    {
        public EYLN()
        {
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string firstName = txt1.Text;
            string lastName = txt2.Text;
            int age = Convert.ToInt32 (txt4.Text);
            string course = txt5.Text;

            txtr.Text = "Nome: " + firstName + " " + lastName
                + "\r\nAge: " + age + "\r\nCourse: " + course;
        }
    }

}