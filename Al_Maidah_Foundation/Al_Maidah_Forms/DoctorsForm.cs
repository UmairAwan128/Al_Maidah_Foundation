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
    public partial class DoctorsForm : MaterialSkin.Controls.MaterialForm
    {

        DoctorsClass doctorClassObj = new DoctorsClass();

        //1. for only one instance we created it here....
        private static DoctorsForm instance;

        //2. now create instance if its not created and don,t create another form if there is one
        //already created......... 
        public static DoctorsForm GetDocotrsFormInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new DoctorsForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        private DoctorsForm()
        {
            InitializeComponent();
        }


        public void myClearTextBoxes()
        {
            //so we cleared them by inserting null or nothing in all textboxes
            DoctorIdtxtBox.Text = "";

            NameTextBox_Doc.Text = "";
            PhonetextBox_Doc.Text = "";
            DocFeestextBox_Doc.Text = "";
            DepcomboBox_Doc.Text = "";
            GendercomboBox_Doc.Text = "";
            
        }


        private void btnAdd_Doc_Click(object sender, EventArgs e)
        {
            doctorClassObj.Name = NameTextBox_Doc.Text;
            doctorClassObj.Phone_Number = PhonetextBox_Doc.Text;
            doctorClassObj.Doctor_Fees = int.Parse(DocFeestextBox_Doc.Text);
            doctorClassObj.Gender = GendercomboBox_Doc.Text;
            doctorClassObj.Phone_Number = PhonetextBox_Doc.Text;
            doctorClassObj.Medical_Dep = DepcomboBox_Doc.Text;

            

            if (NameTextBox_Doc.Text == "")
            {
                MessageBox.Show("Name TextBox should not be null (-__-!) ");
                return;
            }
            if (PhonetextBox_Doc.Text == "")
            {
                MessageBox.Show("Phone NO TextBox should not be null (-__-!)");
                return;
            }




            //2.Now as we created first above    obj(contactClassObj) and then put the values to it i.e from the textboxes  
            //now we will call the insert method that we created in the contactClass for Inserting the data into database
            bool successfullyInserted = doctorClassObj.Insert(doctorClassObj);
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
            DataTable dt = doctorClassObj.Select();
            //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
            dataGridView_Doc.DataSource = dt;
        }

        private void btnDelete_Doc_Click(object sender, EventArgs e)
        {
            if (DoctorIdtxtBox.Text == "")
            {

                MessageBox.Show("Select a Record to Delete (@_@/)", "Warning");
                return;
            }

            doctorClassObj.ID = Convert.ToInt32(DoctorIdtxtBox.Text);

            bool successfullyDeleted = doctorClassObj.Delete(doctorClassObj);

            DialogResult d = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {


                if (successfullyDeleted == true)
                {
                    MessageBox.Show(" Record Successfully Deletedted(@_@/)");

                    //so additionally we need to update or refresh the DataGridView
                    //so we will call the Select Method that we created in contactClass for getting data from the database
                    //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                    DataTable dt = doctorClassObj.Select();
                    //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                    dataGridView_Doc.DataSource = dt;

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

        private void btnUpdate_Doc_Click(object sender, EventArgs e)
        {
            if (DoctorIdtxtBox.Text == "")
            {

                MessageBox.Show("Select a Record to Upadte (@_@/)", "Warning");
                return;
            }


            doctorClassObj.ID = int.Parse(DoctorIdtxtBox.Text);
            
            doctorClassObj.Name = NameTextBox_Doc.Text;
            doctorClassObj.Phone_Number = PhonetextBox_Doc.Text;
            doctorClassObj.Doctor_Fees = int.Parse(DocFeestextBox_Doc.Text);
            doctorClassObj.Gender = GendercomboBox_Doc.Text;
            doctorClassObj.Phone_Number = PhonetextBox_Doc.Text;
            doctorClassObj.Medical_Dep = DepcomboBox_Doc.Text;



            //now update the data to the database as we have already created method for it in contactClass so use it
            //so pass it the contactClassObj in which we move data above
            bool successfullyUpdated = doctorClassObj.Update(doctorClassObj);

            if (successfullyUpdated == true)
            {
                MessageBox.Show(" Record Successfully Updated(@_@/)");

                //so additionally we need to update or refresh the DataGridView
                //so we will call the Select Method that we created in contactClass for getting data from the database
                //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                DataTable dt = doctorClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridView_Doc.DataSource = dt;

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

        private void btnClear_Doc_Click(object sender, EventArgs e)
        {
            myClearTextBoxes();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        private void txtBoxSearchDoc_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtBoxSearchDoc.Text;

            SqlConnection connectSql = new SqlConnection(myconnstring);


            //follwoing is the code for the check boxes in the Doctor UI this checks that how many check boxes
            //are selected and according to that query is generated and after wards passed to sqlAdapter
            string query = "";
            int count = 0;
            if (NameRadioButtonDoc.Checked)
            {
                query = "SELECT * FROM Doctor WHERE Name LIKE '%" + keyWord + "%'";
            }
            else if (PhoneNoradioButtonDoc.Checked)
            {
                query = "SELECT * FROM Doctor WHERE Phone_Number LIKE '%" + keyWord + "%'";
        
            }
            else if (DepradioButtonDoc.Checked)
            {
                query = "SELECT * FROM Doctor WHERE Medical_Dep LIKE '%" + keyWord + "%'";
            }
            else if (GenderradioButtonPat.Checked)
            {
                query = "SELECT * FROM Doctor WHERE Gender LIKE '%" + keyWord + "%'";
            }
            else if (DocFeeradioButtonDoc.Checked)
            {
                query = "SELECT * FROM Doctor WHERE Doctor_Fees LIKE '%" + keyWord + "%'";
            }
            else
            { //we will think as all checked
                query = "SELECT * FROM Doctor WHERE Name LIKE '%" + keyWord + "%' OR Phone_Number LIKE '%" + keyWord + "%' OR Medical_Dep LIKE '%" + keyWord + "%' OR Gender LIKE '%" + keyWord + "%' OR Doctor_Fees LIKE '%" + keyWord + "%'";
            }

            
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectSql);
            
            DataTable dt = new DataTable();
            
            adapter.Fill(dt);
            dataGridView_Doc.DataSource = dt;

        }

        
        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            //loading data to grid view
            DataTable dt = doctorClassObj.Select();

            dataGridView_Doc.DataSource = dt;


           //loaing data to GenderCombo Box
            GendercomboBox_Doc.Items.Clear();
            SqlConnection connectSql = new SqlConnection(myconnstring);
            connectSql.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Gender_Type FROM Gender", connectSql);
            DataTable dt1 = new DataTable();

            adapter.Fill(dt1);

            //what this does is select a row(i.e using dr ) then its column DepName i.e ( dr["DepName"] ) and place 
            //it in the comboBox......
            foreach (DataRow dr in dt1.Rows)
            {
                GendercomboBox_Doc.Items.Add(dr["Gender_Type"].ToString());
            }
            
            //Loading data to Dep ComboBOx
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT Department_Name FROM Medical_Department", connectSql);
            DataTable dt2 = new DataTable();
            
            adapter1.Fill(dt2);

            //what this does is select a row(i.e using dr ) then its column DepName i.e ( dr["DepName"] ) and place 
            //it in the comboBox......
            foreach (DataRow dr in dt2.Rows)
            {
                DepcomboBox_Doc.Items.Add(dr["Department_Name"].ToString());
            }
        }

        private void dataGridView_Doc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowToUpdate = e.RowIndex;
            
            DoctorIdtxtBox.Text = dataGridView_Doc.Rows[rowToUpdate].Cells[0].Value.ToString();

            NameTextBox_Doc.Text = dataGridView_Doc.Rows[rowToUpdate].Cells[1].Value.ToString();
            PhonetextBox_Doc.Text = dataGridView_Doc.Rows[rowToUpdate].Cells[2].Value.ToString();
            DocFeestextBox_Doc.Text = dataGridView_Doc.Rows[rowToUpdate].Cells[3].Value.ToString();
            GendercomboBox_Doc.Text = dataGridView_Doc.Rows[rowToUpdate].Cells[5].Value.ToString();
            DepcomboBox_Doc.Text = dataGridView_Doc.Rows[rowToUpdate].Cells[4].Value.ToString();


        }

        //following method that will be auto called when a key is pressed from keyboard 
        // this method allows user to only enter the digigts not any other character
        //but allows only backspace with 8 and del with 46 key value also
        private void PhonetextBox_Doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //get what key is pressed convert it to char
            char ch = e.KeyChar;
            //check if character is not digit and backspace and del key
            if (!Char.IsDigit(ch) && ch!=8 && ch!=46) {
                //then ignore it i.e don,t enter it in the text box
                e.Handled = true;
            }
            //if digit or backspace or del key so it will be entered
        }

        private void DocFeestextBox_Doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
