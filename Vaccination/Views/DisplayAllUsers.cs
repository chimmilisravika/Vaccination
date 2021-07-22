using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vaccination
{
    public partial class DisplayAllUsers : Form
    {
        public DisplayAllUsers()
        {
            InitializeComponent();
        }

        private void DisplayAllUsers_Load(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            grdvDisplayAllUsers.DataSource = repository.GetVaccinationUsers();

        }

    }
}
