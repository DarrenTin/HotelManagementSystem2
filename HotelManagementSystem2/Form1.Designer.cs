namespace HotelManagementSystem2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxRoomToBook = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxConfirm = new System.Windows.Forms.CheckBox();
            this.buttonSubmit1 = new System.Windows.Forms.Button();
            this.textBoxReenterPin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSetPin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAdditionalInformation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSubmit2 = new System.Windows.Forms.Button();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEnterPin1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRoomBooked1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSubmit3 = new System.Windows.Forms.Button();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxEnterPin2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxRoomBooked2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBoxNotRobot = new System.Windows.Forms.CheckBox();
            this.buttonSubmit4 = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxAdminName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxRoomToBook);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.checkBoxConfirm);
            this.tabPage1.Controls.Add(this.buttonSubmit1);
            this.tabPage1.Controls.Add(this.textBoxReenterPin);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxSetPin);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxAdditionalInformation);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dateTimePickerToDate);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dateTimePickerFromDate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxPhoneNumber);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxLastName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxFirstName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check In";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxRoomToBook
            // 
            this.textBoxRoomToBook.Location = new System.Drawing.Point(117, 105);
            this.textBoxRoomToBook.Name = "textBoxRoomToBook";
            this.textBoxRoomToBook.Size = new System.Drawing.Size(100, 22);
            this.textBoxRoomToBook.TabIndex = 21;
            this.textBoxRoomToBook.Text = "1~100";
            this.textBoxRoomToBook.Enter += new System.EventHandler(this.textBoxRoomToBook_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Room To Book:";
            // 
            // checkBoxConfirm
            // 
            this.checkBoxConfirm.AutoSize = true;
            this.checkBoxConfirm.Location = new System.Drawing.Point(203, 350);
            this.checkBoxConfirm.Name = "checkBoxConfirm";
            this.checkBoxConfirm.Size = new System.Drawing.Size(410, 20);
            this.checkBoxConfirm.TabIndex = 19;
            this.checkBoxConfirm.Text = "I hereby declare that the information provided is true and correct. ";
            this.checkBoxConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit1
            // 
            this.buttonSubmit1.Location = new System.Drawing.Point(365, 376);
            this.buttonSubmit1.Name = "buttonSubmit1";
            this.buttonSubmit1.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit1.TabIndex = 18;
            this.buttonSubmit1.Text = "Submit";
            this.buttonSubmit1.UseVisualStyleBackColor = true;
            this.buttonSubmit1.Click += new System.EventHandler(this.buttonSubmit1_Click);
            // 
            // textBoxReenterPin
            // 
            this.textBoxReenterPin.Location = new System.Drawing.Point(290, 300);
            this.textBoxReenterPin.Name = "textBoxReenterPin";
            this.textBoxReenterPin.PasswordChar = '*';
            this.textBoxReenterPin.Size = new System.Drawing.Size(100, 22);
            this.textBoxReenterPin.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Re-enter Pin:";
            // 
            // textBoxSetPin
            // 
            this.textBoxSetPin.Location = new System.Drawing.Point(67, 300);
            this.textBoxSetPin.Name = "textBoxSetPin";
            this.textBoxSetPin.PasswordChar = '*';
            this.textBoxSetPin.Size = new System.Drawing.Size(100, 22);
            this.textBoxSetPin.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Set Pin:";
            // 
            // textBoxAdditionalInformation
            // 
            this.textBoxAdditionalInformation.Location = new System.Drawing.Point(153, 196);
            this.textBoxAdditionalInformation.Multiline = true;
            this.textBoxAdditionalInformation.Name = "textBoxAdditionalInformation";
            this.textBoxAdditionalInformation.Size = new System.Drawing.Size(486, 82);
            this.textBoxAdditionalInformation.TabIndex = 13;
            this.textBoxAdditionalInformation.Text = "E.g. special request, breakfast, quiet room, promotion code, etc.";
            this.textBoxAdditionalInformation.Enter += new System.EventHandler(this.textBoxAdditionalInformation_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Additional Information:";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(403, 144);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(227, 22);
            this.dateTimePickerToDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "To Date:";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(88, 144);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(227, 22);
            this.dateTimePickerFromDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "From Date:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(287, 64);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(168, 22);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.Text = "e.g. example@gmail.com";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(115, 67);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhoneNumber.TabIndex = 5;
            this.textBoxPhoneNumber.Text = "e.g. 01234567890";
            this.textBoxPhoneNumber.Enter += new System.EventHandler(this.textBoxPhoneNumber_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(295, 28);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.Text = "e.g. Einstein";
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxLastName_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(91, 28);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Tag = "";
            this.textBoxFirstName.Text = "e.g. Albert";
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSubmit2);
            this.tabPage2.Controls.Add(this.textBoxFeedback);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBoxEnterPin1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxRoomBooked1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check Out";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit2
            // 
            this.buttonSubmit2.Location = new System.Drawing.Point(360, 200);
            this.buttonSubmit2.Name = "buttonSubmit2";
            this.buttonSubmit2.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit2.TabIndex = 21;
            this.buttonSubmit2.Text = "Submit";
            this.buttonSubmit2.UseVisualStyleBackColor = true;
            this.buttonSubmit2.Click += new System.EventHandler(this.buttonSubmit2_Click);
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.Location = new System.Drawing.Point(146, 86);
            this.textBoxFeedback.Multiline = true;
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(486, 82);
            this.textBoxFeedback.TabIndex = 15;
            this.textBoxFeedback.Text = "Your feedback is important to us!  We will try our best to offer the most excelle" +
    "nt experience!";
            this.textBoxFeedback.Enter += new System.EventHandler(this.textBoxFeedback_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Feedback (optional):";
            // 
            // textBoxEnterPin1
            // 
            this.textBoxEnterPin1.Location = new System.Drawing.Point(314, 28);
            this.textBoxEnterPin1.Name = "textBoxEnterPin1";
            this.textBoxEnterPin1.PasswordChar = '*';
            this.textBoxEnterPin1.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnterPin1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Enter Pin:";
            // 
            // textBoxRoomBooked1
            // 
            this.textBoxRoomBooked1.Location = new System.Drawing.Point(113, 28);
            this.textBoxRoomBooked1.Name = "textBoxRoomBooked1";
            this.textBoxRoomBooked1.Size = new System.Drawing.Size(100, 22);
            this.textBoxRoomBooked1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Room Booked:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSubmit3);
            this.tabPage3.Controls.Add(this.textBoxReason);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textBoxEnterPin2);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.textBoxRoomBooked2);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(794, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cancel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit3
            // 
            this.buttonSubmit3.Location = new System.Drawing.Point(360, 200);
            this.buttonSubmit3.Name = "buttonSubmit3";
            this.buttonSubmit3.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit3.TabIndex = 22;
            this.buttonSubmit3.Text = "Submit";
            this.buttonSubmit3.UseVisualStyleBackColor = true;
            this.buttonSubmit3.Click += new System.EventHandler(this.buttonSubmit3_Click);
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(132, 86);
            this.textBoxReason.Multiline = true;
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(486, 82);
            this.textBoxReason.TabIndex = 21;
            this.textBoxReason.Text = "e.g. too expensive, found another hotel, other reasons";
            this.textBoxReason.Enter += new System.EventHandler(this.textBoxReason_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Reason (optional):";
            // 
            // textBoxEnterPin2
            // 
            this.textBoxEnterPin2.Location = new System.Drawing.Point(314, 28);
            this.textBoxEnterPin2.Name = "textBoxEnterPin2";
            this.textBoxEnterPin2.PasswordChar = '*';
            this.textBoxEnterPin2.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnterPin2.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Enter Pin:";
            // 
            // textBoxRoomBooked2
            // 
            this.textBoxRoomBooked2.Location = new System.Drawing.Point(113, 28);
            this.textBoxRoomBooked2.Name = "textBoxRoomBooked2";
            this.textBoxRoomBooked2.Size = new System.Drawing.Size(100, 22);
            this.textBoxRoomBooked2.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Room Booked:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBoxNotRobot);
            this.tabPage4.Controls.Add(this.buttonSubmit4);
            this.tabPage4.Controls.Add(this.textBoxPassword);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.textBoxAdminName);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(794, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotRobot
            // 
            this.checkBoxNotRobot.AutoSize = true;
            this.checkBoxNotRobot.Location = new System.Drawing.Point(339, 140);
            this.checkBoxNotRobot.Name = "checkBoxNotRobot";
            this.checkBoxNotRobot.Size = new System.Drawing.Size(109, 20);
            this.checkBoxNotRobot.TabIndex = 23;
            this.checkBoxNotRobot.Text = "I am not robot";
            this.checkBoxNotRobot.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit4
            // 
            this.buttonSubmit4.Location = new System.Drawing.Point(354, 166);
            this.buttonSubmit4.Name = "buttonSubmit4";
            this.buttonSubmit4.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit4.TabIndex = 22;
            this.buttonSubmit4.Text = "Submit";
            this.buttonSubmit4.UseVisualStyleBackColor = true;
            this.buttonSubmit4.Click += new System.EventHandler(this.buttonSubmit4_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(85, 77);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(118, 22);
            this.textBoxPassword.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "Password:";
            // 
            // textBoxAdminName
            // 
            this.textBoxAdminName.Location = new System.Drawing.Point(103, 28);
            this.textBoxAdminName.Name = "textBoxAdminName";
            this.textBoxAdminName.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdminName.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Admin Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Hotel Management System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBoxConfirm;
        private System.Windows.Forms.Button buttonSubmit1;
        private System.Windows.Forms.TextBox textBoxReenterPin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSetPin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAdditionalInformation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRoomToBook;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSubmit2;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEnterPin1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRoomBooked1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSubmit3;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxEnterPin2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxRoomBooked2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBoxNotRobot;
        private System.Windows.Forms.Button buttonSubmit4;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxAdminName;
        private System.Windows.Forms.Label label17;
    }
}

