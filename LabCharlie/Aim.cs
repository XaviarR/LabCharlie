using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCharlie
{
    public partial class AimForm : Form
    {
        //For adding checked radio button into listbox in Visitorform
        public static AimForm aimSelf;
        public string CheckedRB;
        public AimForm()
        {
            InitializeComponent();
            aimSelf = this;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (Meeting_RB.Checked)
            {
                //Form1.Self.MeetingAimButton.Text = Meeting_RB.Text;
                CheckedRB = Meeting_RB.Text;
            }
            else if (SalesAppointment_RB.Checked)
            {
                //Form1.Self.MeetingAimButton.Text = SalesAppointment_RB.Text;
                CheckedRB = SalesAppointment_RB.Text;
            }
            else if (SiteVisit_RB.Checked)
            {
                //Form1.Self.MeetingAimButton.Text = SiteVisit_RB.Text;
                CheckedRB = SiteVisit_RB.Text;
            }
            else if (StudentInterview_RB.Checked)
            {
                //Form1.Self.MeetingAimButton.Text = StudentInterview_RB.Text;
                CheckedRB = StudentInterview_RB.Text;
            }
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
