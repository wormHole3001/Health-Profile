namespace Health_Profile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.ResultsButton = new FontAwesome.Sharp.IconButton();
            this.BMIChartButton = new FontAwesome.Sharp.IconButton();
            this.HeightWeightGroupBox = new System.Windows.Forms.GroupBox();
            this.HeightComboBox = new System.Windows.Forms.ComboBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.DOBGroupBox = new System.Windows.Forms.GroupBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FullNameGroupBox = new System.Windows.Forms.GroupBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BackgroundPanel.SuspendLayout();
            this.HeightWeightGroupBox.SuspendLayout();
            this.DOBGroupBox.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.FullNameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BackgroundPanel.Controls.Add(this.ResultsButton);
            this.BackgroundPanel.Controls.Add(this.BMIChartButton);
            this.BackgroundPanel.Controls.Add(this.HeightWeightGroupBox);
            this.BackgroundPanel.Controls.Add(this.DOBGroupBox);
            this.BackgroundPanel.Controls.Add(this.GenderGroupBox);
            this.BackgroundPanel.Controls.Add(this.FullNameGroupBox);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1192, 834);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // ResultsButton
            // 
            this.ResultsButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ResultsButton.FlatAppearance.BorderSize = 0;
            this.ResultsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultsButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultsButton.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.ResultsButton.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.ResultsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ResultsButton.Location = new System.Drawing.Point(607, 376);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(284, 91);
            this.ResultsButton.TabIndex = 5;
            this.ResultsButton.Text = "Results";
            this.ResultsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResultsButton.UseVisualStyleBackColor = false;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // BMIChartButton
            // 
            this.BMIChartButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BMIChartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BMIChartButton.FlatAppearance.BorderSize = 0;
            this.BMIChartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BMIChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMIChartButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BMIChartButton.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.BMIChartButton.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.BMIChartButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BMIChartButton.Location = new System.Drawing.Point(317, 376);
            this.BMIChartButton.Name = "BMIChartButton";
            this.BMIChartButton.Size = new System.Drawing.Size(284, 91);
            this.BMIChartButton.TabIndex = 4;
            this.BMIChartButton.Text = "BMI Chart";
            this.BMIChartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BMIChartButton.UseVisualStyleBackColor = false;
            // 
            // HeightWeightGroupBox
            // 
            this.HeightWeightGroupBox.Controls.Add(this.HeightComboBox);
            this.HeightWeightGroupBox.Controls.Add(this.HeightLabel);
            this.HeightWeightGroupBox.Controls.Add(this.WeightLabel);
            this.HeightWeightGroupBox.Controls.Add(this.WeightTextBox);
            this.HeightWeightGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeightWeightGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightWeightGroupBox.Location = new System.Drawing.Point(607, 174);
            this.HeightWeightGroupBox.Name = "HeightWeightGroupBox";
            this.HeightWeightGroupBox.Size = new System.Drawing.Size(569, 158);
            this.HeightWeightGroupBox.TabIndex = 3;
            this.HeightWeightGroupBox.TabStop = false;
            this.HeightWeightGroupBox.Text = "Height (in) / Weight (lb)";
            // 
            // HeightComboBox
            // 
            this.HeightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeightComboBox.FormattingEnabled = true;
            this.HeightComboBox.Items.AddRange(new object[] {
            "4\'8\"",
            "4\'9\"",
            "4\'10\"",
            "4\'11\"",
            "5\'0\"",
            "5\'1\"",
            "5\'2\"",
            "5\'3\"",
            "5\'4\"",
            "5\'5\"",
            "5\'6\"",
            "5\'7\"",
            "5\'8\"",
            "5\'9\"",
            "5\'10\"",
            "5\'11\"",
            "6\'1\"",
            "6\'2\"",
            "6\'3\"",
            "6\'4\"",
            "6\'5\"",
            "6\'6\"",
            "6\'7\"",
            "6\'8\"",
            "6\'9\"",
            "6\'10\"",
            "6\'11\"",
            "7\'0\"",
            "7\'1\"",
            "7\'2\"",
            "7\'3\"",
            "7\'4\""});
            this.HeightComboBox.Location = new System.Drawing.Point(100, 84);
            this.HeightComboBox.Name = "HeightComboBox";
            this.HeightComboBox.Size = new System.Drawing.Size(94, 38);
            this.HeightComboBox.TabIndex = 5;
            this.HeightComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.HeightComboBox_Validating);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.HeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeightLabel.Location = new System.Drawing.Point(6, 84);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(82, 32);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.WeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WeightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeightLabel.Location = new System.Drawing.Point(6, 38);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(88, 32);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "Weight";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(100, 38);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(94, 35);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextBox_KeyPress);
            this.WeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WeightTextBox_Validating);
            // 
            // DOBGroupBox
            // 
            this.DOBGroupBox.Controls.Add(this.DateOfBirth);
            this.DOBGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DOBGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOBGroupBox.Location = new System.Drawing.Point(10, 174);
            this.DOBGroupBox.Name = "DOBGroupBox";
            this.DOBGroupBox.Size = new System.Drawing.Size(591, 158);
            this.DOBGroupBox.TabIndex = 2;
            this.DOBGroupBox.TabStop = false;
            this.DOBGroupBox.Text = "Date of Birth";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(6, 34);
            this.DateOfBirth.MaxDate = new System.DateTime(2022, 2, 19, 0, 0, 0, 0);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(516, 35);
            this.DateOfBirth.TabIndex = 0;
            this.DateOfBirth.Value = new System.DateTime(2022, 2, 19, 0, 0, 0, 0);
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderGroupBox.Location = new System.Drawing.Point(607, 10);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(569, 158);
            this.GenderGroupBox.TabIndex = 1;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(6, 76);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(121, 34);
            this.FemaleRadioButton.TabIndex = 1;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(6, 34);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(95, 34);
            this.MaleRadioButton.TabIndex = 0;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FullNameGroupBox
            // 
            this.FullNameGroupBox.Controls.Add(this.LastNameTextBox);
            this.FullNameGroupBox.Controls.Add(this.FirstNameTextBox);
            this.FullNameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullNameGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNameGroupBox.Location = new System.Drawing.Point(10, 10);
            this.FullNameGroupBox.Name = "FullNameGroupBox";
            this.FullNameGroupBox.Size = new System.Drawing.Size(591, 158);
            this.FullNameGroupBox.TabIndex = 0;
            this.FullNameGroupBox.TabStop = false;
            this.FullNameGroupBox.Text = "Full Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(6, 75);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(516, 35);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.Text = "Last Name";
            this.LastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameTextBox_Validating);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(6, 34);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(516, 35);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Text = "First Name";
            this.FirstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1190, 554);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.BackgroundPanel.ResumeLayout(false);
            this.HeightWeightGroupBox.ResumeLayout(false);
            this.HeightWeightGroupBox.PerformLayout();
            this.DOBGroupBox.ResumeLayout(false);
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.FullNameGroupBox.ResumeLayout(false);
            this.FullNameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BackgroundPanel;
        private GroupBox HeightWeightGroupBox;
        private GroupBox DOBGroupBox;
        private GroupBox GenderGroupBox;
        private GroupBox FullNameGroupBox;
        private FontAwesome.Sharp.IconButton ResultsButton;
        private FontAwesome.Sharp.IconButton BMIChartButton;
        private DateTimePicker DateOfBirth;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private TextBox WeightTextBox;
        private Label WeightLabel;
        private ComboBox HeightComboBox;
        private Label HeightLabel;
        private ErrorProvider errorProvider1;
    }
}