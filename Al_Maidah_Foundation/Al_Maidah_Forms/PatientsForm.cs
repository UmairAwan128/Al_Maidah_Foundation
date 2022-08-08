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
    public partial class PatientsForm : MaterialSkin.Controls.MaterialForm
    {

        PatientsClass patientClassObj = new PatientsClass();

        //1. for only one instance we created it here....
        private static PatientsForm instance;

        //2. now create instance if its not created and don,t create another form if there is one
        //already created......... 
        public static PatientsForm GetPatientsFormInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new PatientsForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        private PatientsForm()
        {
            InitializeComponent();
        }


        public void myClearTextBoxes()
        {
            //so we cleared them by inserting null or nothing in all textboxes
            txtBoxPatientId.Text = "";
            NameTextBox_Patient.Text = "";
            PhonetextBox_Patient.Text = "";
            AreatextBox_Patient.Text = "";
            AgetextBox_Patient.Text = "";
            GendercomboBox_Patient.Text = "";
            DocIdcomboBox_Patient.Text = "";
            MedCampIdcomboBox_Patient.Text = "";
        }


        private void btnAdd_Patient_Click(object sender, EventArgs e)
        {
            patientClassObj.Name = NameTextBox_Patient.Text;
            patientClassObj.Phone_Number = PhonetextBox_Patient.Text;
            patientClassObj.Area = AreatextBox_Patient.Text;
            patientClassObj.Age = int.Parse(AgetextBox_Patient.Text);
            patientClassObj.Gender = GendercomboBox_Patient.Text;
            patientClassObj.Doctor_ID = int.Parse(DocIdcomboBox_Patient.Text);
            patientClassObj.Medical_Camp_ID = int.Parse((MedCampIdcomboBox_Patient.Text));
            
            if (NameTextBox_Patient.Text == "")
            {
                MessageBox.Show("Name TextBox should not be null (-__-!) ");
                return;
            }
            if (AgetextBox_Patient.Text == "")
            {
                MessageBox.Show("Age TextBox should not be null (-__-!)");
                return;
            }
            if (AreatextBox_Patient.Text == "")
            {
                MessageBox.Show("Area TextBox should not be null (-__-!)");
                return;
            }



            //2.Now as we created first above    obj(contactClassObj) and then put the values to it i.e from the textboxes  
            //now we will call the insert method that we created in the contactClass for Inserting the data into database
            bool successfullyInserted = patientClassObj.Insert(patientClassObj);
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
            DataTable dt = patientClassObj.Select();
            //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
            dataGridView_Patient.DataSource = dt;
        }


        private void btnDelete_Patient_Click(object sender, EventArgs e)
        {
            if (txtBoxPatientId.Text == "")
            {

                MessageBox.Show("Select a Record to Delete (@_@/)", "Warning");
                return;
            }
            patientClassObj.ID = int.Parse(txtBoxPatientId.Text);

            bool successfullyDeleted = patientClassObj.Delete(patientClassObj);
            DialogResult d = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (successfullyDeleted == true)
                {
                    MessageBox.Show(" Record Successfully Deletedted(@_@/)");

                    //so additionally we need to update or refresh the DataGridView
                    //so we will call the Select Method that we created in contactClass for getting data from the database
                    //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                    DataTable dt = patientClassObj.Select();
                    //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                    dataGridView_Patient.DataSource = dt;

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

        private void btnUpdate_Patient_Click(object sender, EventArgs e)
        {
            if (txtBoxPatientId.Text == "")
            {

                MessageBox.Show("Select a Record to Update (@_@/)", "Warning");
                return;
            }

            patientClassObj.ID = int.Parse(txtBoxPatientId.Text);

            patientClassObj.Name = NameTextBox_Patient.Text;
            patientClassObj.Phone_Number = PhonetextBox_Patient.Text;
            patientClassObj.Area = AreatextBox_Patient.Text;
            patientClassObj.Age = int.Parse(AgetextBox_Patient.Text);
            patientClassObj.Gender = GendercomboBox_Patient.Text;
            patientClassObj.Doctor_ID = int.Parse(DocIdcomboBox_Patient.Text);
            patientClassObj.Medical_Camp_ID = int.Parse((MedCampIdcomboBox_Patient.Text));



            //now update the data to the database as we have already created method for it in contactClass so use it
            //so pass it the contactClassObj in which we move data above
            bool successfullyUpdated = patientClassObj.Update(patientClassObj);

            if (successfullyUpdated == true)
            {
                MessageBox.Show(" Record Successfully Updated(@_@/)");

                //so additionally we need to update or refresh the DataGridView
                //so we will call the Select Method that we created in contactClass for getting data from the database
                //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                DataTable dt = patientClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridView_Patient.DataSource = dt;

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

        private void btnClear_Patient_Click(object sender, EventArgs e)
        {
            myClearTextBoxes();
        }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        private void txtBoxSearchPatient_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtBoxSearchPatient.Text;

            SqlConnection connectSql = new SqlConnection(myconnstring);


            //follwoing is the code for the check boxes in the Doctor UI this checks that how many check boxes
            //are selected and according to that query is generated and after wards passed to sqlAdapter
            string query = "";
            int count = 0;
            if (NameRadioButtonPatient.Checked)
            {
                query = "SELECT * FROM Patient WHERE Name LIKE '%" + keyWord + "%'";

            }
            else if (ArearadioButtonPat.Checked)
            {
                query = "SELECT * FROM Patient WHERE Area LIKE '%" + keyWord + "%'";

            }
            else if (AgeradioButtonPat.Checked)
            {
                query = "SELECT * FROM Patient WHERE Age LIKE '%" + keyWord + "%'";

            }
            else if (GenderradioButtonPat.Checked)
            {
                query = "SELECT * FROM Patient WHERE Gender LIKE '%" + keyWord + "%'";

            }
            else if (DocIDradioButtonPat.Checked)
            {
                query = "SELECT * FROM Patient WHERE Doctor_ID LIKE '%" + keyWord + "%'";

            }
            else if (MedCampIDradioButtonPat.Checked)
            {
                query = "SELECT * FROM Patient WHERE Medical_Camp_ID LIKE '%" + keyWord + "%'";

            }
            else
            { //we will think as all checked
                query = "SELECT * FROM Patient WHERE Name LIKE '%" + keyWord + "%' OR Age LIKE '%" + keyWord + "%' OR Area LIKE '%" + keyWord + "%' OR Medical_Camp_ID LIKE '%" + keyWord + "%' OR Doctor_ID LIKE '%" + keyWord + "%' OR Gender LIKE '%" + keyWord + "%'";
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, connectSql);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView_Patient.DataSource = dt;

        }



        private void dataGridView_Patient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowToUpdate = e.RowIndex;

            txtBoxPatientId.Text = dataGridView_Patient.Rows[rowToUpdate].Cells[0].Value.ToString();

            NameTextBox_Patient.Text = dataGridView_Patient.Rows[rowToUpdate].Cells[1].Value.ToString();
            PhonetextBox_Patient.Text = dataGridView_Patient.Rows[rowToUpdate].Cells[2].Value.ToString();
            AreatextBox_Patient.Text = dataGridView_Patient.Rows[rowToUpdate].Cells[4].Value.ToString();
            AgetextBox_Patient.Text = dataGridView_Patient.Rows[rowToUpdate].Cells[3].Value.ToString();
            GendercomboBox_Patient.Text = dataGridView_Patient.Rows[rowToUpdate].Cells[7].Value.ToString();
            DocIdcomboBox_Patient.Text = dataGridView_Patient.Rows[rowToUpdate].Cells[6].Value.ToString();
            MedCampIdcomboBox_Patient.Text = dataGridView_Patient.Rows[rowToUpdate].Cells[5].Value.ToString();

        }



        private void PatientsForm_Load(object sender, EventArgs e)
        {
            DataTable dt = patientClassObj.Select();

            dataGridView_Patient.DataSource = dt;


            //loaing data to GenderCombo Box
            GendercomboBox_Patient.Items.Clear();
            SqlConnection connectSql = new SqlConnection(myconnstring);
            connectSql.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Gender_Type FROM Gender", connectSql);
            DataTable dtGender = new DataTable();

            adapter.Fill(dtGender);

            //what this does is select a row(i.e using dr ) then its column DepName i.e ( dr["DepName"] ) and place 
            //it in the comboBox......
            foreach (DataRow dr in dtGender.Rows)
            {
                GendercomboBox_Patient.Items.Add(dr["Gender_Type"].ToString());
            }


            DocIdcomboBox_Patient.Items.Clear();
            //Loading data to Dep ComboBOx
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT ID FROM Doctor", connectSql);
            DataTable dtDocID = new DataTable();

            adapter1.Fill(dtDocID);

            //what this does is select a row(i.e using dr ) then its column DepName i.e ( dr["DepName"] ) and place 
            //it in the comboBox......
            foreach (DataRow dr in dtDocID.Rows)
            {
                DocIdcomboBox_Patient.Items.Add(dr["ID"].ToString());
            }

            MedCampIdcomboBox_Patient.Items.Clear();
            //Loading data to Dep ComboBOx
            SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT ID FROM Medical_Camp", connectSql);
            DataTable dtMedCampID = new DataTable();

            adapter2.Fill(dtMedCampID);

            //what this does is select a row(i.e using dr ) then its column DepName i.e ( dr["DepName"] ) and place 
            //it in the comboBox......
            foreach (DataRow dr in dtMedCampID.Rows)
            {
                MedCampIdcomboBox_Patient.Items.Add(dr["ID"].ToString());
            }
        }
        
        //following method that will be auto called when a key is pressed from keyboard 
        // this method allows user to only enter the digigts not any other character
        //but allows only backspace with 8 and del with 46 key value also
        //get what key is pressed convert it to char

        private void AgetextBox_Patient_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        //get what key is pressed convert it to char

        private void PhonetextBox_Patient_KeyPress(object sender, KeyPressEventArgs e)
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
