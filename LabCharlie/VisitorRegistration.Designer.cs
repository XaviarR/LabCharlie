namespace LabCharlie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.MobileLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Surname_TB = new System.Windows.Forms.TextBox();
            this.Mobile_TB = new System.Windows.Forms.TextBox();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MeetingWithLabel = new System.Windows.Forms.Label();
            this.MeetingAimLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TimeHour = new System.Windows.Forms.NumericUpDown();
            this.TimeMinute = new System.Windows.Forms.NumericUpDown();
            this.MeetingWithComboBox = new System.Windows.Forms.ComboBox();
            this.MeetingAimButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ListBox = new System.Windows.Forms.ListBox();
            this.VisitorsOnSite_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(9, 79);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(64, 16);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Surname:";
            // 
            // MobileLabel
            // 
            this.MobileLabel.AutoSize = true;
            this.MobileLabel.Location = new System.Drawing.Point(9, 153);
            this.MobileLabel.Name = "MobileLabel";
            this.MobileLabel.Size = new System.Drawing.Size(51, 16);
            this.MobileLabel.TabIndex = 2;
            this.MobileLabel.Text = "Mobile:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(9, 227);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 16);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email:";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(12, 41);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(208, 22);
            this.Name_TB.TabIndex = 4;
            // 
            // Surname_TB
            // 
            this.Surname_TB.Location = new System.Drawing.Point(12, 113);
            this.Surname_TB.Name = "Surname_TB";
            this.Surname_TB.Size = new System.Drawing.Size(208, 22);
            this.Surname_TB.TabIndex = 5;
            // 
            // Mobile_TB
            // 
            this.Mobile_TB.Location = new System.Drawing.Point(12, 182);
            this.Mobile_TB.Name = "Mobile_TB";
            this.Mobile_TB.Size = new System.Drawing.Size(208, 22);
            this.Mobile_TB.TabIndex = 6;
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(12, 264);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(208, 22);
            this.Email_TB.TabIndex = 7;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(291, 13);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(39, 16);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Date:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(294, 78);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(41, 16);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "Time:";
            // 
            // MeetingWithLabel
            // 
            this.MeetingWithLabel.AutoSize = true;
            this.MeetingWithLabel.Location = new System.Drawing.Point(294, 152);
            this.MeetingWithLabel.Name = "MeetingWithLabel";
            this.MeetingWithLabel.Size = new System.Drawing.Size(87, 16);
            this.MeetingWithLabel.TabIndex = 10;
            this.MeetingWithLabel.Text = "Meeting With:";
            // 
            // MeetingAimLabel
            // 
            this.MeetingAimLabel.AutoSize = true;
            this.MeetingAimLabel.Location = new System.Drawing.Point(294, 226);
            this.MeetingAimLabel.Name = "MeetingAimLabel";
            this.MeetingAimLabel.Size = new System.Drawing.Size(84, 16);
            this.MeetingAimLabel.TabIndex = 11;
            this.MeetingAimLabel.Text = "Meeting Aim:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 3, 0, 0, 0, 0);
            // 
            // TimeHour
            // 
            this.TimeHour.Location = new System.Drawing.Point(297, 112);
            this.TimeHour.Name = "TimeHour";
            this.TimeHour.Size = new System.Drawing.Size(120, 22);
            this.TimeHour.TabIndex = 13;
            // 
            // TimeMinute
            // 
            this.TimeMinute.Location = new System.Drawing.Point(445, 112);
            this.TimeMinute.Name = "TimeMinute";
            this.TimeMinute.Size = new System.Drawing.Size(120, 22);
            this.TimeMinute.TabIndex = 14;
            // 
            // MeetingWithComboBox
            // 
            this.MeetingWithComboBox.FormattingEnabled = true;
            this.MeetingWithComboBox.Items.AddRange(new object[] {
            "Jatinder Singh",
            "Beerindeer Singh",
            "Rashmi Munjal"});
            this.MeetingWithComboBox.Location = new System.Drawing.Point(297, 179);
            this.MeetingWithComboBox.Name = "MeetingWithComboBox";
            this.MeetingWithComboBox.Size = new System.Drawing.Size(268, 24);
            this.MeetingWithComboBox.TabIndex = 15;
            // 
            // MeetingAimButton
            // 
            this.MeetingAimButton.Location = new System.Drawing.Point(294, 262);
            this.MeetingAimButton.Name = "MeetingAimButton";
            this.MeetingAimButton.Size = new System.Drawing.Size(271, 23);
            this.MeetingAimButton.TabIndex = 16;
            this.MeetingAimButton.Text = "Meeting Aim";
            this.MeetingAimButton.UseVisualStyleBackColor = true;
            this.MeetingAimButton.Click += new System.EventHandler(this.MeetingAimButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(12, 334);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(553, 71);
            this.SignInButton.TabIndex = 17;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(596, 40);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(339, 356);
            this.ListBox.TabIndex = 18;
            // 
            // VisitorsOnSite_Label
            // 
            this.VisitorsOnSite_Label.AutoSize = true;
            this.VisitorsOnSite_Label.Location = new System.Drawing.Point(596, 12);
            this.VisitorsOnSite_Label.Name = "VisitorsOnSite_Label";
            this.VisitorsOnSite_Label.Size = new System.Drawing.Size(97, 16);
            this.VisitorsOnSite_Label.TabIndex = 19;
            this.VisitorsOnSite_Label.Text = "Visitors On Site";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.VisitorsOnSite_Label);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.MeetingAimButton);
            this.Controls.Add(this.MeetingWithComboBox);
            this.Controls.Add(this.TimeMinute);
            this.Controls.Add(this.TimeHour);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MeetingAimLabel);
            this.Controls.Add(this.MeetingWithLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Email_TB);
            this.Controls.Add(this.Mobile_TB);
            this.Controls.Add(this.Surname_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.MobileLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Visitor Registration";
            ((System.ComponentModel.ISupportInitialize)(this.TimeHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label MobileLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Surname_TB;
        private System.Windows.Forms.TextBox Mobile_TB;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label MeetingWithLabel;
        private System.Windows.Forms.Label MeetingAimLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown TimeHour;
        private System.Windows.Forms.NumericUpDown TimeMinute;
        private System.Windows.Forms.ComboBox MeetingWithComboBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label VisitorsOnSite_Label;
        public System.Windows.Forms.Button MeetingAimButton;
        public System.Windows.Forms.ListBox ListBox;
    }
}

