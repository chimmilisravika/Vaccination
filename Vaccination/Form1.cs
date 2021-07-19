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
    
    public partial class reg_form : Form
    {
        public static string Username = string.Empty;
        public static string Gender = string.Empty;
        public static string Contact_num = string.Empty;
        public static string age = string.Empty;
        public static string VaccineName = string.Empty;
        public static string address = string.Empty;
        public static string adress_prf = string.Empty;

        public reg_form()
        {
            InitializeComponent();
        }

        private void reg_form_Load(object sender, EventArgs e)
        {
            btn_submit.Enabled = false;
            Adres_prf.Items.Add("Adhar Card");
            Adres_prf.Items.Add("Voter Id");
            Adres_prf.Items.Add("PAN Card");
            Adrress_txt.MaxLength = 300;
        }
        private void Username_txt_TextChanged(object sender, EventArgs e)
        {
            if(Username_txt.Text!="" && Adrress_txt.Text!="" && Adres_prf.Text!="")
            {
                btn_submit.Enabled = true;
            }
        }

        private void Adrress_txt_TextChanged(object sender, EventArgs e)
        {
            if (Username_txt.Text != "" && Adrress_txt.Text != "" && Adres_prf.Text != "")
            {
                btn_submit.Enabled = true;
            }
        }

        private void Adres_prf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Username_txt.Text != "" && Adrress_txt.Text != "" && Adres_prf.Text != "")
            {
                btn_submit.Enabled = true;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Username = Username_txt.Text;
            if (Female_Rbtn.Checked == true)
            {
                Gender = "Female";
            }
            else if(Male_Rbtn.Checked==true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "NA";
            }

            Contact_num = ContactNum_txt.Text;
            age = age_txt.Text;
            if(covishield_Rbtn.Checked==true)
            {
                VaccineName = "Covishield";
            }
            else if(Covaxin_Rbtn.Checked==true)
            {
                VaccineName = "Covaxin";
            }
            else if(Spuntnik_Rbtn.Checked==true)
            {
                VaccineName = "Spuntnik";
            }
            else
            {
                VaccineName = "Available Vaccine";
            }
            address = Adrress_txt.Text;
            adress_prf = Adres_prf.Text;
            this.Hide();
            //Call the Confirm registration
            Confirm_registration reg_confirm = new Confirm_registration();
            reg_confirm.Show();
        }

        private void Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled == true)
            {
                MessageBox.Show("Please enter only numeric characters", "Contact Number");
            }
        }
        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled == true)
            {
                MessageBox.Show("Please enter only numeric characters", "Age");
            }
        }
       
        private void ContactNum_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
