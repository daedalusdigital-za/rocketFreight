using MySql.Data.MySqlClient;
using System.Data.SQLite;
using RocketFreight.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using RocketFreight.Classes;
using RocketFreight.Data;
using System.Collections.Generic;

namespace RocketFreight.Data
{
    public class AppDBModel : DbContext
    {
        // Your context has been configured to use a 'MySqlModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RocketFreight.Data.MySqlModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MySqlModel' 
        // connection string in the application configuration file.
        public AppDBModel(string Constring)
            : base(Constring)//"name=MySqlModel")
            //"Data Source=C:\\Users\\HP\\OneDrive\\Documents\\SqlLiteDBs\\RocketFreight.sqlite;"")
        {
            if (Properties.Settings.Default.DBType == "SQLite")
            {
                //string conStr = "Data Source=RocketFreight.db;Version=3;";
                //Database.Connection.ConnectionString = conStr;
                //Database.SetInitializer<AppDBModel>(
                //    new DropCreateDatabaseIfModelChanges<AppDBModel>());
                if (!Database.Exists())
                {
                    Database.CreateIfNotExists();
                }
            }
            else if (Properties.Settings.Default.DBType == "MySQL")
            {
                string conStr = Properties.Settings.Default.ConStringMySql;
                Database.Connection.ConnectionString = conStr;
                string dbName = Statics.GetDatabaseName();
                if(conStr.Contains(dbName))
                {
                    try
                    {
                        MySqlCommand upgCommand = new MySqlCommand();
                        upgCommand.Connection = new MySqlConnection(conStr.Replace("database=" + dbName, ""));//"server=127.0.0.1;user id=root;"
                        upgCommand.CommandText = @"CREATE DATABASE IF NOT EXISTS " + dbName;
                        upgCommand.Connection.Open();
                        if (upgCommand.ExecuteNonQuery() >= 1)
                        {
                            upgCommand.Connection.Close();

                            upgCommand.Connection = new MySqlConnection(conStr);// "server=127.0.0.1;user id=root;database=RocketFreight;");
                            upgCommand.CommandText = System.IO.File.ReadAllText("Data\\RocketFreight_MySQL.sql");
                            upgCommand.Connection.Open();
                            upgCommand.ExecuteNonQuery();
                            upgCommand.Connection.Close();
                        }


                        //    DataModel.Database.ExecuteSqlCommand(File.ReadAllText("script.sql"));
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(Statics.GetException(ex));
                    }
                }
            }
            else if (Properties.Settings.Default.DBType == "SQL Server")
            {
                Database.Connection.ConnectionString = Properties.Settings.Default.ConStringSQLServer;
                //Database.Delete();
                if (!Database.Exists())
                {
                    Database.CreateIfNotExists();
                    Database.ExecuteSqlCommand(System.IO.File.ReadAllText("Data\\RocketFreight_SQL_Server_Data.sql"));
                }
            }
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<OrderRequest> OrderRequests { get; set; }
        public virtual DbSet<Route> Routes  { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<DriverAssignment> DriverAssignments { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Compliance> Compliances { get; set; }
    }

}