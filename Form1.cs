using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerEntryForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter your name");
                return;
            }
            string name = txtName.Text;

            string country = cmbCountry.SelectedItem.ToString();

            string gender = rdoMale.Checked ?
                            "Male" : "Female";

            string hobbies = "";
            if (chkMusic.Checked)
                hobbies += "Music ";

            if (chkSports.Checked)
                hobbies += "Sports ";

            if (chkTravel.Checked)
                hobbies += "Travel ";
            string status =
      cmbStatus.SelectedItem.ToString();
            PreviewForm preview =
      new PreviewForm(
          name,
          country,
          gender,
          hobbies,
          status);

            preview.Show();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();

            cmbCountry.SelectedIndex = -1;

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            chkMusic.Checked = false;
            chkSports.Checked = false;
            chkTravel.Checked = false;

            cmbStatus.SelectedIndex = -1;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
