using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Vaccination
{
    
    public partial class confirmRegistration : Form
    {
        public confirmRegistration()
        {
            InitializeComponent();
        }

        // Call Successful Registration Form
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            successfulRegistration successReg = new successfulRegistration();
            successReg.Show();
        }

        // Loading all the details from Mainform class
        private void Confirm_registration_Load(object sender, EventArgs e)
        {
            lblName.Text = formRegistration.userName;
            lblGender.Text = formRegistration.Gender;
            lblContactNum.Text = formRegistration.contactNumber;
            lblAge.Text = formRegistration.Age;
            lblVaccineName.Text = formRegistration.vaccineName;
            lblAddress.Text = formRegistration.Address;
            lblAddressProof.Text = formRegistration.addressProof;

        }
    }
}
