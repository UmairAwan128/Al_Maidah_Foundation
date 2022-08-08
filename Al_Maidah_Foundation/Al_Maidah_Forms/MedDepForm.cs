using Al_Maidah_Foundation.Al_Maidah_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Maidah_Foundation.Al_Maidah_Forms
{
    public partial class MedDepForm : MaterialSkin.Controls.MaterialForm
    {
        MedDepartmentClass MedDepClassObj = new MedDepartmentClass();

        //1. for only one instance we created it here....
        private static MedDepForm instance;

        //2. now create instance if its not created and don,t create another form if there is one
        //already created......... 
        public static MedDepForm GetMedDepFormInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new MedDepForm();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }


        private MedDepForm()
        {
            InitializeComponent();
        }

        public void myClearTextBoxes()
        {
            //so we cleared them by inserting null or nothing in all textboxes
            txtBoxMedDepID.Text = "";
            MedDepNameTextBox_MedDep.Text = "";
        }

        private void MedDepForm_Load(object sender, EventArgs e)
        {
            DataTable dt = MedDepClassObj.Select();

            dataGridView_MedDep.DataSource = dt;

        }

        private void btnAdd_Donation_Click(object sender, EventArgs e)
        {
            MedDepClassObj.Department_Name = MedDepNameTextBox_MedDep.Text;
            

            if (MedDepNameTextBox_MedDep.Text == "")
            {
                MessageBox.Show("Med Dep Name TextBox should not be null (-__-!) ");
                return;
            }

            //2.Now as we created first above    obj(contactClassObj) and then put the values to it i.e from the textboxes  
            //now we will call the insert method that we created in the contactClass for Inserting the data into database
            bool successfullyInserted = MedDepClassObj.Insert(MedDepClassObj);
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
            DataTable dt = MedDepClassObj.Select();
            //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
            dataGridView_MedDep.DataSource = dt;
        }

        private void btnDelete_Donation_Click(object sender, EventArgs e)
        {

            if (txtBoxMedDepID.Text == "")
            {

                MessageBox.Show("Select a Record to Delete (@_@/)","Warning");
                return;
            }
                MedDepClassObj.ID = Convert.ToInt32(txtBoxMedDepID.Text);
                bool successfullyDeleted = MedDepClassObj.Delete(MedDepClassObj);
                DialogResult d = MessageBox.Show("Are you sure you want to delete record?", "Warning", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {

                    if (successfullyDeleted == true)
                    {
                        MessageBox.Show(" Record Successfully Deletedted(@_@/)");

                        //so additionally we need to update or refresh the DataGridView
                        //so we will call the Select Method that we created in contactClass for getting data from the database
                        //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                        DataTable dt = MedDepClassObj.Select();
                        //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                        dataGridView_MedDep.DataSource = dt;

                        //as we Delete data the problem is that the data stays in the textboxes after deleted
                        //so to auto remove the data after the data i.e deleted we will call the ClearTextBoxes() method we creted
                        myClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Record(-_-?). Try Again!. ");
                    }
                }
            
            else {
                MessageBox.Show("Select a record to Delete. (@_@/)");
            }
        }

        private void btnUpdate_Donation_Click(object sender, EventArgs e)
        {


            if (txtBoxMedDepID.Text == "")
            {

                MessageBox.Show("Select a Record to Update (@_@/)", "Warning");
                return;
            }

            MedDepClassObj.ID = int.Parse(txtBoxMedDepID.Text);

            MedDepClassObj.Department_Name = MedDepNameTextBox_MedDep.Text;
            

            //now update the data to the database as we have already created method for it in contactClass so use it
            //so pass it the contactClassObj in which we move data above
            bool successfullyUpdated = MedDepClassObj.Update(MedDepClassObj);

            if (successfullyUpdated == true)
            {
                MessageBox.Show(" Record Successfully Updated(@_@/)");

                //so additionally we need to update or refresh the DataGridView
                //so we will call the Select Method that we created in contactClass for getting data from the database
                //the method will return DataTable(or all the data from the table(empContact Table) from dataBase)
                DataTable dt = MedDepClassObj.Select();
                //now put the data that we get above from database empContact table into the GridView in the View(UI).. 
                dataGridView_MedDep.DataSource = dt;

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

        private void dataGridView_MedDep_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowToUpdate = e.RowIndex;
            txtBoxMedDepID.Text = dataGridView_MedDep.Rows[rowToUpdate].Cells[0].Value.ToString();

            MedDepNameTextBox_MedDep.Text = dataGridView_MedDep.Rows[rowToUpdate].Cells[1].Value.ToString();
            
        }
    }
}
