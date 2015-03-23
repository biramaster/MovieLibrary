using LibrarySystem;
using MovieLibrary.Controll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.DAL
{
    class DataAccessLayerDBA
    {
        private static SqlConnection sqlConnect;
        private static SqlDataAdapter mDirector;
        private static DataSet mDataSet;
        private static DataTable mDataTable;

        public static bool ReadFromDatabase()
        {



            return true;
        }

        public static bool SaveToDatabase()
        {
            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MovieLibrary.mdf;Integrated Security=True";

            sqlConnect.Open();

            DirectorList dl = ServiceProvider.GetDirectorService();

            //mDirector = new SqlDataAdapter(cmdString, sqlConnect);

            /*SqlCommand cmd = new SqlCommand(cmdString, sqlConnect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            */
            using (SqlCommand cmd = sqlConnect.CreateCommand())
            {
                cmd.CommandText = "@AddDirector";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar,50);

                for (int i = 0; i < dl.Count(); i++)
                {
                   
                    cmd.Parameters["@ID"].Value = dl.Get(i).ID;
                    cmd.Parameters["@NAME"].Value = dl.Get(i).Name;
                    int res = 0;
                    try
                    {
                        res = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    //Debug.Write(cmdString + res + "\n");
                }

            }
            /*DataTable table = new DataTable("Director");
           
            int result = mDirector.Update()

            Debug.Write("How many rows in my database:"+result+ "\n");
            */
            return true;

        }
    }
}
