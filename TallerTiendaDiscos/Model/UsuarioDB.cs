using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TallerTiendaDiscos.Model
{
    public class UsuarioDB
    {
        readonly SQLiteAsyncConnection database;

        public UsuarioDB(string dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<Usuario>().Wait();
        }

        public Task<Usuario> GetUsuariosByUserName(string user)
        {
            return database.Table<Usuario>().Where(s => s.UserName == user).FirstOrDefaultAsync();
        }

        public Task<Usuario> GetUsuarioById(int id)
        {
            return database.Table<Usuario>().Where(s => s.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveUsuario(Usuario stud)
        {
            return database.InsertAsync(stud);
        }

        public bool LoginValidate(string userName1, string pwd1)
        {
            var data = database.Table<Usuario>();
            var d1 = data.Where(x => x.UserName == userName1 && x.Password == pwd1).FirstOrDefaultAsync();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
