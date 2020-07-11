using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerTiendaDiscos.Model
{
    public class Cart
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ImagenURL { get; set; }
        

       
    }
}
