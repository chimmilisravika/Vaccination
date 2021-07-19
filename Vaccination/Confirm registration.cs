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
    
    public partial class Confirm_registration : Form
    {
        //reg_form frm = new reg_form();
        public Confirm_registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Success_reg successReg = new Success_reg();
            successReg.Show();
        }

        private void Confirm_registration_Load(object sender, EventArgs e)
        {
            Name_lbl.Text = reg_form.Username;
            Gender_lbl.Text = reg_form.Gender;
            Contact_lbl.Text = reg_form.Contact_num;
            age_lbl.Text = reg_form.age;
            Vac_name_lbl.Text = reg_form.VaccineName;
            adrs_lbl.Text = reg_form.address;
            adrs_prf_lbl.Text = reg_form.adress_prf;

        }
    }
}
