using LibrarySystem;
using MovieGenerator.Model;
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
        private SqlConnection msqlConnection;
        private SqlDataAdapter mMoviesAdapter;
        private DataSet mDataSet;
        private String mConnectionString;

        public DataAccessLayerDBA()
        {
            mConnectionString = @"Data Source=RUBAND-SQLSERVE\RUBIRAMSSQLSERVE;Initial Catalog=MovieLibrary;User ID=elevbenny;Password=elevbenny";
            //mConnectionString = MovieLibrary.Properties.Settings.Default.MovieLibraryConnectionString;

            msqlConnection = new SqlConnection(mConnectionString);

            msqlConnection.Open();

            //CreateIfNotExists(); // Setup the database

            msqlConnection.Close();
        }

        private void CreateIfNotExists()
        {
            List<string> sqlList = new List<string>();
            //sqlList.Add("if not exists (select * from master.sys.databases where name = '[MOVIELIBRARY]') " +
            //             "CREATE DATABASE MOVIELIBRARY");
            sqlList.Add("USE MovieLibrary");
            sqlList.Add("CREATE TABLE [dbo].[Director] ([Id]   INT NOT NULL, [Name] VARCHAR (50) NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[Movies] ([Id] INT NOT NULL,[Title] VARCHAR (100) NULL,[Genre] VARCHAR (50)  NULL, [DirectorID] INT NULL,[Age] INT NULL,[Path] VARCHAR (100) NULL,[Runtime] INT NULL,PRIMARY KEY CLUSTERED ([Id] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[Member] ([Id] INT NOT NULL, [PersonalID] VARCHAR (50) NULL,[Name] VARCHAR (50) NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[Loan] ([Id] INT NOT NULL,[filmID] INT NULL,[memberID] INT NULL,[TimeOfLoan] DATETIME NULL, [DueDate] DATETIME NULL,[TimeOfReturn ] DATETIME NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");
            sqlList.Add("CREATE TABLE [dbo].[MovieCopy] ([Id] INT NOT NULL, [filmId] INT NULL, PRIMARY KEY CLUSTERED ([Id] ASC));");

            SqlCommand cmd;
            foreach (var sql in sqlList)
            {
                try
                {
                    cmd = new SqlCommand(sql, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public SqlDataAdapter ReadFromDatabaseMovies1()
        {
            msqlConnection.Open();

            mMoviesAdapter = new SqlDataAdapter("SELECT * FROM dbo.Movies", msqlConnection);

            mDataSet = new DataSet("Movies");

            mMoviesAdapter.FillSchema(mDataSet, SchemaType.Source, "dbo.Movies");

            mMoviesAdapter.Fill(mDataSet, "dbo.Movies");

            msqlConnection.Close();

            return mMoviesAdapter;
        }

        public void SaveMoviesToDatabase()
        {
            msqlConnection.Open();
            string sqlString;
            List<string> sqlList = new List<string>();
            MovieList movies = ServiceProvider.GetMovieService();
            SqlCommand cmd;
            sqlString = "delete from dbo.movies;";
            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
           
            for (int i = 0; i < movies.Count(); i++)
			{
                sqlString = "insert into dbo.movies(id,title,genre,directorid,age,path,runtime) values(" +
                            movies.Get(i).getId() + ",'" +
                            movies.Get(i).getTitle() + "','" +
                            movies.Get(i).getGenre() + "'," +
                            movies.Get(i).getDirector() + "," +
                            movies.Get(i).getAge().ToString() + ",'" +
                            movies.Get(i).getPath() + "'," +  
                            movies.Get(i).getTime().ToString() + ");";
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
			}

            msqlConnection.Close();
        }

        public void SaveDirectorToDatabase()
        {
            msqlConnection.Open();

            List<string> sqlList = new List<string>();
            DirectorList director = ServiceProvider.GetDirectorService();
            SqlCommand cmd;
            string sqlString;

            sqlString = "delete from dbo.director;";
            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }


            for (int i = 0; i < director.Count(); i++)
            {
                sqlString = "insert into dbo.director(id,name) values(" +
                            director.Get(i).ID + ",'" +
                            director.Get(i).Name + "')";
                            
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }

            msqlConnection.Close();
        }

        public bool SaveToDatabase()
        {
            
            return true;

        }

        public SqlDataAdapter getMoviesAdapter()
        {
            return this.mMoviesAdapter;
        }

        public List<Director> ReadFromDatabaseDirector()
        {
            List<Director> directorList = new List<Director>();

            msqlConnection.Open();
            SqlCommand cmd;

            cmd = new SqlCommand("USE MovieLibrary;", msqlConnection);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("SELECT * FROM dbo.Director", msqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Director director = new Director(reader.GetInt32(0).ToString(), reader.GetString(1));
                    directorList.Add(director);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            msqlConnection.Close();
            return directorList;
            
        }

        public List<Movie> ReadFromDatabaseMovies()
        {
            List<Movie> movieList = new List<Movie>();

            msqlConnection.Open();
            SqlCommand cmd;

            cmd = new SqlCommand("USE MovieLibrary;", msqlConnection);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("SELECT * FROM dbo.Movies", msqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Movie movie = new Movie(reader.GetInt32(0), 
                                            reader.GetString(1),
                                            reader.GetString(2),
                                            reader.GetInt32(3),
                                            reader.GetInt32(4),
                                            reader.GetString(5),
                                            reader.GetInt32(6));
                    movieList.Add(movie);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            msqlConnection.Close();
            return movieList;

        }
    }
}
