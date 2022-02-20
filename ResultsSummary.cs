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
            /* Formula to calculate BMI based on inches and pounds
             * Formula: weight (lb) / [height (in)]2 x 703
            */
            String[] Year = Form1.SetDateOfBirth.Split('/');
            string DateYear = Year[2];
            string currentYear = DateTime.Now.Year.ToString();
            double BMICalculated = (double.Parse(Form1.SetWeight) / Math.Pow((double.Parse(Form1.SetHeight)),2)) * 703;
            int MaxHeartRate = 220 - (int.Parse(currentYear) - int.Parse(DateYear)); // Forumla 220 - Age
            int TargetHeartRateMin = (int)(MaxHeartRate * .50); // Formula MaxHeartRate * .50
            int TargetHeartRateMax = (int)(MaxHeartRate * .85); // Formula MaxHeartRate * .85

            FirstName.Text = Form1.SetFirstName;
            LastName.Text = Form1.SetLastName;
            DateOfBirth.Text = Form1.SetDateOfBirth;
            Weight.Text = Form1.SetWeight;
            Gender.Text = Form1.SetGender; 
            Height.Text = Form1.SetHeight;
            BMI.Text = BMICalculated.ToString();
            MaxHR.Text = MaxHeartRate.ToString() + " bpm";
            TargetHR.Text = TargetHeartRateMin.ToString() + "-" + TargetHeartRateMax.ToString() + " bpm";
        }
    }
}
