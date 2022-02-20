using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Profile
{
    public partial class ResultsSummary : Form
    {
        public ResultsSummary()
        {
            InitializeComponent();
        }

        private void ResultsSummary_Load(object sender, EventArgs e)
        {
            FirstName.Text = Form1.SetFirstName;
            LastName.Text = Form1.SetLastName;
            DateOfBirth.Text = Form1.SetDateOfBirth;
            Weight.Text = Form1.SetWeight;
            Gender.Text = Form1.SetGender; 
            Height.Text = Form1.SetHeight;
        }
    }
}
