using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerTiendaDiscos.Model;
using TallerTiendaDiscos.Comun;
using System.Diagnostics;
using Newtonsoft.Json;

namespace TallerTiendaDiscos.Data
{
    class RestServices : IRestServices
    {
        HttpClient _client;

        public RestServices()
        {
            _client = new HttpClient();
        }

        public List<Artista> Artista { get; set; }
        public List<Discos> Discos { get; set; }
        public async Task<List<Artista>> GetDataArtista()
        {
            Artista = new List<Artista>();

            var uri = new Uri(string.Format(Constants.ArtistasUrl, string.Empty));

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    Artista = JsonConvert.DeserializeObject<List<Artista>>(content);
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return Artista;
        }

        public async Task<List<Discos>> GetDataDiscos()
        {
            Discos = new List<Discos>();

            var uri = new Uri(string.Format(Constants.DiscosUrl, string.Empty));

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    Discos = JsonConvert.DeserializeObject<List<Discos>>(content);
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return Discos;
        }

        public async Task<List<Discos>> GetPopDiscos()
        {
            Discos = new List<Discos>();

            var uri = new Uri(string.Format(Constants.PopsUrl, string.Empty));

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    Discos = JsonConvert.DeserializeObject<List<Discos>>(content);
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return Discos;
        }

        public async Task<List<Discos>> GetRockDiscos()
        {
            Discos = new List<Discos>();

            var uri = new Uri(string.Format(Constants.RockUrl, string.Empty));

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    Discos = JsonConvert.DeserializeObject<List<Discos>>(content);
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error {0}", ex.Message);
            }

            return Discos;
        }
    }
}
