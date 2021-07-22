using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaccination
{    
    public partial class formRegistration : Form
    {
        public static List<Vaccination_Details> display_Users = new List<Vaccination_Details>();
        //Variable declaration
        public static string userName = string.Empty;
        public static string Gender = string.Empty;
        public static string contactNumber = string.Empty;
        public static string Age = string.Empty;
        public static string vaccineName = string.Empty;
        public static string Address = string.Empty;
        public static string addressProof = string.Empty;
       
        //Constructor Method
        public formRegistration()
        {
            InitializeComponent();
        }
        //Operations while loading form
    private void reg_form_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            txtAddressProof.Items.Add("Adhar Card");
            txtAddressProof.Items.Add("Voter Id");
            txtAddressProof.Items.Add("PAN Card");
            txtAddress.MaxLength = 300;
            txtContactNumber.MaxLength = 10;
        }
        //Making Submit button enable
        private void Username_txt_TextChanged(object sender, EventArgs e)
        {
            if(txtUserName.Text!="" && txtAddress.Text!="" && txtAddressProof.Text!="")
            {
                btnSubmit.Enabled = true;
            }
        }

        private void Adrress_txt_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtAddress.Text != "" && txtAddressProof.Text != "")
            {
                btnSubmit.Enabled = true;
            }
        }

        private void Adres_prf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtAddress.Text != "" && txtAddressProof.Text != "")
            {
                btnSubmit.Enabled = true;
            }
        }
        //Call the Confirm registration
        private void btn_submit_Click(object sender, EventArgs e)
        {
            Vaccination_Details vacDetails = new Vaccination_Details();

            vacDetails.userName = txtUserName.Text;
            if (rbFemale.Checked == true)
            {
                vacDetails.Gender = "Female";
            }
            else if (rbMale.Checked == true)
            {
                vacDetails.Gender = "Male";
            }
            else
            {
                vacDetails.Gender = "NA";
            }

            vacDetails.contactNumber = txtContactNumber.Text;
            vacDetails.Age = txtAge.Text;
            if (rbCovishield.Checked == true)
            {
                vacDetails.vaccineName = "Covishield";
            }
            else if (rbCovaxin.Checked == true)
            {
                vacDetails.vaccineName = "Covaxin";
            }
            else if (rbSpuntnik.Checked == true)
            {
                vacDetails.vaccineName = "Spuntnik";
            }
            else
            {
                vacDetails.vaccineName = "Available Vaccine";
            }
            vacDetails.Address = txtAddress.Text;
            vacDetails.addressProof = txtAddressProof.Text;


            this.Hide();
            confirmRegistration reg_confirm = new confirmRegistration(vacDetails);
            reg_confirm.Show();
        }
        //Contact number key press events
        private void Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled == true)
            {
                MessageBox.Show("Please enter only numeric characters", "Contact Number");
            }
        }
        //Age key press events
        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled == true)
            {
                MessageBox.Show("Please enter only numeric characters", "Age");
            }
        }

        private void btnDisplayUsers_Click(object sender, EventArgs e)
        {
            DisplayAllUsers displayUsers = new DisplayAllUsers();
            displayUsers.Show();
        }
    }
}
