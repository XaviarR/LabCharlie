namespace LabCharlie
{
    partial class AimForm
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
            this.SpecifyLabel = new System.Windows.Forms.Label();
            this.Meeting_RB = new System.Windows.Forms.RadioButton();
            this.SiteVisit_RB = new System.Windows.Forms.RadioButton();
            this.SalesAppointment_RB = new System.Windows.Forms.RadioButton();
            this.StudentInterview_RB = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpecifyLabel
            // 
            this.SpecifyLabel.AutoSize = true;
            this.SpecifyLabel.Location = new System.Drawing.Point(23, 29);
            this.SpecifyLabel.Name = "SpecifyLabel";
            this.SpecifyLabel.Size = new System.Drawing.Size(243, 16);
            this.SpecifyLabel.TabIndex = 0;
            this.SpecifyLabel.Text = "Please specify the nature of the meeting";
            // 
            // Meeting_RB
            // 
            this.Meeting_RB.AutoSize = true;
            this.Meeting_RB.Location = new System.Drawing.Point(26, 85);
            this.Meeting_RB.Name = "Meeting_RB";
            this.Meeting_RB.Size = new System.Drawing.Size(76, 20);
            this.Meeting_RB.TabIndex = 1;
            this.Meeting_RB.TabStop = true;
            this.Meeting_RB.Text = "Meeting";
            this.Meeting_RB.UseVisualStyleBackColor = true;
            // 
            // SiteVisit_RB
            // 
            this.SiteVisit_RB.AutoSize = true;
            this.SiteVisit_RB.Location = new System.Drawing.Point(26, 151);
            this.SiteVisit_RB.Name = "SiteVisit_RB";
            this.SiteVisit_RB.Size = new System.Drawing.Size(79, 20);
            this.SiteVisit_RB.TabIndex = 2;
            this.SiteVisit_RB.TabStop = true;
            this.SiteVisit_RB.Text = "Site Visit";
            this.SiteVisit_RB.UseVisualStyleBackColor = true;
            // 
            // SalesAppointment_RB
            // 
            this.SalesAppointment_RB.AutoSize = true;
            this.SalesAppointment_RB.Location = new System.Drawing.Point(267, 85);
            this.SalesAppointment_RB.Name = "SalesAppointment_RB";
            this.SalesAppointment_RB.Size = new System.Drawing.Size(141, 20);
            this.SalesAppointment_RB.TabIndex = 3;
            this.SalesAppointment_RB.TabStop = true;
            this.SalesAppointment_RB.Text = "Sales Appointment";
            this.SalesAppointment_RB.UseVisualStyleBackColor = true;
            // 
            // StudentInterview_RB
            // 
            this.StudentInterview_RB.AutoSize = true;
            this.StudentInterview_RB.Location = new System.Drawing.Point(267, 151);
            this.StudentInterview_RB.Name = "StudentInterview_RB";
            this.StudentInterview_RB.Size = new System.Drawing.Size(128, 20);
            this.StudentInterview_RB.TabIndex = 4;
            this.StudentInterview_RB.TabStop = true;
            this.StudentInterview_RB.Text = "Student interview";
            this.StudentInterview_RB.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(191, 224);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(333, 224);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StudentInterview_RB);
            this.Controls.Add(this.SalesAppointment_RB);
            this.Controls.Add(this.SiteVisit_RB);
            this.Controls.Add(this.Meeting_RB);
            this.Controls.Add(this.SpecifyLabel);
            this.Name = "AimForm";
            this.Text = "Aim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpecifyLabel;
        private System.Windows.Forms.RadioButton Meeting_RB;
        private System.Windows.Forms.RadioButton SiteVisit_RB;
        private System.Windows.Forms.RadioButton SalesAppointment_RB;
        private System.Windows.Forms.RadioButton StudentInterview_RB;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}