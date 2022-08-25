using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDataEntry
{
    public partial class FormCustomerDataEntry : Form
    {
        public FormCustomerDataEntry()
        {
            InitializeComponent();
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void Hobbies_Click(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void Country_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            string Gender = "";
            string Hobbies = "";
            string Status = "";
            if(checkMale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            if(checkPaint.Checked)
            {
                Hobbies = "Painting";
            }
            else
            {
                Hobbies = "Reading";
            }
            if(radioMarried.Checked)
            {
                Status = "married";
            }
            else
            {
                Status = "single";
            }
            FormCustomerPreview obj = new FormCustomerPreview();
            obj.SetValues(txtCustomerName.Text,
                          cmbCountries.Text.ToString(),Gender,Hobbies,Status,txtAddress.Text);
            obj.ShowDialog();
        }
    }
}
