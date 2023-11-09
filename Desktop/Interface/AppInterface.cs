using RocketFreight.Classes;
using RocketFreight.Data;
using RocketFreight.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketFreight.Interface
{
    public class AppInterface : IAppInterface
    {
        Data.AppDBModel DataModel;// = new Data.MySqlModel(
            //"server=127.0.0.1;user id=root;database=RocketFreight");

        cdmdotnet.AutoMapper.AutomapHelper automapHelper = 
            new cdmdotnet.AutoMapper.AutomapHelper();

        public AppInterface(bool seed = false)
        {
            try
            {
                if (Properties.Settings.Default.DBType == "SQLite")
                {
                    //System.Data.SQLite.EF6
                    DataModel = new Data.AppDBModel("SQLiteDbContext");
                }
                else if (Properties.Settings.Default.DBType == "MySQL")
                {
                    DataModel = new Data.AppDBModel("MySqlModel");// Properties.Settings.Default.ConStringMySql);
                }
                else {
                    DataModel = new Data.AppDBModel(Properties.Settings.Default.ConStringSQLServer);
                }

                if (seed)
                {
                    // Create an instance of the DataSeeder
                    var dataSeeder = new DataSeeder();

                    // Seed sample data for different classes
                    DataModel.Trips.AddRange(dataSeeder.SeedTrips());
                    DataModel.OrderRequests.AddRange(dataSeeder.SeedOrderRequests());
                    DataModel.Routes.AddRange(dataSeeder.SeedRoutes());
                    DataModel.Vehicles.AddRange(dataSeeder.SeedVehicles());
                    DataModel.Drivers.AddRange(dataSeeder.SeedDrivers());
                    DataModel.Products.AddRange(dataSeeder.SeedProducts());
                    DataModel.Orders.AddRange(dataSeeder.SeedOrders());
                    DataModel.Expenses.AddRange(dataSeeder.SeedExpenses());
                    DataModel.DriverAssignments.AddRange(dataSeeder.SeedDriverAssignments());
                    DataModel.Notifications.AddRange(dataSeeder.SeedNotifications());
                    DataModel.Compliances.AddRange(dataSeeder.SeedComplianceRecords());
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public async Task<User> GetUser(int Id)
        {
            return await DataModel.Users.FindAsync(Id);
        }

        public async Task<List<User>> GetUsers()
        {
            return await DataModel.Users.ToListAsync();
        }

        public async Task<bool> RemoveUser(int Id)
        {
            var result = await DataModel.Users.FindAsync(Id);
            if (result == null)
                throw new Exception("Item not found!");
            DataModel.Users.Remove(result);
            if (DataModel.SaveChanges() > 0)
                return true;
            return false;
        }
        
        public async Task<bool> SaveUser(User item)
        {
            if (DataModel.Users.FirstOrDefault(x => x.Username.ToLower() == item.Username.ToLower()) != null)
            {
                throw new Exception("Username is taken");
            }
            item.CreatedOn = DateTime.Now;
            item.LastModifiedOn = DateTime.Now;
            DataModel.Users.Add(item);
            if (await DataModel.SaveChangesAsync() > 0)
                return true;
            return false;
        }
        
        public async Task<bool> UpdateUser(User item, int i)
        {
            var oldItem = await DataModel.Users.FindAsync(i);
            if (oldItem == null)
                throw new Exception("Item not found!");

            oldItem.Address = item.Address;
            oldItem.Email = item.Email;
            oldItem.LastModifiedOn = DateTime.Now;
            //oldItem.Username = item.Username;
            oldItem.Password = item.Password;
            oldItem.FirstName = item.FirstName;
            oldItem.LastName = item.LastName;
            oldItem.Type = item.Type;
            oldItem.Phone = item.Phone;
            if (item.ProfileImage != null)
                oldItem.ProfileImage = item.ProfileImage;

            DataModel.Entry(oldItem).State = 
                System.Data.Entity.EntityState.Modified;
            if (DataModel.SaveChanges() > 0)
                return true;

            return false;
        }

    }
}
