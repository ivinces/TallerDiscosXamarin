using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TallerTiendaDiscos.Model;

namespace TallerTiendaDiscos.Data
{
    public interface IRestServices
    {
        Task<List<Artista>> GetDataArtista();
        Task<List<Discos>> GetDataDiscos();
        Task<List<Discos>> GetRockDiscos();
        Task<List<Discos>> GetPopDiscos();

    }
}
