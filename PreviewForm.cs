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
    public partial class PreviewForm: Form
    {
        public PreviewForm(string name,
                       string country,
                       string gender,
                       string hobbies,
                       string status)
        {
            InitializeComponent();
            lblName.Text = name;
            lblCountry1.Text = country;
            lblGender.Text = gender;
            lblHobby.Text = hobbies;
            lblStatus.Text = status;
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
