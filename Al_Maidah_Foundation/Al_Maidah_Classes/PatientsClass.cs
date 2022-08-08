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
    class PatientsClass
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone_Number { get; set; }
        public int Age { get; set; }
        public string Area { get; set; }
        public int Medical_Camp_ID { get; set; }
        public int Doctor_ID { get; set; }
        public string Gender { get; set; }


        //establishing connection with database
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //method for getting data from specific table here member table 
        public System.Data.DataTable Select()
        {

            SqlConnection connectSql = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM Patient";

                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                connectSql.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to  get data from datbase (-_-?).\n\n" + e.Message);
            }
            finally
            {
                connectSql.Close();
            }
            return dt;
        }



        //this method will insert data in our database from this application
        //passed here the obj of this class
        public bool Insert(PatientsClass c)
        {

            //is data inserted?
            bool isSuccess = false;

            //step 1: get database connection.
            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO Patient" +
                    " (Name, Phone_Number, Age, Area, Medical_Camp_ID, Doctor_ID, Gender)" +
                    " VALUES (@Name, @Phone_Number, @Age, @Area, @Medical_Camp_ID, @Doctor_ID, @Gender) ";

                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                //now create parameter to add data to database.
                //c.FirstName where c is the object of this very class created in parameter passing of this func  
                //tell that add the value in c.FirstName to FirstName column in the database using the query written above
                //also as we mentioned 5 columns and against it 5 variables in the query so here we assign them values...
                sqlCommand.Parameters.AddWithValue("@Name", c.Name);
                sqlCommand.Parameters.AddWithValue("@Phone_Number", c.Phone_Number);
                sqlCommand.Parameters.AddWithValue("@Age", c.Age);
                sqlCommand.Parameters.AddWithValue("@Area", c.Area);
                sqlCommand.Parameters.AddWithValue("@Medical_Camp_ID", c.Medical_Camp_ID);
                sqlCommand.Parameters.AddWithValue("@Doctor_ID", c.Doctor_ID);
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
                MessageBox.Show("Failed to add record (-_-?). Try Again.\n\n"+e.Message);
            }
            finally
            {
                connectSql.Close();
            }

            return isSuccess;
        }

        //this method will Update data in our database from this application
        //passed here the obj(contactClass) of this class
        public bool Update(PatientsClass c)
        {
            bool isSuccess = false;

            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {
                string query = "UPDATE Patient SET Name=@Name," +
                               " Phone_Number=@Phone_Number," +
                               " Age=@Age, " +
                               "Area=@Area," +
                               " Medical_Camp_ID=@Medical_Camp_ID, " +
                               "Doctor_ID=@Doctor_ID, Gender=@Gender" +
                               " where ID=@ID";


                SqlCommand sqlCommand = new SqlCommand(query, connectSql);
                
                sqlCommand.Parameters.AddWithValue("@Name", c.Name);
                sqlCommand.Parameters.AddWithValue("@Phone_Number", c.Phone_Number);
                sqlCommand.Parameters.AddWithValue("@Age", c.Age);
                sqlCommand.Parameters.AddWithValue("@Area", c.Area);
                sqlCommand.Parameters.AddWithValue("@Medical_Camp_ID", c.Medical_Camp_ID);
                sqlCommand.Parameters.AddWithValue("@Doctor_ID", c.Doctor_ID);
                sqlCommand.Parameters.AddWithValue("@Gender", c.Gender);
                
                sqlCommand.Parameters.AddWithValue("@ID", c.ID);


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
        public bool Delete(PatientsClass c)
        {
            //is data inserted?
            bool isSuccess = false;

            //step 1: get database connection.
            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {

                string query = "DELETE FROM Patient WHERE ID=@ID";

                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                //also as we mentioned 1 column and against it 1 variable in the query so here we assign it value...
                sqlCommand.Parameters.AddWithValue("@ID", c.ID);

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
                MessageBox.Show("Failed to delete record (-_-?). Try Again. \n\n" + e.Message);
            }
            finally
            {
                connectSql.Close();
            }

            return isSuccess;
        }

    }
}
