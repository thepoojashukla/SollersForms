using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CountryDropdown.Items.Add("India");
            CountryDropdown.Items.Add("Australia");
            CountryDropdown.Items.Add("USA");
            CountryDropdown.Items.Add("England");
            CountryDropdown.Items.Add("NewZealand");
        }

        private void CountryDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(CountryDropdown.SelectedIndex.ToString());
        }

    }
}
