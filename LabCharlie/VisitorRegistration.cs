using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCharlie
{
    public partial class Form1 : Form
    {
        //Used in Aim.cs to call MeetingAimButton
        public static Form1 Self;

        public static bool ClickedMeetingAim;
        
        
        public Form1()
        {
            InitializeComponent();
            Self = this;
            ClickedMeetingAim = false;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            //Mobile only allows integers
            string getMobile = Mobile_TB.Text;
            int mobileNumber;
            bool validMobile = int.TryParse(getMobile, out mobileNumber);

            //Create regex to require @ and . symbols
            Regex validSymbols = new Regex (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = validSymbols.Match (Email_TB.Text);

            //Validations required

            if (Name_TB.Text == "")
            {
                Name_TB.Focus();
                MessageBox.Show("Name is required");
            }
            else if (Surname_TB.Text == "")
            {
                Surname_TB.Focus();
                MessageBox.Show("Surname is required");
            }
            else if (validMobile != true)
            {   
                Mobile_TB.Focus();
                MessageBox.Show("Mobile is required");
            }
            else if (match.Success != true)
            {
                Email_TB.Focus();
                MessageBox.Show("Email is required");
            }
            else if (TimeHour.Value == 0)
            {
                MessageBox.Show("Invalid Hour time");
            }
            else if (MeetingWithComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a trainer to meet with");
            }
            else if (ClickedMeetingAim == false)
            {
                MessageBox.Show("Please click this button and select meeting aim");
            }
            //only executes when all conditions are met including clicking button
            if (Name_TB.Text != String.Empty && Surname_TB.Text != String.Empty && Mobile_TB.Text != String.Empty && Email_TB.Text != string.Empty && ClickedMeetingAim == true)
            {   //Adds into Listbox
                ListBox.Items.Add("Name: " + Name_TB.Text);
                ListBox.Items.Add("Surname: " + Surname_TB.Text);
                ListBox.Items.Add("Mobile: " + Mobile_TB.Text);
                ListBox.Items.Add("Email: " + Email_TB.Text);
                ListBox.Items.Add("Date: " + dateTimePicker1.Value);
                ListBox.Items.Add("Time: " + TimeHour.Value + ": " + TimeMinute.Value);
                ListBox.Items.Add("Meeting With: " + MeetingWithComboBox.Text);
                ListBox.Items.Add("Meeting Aim: " + AimForm.aimSelf.CheckedRB);

                //Reset all TextBoxes
                ResetTB();
            }
        }

        private void MeetingAimButton_Click(object sender, EventArgs e)
        {
            //Shows new form on click of button
            ClickedMeetingAim = true;
            AimForm aimForm = new AimForm();
            aimForm.Show();
        }

        private void ResetTB()
        {
            Name_TB.Text = String.Empty;
            Surname_TB.Text= String.Empty;
            Mobile_TB.Text= String.Empty;
            Email_TB.Text = String.Empty;
            MeetingWithComboBox.Text = String.Empty;
            TimeHour.Value = 0;
            TimeMinute.Value = 0;
        }
    }
}
