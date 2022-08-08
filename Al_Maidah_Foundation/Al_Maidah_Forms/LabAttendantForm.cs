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
    public partial class LabAttendantForm : MaterialSkin.Controls.MaterialForm
    {
        LabAttendantsClass labAttendantClassObj = new LabAttendantsClass();

        //1. for only one instance we created it here....
        private static LabAttendantForm instance;

        //2. now create instance if its not created and don,t create another form if there is one
        //already created......... 
        public static LabAttendantForm GetLabAttendantFormInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new LabAttendantForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        private LabAttendantForm()
        {
            InitializeComponent();
        }

        public void myClearTextBoxes()
        {
            //so we cleared them by inserting null or nothing in all textboxes
            LabAttendentIdtxtBox.Text = "";
            NameTextBox_LabAtt.Text = "";
            PhonetextBox_LabAtt.Text = "";
            FeestextBox__LabAtt.Text = "";
            GendercomboBox_LabAtt.Text = "";

        }

        private void btnAdd_LabAtt_Click(object sender, EventArgs e)
        {
            labAttendantClassObj.Name = NameTextBox_LabAtt.Text;
            labAttendantClassObj.Phone_Number = PhonetextBox_LabAtt.Text;
            labAttendantClassObj.Lab_Attendant_Fees = int.Parse(FeestextBox__LabAtt.Text);
            labAttendantClassObj.Gender = GendercomboBox_LabAtt.Text;
            

            if (NameTextBox_LabAtt.Text == "")
            {
                MessageBox.Show("Name TextBox should not be null (-__-!) ");
                return;
            }
            if (PhonetextBox_LabAtt.Text == "")
            {
                MessageBox.Show("Phone NO TextBox should not be null (-__-!)");
                return;
            }




            //2.Now as we created first above    obj(contactClassObj) and then put the values to it i.e from the textboxes  
            //now we will call the insert method that we created in the contactClass for Inserting the data into database
            bool successfullyInserted = labAttendantClassObj.Insert(labAttendantClassObj);
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
            DataTable dt = labAttendantClassObj.Select();
            //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
            dataGridView_LabAtt.DataSource = dt;
        }

        private void btnDelete_LabAtt_Click(object sender, EventArgs e)
        {

            if (LabAttendentIdtxtBox.Text == "")
            {

                MessageBox.Show("Select a Record to Delete (@_@/)", "Warning");
                return;
            }

            labAttendantClassObj.ID = Convert.ToInt32(LabAttendentIdtxtBox.Text);

            bool successfullyDeleted = labAttendantClassObj.Delete(labAttendantClassObj);
            DialogResult d = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (successfullyDeleted == true)
                {
                    MessageBox.Show(" Record Successfully Deletedted(@_@/)");

                    //so additionally we need to update or refresh the DataGridView
                    //so we will call the Select Method that we created in contactClass for getting data from the database
                    //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                    DataTable dt = labAttendantClassObj.Select();
                    //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                    dataGridView_LabAtt.DataSource = dt;

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

        private void btnUpdate_LabAtt_Click(object sender, EventArgs e)
        {
            if (LabAttendentIdtxtBox.Text == "")
            {

                MessageBox.Show("Select a Record to Update (@_@/)", "Warning");
                return;
            }

            labAttendantClassObj.ID = int.Parse(LabAttendentIdtxtBox.Text);

            labAttendantClassObj.Name = NameTextBox_LabAtt.Text;
            labAttendantClassObj.Phone_Number = PhonetextBox_LabAtt.Text;
            labAttendantClassObj.Lab_Attendant_Fees = int.Parse(FeestextBox__LabAtt.Text);
            labAttendantClassObj.Gender = GendercomboBox_LabAtt.Text;


            //now update the data to the database as we have already created method for it in contactClass so use it
            //so pass it the contactClassObj in which we move data above
            bool successfullyUpdated = labAttendantClassObj.Update(labAttendantClassObj);

            if (successfullyUpdated == true)
            {
                MessageBox.Show(" Record Successfully Updated(@_@/)");

                //so additionally we need to update or refresh the DataGridView
                //so we will call the Select Method that we created in contactClass for getting data from the database
                //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                DataTable dt = labAttendantClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridView_LabAtt.DataSource = dt;

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

        private void btnClear_LabAtt_Click(object sender, EventArgs e)
        {
            myClearTextBoxes();
        }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        private void txtBoxSearchLabAtt_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtBoxSearchLabAtt.Text;

            SqlConnection connectSql = new SqlConnection(myconnstring);


            //follwoing is the code for the check boxes in the Doctor UI this checks that how many check boxes
            //are selected and according to that query is generated and after wards passed to sqlAdapter
            string query = "";
            int count = 0;
            if (NameRadioButtonLabAtt.Checked)
            {
                query = "SELECT * FROM Lab_Attendant WHERE Name LIKE '%" + keyWord + "%'";
                
            }
            else if (GenderradioButtonLabAtt.Checked)
            {
                query = "SELECT * FROM Lab_Attendant WHERE Gender LIKE '%" + keyWord + "%'";
    
            }
            else if (FeesradioButtonLabAtt.Checked)
            {
                query = "SELECT * FROM Lab_Attendant WHERE Lab_Attendant_Fees LIKE '%" + keyWord + "%'";
            }
            else if (PhoneNoradioButtonLabAtt.Checked)
            {
                query = "SELECT * FROM Lab_Attendant WHERE Phone_Number LIKE '%" + keyWord + "%'";
            }
            else
            { //we will think as all checked
                query = "SELECT * FROM Lab_Attendant WHERE Name LIKE '%" + keyWord + "%' OR Gender LIKE '%" + keyWord + "%' OR Lab_Attendant_Fees LIKE '%" + keyWord + "%' OR Phone_Number LIKE '%" + keyWord + "%'";
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, connectSql);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView_LabAtt.DataSource = dt;

        }

        private void LabAttendantForm_Load(object sender, EventArgs e)
        {
            //loading data to grid view
            DataTable dt = labAttendantClassObj.Select();

            dataGridView_LabAtt.DataSource = dt;


            //loaing data to GenderCombo Box
            GendercomboBox_LabAtt.Items.Clear();
            SqlConnection connectSql = new SqlConnection(myconnstring);
            connectSql.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Gender_Type FROM Gender", connectSql);
            DataTable dt1 = new DataTable();

            adapter.Fill(dt1);

            //what this does is select a row(i.e using dr ) then its column DepName i.e ( dr["DepName"] ) and place 
            //it in the comboBox......
            foreach (DataRow dr in dt1.Rows)
            {
                GendercomboBox_LabAtt.Items.Add(dr["Gender_Type"].ToString());
            }
            
        }

        private void dataGridView_LabAtt_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowToUpdate = e.RowIndex;
            
            LabAttendentIdtxtBox.Text = dataGridView_LabAtt.Rows[rowToUpdate].Cells[0].Value.ToString();

            NameTextBox_LabAtt.Text = dataGridView_LabAtt.Rows[rowToUpdate].Cells[1].Value.ToString();
            PhonetextBox_LabAtt.Text = dataGridView_LabAtt.Rows[rowToUpdate].Cells[2].Value.ToString();
            FeestextBox__LabAtt.Text = dataGridView_LabAtt.Rows[rowToUpdate].Cells[3].Value.ToString();
            GendercomboBox_LabAtt.Text = dataGridView_LabAtt.Rows[rowToUpdate].Cells[4].Value.ToString();

        }

        //following method that will be auto called when a key is pressed from keyboard 
        // this method allows user to only enter the digigts not any other character
        //but allows only backspace with 8 and del with 46 key value also
        private void PhonetextBox_LabAtt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void FeestextBox__LabAtt_KeyPress(object sender, KeyPressEventArgs e)
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
