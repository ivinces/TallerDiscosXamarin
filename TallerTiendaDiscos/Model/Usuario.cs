using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerTiendaDiscos.Model
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
