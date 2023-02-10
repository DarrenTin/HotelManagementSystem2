using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePickerFromDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerFromDate.CustomFormat = "yyyy MMM dd, ddd";
            dateTimePickerFromDate.MinDate = DateTime.Now;
            dateTimePickerFromDate.MaxDate = DateTime.Now.AddDays(7);

            dateTimePickerToDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerToDate.CustomFormat = "yyyy MMM dd, ddd";
            dateTimePickerToDate.MinDate = DateTime.Now.AddDays(1);
            dateTimePickerToDate.MaxDate = DateTime.Now.AddDays(30);
        }

        public class CustomerForm
        {
            public int No { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string RoomToBook { get; set; }
            public string FromDate { get; set; }
            public string ToDate { get; set; }
            public string AddInfo { get; set; }
            public string Pin { get; set; } // set and reset become 1
            public string Status { get; set; }

        }

        public class FeedbackForm
        {
            public int No { get; set; }
            public string CheckedOutRoom { get; set; }
            public string Feedback { get; set; }
        }

        public class CancelForm
        {
            public int No { get; set; }
            public string CancelledRoom { get; set; }
            public string Reason { get; set; }
        }

        List<CustomerForm> customerList { get; set; } = new List<CustomerForm>();
        List<FeedbackForm> feedbackList { get; set; } = new List<FeedbackForm>();
        List<CancelForm> cancelList { get; set; } = new List<CancelForm>();
        Form2 f2 = new Form2();
        int No = 1;
        string defaultAdminName = "admin";
        string defaultAdminPassword = "password";

        private void buttonSubmit1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFirstName.Text)
                && !string.IsNullOrWhiteSpace(textBoxLastName.Text)
                && (!string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text)
                || !string.IsNullOrWhiteSpace(textBoxEmail.Text)) // at least 1 contact
                && !string.IsNullOrWhiteSpace(textBoxRoomToBook.Text)
                && !string.IsNullOrWhiteSpace(textBoxSetPin.Text)
                && !string.IsNullOrWhiteSpace(textBoxReenterPin.Text)
                && textBoxSetPin.Text == textBoxReenterPin.Text
                && checkBoxConfirm.Checked)
            {

                //if (true) {

                //clear default value
                if (textBoxFirstName.Text == "e.g. Albert") textBoxFirstName.Text = "";
                if (textBoxLastName.Text == "e.g. Einstein") textBoxLastName.Text = "";
                if (textBoxPhoneNumber.Text == "e.g. 01234567890") textBoxPhoneNumber.Text = "";
                if (textBoxEmail.Text == "e.g. example@gmail.com") textBoxEmail.Text = "";
                if (textBoxRoomToBook.Text == "1~100") textBoxRoomToBook.Text = "";
                if (textBoxAdditionalInformation.Text == "E.g. special request, breakfast, quiet room, promotion code, etc.") textBoxAdditionalInformation.Text = "";
                if (textBoxFeedback.Text == "Your feedback is important to us!  We will try our best to offer the most excellent experience!") textBoxFeedback.Text = "";
                if (textBoxReason.Text == "e.g. too expensive, found another hotel, other reasons") textBoxReason.Text = "";

                // all variable from form
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLastName.Text;
                string phoneNumber = textBoxPhoneNumber.Text;
                string email = textBoxEmail.Text;
                string roomToBook = textBoxRoomToBook.Text;
                string fromDate = dateTimePickerFromDate.Value.ToString("yyyy MMM dd, ddd");
                string toDate = dateTimePickerToDate.Value.ToString("yyyy MMM dd, ddd");
                string addInfo = textBoxAdditionalInformation.Text;
                string setPin = textBoxSetPin.Text;
                string reenterPin = textBoxReenterPin.Text;
                string confirm = checkBoxConfirm.Checked.ToString();

                // testing variable
                string testedVar = String.Format(
                    "{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}",
                    firstName, lastName, phoneNumber, email, roomToBook,
                    fromDate, toDate, addInfo, setPin, reenterPin, confirm);
                MessageBox.Show(testedVar, "Testing", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // add info to list
                customerList.Add(new CustomerForm
                {
                    No = No++,
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber,
                    Email = email,
                    RoomToBook = roomToBook,
                    FromDate = fromDate,
                    ToDate = toDate,
                    AddInfo = addInfo,
                    Pin = setPin,
                    Status = "Checked In",
                });

                DataTable dt1 = new DataTable();
                dt1.Columns.Add("No.");
                dt1.Columns.Add("FirstName");
                dt1.Columns.Add("LastName");
                dt1.Columns.Add("PhoneNumber");
                dt1.Columns.Add("Email");
                dt1.Columns.Add("RoomToBook");
                dt1.Columns.Add("FromDate");
                dt1.Columns.Add("ToDate");
                dt1.Columns.Add("AddInfo");
                dt1.Columns.Add("Pin");
                dt1.Columns.Add("Status");

                foreach (var sf in customerList)
                {
                    DataRow dr = dt1.NewRow();
                    dr[0] = sf.No;
                    dr[1] = sf.FirstName;
                    dr[2] = sf.LastName;
                    dr[3] = sf.PhoneNumber;
                    dr[4] = sf.Email;
                    dr[5] = sf.RoomToBook;
                    dr[6] = sf.FromDate;
                    dr[7] = sf.ToDate;
                    dr[8] = sf.AddInfo;
                    dr[9] = sf.Pin;
                    dr[10] = sf.Status;
                    dt1.Rows.Add(dr);
                }
                f2.dataGridView1.DataSource = dt1;
            } else
            {
                if(textBoxSetPin.Text != textBoxReenterPin.Text){
                    MessageBox.Show("Pins not match!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!checkBoxConfirm.Checked)
                {
                    MessageBox.Show("Please ensure the information provided is true and correct. ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please fill in all required info!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSubmit2_Click(object sender, EventArgs e)
        {
            // room to check out is existed
            bool roomExists = false;
            foreach (var customer in customerList)
            {
                if (customer.RoomToBook == textBoxRoomBooked1.Text 
                    && customer.Status == "Checked In"
                    && customer.Pin == textBoxEnterPin1.Text)
                {
                    roomExists = true;
                    break;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBoxRoomBooked1.Text)
                && !string.IsNullOrWhiteSpace(textBoxEnterPin1.Text)
                && roomExists)
            {

                //if (true) {
                //clear default value
                if (textBoxFeedback.Text == "Your feedback is important to us!  We will try our best to offer the most excellent experience!") textBoxFeedback.Text = "";

                string roomBookedCheckOut = textBoxRoomBooked1.Text;
                string enterPinCheckOut = textBoxEnterPin1.Text;
                string feedback = textBoxFeedback.Text;

                // testing variable
                string testedVar = String.Format("{0}\n{1}\n{2}", roomBookedCheckOut, enterPinCheckOut, feedback);
                MessageBox.Show(testedVar, "Testing", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // do some change in customerList
                f2.dataGridView1.Rows[Convert.ToInt32(roomBookedCheckOut) - 1].Cells[10].Value = "Checked Out";

                // add info to list
                feedbackList.Add(new FeedbackForm
                {
                    No = (from x in customerList
                          where x.RoomToBook == roomBookedCheckOut
                          select x.No).FirstOrDefault(),
                    CheckedOutRoom = roomBookedCheckOut,
                    Feedback = feedback,
                });

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("No.");
                dt2.Columns.Add("CheckedOutRoom");
                dt2.Columns.Add("Feedback");

                foreach (var sf in feedbackList)
                {
                    DataRow dr = dt2.NewRow();
                    dr[0] = sf.No;
                    dr[1] = sf.CheckedOutRoom;
                    dr[2] = sf.Feedback;
                    dt2.Rows.Add(dr);
                }
                f2.dataGridView2.DataSource = dt2;
            }
            else
            {
                if (!roomExists)
                {
                    MessageBox.Show("Room not found or pin not matched!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please fill in all required info!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSubmit3_Click(object sender, EventArgs e)
        {
            // room to check out is existed
            bool roomExists = false;
            foreach (var customer in customerList)
            {
                if (customer.RoomToBook == textBoxRoomBooked2.Text
                    && customer.Status == "Checked In"
                    && customer.Pin == textBoxEnterPin2.Text)
                {
                    roomExists = true;
                    break;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBoxRoomBooked2.Text)
                && !string.IsNullOrWhiteSpace(textBoxEnterPin2.Text)
                && roomExists)
            {
                // if(true){
                //clear default value
                if (textBoxReason.Text == "e.g. too expensive, found another hotel, other reasons") textBoxReason.Text = "";

                string roomBookedCancel = textBoxRoomBooked2.Text;
                string enterPinCancel = textBoxEnterPin2.Text;
                string reason = textBoxReason.Text;

                // testing variable
                string testedVar = String.Format("{0}\n{1}\n{2}", roomBookedCancel, enterPinCancel, reason);
                MessageBox.Show(testedVar, "Testing", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // do some change in customerList
                f2.dataGridView1.Rows[Convert.ToInt32(roomBookedCancel) - 1].Cells[10].Value = "Cancelled";

                // add info to list
                cancelList.Add(new CancelForm
                {
                    No = (from x in customerList
                          where x.RoomToBook == roomBookedCancel
                          select x.No).FirstOrDefault(),
                    CancelledRoom = roomBookedCancel,
                    Reason = reason,
                });

                DataTable dt3 = new DataTable();
                dt3.Columns.Add("No.");
                dt3.Columns.Add("CancelledRoom");
                dt3.Columns.Add("Reason");

                foreach (var sf in cancelList)
                {
                    DataRow dr = dt3.NewRow();
                    dr[0] = sf.No;
                    dr[1] = sf.CancelledRoom;
                    dr[2] = sf.Reason;
                    dt3.Rows.Add(dr);
                }
                f2.dataGridView3.DataSource = dt3;
            }
            else
            {
                if (!roomExists)
                {
                    MessageBox.Show("Room not found or pin not matched!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please fill in all required info!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSubmit4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAdminName.Text)
                && !string.IsNullOrWhiteSpace(textBoxPassword.Text)
                && textBoxAdminName.Text == defaultAdminName
                && textBoxPassword.Text == defaultAdminPassword
                && checkBoxNotRobot.Checked)
            {
                string adminName = textBoxAdminName.Text;
                string password = textBoxPassword.Text;
                string notRobot = checkBoxNotRobot.Checked.ToString();

                // testing variable
                string testedVar = String.Format("{0}\n{1}\n{2}", adminName, password, notRobot);
                    MessageBox.Show(testedVar, "Testing", MessageBoxButtons.OK, MessageBoxIcon.Information);

                f2.Show();
            }
            else
            {
                if (!checkBoxNotRobot.Checked)
                {
                    MessageBox.Show("Please prove that you are not a robot!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    MessageBox.Show("Incorrect admin name or admin password not matched!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "e.g. Albert")
            {
                textBoxFirstName.Text = "";
            }
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "e.g. Einstein")
            {
                textBoxLastName.Text = "";
            }
        }

        private void textBoxPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text == "e.g. 01234567890")
            {
                textBoxPhoneNumber.Text = "";
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "e.g. example@gmail.com")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxRoomToBook_Enter(object sender, EventArgs e)
        {
            if (textBoxRoomToBook.Text == "1~100")
            {
                textBoxRoomToBook.Text = "";
            }
        }

        private void textBoxAdditionalInformation_Enter(object sender, EventArgs e)
        {
            if (textBoxAdditionalInformation.Text == "E.g. special request, breakfast, quiet room, promotion code, etc.")
            {
                textBoxAdditionalInformation.Text = "";
            }
        }

        private void textBoxFeedback_Enter(object sender, EventArgs e)
        {
            if (textBoxFeedback.Text == "Your feedback is important to us!  We will try our best to offer the most excellent experience!")
            {
                textBoxFeedback.Text = "";
            }
        }

        private void textBoxReason_Enter(object sender, EventArgs e)
        {
            if (textBoxReason.Text == "e.g. too expensive, found another hotel, other reasons")
            {
                textBoxReason.Text = "";
            }
        }
    }
}
