using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Maidah_Foundation.Al_Maidah_Classes
{
    class MembersClass
    {
        //getter and setters will act as data carrier to our applications
        
        //Form_Number is the MemberId
        public int Form_Number { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; }
        public string Phone_Number { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Blood_Group { get; set; }
        
        //Date_Time is the Joining Date
        public DateTime Date_Time { get; set; }

        public string Gender { get; set; }


        //establishing connection with database
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

         //method for getting data from specific table here member table 
        public DataTable Select()
        {
            SqlConnection connectSql = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM Member";    

                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand); 
                connectSql.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to  get data from datbase (-_-?). \n\n" + e.Message);
            }
            finally
            {
                connectSql.Close();
            }
            return dt;
        }



        //this method will insert data in our database from this application
        //passed here the obj of this class
        public bool Insert(MembersClass c)
        {

            //is data inserted?
            bool isSuccess = false;

            //step 1: get database connection.
            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {                                                                                                                                                           
                string query = "INSERT INTO Member" +
                    " (First_Name, Last_Name, CNIC, Address, Phone_Number, Date_Of_Birth, Blood_Group, Date_Time, Gender)" +
                    " VALUES (@First_Name, @Last_Name, @CNIC, @Address, @Phone_Number, @Date_Of_Birth, @Blood_Group, @Date_Time, @Gender) ";
   
                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                //now create parameter to add data to database.
                //c.FirstName where c is the object of this very class created in parameter passing of this func  
                //tell that add the value in c.FirstName to FirstName column in the database using the query written above
                //also as we mentioned 5 columns and against it 5 variables in the query so here we assign them values...
                sqlCommand.Parameters.AddWithValue("@First_Name", c.First_Name);
                sqlCommand.Parameters.AddWithValue("@Last_Name", c.Last_Name);
                sqlCommand.Parameters.AddWithValue("@CNIC", c.CNIC);
                sqlCommand.Parameters.AddWithValue("@Address", c.Address);
                sqlCommand.Parameters.AddWithValue("@Phone_Number", c.Phone_Number);
                sqlCommand.Parameters.AddWithValue("@Date_Of_Birth", c.Date_Of_Birth);
                sqlCommand.Parameters.AddWithValue("@Blood_Group", c.Blood_Group);

                //Date_Time is the Joining Date
                sqlCommand.Parameters.AddWithValue("@Date_Time", c.Date_Time);
                sqlCommand.Parameters.AddWithValue("@Gender", c.Gender);

                //now open connecion
                connectSql.Open();

                //ExecuteNonQuery() tells the no of rows affected so after inserting if zero row affected then data not inserted
                //but if 1 or more rows affected the data inserted. 
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to add record (-_-?). Try Again. \n\n" + e.Message);
            }
            finally
            {
                connectSql.Close();
            }

            return isSuccess;
        }

        //this method will Update data in our database from this application
        //passed here the obj(contactClass) of this class
        public bool Update(MembersClass c)
        {
            bool isSuccess = false;

            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {
            string query = "UPDATE Member SET First_Name=@First_Name, Last_Name=@Last_Name," +
                           " CNIC=@CNIC, Address=@Address, Phone_Number=@Phone_Number," +
                           " Date_Of_Birth=@Date_Of_Birth, Blood_Group=@Blood_Group, " +
                           "Date_Time=@Date_Time, Gender=@Gender" +
                           " where Form_Number=@Form_Number";

                
                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                sqlCommand.Parameters.AddWithValue("@First_Name", c.First_Name);
                sqlCommand.Parameters.AddWithValue("@Last_Name", c.Last_Name);
                sqlCommand.Parameters.AddWithValue("@CNIC", c.CNIC);
                sqlCommand.Parameters.AddWithValue("@Address", c.Address);
                sqlCommand.Parameters.AddWithValue("@Phone_Number", c.Phone_Number);
                sqlCommand.Parameters.AddWithValue("@Date_Of_Birth", c.Date_Of_Birth);
                sqlCommand.Parameters.AddWithValue("@Blood_Group", c.Blood_Group);

                //Date_Time is the Joining Date
                sqlCommand.Parameters.AddWithValue("@Date_Time", c.Date_Time);
                sqlCommand.Parameters.AddWithValue("@Gender", c.Gender);

                sqlCommand.Parameters.AddWithValue("@Form_Number", c.Form_Number);


                connectSql.Open();

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to update record (-_-?). Try Again.\n\n" + e.Message);
            }
            finally
            {
                connectSql.Close();
            }

            return isSuccess;
        }

        //this method will delete data from our database using this application
        //passed here the obj(contactClass) of this class
        public bool Delete(MembersClass c)
        {
            //is data inserted?
            bool isSuccess = false;

            //step 1: get database connection.
            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {

                string query = "DELETE FROM Member WHERE Form_Number=@Form_Number";

                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                //also as we mentioned 1 column and against it 1 variable in the query so here we assign it value...
                sqlCommand.Parameters.AddWithValue("@Form_Number", c.Form_Number);

                connectSql.Open();

                //ExecuteNonQuery() tells the no of rows affected so after inserting if zero row affected then data not inserted
                //but if 1 or more rows affected the data inserted. 
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to delete record (-_-?). Try Again.\n\n" + e.Message);
            }
            finally
            {
                connectSql.Close();
            }

            return isSuccess;
        }

    }
}
