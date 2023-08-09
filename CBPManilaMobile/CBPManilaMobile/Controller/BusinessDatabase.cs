using CBPManilaMobile.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CBPManilaMobile.View;

namespace CBPManilaMobile.Controller
{
    public class BusinessDatabase
    {
        readonly SQLiteAsyncConnection database;
        public BusinessDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Business>().Wait();
        }

        // Fetching Up Datas
        public Task<List<Business>> GetBusinessAsync()
        {
            return database.Table<Business>().ToListAsync();
        }

        public Task<List<Business>> FilterPlacesAsync(String place)
        {
            return database.Table<Business>().Where(i => i.Municipal == place).ToListAsync();
        }

        public Task<List<Business>> FilterCategotyAsync(String category)
        {
            return database.Table<Business>().Where(i => i.Category == category).ToListAsync();
        }

        public Task<List<Business>> FilterCategotyAndPlacesAsync(String category, String municipal)
        {
            return database.Table<Business>().Where(i => i.Category == category).Where(i => i.Municipal == municipal).ToListAsync();
        }

        //----------

        public Task<int> SaveBusinessAsync(Business business)
        {
            if (business.ID == 0)
            {
                return database.InsertAsync(business);
            }
            else
            {
                return database.UpdateAsync(business);
            }
        }

        // Delete
        public Task<int> DeleteBusinessAsync(Business business)
        {
            return database.DeleteAsync(business);
        }
    }
}
