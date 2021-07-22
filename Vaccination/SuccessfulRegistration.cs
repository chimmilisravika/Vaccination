using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vaccination
{
    public partial class successfulRegistration : Form
    {
        public successfulRegistration()
        {
            InitializeComponent();
        }
        //Load all the details from fromRegistration
        private void successfulRegistration_Load(object sender, EventArgs e)
        {
            
            lblUserName.Text = formRegistration.userName;
            lblContactNum.Text = formRegistration.contactNumber;
            lblContactNumber.Text = formRegistration.vaccineName;

        }
        //While closing Successful Registration form call MainForm
        private void successfulRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            formRegistration regForm = new formRegistration();
            regForm.Show();
        }
    }
}
