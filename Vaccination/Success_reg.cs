using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vaccination
{
    public partial class Success_reg : Form
    {
        //reg_form frm = new reg_form();
        public Success_reg()
        {
            InitializeComponent();
        }

        private void Success_reg_Load(object sender, EventArgs e)
        {
            
            label_Name.Text = reg_form.Username;
            Contact_Label.Text = reg_form.Contact_num;
            Vac_Name.Text = reg_form.VaccineName;

        }

        private void Contact_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
