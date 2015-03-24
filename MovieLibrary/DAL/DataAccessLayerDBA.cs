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
        private static SqlConnection msqlConnection;
        private static SqlDataAdapter mMoviesAdapter;
        private static DataSet mDataSet;
        private static String mConnectionString;

        public DataAccessLayerDBA()
        {
            mConnectionString = MovieLibrary.Properties.Settings.Default.MovieLibraryConnectionString;

            msqlConnection = new SqlConnection(mConnectionString);

            msqlConnection.Open();

            //CreateIfNotExists(); // Setup the database

            mMoviesAdapter = new SqlDataAdapter("SELECT * FROM dbo.Movies", msqlConnection);

            mDataSet = new DataSet("Movies");

            mMoviesAdapter.FillSchema(mDataSet, SchemaType.Source, "dbo.Movies");

            mMoviesAdapter.Fill(mDataSet, "dbo.Movies");

            msqlConnection.Close();
        }

        public static bool ReadFromDatabase()
        {

            return true;
        }

        public void SaveMovies()
        {

        }

        public static bool SaveToDatabase()
        {
            
            return true;

        }
    }
}
