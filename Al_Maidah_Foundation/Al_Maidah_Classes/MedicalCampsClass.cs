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
    class MedicalCampsClass
    {

        public int ID { get; set; }
        public string Venue { get; set; }
        public string Description { get; set; }
        public DateTime Camp_Date { get; set; }
       

        //establishing connection with database
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //method for getting data from specific table here member table 
        public DataTable Select()
        {

            SqlConnection connectSql = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM Medical_Camp";

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
        public bool Insert(MedicalCampsClass c)
        {

            //is data inserted?
            bool isSuccess = false;

            //step 1: get database connection.
            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO Medical_Camp" +
                    " (Venue, Camp_Date, Description)" +
                    " VALUES (@Venue, @Camp_Date, @Description) ";

                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                //now create parameter to add data to database.
                //c.FirstName where c is the object of this very class created in parameter passing of this func  
                //tell that add the value in c.FirstName to FirstName column in the database using the query written above
                //also as we mentioned 5 columns and against it 5 variables in the query so here we assign them values...
                sqlCommand.Parameters.AddWithValue("@Venue", c.Venue);
                sqlCommand.Parameters.AddWithValue("@Description", c.Description);
                sqlCommand.Parameters.AddWithValue("@Camp_Date", c.Camp_Date);
            
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
        public bool Update(MedicalCampsClass c)
        {
            bool isSuccess = false;

            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {
                string query = "UPDATE Medical_Camp SET Venue=@Venue," +
                               " Camp_Date=@Camp_Date," +
                               " Description=@Description " +
                               " where ID=@ID";


                SqlCommand sqlCommand = new SqlCommand(query, connectSql);

                sqlCommand.Parameters.AddWithValue("@Venue", c.Venue);
                sqlCommand.Parameters.AddWithValue("@Description", c.Description);
                sqlCommand.Parameters.AddWithValue("@Camp_Date", c.Camp_Date);
                
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
        public bool Delete(MedicalCampsClass c)
        {
            //is data inserted?
            bool isSuccess = false;

            //step 1: get database connection.
            SqlConnection connectSql = new SqlConnection(myconnstring);

            try
            {

                string query = "DELETE FROM Medical_Camp WHERE ID=@ID";

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
