using System;
using System.Collections.Generic;
using System.Text;

namespace TallerTiendaDiscos.Comun
{
    class Constants
    {
        public static string BaseAddress = "http://192.168.1.179:8000";
        //public static string TodoItemsUrl = BaseAddress + "/apiresttest/api/{0}/{1}/{2}";
        public static string PopsUrl = BaseAddress + "/pop/?format=json";
        public static string RockUrl = BaseAddress + "/rock/?format=json";
        public static string ArtistasUrl = BaseAddress + "/artistas/?format=json";
        public static string DiscosUrl = BaseAddress + "/discos/?format=json";
    }
}