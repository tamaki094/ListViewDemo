using ListViewDemo.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDemo.Data
{
    public class FriendDataBase
    {
        readonly SQLiteAsyncConnection database;

        public FriendDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Friend>().Wait();
        }

        public async Task<List<Friend>> getItemsAsync()
        {
            return await database.Table<Friend>().ToListAsync();
        }

        public Task<Friend> getItemAsync(int id)
        {
            return database.Table<Friend>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> saveItemAsync(Friend item)
        {
            if(item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> deleteItemAsync(Friend item)
        {
            return database.DeleteAsync(item);
        }
    }
}
