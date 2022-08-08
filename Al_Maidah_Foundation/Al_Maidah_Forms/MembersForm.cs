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

namespace Al_Maidah_Foundation
{
    public partial class MembersForm : MaterialSkin.Controls.MaterialForm
    {
        MembersClass memberClassObj = new MembersClass();

        //1. for only one instance we created it here....
        private static MembersForm instance;
        
        //2. now create instance if its not created and don,t create another form if there is one
        //already created......... 
        public static MembersForm GetMembersFormInstance() {

            if (instance == null || instance.IsDisposed)
            {
                instance = new MembersForm();
            }
            else {
                instance.BringToFront();
            }
            return instance;
        } 

        private MembersForm()
        {
            InitializeComponent();
        }

            public void myClearTextBoxes()
            {
                //so we cleared them by inserting null or nothing in all textboxes
                txtBoxMemId.Text = "";
                FirstNameTextBox_Mem.Text = "";
                LastNametextBox_Mem.Text = "";
                AddresstextBox_Mem.Text = "";
                CNICtextBox_Mem.Text = "";
                PhonetextBox_Mem.Text = "";
                BloodGrouptextBox_Mem.Text = "";
                DOBdatePicker_Mem.Text = "";
                GendercomboBox_Mem.Text = "";

            }


            private void MembersForm_Load(object sender, EventArgs e)
            {
                //Load all the Data to the DataGridView
                //so we will call the Select Method that we created in contactClass for getting data from the database
                //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                DataTable dt = memberClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridViewMem.DataSource = dt;
                // DataSource also gets the data from dataGridView
            
                //Following is the code for the GenderComboBox in the UI what this does is retrieve Gender_Type from Gender(Table)
                //and place them in this comboBox
                GendercomboBox_Mem.Items.Clear();
                SqlConnection connectSql = new SqlConnection(myconnstring);
                connectSql.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Gender_Type FROM Gender", connectSql);
                DataTable dt1 = new DataTable();

                adapter.Fill(dt1);

                //what this does is select a row(i.e using dr ) then its column DepName i.e ( dr["DepName"] ) and place 
                //it in the comboBox......
                foreach (DataRow dr in dt1.Rows)
                {
                    GendercomboBox_Mem.Items.Add(dr["Gender_Type"].ToString());
                }
            }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            memberClassObj.First_Name = FirstNameTextBox_Mem.Text;
            memberClassObj.Last_Name = LastNametextBox_Mem.Text;
            memberClassObj.Phone_Number = PhonetextBox_Mem.Text;
            memberClassObj.Address = AddresstextBox_Mem.Text;
            memberClassObj.Date_Of_Birth = DateTime.Parse(DOBdatePicker_Mem.Text);
            memberClassObj.Blood_Group = BloodGrouptextBox_Mem.Text;
            memberClassObj.Date_Time = DateTime.Parse(JoiningdateTimePicker.Text);
            memberClassObj.Gender = GendercomboBox_Mem.Text;
            memberClassObj.CNIC = CNICtextBox_Mem.Text;


            if (FirstNameTextBox_Mem.Text == "")
            {
                MessageBox.Show("FirstName TextBox should not be null (-__-!) ");
                return;
            }
            if (LastNametextBox_Mem.Text == "")
            {
                MessageBox.Show("LastName TextBox should not be null (-__-!)");
                return;
            }
            if (PhonetextBox_Mem.Text == "")
            {
                MessageBox.Show("Phone No TextBox should not be null (-__-!)");
                return;
            }



            //2.Now as we created first above obj(contactClassObj) and then put the values to it i.e from the textboxes  
            //now we will call the insert method that we created in the contactClass for Inserting the data into database
            bool successfullyInserted = memberClassObj.Insert(memberClassObj);
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
                DataTable dt = memberClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridViewMem.DataSource = dt;
            }

        private void btnDeleteMem_Click(object sender, EventArgs e)
        {

            if (txtBoxMemId.Text == "")
            {

                MessageBox.Show("Select a Record to Delete (@_@/)", "Warning");
                return;
            }

            //So whwn the Delete button is clicked  
            //first get data(ContactID) from textbox(txtBoxContactId) and convert to int
            memberClassObj.Form_Number = Convert.ToInt32(txtBoxMemId.Text);

            //now Delete the data from the database as we have already created method for it in contactClass so use it
            //so pass it the contactClassObj in which we move data above
            bool successfullyDeleted = memberClassObj.Delete(memberClassObj);
            DialogResult d = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (successfullyDeleted == true)
                {
                    MessageBox.Show(" Record Successfully Deletedted(@_@/)");

                    //so additionally we need to update or refresh the DataGridView
                    //so we will call the Select Method that we created in contactClass for getting data from the database
                    //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                    DataTable dt = memberClassObj.Select();
                    //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                    dataGridViewMem.DataSource = dt;

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
            private void btnUpdateMem_Click(object sender, EventArgs e)
            {

            if (txtBoxMemId.Text == "")
            {

                MessageBox.Show("Select a Record to Update (@_@/)", "Warning");
                return;
            }

            //So whwn the update button is clicked  
            //first get data from text box and convert to int if needed and then pass it to contactClassObj 

            memberClassObj.Form_Number = int.Parse(txtBoxMemId.Text);
                memberClassObj.First_Name = FirstNameTextBox_Mem.Text;
                memberClassObj.Last_Name = LastNametextBox_Mem.Text;
                memberClassObj.Phone_Number = PhonetextBox_Mem.Text;
                memberClassObj.Address = AddresstextBox_Mem.Text;
                memberClassObj.Date_Of_Birth = DateTime.Parse(DOBdatePicker_Mem.Text);
                memberClassObj.Blood_Group = BloodGrouptextBox_Mem.Text;
                memberClassObj.Date_Time = DateTime.Parse(JoiningdateTimePicker.Text);
                memberClassObj.Gender = GendercomboBox_Mem.Text;
                memberClassObj.CNIC = CNICtextBox_Mem.Text;

                 
                

                //now update the data to the database as we have already created method for it in contactClass so use it
                //so pass it the contactClassObj in which we move data above
                bool successfullyUpdated = memberClassObj.Update(memberClassObj);

                if (successfullyUpdated == true)
                {
                    MessageBox.Show(" Record Successfully Updated(@_@/)");
                    
                    //so additionally we need to update or refresh the DataGridView
                    //so we will call the Select Method that we created in contactClass for getting data from the database
                    //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                    DataTable dt = memberClassObj.Select();
                    //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                    dataGridViewMem.DataSource = dt;

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

            private void btnClearMem_Click(object sender, EventArgs e)
            {
                myClearTextBoxes();
            }
        
            private void dataGridViewMem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                int rowToUpdate = e.RowIndex;
              
                txtBoxMemId.Text = dataGridViewMem.Rows[rowToUpdate].Cells[0].Value.ToString();
                FirstNameTextBox_Mem.Text = dataGridViewMem.Rows[rowToUpdate].Cells[1].Value.ToString();
                LastNametextBox_Mem.Text = dataGridViewMem.Rows[rowToUpdate].Cells[2].Value.ToString();
                PhonetextBox_Mem.Text = dataGridViewMem.Rows[rowToUpdate].Cells[5].Value.ToString();
                AddresstextBox_Mem.Text = dataGridViewMem.Rows[rowToUpdate].Cells[4].Value.ToString();
                DOBdatePicker_Mem.Text = dataGridViewMem.Rows[rowToUpdate].Cells[6].Value.ToString();
                BloodGrouptextBox_Mem.Text = dataGridViewMem.Rows[rowToUpdate].Cells[7].Value.ToString();
                JoiningdateTimePicker.Text = dataGridViewMem.Rows[rowToUpdate].Cells[8].Value.ToString();
                GendercomboBox_Mem.Text = dataGridViewMem.Rows[rowToUpdate].Cells[9].Value.ToString();
                CNICtextBox_Mem.Text = dataGridViewMem.Rows[rowToUpdate].Cells[3].Value.ToString();

            }

            static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

            private void txtBoxSearchMem_TextChanged(object sender, EventArgs e)
            {
                string keyWord = txtBoxSearchMem.Text;

                //step 1: get database connection.
                SqlConnection connectSql = new SqlConnection(myconnstring);



            //follwoing is the code for the check boxes in the Members UI this checks that how many check boxes
            //are selected and according to that query is generated and after wards passed to sqlAdapter
            string query = "";
            int count = 0;
            if (FirstNameRadioButtonMem.Checked)
            {
                query = "SELECT * FROM Member WHERE First_Name LIKE '%" + keyWord + "%'";
               
            }
            else if (LastNameradioButtonMem.Checked)
            {
                query = "SELECT * FROM Member WHERE Last_Name LIKE '%" + keyWord + "%'";
               
            }
            else if (BloodGroupradioButtonMem.Checked)
            {
                query = "SELECT * FROM Member WHERE Blood_Group LIKE '%" + keyWord + "%'";
            }
            else if (AddressradioButtonMem.Checked)
            {
                query = "SELECT * FROM Member WHERE Address LIKE '%" + keyWord + "%'";

            }
            else if (GenderradioButtonMem.Checked)
            {
                query = "SELECT * FROM Member WHERE Gender LIKE '%" + keyWord + "%'";
            }
            else
            { //we will think as all checked
                query = "SELECT * FROM Member WHERE First_Name LIKE '%" + keyWord + "%' OR Last_Name LIKE '%" + keyWord + "%' OR Blood_Group LIKE '%" + keyWord + "%'OR Address LIKE '%" + keyWord + "%' OR Gender LIKE '%" + keyWord + "%'";
            }
            
            //now create sql dataAdapter to pass query and connection(telling which database you want to run this query)
            //folloing is the short way you can also create seperate obj of query and pass them
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectSql);
                //then create obj of dataTable for storing the data or result of the query in the adapter.
                DataTable dt = new DataTable();

                //Now data or result against the query in the adapter is moved to the dataTable(dt)
                adapter.Fill(dt);
                //and is displayed in the DataGrid...
                dataGridViewMem.DataSource = dt;

            }

        //following method that will be auto called when a key is pressed from keyboard 
        // this method allows user to only enter the digigts not any other character
        //but allows only backspace with 8 and del with 46 key value also

        private void PhonetextBox_Mem_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridViewMem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



