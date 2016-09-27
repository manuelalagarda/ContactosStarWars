using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactosStarWars.Aplicacion
{
    public class ContactosStarWarsServicio
    {
        private const string URL_STARWARS = @"https://starwars-json-server-ewtdxbyfdz.now.sh/people";
        public IList<Contacto> ObtenerContactos()
        {
            string respuestaHTTP = RealizarPeticionHTTP(URL_STARWARS);

            return JsonConvert.DeserializeObject<IList<Contacto>>(respuestaHTTP);
            
        }

        private string RealizarPeticionHTTP(string url)
        {
            string respuesta = "";

            HttpWebRequest http = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)http.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                respuesta = sr.ReadToEnd();
            }


            return respuesta;
        }
    }
}
