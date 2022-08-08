using Al_Maidah_Foundation.Al_Maidah_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Maidah_Foundation.Al_Maidah_Forms
{
    public partial class DonationsForm : MaterialSkin.Controls.MaterialForm
    {

        DonationsClass donationClassObj = new DonationsClass();

        //1. for only one instance we created it here....
        private static DonationsForm instance;

        //2. now create instance if its not created and don,t create another form if there is one
        //already created......... 
        public static DonationsForm GetDonationFormInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new DonationsForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }


        private DonationsForm()
        {
            InitializeComponent();
        }

        public void myClearTextBoxes()
        {
            //so we cleared them by inserting null or nothing in all textboxes
            txtBoxDonId.Text = "";
            NameTextBox_Donation.Text = "";
            PhonetextBox_Donation.Text = "";
            AmountTextBox_Donation.Text = "";
            othertextBox_Donation.Text = "";
            DatedatePicker_Donation.Text = "";

        }

        private void btnAdd_Donation_Click(object sender, EventArgs e)
        {
            donationClassObj.Name = NameTextBox_Donation.Text;
            donationClassObj.Phone_Number = PhonetextBox_Donation.Text;
            donationClassObj.Donation_Type_Amount = int.Parse(AmountTextBox_Donation.Text);
            donationClassObj.Donation_Type_Other = othertextBox_Donation.Text;
            donationClassObj.Donation_Date = DateTime.Parse(DatedatePicker_Donation.Text);


            if (NameTextBox_Donation.Text == "")
            {
                MessageBox.Show("Name TextBox should not be null (-__-!) ");
                return;
            }

            //2.Now as we created first above    obj(contactClassObj) and then put the values to it i.e from the textboxes  
            //now we will call the insert method that we created in the contactClass for Inserting the data into database
            bool successfullyInserted = donationClassObj.Insert(donationClassObj);
            //as insert method gets contactClassObj and returns bool(which if true tells data inserted in database false not inserted)
            if (successfullyInserted == true)
            {
                MessageBox.Show("New Record Successfully Inserted(@_@/)");

                //as we add data to textboxes and press ADD button the now data will be inserted to dataBase and
                //displayed in the gridview but the problem is that the data stays in the textboxes after inserted
                //so to auto remove the data after the data is inserted we will call the myClearTextBoxes() method we creted below ...
                myClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Failed to add new Record(-_-?). Try Again. ");
            }

            //3. Now Load all the Data to the DataGridView
            //so we will call the Select Method that we created in contactClass for getting data from the database
            //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
            DataTable dt = donationClassObj.Select();
            //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
            dataGridView_Donation.DataSource = dt;
        }

        private void btnDelete_Donation_Click(object sender, EventArgs e)
        {
            if (txtBoxDonId.Text == "")
            {

                MessageBox.Show("Select a Record to Delete (@_@/)", "Warning");
                return;
            }

            donationClassObj.Receipt_Number = Convert.ToInt32(txtBoxDonId.Text);

            bool successfullyDeleted = donationClassObj.Delete(donationClassObj);

            DialogResult d = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (successfullyDeleted == true)
                {
                    MessageBox.Show(" Record Successfully Deletedted(@_@/)");

                    //so additionally we need to update or refresh the DataGridView
                    //so we will call the Select Method that we created in contactClass for getting data from the database
                    //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                    DataTable dt = donationClassObj.Select();
                    //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                    dataGridView_Donation.DataSource = dt;

                    //as we Delete data the problem is that the data stays in the textboxes after deleted
                    //so to auto remove the data after the data i.e deleted we will call the ClearTextBoxes() method we creted
                    myClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Failed to Delete Record(-_-?). Try Again!. ");
                }

            }
        }

        private void btnUpdate_Donation_Click(object sender, EventArgs e)
        {
            if (txtBoxDonId.Text == "")
            {

                MessageBox.Show("Select a Record to Update (@_@/)", "Warning");
                return;
            }

            donationClassObj.Receipt_Number = int.Parse(txtBoxDonId.Text);
            
            donationClassObj.Name = NameTextBox_Donation.Text;
            donationClassObj.Phone_Number = PhonetextBox_Donation.Text;
            donationClassObj.Donation_Type_Amount = int.Parse(AmountTextBox_Donation.Text);
            donationClassObj.Donation_Type_Other = othertextBox_Donation.Text;
            donationClassObj.Donation_Date = DateTime.Parse(DatedatePicker_Donation.Text);


            //now update the data to the database as we have already created method for it in contactClass so use it
            //so pass it the contactClassObj in which we move data above
            bool successfullyUpdated = donationClassObj.Update(donationClassObj);

            if (successfullyUpdated == true)
            {
                MessageBox.Show(" Record Successfully Updated(@_@/)");

                //so additionally we need to update or refresh the DataGridView
                //so we will call the Select Method that we created in contactClass for getting data from the database
                //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                DataTable dt = donationClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridView_Donation.DataSource = dt;

                //as we update data to textboxes and press Update button then now data will be inserted to dataBase and
                //displayed in the gridview but the problem is that the data stays in the textboxes after updated
                //so to auto remove the data after the data is updated we will call the ClearTextBoxes() method we creted
                myClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Failed to Update Record(-_-?). Try Again!. ");
            }
        }

        private void btnClear_Donation_Click(object sender, EventArgs e)
        {
            myClearTextBoxes();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void txtBoxSearchDonation_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtBoxSearchDonation.Text;

            SqlConnection connectSql = new SqlConnection(myconnstring);


            //follwoing is the code for the check boxes in the Doctor UI this checks that how many check boxes
            //are selected and according to that query is generated and after wards passed to sqlAdapter
            string query = "";
            int count = 0;
            if (NameRadioButtonDon.Checked)
            {
                query = "SELECT * FROM Donation WHERE Name LIKE '%" + keyWord + "%'";

            }
            else if (OtherTyperadioButtonDon.Checked)
            {
                query = "SELECT * FROM Donation WHERE Donation_Type_Other LIKE '%" + keyWord + "%'";
         
            }
            else if (DateradioButtonDon.Checked)
            {
                query = "SELECT * FROM Donation WHERE Donation_Date LIKE '%" + keyWord + "%'";
            }
            else
            { //we will think as all checked
                query = "SELECT * FROM Donation WHERE Name LIKE '%" + keyWord + "%' OR Donation_Type_Other LIKE '%" + keyWord + "%' OR Donation_Date LIKE '%" + keyWord + "%'";
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, connectSql);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView_Donation.DataSource = dt;
        }

        private void dataGridView_Donation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowToUpdate = e.RowIndex;
  
            txtBoxDonId.Text = dataGridView_Donation.Rows[rowToUpdate].Cells[0].Value.ToString();
            
            NameTextBox_Donation.Text = dataGridView_Donation.Rows[rowToUpdate].Cells[1].Value.ToString();
            PhonetextBox_Donation.Text = dataGridView_Donation.Rows[rowToUpdate].Cells[5].Value.ToString();
            AmountTextBox_Donation.Text = dataGridView_Donation.Rows[rowToUpdate].Cells[2].Value.ToString();
            othertextBox_Donation.Text = dataGridView_Donation.Rows[rowToUpdate].Cells[3].Value.ToString();
            DatedatePicker_Donation.Text = dataGridView_Donation.Rows[rowToUpdate].Cells[4].Value.ToString();
            
        }

        private void DonationsForm_Load(object sender, EventArgs e)
        {
                        //loading data to grid view
            DataTable dt = donationClassObj.Select();

            dataGridView_Donation.DataSource = dt;
            
        }

        //following method that will be auto called when a key is pressed from keyboard 
        // this method allows user to only enter the digigts not any other character
        //but allows only backspace with 8 and del with 46 key value also

        private void AmountTextBox_Donation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //get what key is pressed convert it to char
            char ch = e.KeyChar;
            //check if character is not digit and backspace and del key
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                //then ignore it i.e don,t enter it in the text box
                e.Handled = true;
            }
            //if digit or backspace or del key so it will be entered

        }

        //following method that will be auto called when a key is pressed from keyboard 
        // this method allows user to only enter the digigts not any other character
        //but allows only backspace with 8 and del with 46 key value also

        private void PhonetextBox_Donation_KeyPress(object sender, KeyPressEventArgs e)
        {

            //get what key is pressed convert it to char
            char ch = e.KeyChar;
            //check if character is not digit and backspace and del key
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                //then ignore it i.e don,t enter it in the text box
                e.Handled = true;
            }
            //if digit or backspace or del key so it will be entered

        }
    }
}
