using System;
using System.Collections.Generic;
using System.Text;

namespace TallerTiendaDiscos.Model
{
    public class Discos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrlDiscos { get; set; }
        public List<string> Canciones { get; set; }
    }
}
