using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TallerTiendaDiscos.Model
{
    public class CarritoComprasDB
    {
        readonly SQLiteAsyncConnection database;

        public CarritoComprasDB(string dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<Cart>().Wait();
        }

        //Retorna todos los discos (list view)
        public Task<List<Cart>> GetDiscos()
        {
            return database.Table<Cart>().ToListAsync();
        }

        //Retorno de informacion seleccionado de la lista
        public Task<Cart> GetDiscosById(int id)
        {
            return database.Table<Cart>().Where(s => s.ID == id).FirstOrDefaultAsync();
        }

        //Registro de discos
        public Task<int> SaveDiscos(Cart stud)
        {
            return database.InsertAsync(stud);
        }

        //Update de discos
        public Task<int> UpdateDiscos(Cart stud)
        {
            return database.UpdateAsync(stud);
        }

        //delete de discos
        public Task<int> DeleteDiscos(Cart stud)
        {
            return database.DeleteAsync(stud);
        }

    }
}
