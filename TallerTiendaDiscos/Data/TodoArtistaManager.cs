using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TallerTiendaDiscos.Model;

namespace TallerTiendaDiscos.Data
{
    public class TodoArtistaManager
    {
        IRestServices _restServices;


        public TodoArtistaManager(IRestServices services)
        {
            _restServices = services;
        }

        public Task<List<Artista>> GetArtistaItem()
        {
            return _restServices.GetDataArtista();
        }

        public Task<List<Discos>> GetDiscosItem() 
        {
            return _restServices.GetDataDiscos();
        }
        public Task<List<Discos>> GetPopItem()
        {
            return _restServices.GetPopDiscos();
        }
        public Task<List<Discos>> GetRockItem()
        {
            return _restServices.GetRockDiscos();
        }
    }
}
