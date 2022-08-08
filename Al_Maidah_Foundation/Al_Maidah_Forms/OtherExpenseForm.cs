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
    public partial class OtherExpenseForm : MaterialSkin.Controls.MaterialForm
    {

        OtherExpenseClass otherExpClassObj = new OtherExpenseClass();

        //1. for only one instance we created it here....
        private static OtherExpenseForm instance;

        //2. now create instance if its not created and don,t create another form if there is one
        //already created......... 
        public static OtherExpenseForm GetExpenseFormInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new OtherExpenseForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }


        public OtherExpenseForm()
        {
            InitializeComponent();
        }

        public void myClearTextBoxes()
        {
            //so we cleared them by inserting null or nothing in all textboxes
            txtBoxExpenseId.Text = "";
            DetailTextBox_Expense.Text = "";
            AmountTextBox_Expense.Text = "";
            DatedatePicker_Expense.Text = "";

        }

        private void btnAdd_Expense_Click(object sender, EventArgs e)
        {
            otherExpClassObj.Amount = int.Parse(AmountTextBox_Expense.Text);
            otherExpClassObj.Expense_Details = DetailTextBox_Expense.Text;
            otherExpClassObj.Expense_Date = DateTime.Parse(DatedatePicker_Expense.Text);


            if (AmountTextBox_Expense.Text == "")
            {
                MessageBox.Show("Amount TextBox should not be null (-__-!) ");
                return;
            }

            //2.Now as we created first above    obj(contactClassObj) and then put the values to it i.e from the textboxes  
            //now we will call the insert method that we created in the contactClass for Inserting the data into database
            bool successfullyInserted = otherExpClassObj.Insert(otherExpClassObj);
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
            DataTable dt = otherExpClassObj.Select();
            //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
            dataGridView_Expense.DataSource = dt;
        }
        private void btnUpdate_Expense_Click(object sender, EventArgs e)
        {

            if (txtBoxExpenseId.Text == "")
            {

                MessageBox.Show("Select a Record to Update (@_@/)", "Warning");
                return;
            }
            otherExpClassObj.ID = int.Parse(txtBoxExpenseId.Text);

            otherExpClassObj.Amount = int.Parse(AmountTextBox_Expense.Text);
            otherExpClassObj.Expense_Details = DetailTextBox_Expense.Text;
            otherExpClassObj.Expense_Date = DateTime.Parse(DatedatePicker_Expense.Text);


            //now update the data to the database as we have already created method for it in contactClass so use it
            //so pass it the contactClassObj in which we move data above
            bool successfullyUpdated = otherExpClassObj.Update(otherExpClassObj);

            if (successfullyUpdated == true)
            {
                MessageBox.Show(" Record Successfully Updated(@_@/)");

                //so additionally we need to update or refresh the DataGridView
                //so we will call the Select Method that we created in contactClass for getting data from the database
                //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                DataTable dt = otherExpClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridView_Expense.DataSource = dt;

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

        private void btnDelete_Expense_Click(object sender, EventArgs e)
        {

            if (txtBoxExpenseId.Text == "")
            {

                MessageBox.Show("Select a Record to Delete (@_@/)", "Warning");
                return;
            }

            otherExpClassObj.ID = Convert.ToInt32(txtBoxExpenseId.Text);

            bool successfullyDeleted = otherExpClassObj.Delete(otherExpClassObj);

            DialogResult d = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {


                if (successfullyDeleted == true)
                {
                    MessageBox.Show(" Record Successfully Deletedted(@_@/)");

                    //so additionally we need to update or refresh the DataGridView
                    //so we will call the Select Method that we created in contactClass for getting data from the database
                    //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                    DataTable dt = otherExpClassObj.Select();
                    //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                    dataGridView_Expense.DataSource = dt;

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
            private void btnClear_Expense_Click(object sender, EventArgs e)
        {
            myClearTextBoxes();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void txtBoxSearchDonation_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtBoxSearchExpense.Text;

            SqlConnection connectSql = new SqlConnection(myconnstring);


            //follwoing is the code for the check boxes in the Doctor UI this checks that how many check boxes
            //are selected and according to that query is generated and after wards passed to sqlAdapter
            string query = "";
            int count = 0;

            if (DetailsRadioButtonExp.Checked)
            {
                query = "SELECT * FROM Other_Expense WHERE Expense_Details LIKE '%" + keyWord + "%'";

            }
            else if (DateradioButtonExp.Checked)
            {
                query = "SELECT * FROM Other_Expense WHERE Expense_Date LIKE '%" + keyWord + "%'";

            }
            else
            { //we will think as all checked
                query = "SELECT * FROM Other_Expense WHERE Expense_Date LIKE '%" + keyWord + "%' OR Expense_Details LIKE '%" + keyWord + "%'";
            }
            
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectSql);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView_Expense.DataSource = dt;
        }
        private void OtherExpenseForm_Load(object sender, EventArgs e)
        {
            //loading data to grid view
            DataTable dt = otherExpClassObj.Select();

            dataGridView_Expense.DataSource = dt;

        }

        private void dataGridView_Expense_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowToUpdate = e.RowIndex;

            txtBoxExpenseId.Text = dataGridView_Expense.Rows[rowToUpdate].Cells[0].Value.ToString();

            AmountTextBox_Expense.Text = dataGridView_Expense.Rows[rowToUpdate].Cells[3].Value.ToString();
            DetailTextBox_Expense.Text = dataGridView_Expense.Rows[rowToUpdate].Cells[1].Value.ToString();
            DatedatePicker_Expense.Text = dataGridView_Expense.Rows[rowToUpdate].Cells[2].Value.ToString();

        }

        //following method that will be auto called when a key is pressed from keyboard 
        // this method allows user to only enter the digigts not any other character
        //but allows only backspace with 8 and del with 46 key value also

        private void AmountTextBox_Expense_KeyPress(object sender, KeyPressEventArgs e)
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
