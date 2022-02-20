namespace Health_Profile
{
    public partial class Form1 : Form
    {
        /* Public members used for passing over to the second form */
        public static string? SetFirstName = null;
        public static string? SetLastName = null;
        public static string? SetGender = null;
        public static string? SetWeight = null;
        public static string? SetHeight = null;
        public static string? SetDateOfBirth = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            /* Only allow one decimal point */
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void FirstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(FirstNameTextBox, "First name should not be left blank.");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(FirstNameTextBox, String.Empty);
            }

        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            /* Validate that a gender has been chosen. */
            if (!MaleRadioButton.Checked && !FemaleRadioButton.Checked)
            {
                MessageBox.Show("Please select gender ", "Error");
                return;
            }
            
            if (ValidateChildren())
            {
                /* Set the user details to be passed to form 2 */
                SetFirstName = FirstNameTextBox.Text;
                SetLastName = LastNameTextBox.Text;
                if (MaleRadioButton.Checked)
                {
                    SetGender = "Male";
                }
                if (FemaleRadioButton.Checked)
                {
                    SetGender = "Female";
                }
                SetWeight = WeightTextBox.Text;
                SetHeight = HeightComboBox.Text;
                SetDateOfBirth = DateOfBirth.Text;
                ResultsSummary resultsSummary = new ResultsSummary();
                resultsSummary.Show();
            }
            
        }

        private void LastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LastNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(LastNameTextBox, "Last name should not be left blank.");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(LastNameTextBox, String.Empty);
            }
        }

        private void WeightTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(WeightTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(WeightTextBox, "Please enter a weight in pounds");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(WeightTextBox, String.Empty);
            }
        }

        private void HeightComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(HeightComboBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(HeightComboBox, "Please choose a height");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(HeightComboBox, String.Empty);  
            }
        }

        private void BMIChartButton_Click(object sender, EventArgs e)
        {
            BMIChart bmiChart = new BMIChart();
            bmiChart.Show();    
        }
    }
}