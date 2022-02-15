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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.DobGroupBox = new System.Windows.Forms.GroupBox();
            this.DobBox = new System.Windows.Forms.DateTimePicker();
            this.HeightWeightBox = new System.Windows.Forms.GroupBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTrackBar = new System.Windows.Forms.TrackBar();
            this.HeightComboBox = new System.Windows.Forms.ComboBox();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.DobGroupBox.SuspendLayout();
            this.HeightWeightBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(263, 834);
            this.MenuPanel.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(263, 200);
            this.LogoPanel.TabIndex = 0;
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.LastNameTextBox);
            this.NameGroupBox.Controls.Add(this.FirstNameTextBox);
            this.NameGroupBox.Location = new System.Drawing.Point(269, 0);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(504, 160);
            this.NameGroupBox.TabIndex = 1;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.LastNameTextBox.Location = new System.Drawing.Point(6, 80);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(491, 39);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.FirstNameTextBox.Location = new System.Drawing.Point(6, 38);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(491, 39);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Text = "First Name";
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.Location = new System.Drawing.Point(269, 162);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(503, 156);
            this.GenderGroupBox.TabIndex = 2;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(6, 80);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(122, 36);
            this.FemaleRadioButton.TabIndex = 1;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(6, 38);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(98, 36);
            this.MaleRadioButton.TabIndex = 0;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // DobGroupBox
            // 
            this.DobGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DobGroupBox.Controls.Add(this.DobBox);
            this.DobGroupBox.Location = new System.Drawing.Point(269, 324);
            this.DobGroupBox.Name = "DobGroupBox";
            this.DobGroupBox.Size = new System.Drawing.Size(503, 96);
            this.DobGroupBox.TabIndex = 3;
            this.DobGroupBox.TabStop = false;
            this.DobGroupBox.Text = "Date of Birth";
            // 
            // DobBox
            // 
            this.DobBox.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.DobBox.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.DobBox.Location = new System.Drawing.Point(6, 38);
            this.DobBox.MaxDate = new System.DateTime(2022, 2, 15, 0, 0, 0, 0);
            this.DobBox.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DobBox.Name = "DobBox";
            this.DobBox.Size = new System.Drawing.Size(485, 39);
            this.DobBox.TabIndex = 0;
            this.DobBox.Value = new System.DateTime(2022, 2, 15, 0, 0, 0, 0);
            // 
            // HeightWeightBox
            // 
            this.HeightWeightBox.Controls.Add(this.WeightTextBox);
            this.HeightWeightBox.Controls.Add(this.WeightTrackBar);
            this.HeightWeightBox.Controls.Add(this.HeightComboBox);
            this.HeightWeightBox.Location = new System.Drawing.Point(269, 426);
            this.HeightWeightBox.Name = "HeightWeightBox";
            this.HeightWeightBox.Size = new System.Drawing.Size(491, 172);
            this.HeightWeightBox.TabIndex = 4;
            this.HeightWeightBox.TabStop = false;
            this.HeightWeightBox.Text = "Height (in) / Weight (lb)";
            this.HeightWeightBox.Enter += new System.EventHandler(this.HeightGroupBox_Enter);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(320, 84);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.ReadOnly = true;
            this.WeightTextBox.Size = new System.Drawing.Size(165, 39);
            this.WeightTextBox.TabIndex = 7;
            // 
            // WeightTrackBar
            // 
            this.WeightTrackBar.Location = new System.Drawing.Point(6, 84);
            this.WeightTrackBar.Maximum = 400;
            this.WeightTrackBar.Name = "WeightTrackBar";
            this.WeightTrackBar.Size = new System.Drawing.Size(308, 90);
            this.WeightTrackBar.TabIndex = 6;
            this.WeightTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.WeightTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // HeightComboBox
            // 
            this.HeightComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            "6\'0\"",
            "6\'1\"",
            "6\'2\"",
            "6\'3\"",
            "6\'4\"",
            "6\'5\"",
            "6\'6\"",
            "6\'7\"",
            "6\'8\""});
            this.HeightComboBox.Location = new System.Drawing.Point(6, 38);
            this.HeightComboBox.Name = "HeightComboBox";
            this.HeightComboBox.Size = new System.Drawing.Size(485, 40);
            this.HeightComboBox.TabIndex = 5;
            // 
            // ResultPanel
            // 
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResultPanel.Location = new System.Drawing.Point(790, 0);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(400, 834);
            this.ResultPanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 834);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.HeightWeightBox);
            this.Controls.Add(this.DobGroupBox);
            this.Controls.Add(this.GenderGroupBox);
            this.Controls.Add(this.NameGroupBox);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.DobGroupBox.ResumeLayout(false);
            this.HeightWeightBox.ResumeLayout(false);
            this.HeightWeightBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Panel LogoPanel;
        private GroupBox NameGroupBox;
        private GroupBox GenderGroupBox;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private GroupBox DobGroupBox;
        private DateTimePicker DobBox;
        private GroupBox HeightWeightBox;
        private ComboBox HeightComboBox;
        private TrackBar WeightTrackBar;
        private TextBox WeightTextBox;
        private Panel ResultPanel;
    }
}