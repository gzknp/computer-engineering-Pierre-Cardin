using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace cengPC
{
    public class UyeDatabase
    {
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
            
        }
    }
}
