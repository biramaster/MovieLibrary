//-------------------------------------------------------------------------------------
// File name...................: DataAccess.cs
// Purpose.....................: Managinge communication between the application and a database 
//                               Data Access Layer (DAL).
// Programmer..................: André Rubira
// Date........................: 2013-01-28
// Version.....................:
// Changed.....................: 2013-02-10
//--------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;

namespace DAL
{
    public class DataAccess
    {
        // Fields
        SqlConnection mConnection;
        SqlDataAdapter mDataAdapterAnimals;

        public DataSet mDataSet;
        //string conStr = @"Data Source=.\SQLEXPINS1;Integrated Security=False;Initial Catalog=AnimalDBA;User ID=sa;Password=Novell12345;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=AnimalDBA;Integrated Security=True";

        // Default Constructor
        public DataAccess()
        {

            mConnection = new SqlConnection(conStr);
            
            mConnection.Open();

            //CreateIfNotExists(); // Setup the database

            mDataAdapterAnimals = new SqlDataAdapter("SELECT * FROM dbo.AnimalDummy", mConnection);

            mDataSet = new DataSet("AnimalDummy");
            
            mDataAdapterAnimals.FillSchema(mDataSet, SchemaType.Source, "dbo.AnimalDummy");
            
            mDataAdapterAnimals.Fill(mDataSet,"dbo.AnimalDummy");

            mConnection.Close();
        }

       
        // Propertie. Returns how many rows exists in a table. 
        public int AnimalsDBCount { get { return mDataSet.Tables[0].Rows.Count;}  }


        /// <summary>
        /// CreateIfNotExists is a method in the DataAccess class that
        /// creates a database and a table
        /// </summary>
        public void CreateIfNotExists()
        {
            string sql = "if not exists (select * from master.sys.databases where name = '[AnimalDBA]') " +
                         "CREATE DATABASE AnimalDBA";

            SqlCommand cmd = new SqlCommand(sql, mConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            sql = "USE AnimalDBA";

            cmd = new SqlCommand(sql, mConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                
                throw;
            }
            

            sql = "CREATE TABLE [dbo].[AnimalDummy](	[Id] [int] NOT NULL," +
                         "[Name] [nvarchar](50) NULL,[Age] [float] NULL," +
                         "[Category] [nvarchar](50) NULL,[Gender] [nvarchar](10) NULL," +
                         "[Path] [nvarchar](100) NULL,[ExtraInfo] [text] NULL,	" +
                         "[Type] [nvarchar](50) NULL,[WingLength] [nvarchar](8) NULL," +
                         "[IsPoison] [bit] NULL,[IsHoneyBee] [bit] NULL," +
                         "[AmountOfHoney] [nvarchar](8) NULL,[NrOfTeeth] [nvarchar](5) NULL," +
                         "[UnderQuarantine] [bit] NULL,[DaysInQuarantine] [nvarchar](8) NULL," +
                         "[Speed] [nvarchar](8) NULL,[IsInvertebrate] [bit] NULL," +
                         "[ReptileCategory] [nvarchar](30) NULL, PRIMARY KEY CLUSTERED" +
                         " ([Id] ASC )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF," +
                         "IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)" +
                         "ON [PRIMARY] ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]";

            cmd = new SqlCommand(sql, mConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// DeleteAnimalData is a method in the DataAccess class that
        /// drops and create the table AnimalDummy
        /// </summary>
        public void DeleteAnimalData() 
        {
            mConnection.Open();

            SqlCommand cmd = new SqlCommand("Drop table AnimalDummy;", mConnection);

            cmd.ExecuteNonQuery();

            string sql = "CREATE TABLE [dbo].[AnimalDummy](	[Id] [int] NOT NULL,"+
                         "[Name] [nvarchar](50) NULL,[Age] [float] NULL,"+
                         "[Category] [nvarchar](50) NULL,[Gender] [nvarchar](10) NULL,"+
                         "[Path] [nvarchar](100) NULL,[ExtraInfo] [text] NULL,	"+
                         "[Type] [nvarchar](50) NULL,[WingLength] [nvarchar](8) NULL,"+
                         "[IsPoison] [bit] NULL,[IsHoneyBee] [bit] NULL,"+
                         "[AmountOfHoney] [nvarchar](8) NULL,[NrOfTeeth] [nvarchar](5) NULL,"+
                         "[UnderQuarantine] [bit] NULL,[DaysInQuarantine] [nvarchar](8) NULL,"+
                         "[Speed] [nvarchar](8) NULL,[IsInvertebrate] [bit] NULL,"+
                         "[ReptileCategory] [nvarchar](30) NULL, PRIMARY KEY CLUSTERED"+
                         " ([Id] ASC )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF,"+
                         "IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)"+
                         "ON [PRIMARY] ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]";

            cmd = new SqlCommand(sql, mConnection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                throw;
            }
            

            mDataAdapterAnimals = new SqlDataAdapter("SELECT * FROM dbo.AnimalDummy", mConnection);

            mDataSet = new DataSet("AnimalDummy");

            mDataAdapterAnimals.FillSchema(mDataSet, SchemaType.Source, "dbo.AnimalDummy");

            mDataAdapterAnimals.Fill(mDataSet, "dbo.AnimalDummy");

            mConnection.Close();
        
        }

        /// <summary>
        /// LoadAnimalData is a method in the DataAccess class that
        /// reads data from table AnimalDummy into a DataSet
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet LoadAnimalData()
        {
            mConnection.Open();

            mDataAdapterAnimals = new SqlDataAdapter("SELECT * FROM dbo.AnimalDummy", mConnection);

            mDataSet = new DataSet("AnimalDummy");

            mDataAdapterAnimals.FillSchema(mDataSet, SchemaType.Source, "dbo.AnimalDummy");

            mDataAdapterAnimals.Fill(mDataSet, "dbo.AnimalDummy");

            mConnection.Close();

            return mDataSet;
        }

        /// <summary>
        /// SaveAnimal is a method in the DataAccess class that
        /// saves a DataSet to a database via a dataadapter
        /// </summary>
        public void SaveAnimal() 
        {
            mConnection.Open();

            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(mDataAdapterAnimals);

            mDataAdapterAnimals.Update(mDataSet, "dbo.AnimalDummy");

            mConnection.Close();
        }        

    }
}
