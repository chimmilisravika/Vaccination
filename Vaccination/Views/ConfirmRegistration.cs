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
        private Vaccination_Details vacDetails;
        public confirmRegistration(Vaccination_Details UserDetails)
        {
            InitializeComponent();
            this.vacDetails = UserDetails;
        }

        // Call Successful Registration Form
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            repository.AddVaccinationUsers(vacDetails);
            this.Hide();
            successfulRegistration successReg = new successfulRegistration(vacDetails);
            successReg.Show();
        }

        // Loading all the details from Mainform class
        private void Confirm_registration_Load(object sender, EventArgs e)
        {
            LoadControls(vacDetails);
        }
        void LoadControls(Vaccination_Details UserDetails)
        {
            lblName.Text = UserDetails.userName;
            lblGender.Text = UserDetails.Gender;
            lblContactNum.Text = UserDetails.contactNumber;
            lblAge.Text = UserDetails.Age;
            lblVaccineName.Text = UserDetails.vaccineName;
            lblAddress.Text = UserDetails.Address;
            lblAddressProof.Text = UserDetails.addressProof;
        }
    }
}
