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
    public partial class MedicalCampForm : MaterialSkin.Controls.MaterialForm
    {
        MedicalCampsClass MedCampClassObj = new MedicalCampsClass();

        //1. for only one instance we created it here....
        private static MedicalCampForm instance;

        //2. now create instance if its not created and don,t create another form if there is one
        //already created......... 
        public static MedicalCampForm GetMedicalCampFormInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new MedicalCampForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }

        private MedicalCampForm()
        {
            InitializeComponent();
        }

        public void myClearTextBoxes()
        {
            //so we cleared them by inserting null or nothing in all textboxes
            MedicalCampIDtxtBox.Text = "";
            VenuetxtBoxMedCamp.Text = "";
            DesctextBox_MedCamp.Text = "";
            campDatePicker_MedCamp.Text = "";
            
        }

        private void btnAdd_MedCamp_Click(object sender, EventArgs e)
        {
            MedCampClassObj.Venue = VenuetxtBoxMedCamp.Text;
            MedCampClassObj.Camp_Date = DateTime.Parse(campDatePicker_MedCamp.Text);
            MedCampClassObj.Description = DesctextBox_MedCamp.Text;
            

            if (VenuetxtBoxMedCamp.Text == "")
            {
                MessageBox.Show("Camp Venue should not be null (-__-!) ");
                return;
            }
            
            //2.Now as we created first above obj(contactClassObj) and then put the values to it i.e from the textboxes  
            //now we will call the insert method that we created in the contactClass for Inserting the data into database
            bool successfullyInserted = MedCampClassObj.Insert(MedCampClassObj);
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
            DataTable dt = MedCampClassObj.Select();
            //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
            dataGridView_MedCamp.DataSource = dt;
        }

        private void btnDelete_MedCamp_Click(object sender, EventArgs e)
        {
            if (MedicalCampIDtxtBox.Text == "")
            {

                MessageBox.Show("Select a Record to Delete (@_@/)", "Warning");
                return;
            }

            MedCampClassObj.ID = Convert.ToInt32(MedicalCampIDtxtBox.Text);

            bool successfullyDeleted = MedCampClassObj.Delete(MedCampClassObj);
            DialogResult d = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (successfullyDeleted == true)
                {
                    MessageBox.Show(" Record Successfully Deletedted(@_@/)");

                    //so additionally we need to update or refresh the DataGridView
                    //so we will call the Select Method that we created in contactClass for getting data from the database
                    //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                    DataTable dt = MedCampClassObj.Select();
                    //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                    dataGridView_MedCamp.DataSource = dt;

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

        private void btnUpdate_MedCamp_Click(object sender, EventArgs e)
        {
            if (MedicalCampIDtxtBox.Text == "")
            {

                MessageBox.Show("Select a Record to Update (@_@/)", "Warning");
                return;
            }

            MedCampClassObj.ID = int.Parse(MedicalCampIDtxtBox.Text);

            MedCampClassObj.Venue = VenuetxtBoxMedCamp.Text;
            MedCampClassObj.Camp_Date = DateTime.Parse(campDatePicker_MedCamp.Text);
            MedCampClassObj.Description = DesctextBox_MedCamp.Text;


            //now update the data to the database as we have already created method for it in contactClass so use it
            //so pass it the contactClassObj in which we move data above
            bool successfullyUpdated = MedCampClassObj.Update(MedCampClassObj);

            if (successfullyUpdated == true)
            {
                MessageBox.Show(" Record Successfully Updated(@_@/)");

                //so additionally we need to update or refresh the DataGridView
                //so we will call the Select Method that we created in contactClass for getting data from the database
                //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                DataTable dt = MedCampClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridView_MedCamp.DataSource = dt;

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

        private void btnClear_MedCamp_Click(object sender, EventArgs e)
        {
            myClearTextBoxes();
        }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void txtBoxSearchMedCamp_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtBoxSearchMedCamp.Text;

            SqlConnection connectSql = new SqlConnection(myconnstring);


            //follwoing is the code for the check boxes in the Doctor UI this checks that how many check boxes
            //are selected and according to that query is generated and after wards passed to sqlAdapter
            string query = "";
            int count = 0;
            if (venueRadioButtonMedCamp.Checked)
            {
                query = "SELECT * FROM Medical_Camp WHERE Venue LIKE '%" + keyWord + "%'";

            
            }
            else if (CampDateradioButtonMedCamp.Checked)
            {
                query = "SELECT * FROM Medical_Camp WHERE Camp_Date LIKE '%" + keyWord + "%'";
        
            }
            else
            { //we will think as all checked
                query = "SELECT * FROM Medical_Camp WHERE Venue LIKE '%" + keyWord + "%' OR Camp_Date LIKE '%" + keyWord + "%'";
            }


            SqlDataAdapter adapter = new SqlDataAdapter(query, connectSql);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView_MedCamp.DataSource = dt;
        }


        private void dataGridView_MedCamp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowToUpdate = e.RowIndex;
            MedicalCampIDtxtBox.Text = dataGridView_MedCamp.Rows[rowToUpdate].Cells[0].Value.ToString();
            
            VenuetxtBoxMedCamp.Text= dataGridView_MedCamp.Rows[rowToUpdate].Cells[1].Value.ToString();
            campDatePicker_MedCamp.Text = dataGridView_MedCamp.Rows[rowToUpdate].Cells[2].Value.ToString();
            DesctextBox_MedCamp.Text = dataGridView_MedCamp.Rows[rowToUpdate].Cells[3].Value.ToString();

        }

        private void MedicalCampForm_Load(object sender, EventArgs e)
        {
            //loading data to grid view
            DataTable dt = MedCampClassObj.Select();

            dataGridView_MedCamp.DataSource = dt;

            
        }
    }
}
