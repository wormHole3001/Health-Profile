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
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.ResultsButton = new FontAwesome.Sharp.IconButton();
            this.BMIChartButton = new FontAwesome.Sharp.IconButton();
            this.HeightWeightGroupBox = new System.Windows.Forms.GroupBox();
            this.DOBGroupBox = new System.Windows.Forms.GroupBox();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FullNameGroupBox = new System.Windows.Forms.GroupBox();
            this.BackgroundPanel.SuspendLayout();
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
            this.HeightWeightGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeightWeightGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightWeightGroupBox.Location = new System.Drawing.Point(607, 174);
            this.HeightWeightGroupBox.Name = "HeightWeightGroupBox";
            this.HeightWeightGroupBox.Size = new System.Drawing.Size(569, 158);
            this.HeightWeightGroupBox.TabIndex = 3;
            this.HeightWeightGroupBox.TabStop = false;
            this.HeightWeightGroupBox.Text = "Height (in) / Weight (lb)";
            // 
            // DOBGroupBox
            // 
            this.DOBGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DOBGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOBGroupBox.Location = new System.Drawing.Point(10, 174);
            this.DOBGroupBox.Name = "DOBGroupBox";
            this.DOBGroupBox.Size = new System.Drawing.Size(591, 158);
            this.DOBGroupBox.TabIndex = 2;
            this.DOBGroupBox.TabStop = false;
            this.DOBGroupBox.Text = "Date of Birth";
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderGroupBox.Location = new System.Drawing.Point(607, 10);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(569, 158);
            this.GenderGroupBox.TabIndex = 1;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // FullNameGroupBox
            // 
            this.FullNameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullNameGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNameGroupBox.Location = new System.Drawing.Point(10, 10);
            this.FullNameGroupBox.Name = "FullNameGroupBox";
            this.FullNameGroupBox.Size = new System.Drawing.Size(591, 158);
            this.FullNameGroupBox.TabIndex = 0;
            this.FullNameGroupBox.TabStop = false;
            this.FullNameGroupBox.Text = "Full Name";
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
            this.Text = "Form1";
            this.BackgroundPanel.ResumeLayout(false);
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
    }
}