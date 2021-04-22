using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace cengPC
{
    public class UyeDatabase
    {/*
        readonly SQLiteAsyncConnection _uyedatabase;
        public UyeDatabase(string dbPath)
        {
            _uyedatabase = new SQLiteAsyncConnection(dbPath);
            _uyedatabase.CreateTableAsync<Uyeler>().Wait();
        }
        public Task<List<Uyeler>> GetUyelerAsync()
        {
            return _uyedatabase.Table<Uyeler>().ToListAsync();
        }
        public Task<int> SaveUyelerAsync(Uyeler uyeler)
        {
            
            return _uyedatabase.InsertAsync(uyeler);
            
        }*/
        readonly SQLiteAsyncConnection database;
        public UyeDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Uye>().Wait();
        }
        public async Task<List<Uye>> GetUyelerAsync() 
        {
            return await database.Table<Uye>().ToListAsync(); 
        }
        public Task<Uye> GetUyeAsync(int id)
        {
            return database.Table<Uye>().Where(i => i.id == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveUyeAsync(Uye uye )
        {
            if(uye.id != 0)
            {
                return database.UpdateAsync(uye);
            }
            else
            {
                return database.InsertAsync(uye);
            }
        }
        public Task<int> DeleteUyeAsync (Uye uye)
        {
            return database.DeleteAsync(uye);
        }
    }
}
