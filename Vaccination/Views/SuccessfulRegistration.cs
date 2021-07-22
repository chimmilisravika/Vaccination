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
        public successfulRegistration(Vaccination_Details UserDetails)
        {
            InitializeComponent();
            lblUserName.Text = UserDetails.userName;
            lblContactNum.Text = UserDetails.contactNumber;
            lblContactNumber.Text = UserDetails.vaccineName;
        }
        //Load all the details from fromRegistration
        private void successfulRegistration_Load(object sender, EventArgs e)
        {
            
           

        }
        //While closing Successful Registration form call MainForm
        private void successfulRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            formRegistration regForm = new formRegistration();
            regForm.Show();
        }
    }
}
